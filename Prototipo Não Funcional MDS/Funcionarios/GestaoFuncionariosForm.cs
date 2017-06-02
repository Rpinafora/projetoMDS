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
        Utilizadores funcionarioSelecionado;

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
            if (funcionarioSelecionado != null)
            {
                EditarFuncionarioForm form = new EditarFuncionarioForm();
                form.container = container;
                form.funcionario = funcionarioSelecionado;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    container.SaveChanges();
                    RefrashListaFuncionarios();
                }
            }
            else
                MessageBox.Show("Por favor selecione o doutor que pretende editar");
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
            if (funcionarioSelecionado != null)
            {
                DialogResult confirmar = MessageBox.Show("Eliminar o funcionário '" + funcionarioSelecionado.nome + "'?", "Eliminar funcionário", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    container.PessoasSet.Remove(funcionarioSelecionado);
                    container.SaveChanges();
                    RefrashListaFuncionarios();
                    funcionarioSelecionado = null;
                }
            }
            else
                MessageBox.Show("Por favor selecione o funcionário que pretende eliminar");
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarConta form = new EditarConta();
            form.conta = funcionarioSelecionado;
            if (form.DialogResult == DialogResult.Yes)
            {
                container.SaveChanges();
                RefrashListaFuncionarios();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionarioSelecionado = (Utilizadores)listBox1.SelectedItem;
        }
    }
}

