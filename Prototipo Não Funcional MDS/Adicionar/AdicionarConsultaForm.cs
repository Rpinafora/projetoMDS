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
    public partial class AdicionarConsultaForm : Form
    {
        public AdicionarConsultaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaRegistoForm form = new ConsultaRegistoForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestaoPacientesForm form = new GestaoPacientesForm();
            form.ShowDialog();
        }
    }
}
