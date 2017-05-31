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
        
        public GestaoPacientesForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
        }

        private void button_adicionarPaciente_Click(object sender, EventArgs e)
        {
            AdicionarPacienteForm form = new AdicionarPacienteForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                container.PessoasSet.Add(form.novoPaciente);                  
               
                container.SaveChanges();
            }
        }

        private void button_editarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void button_eliminarPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem acerteza que pretende eliminar?");
        }
    }
}
