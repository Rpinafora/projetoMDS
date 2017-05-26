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
    public partial class LoginForm : Form
    {

        modelo
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                GestaoFuncionariosForm form = new GestaoFuncionariosForm();
                form.ShowDialog();
            }
            else if(textBox1.Text == "doutor")
            {
                GestaoConsultasAgendadasForm form = new GestaoConsultasAgendadasForm();
                form.ShowDialog();
            }
            else
            {
                FuncionarioForm form = new FuncionarioForm();
                form.ShowDialog();
            }
        }
    }
}
