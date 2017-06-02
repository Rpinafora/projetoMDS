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
    public partial class GestaoFuncionariosForm : Form
    {
        ModeloContainer container;

        public GestaoFuncionariosForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            RefrashListaFuncionarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarFuncionarioForm form = new AdicionarFuncionarioForm();
            DialogResult resultado = form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                AdicionarUser(form.novoUser);
                RefrashListaFuncionarios();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarFuncionarioForm form = new AdicionarFuncionarioForm();
            form.ShowDialog();
        }

        private void AdicionarUser(Utilizadores user)
        {
            container.PessoasSet.Add(user);
            container.SaveChanges();
        }
        private void RefrashListaFuncionarios()
        {
            listBox1.Items.Clear();
            foreach (Utilizadores utilizador in container.PessoasSet.OfType<Utilizadores>())
            {
                if (utilizador.funcao == "Funcionario")
                {
                    listBox1.Items.Add(utilizador);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilizadores utilizadorselecionado = (Utilizadores)listBox1.SelectedItem;
            if (utilizadorselecionado == null)
            {
                MessageBox.Show("Selecione um utilizador");

            }
            else
            {
                foreach (Utilizadores utilizador in container.PessoasSet.OfType<Utilizadores>())
                {

                    if (utilizadorselecionado.nome == utilizador.nome)
                    {
                        container.PessoasSet.Remove(utilizador);
                    }

                }
                container.SaveChanges();
                RefrashListaFuncionarios();

            }
        }

    }
}

