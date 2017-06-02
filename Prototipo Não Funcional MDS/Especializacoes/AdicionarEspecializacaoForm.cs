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
    public partial class AdicionarEspecializacaoForm : Form
    {
        public Especializacoes novaEspecializacao;
        public AdicionarEspecializacaoForm()
        {
            InitializeComponent();
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength > 0)
            {
                novaEspecializacao = new Especializacoes
                {
                    nome = txt_nome.Text,
                    obs = txt_obs.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Por favor introduza o nome da especialização");
        }
    }
}
