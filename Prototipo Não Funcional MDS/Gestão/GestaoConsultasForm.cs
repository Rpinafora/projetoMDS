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
        private ModeloContainer container = new ModeloContainer();
        public GestaoConsultasForm()
        {
            InitializeComponent();
            refreshListaConsultas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem acerteza que pretende eliminar?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarConsultaForm form = new AdicionarConsultaForm();
            form.ShowDialog();
            refreshListaConsultas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaRegistoForm form = new ConsultaRegistoForm();
            form.ShowDialog();
        }

        public void refreshListaConsultas()
        {
            listBox_consultas.Items.Clear();
            listBox_consultas.Items.AddRange(container.ConsultasSet.ToArray());
        }
    }
}
