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
    public partial class GestaoConsultasForm : Form
    {
        public GestaoConsultasForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem acerteza que pretende eliminar?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarConsultaForm form = new AdicionarConsultaForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaRegistoForm form = new ConsultaRegistoForm();
            form.ShowDialog();
        }
    }
}
