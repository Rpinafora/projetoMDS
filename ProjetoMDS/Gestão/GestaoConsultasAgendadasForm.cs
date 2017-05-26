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
    public partial class GestaoConsultasAgendadasForm : Form
    {
        public GestaoConsultasAgendadasForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalhesConsultaForm form = new DetalhesConsultaForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestao_Arquivo form = new Gestao_Arquivo();
            form.ShowDialog();
        }
    }
}
