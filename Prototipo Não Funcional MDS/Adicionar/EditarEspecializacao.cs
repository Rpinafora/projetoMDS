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
    public partial class EditarEspecializacao : Form
    {
        public Especializacoes especializacao;

        public EditarEspecializacao()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength > 0)
            {
                especializacao.nome = txt_nome.Text;
                especializacao.obs = txt_obs.Text;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Por favor introduza o nome da especialização");
        }

        private void EditarEspecializacao_Load(object sender, EventArgs e)
        {
            txt_nome.Text = especializacao.nome;
            txt_obs.Text = especializacao.obs;
        }
    }
}
