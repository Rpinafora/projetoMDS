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
        public GestaoEspecializacoesForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_adicionarEspecializacao_Click(object sender, EventArgs e)
        {
            AdicionarEspecializacaoForm form = new AdicionarEspecializacaoForm();
            form.Show();
        }
    }
}
