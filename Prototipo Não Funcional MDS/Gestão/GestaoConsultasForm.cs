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
        private Consultas consultaSelecionada;
        public GestaoConsultasForm()
        {
            InitializeComponent();
            refreshListaConsultas();
        }

        public void refreshListaConsultas()
        {
            listBox_consultas.Items.Clear();
            listBox_consultas.Items.AddRange(container.ConsultasSet.ToArray());
        }

        private void button_editarConsulta_Click(object sender, EventArgs e)
        {
           /*
            form.consulta = consultaSelecionada;
            DialogResult resultado = form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                container.SaveChanges();
                refreshListaConsultas();
            }*/
        }

        private void button_registarConsulta_Click(object sender, EventArgs e)
        {
            AdicionarConsultaForm form = new AdicionarConsultaForm();
            form.ShowDialog();
            refreshListaConsultas();
        }

        private void listBox_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaSelecionada = (Consultas)listBox_consultas.SelectedItem;
        }
    }
}
