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
            bool login = false;

            foreach (Utilizadores utilizador in container.PessoasSet.OfType<Utilizadores>())
            {
                if (utilizador.funcao == "Doutor")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        GestaoConsultasAgendadasForm form = new GestaoConsultasAgendadasForm();
                        form.ShowDialog();
                        login = true;
                    }
                }
                if (utilizador.funcao == "Funcionario")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        FuncionarioForm form = new FuncionarioForm();
                        form.ShowDialog();
                        login = true;
                    }
                }
            }
            if (textBox1.Text == "master" && textBox2.Text == "master")
            {
                GestaoFuncionariosForm form = new GestaoFuncionariosForm();
                form.ShowDialog();
                login = true;
            }

            if(!login)
            {
                MessageBox.Show("Dados de acesso inválidos, por favor tente novamente");
            }

        }
    }
}
