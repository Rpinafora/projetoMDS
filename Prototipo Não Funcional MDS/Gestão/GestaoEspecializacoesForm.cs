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
    public partial class GestaoEspecializacoesForm : Form
    {
        private ModeloContainer container;
        private Especializacoes espSelecionada;

        public GestaoEspecializacoesForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            RefreshListaEspecializacoes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshListaEspecializacoes()
        {
            lbx_especializacoes.Items.Clear();
            lbx_especializacoes.Items.AddRange(container.EspecializacoesSet.ToArray());
        }

        private void lbx_especializacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            espSelecionada = (Especializacoes)lbx_especializacoes.SelectedItem;
        }

        private void EventoAdicionarEspecializacao(object sender, EventArgs e)
        {
            AdicionarEspecializacaoForm form = new AdicionarEspecializacaoForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK && form.novaEspecializacao != null)
            {
                container.EspecializacoesSet.Add(form.novaEspecializacao);
                container.SaveChanges();
                RefreshListaEspecializacoes();
            }
        }

        private void EventoEditarEspecializacao(object sender, EventArgs e)
        {
            if (espSelecionada != null)
            {
                EditarEspecializacao form = new EditarEspecializacao();
                form.especializacao = espSelecionada;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    container.SaveChanges();
                    RefreshListaEspecializacoes();
                }
            }
            else
                MessageBox.Show("Por favor selecione a especialização que pretende editar");
        }

        private void EventoEliminarEspecializacao(object sender, EventArgs e)
        {
            if (espSelecionada != null)
            {
                DialogResult confirmar = MessageBox.Show("Eliminar a especialização '" + espSelecionada.nome + "'?", "Eliminar especialização", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    container.EspecializacoesSet.Remove(espSelecionada);
                    container.SaveChanges();
                    RefreshListaEspecializacoes();
                    espSelecionada = null;
                }
            }
            else
                MessageBox.Show("Por favor selecione a especialização que pretende eliminar");
        }

        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            lbx_especializacoes.Items.Clear();
            if (txt_procurar.TextLength > 0)
            {
                foreach (Especializacoes esp in container.EspecializacoesSet)
                {

                    if (esp.nome.Contains(txt_procurar.Text))
                        lbx_especializacoes.Items.Add(esp);
                }
            }
            else
                RefreshListaEspecializacoes();
        }
    }
}
