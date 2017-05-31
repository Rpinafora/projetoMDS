using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Não_Funcional_MDS
{
    public partial class GestaoPacientesForm : Form
    {
        private ModeloContainer container;
        private Pacientes pacienteSelecionado;
        
        public GestaoPacientesForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            RefreshListaPacientes();
        }

        private void button_adicionarPaciente_Click(object sender, EventArgs e)
        {
            AdicionarPacienteForm form = new AdicionarPacienteForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                container.PessoasSet.Add(form.novoPaciente);                
                container.SaveChanges();
                RefreshListaPacientes();
            }
        }

        private void button_editarPaciente_Click(object sender, EventArgs e)
        {
            EditarPacienteForm form = new EditarPacienteForm();
            form.paciente = pacienteSelecionado;
            DialogResult resultado = form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                RefreshListaPacientes();
                container.SaveChanges();
            }
        }

        private void button_eliminarPaciente_Click(object sender, EventArgs e)
        {
            if (pacienteSelecionado != null)
            {
                DialogResult dialogResult = MessageBox.Show("Tem acerteza que pretende eliminar?","Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    container.PessoasSet.Remove(pacienteSelecionado);
                    container.SaveChanges();
                    listBox_pacientes.ClearSelected();
                    pacienteSelecionado = null;
                    RefreshListaPacientes();                  
                    
                }
            }            
        }

        private void RefreshListaPacientes()
        {
            listBox_pacientes.Items.Clear();
            listBox_pacientes.Items.AddRange(container.PessoasSet.OfType<Pacientes>().ToArray());
        }

        private void listBox_pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSelecionado = (Pacientes)listBox_pacientes.SelectedItem;
        }
    }
}
