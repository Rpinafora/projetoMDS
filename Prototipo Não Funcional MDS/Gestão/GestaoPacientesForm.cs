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
        public GestaoPacientesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarPacienteForm form = new AdicionarPacienteForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem acerteza que pretende eliminar?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarPacienteForm form = new AdicionarPacienteForm();
            form.ShowDialog();
        }
    }
}
