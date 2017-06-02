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
            Utilizadores contaLogada = null;

            foreach (Utilizadores utilizador in container.PessoasSet.OfType<Utilizadores>())
            {
                if (utilizador.funcao == "Doutor")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        contaLogada = utilizador;
                        
                        login = true;
                    }
                }
                if (utilizador.funcao == "Funcionario")
                {
                    if (utilizador.email == textBox1.Text && utilizador.password == textBox2.Text)
                    {
                        contaLogada = utilizador;
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
            else
            {
                if (contaLogada.funcao == "Funcionario")
                {
                    FuncionarioForm form = new FuncionarioForm();
                    form.container = container;
                    form.utilizador = contaLogada;
                    form.ShowDialog();
                }
                else if (contaLogada.funcao == "Doutor")
                {
                    GestaoConsultasAgendadasForm form = new GestaoConsultasAgendadasForm();
                    form.container = container;
                    form.utilizador = contaLogada;
                    form.ShowDialog();
                }
            }
        }
    }
}
