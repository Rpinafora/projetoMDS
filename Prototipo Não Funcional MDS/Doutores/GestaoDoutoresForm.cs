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
    public partial class GestaoDoutoresForm : Form
    {

        private ModeloContainer container;
        private Doutores doutorSelecionado;

        public GestaoDoutoresForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            RefreshListaDoutores();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestaoEspecializacoesForm form = new GestaoEspecializacoesForm();
            form.ShowDialog();
        }

        private void EventoEliminarDoutor(object sender, EventArgs e)
        {
            if (doutorSelecionado != null)
            {
                DialogResult confirmar = MessageBox.Show("Eliminar o doutor '" + doutorSelecionado.nome + "'?", "Eliminar Doutor", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    doutorSelecionado.Especializacoes.Clear();
                    container.PessoasSet.Remove(doutorSelecionado);
                    container.SaveChanges();
                    RefreshListaDoutores();
                    doutorSelecionado = null;
                }
            }
            else
                MessageBox.Show("Por favor selecione o doutor que pretende eliminar");
        }

        private void EventoEditarDoutor(object sender, EventArgs e)
        {
            if (doutorSelecionado != null)
            {
                EditarDoutorForm form = new EditarDoutorForm();
                form.container = container;
                form.doutor = doutorSelecionado;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    container.SaveChanges();
                    RefreshListaDoutores();
                }
            }
            else
                MessageBox.Show("Por favor selecione o doutor que pretende editar");
        }

        private void EventoAdicionarDoutor(object sender, EventArgs e)
        {
            AdicionarDoutorForm form = new AdicionarDoutorForm();
            form.container = container;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK && form.novoDoutor != null)
            {
                container.PessoasSet.Add(form.novoDoutor);
                container.SaveChanges();
                RefreshListaDoutores();
            }
        }

        private void RefreshListaDoutores()
        {
            lbx_doutores.Items.Clear();
            lbx_doutores.Items.AddRange(container.PessoasSet.OfType<Doutores>().ToArray());
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            doutorSelecionado = (Doutores)lbx_doutores.SelectedItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbx_doutores.Items.Clear();
            if (txt_procurar.TextLength > 0)
            {
                foreach (Doutores doutor in container.PessoasSet.OfType<Doutores>())
                {

                    if (doutor.nome.ToLower().Contains(txt_procurar.Text.ToLower()))
                        lbx_doutores.Items.Add(doutor);
                }
            }
            else
                RefreshListaDoutores();
        }
    }
}
