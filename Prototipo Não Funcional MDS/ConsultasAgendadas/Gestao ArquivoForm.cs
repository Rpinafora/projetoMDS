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
    public partial class Gestao_Arquivo : Form
    {
        ModeloContainer container;
        public Gestao_Arquivo()
        {
            InitializeComponent();

            container = new ModeloContainer();
            refreshListaConsultas();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalhesConsultaForm form = new DetalhesConsultaForm((Consultas)listBox1.SelectedItem);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshListaConsultas()
        {
            foreach (Consultas consulta in container.ConsultasSet)
            {
                if (consulta.estado == "Consulta realizada")
                {
                    listBox1.Items.Add(consulta);
                }
            }
        }
    }
}
