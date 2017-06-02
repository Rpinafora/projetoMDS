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

        ModeloContainer container;
        public LoginForm()
        {
            InitializeComponent();

            container = new ModeloContainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Utilizadores utilizador in container.PessoasSet.OfType<Utilizadores>())
            {
                if (utilizador.funcao == "Doutor")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        GestaoConsultasAgendadasForm form = new GestaoConsultasAgendadasForm();
                        form.ShowDialog();
                    }
                }
                if (utilizador.funcao == "Funcionario")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        FuncionarioForm form = new FuncionarioForm();
                        form.ShowDialog();
                    }
                }
                if (textBox1.Text == "Admin")
                {
                    AdminForm form = new AdminForm();
                    form.ShowDialog();
                }

            }

        }
    }
}
