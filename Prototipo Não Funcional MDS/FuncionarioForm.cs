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
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestaoConsultasForm form = new GestaoConsultasForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestaoPacientesForm form = new GestaoPacientesForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestaoDoutoresForm form = new GestaoDoutoresForm();
            form.ShowDialog();
        }
    }
}
