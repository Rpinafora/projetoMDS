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
    public partial class AdicionarConsultaForm : Form
    {
        private Pacientes pacienteSlecionado;
        private ModeloContainer container;
        public AdicionarConsultaForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            RefreshListaPacientes();
        }

        private void button_registarConsulta_Click(object sender, EventArgs e)
        {
            if (pacienteSlecionado != null)
            {
                ConsultaRegistoForm form = new ConsultaRegistoForm();
                form.paciente = pacienteSlecionado;
                DialogResult resultado = form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    RefreshListaPacientes();
                    container.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Selecione o paciente a quem marcar consulta");
            }
            
        }

        private void listBox_pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSlecionado = (Pacientes)listBox_pacientes.SelectedItem;
        }

        private void RefreshListaPacientes()
        {
            listBox_pacientes.Items.Clear();
            listBox_pacientes.Items.AddRange(container.PessoasSet.OfType<Pacientes>().ToArray());
        }
    }
}
