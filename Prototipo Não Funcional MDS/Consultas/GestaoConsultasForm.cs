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
            foreach (Consultas consulta in container.ConsultasSet)
            {
                if (consulta.estado == "Agendada")
                {
                    listBox_consultas.Items.Add(consulta);
                }
            }
        }

        private void button_editarConsulta_Click(object sender, EventArgs e)
        {
            if (consultaSelecionada != null)
            {
                EditarConsultaForm form = new EditarConsultaForm();
                form.consulta = consultaSelecionada;
                DialogResult resultado = form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    container.SaveChanges();
                    refreshListaConsultas();
                }
            }
            else
            {
                MessageBox.Show("Selecione a consulta a editar");
            }

        }

        private void button_registarConsulta_Click(object sender, EventArgs e)
        {
            AdicionarConsultaForm form = new AdicionarConsultaForm();
            form.ShowDialog();
            refreshListaConsultas();
        }

        private void listBox_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaSelecionada = null;
            consultaSelecionada = (Consultas)listBox_consultas.SelectedItem;
        }

        private void button_eliminarConsulta_Click(object sender, EventArgs e)
        {
            if (consultaSelecionada != null)
            {

                DialogResult dialogResult = MessageBox.Show("Tem acerteza que pretende eliminar?", "Eliminar", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    container.ConsultasSet.Remove(consultaSelecionada);
                    container.SaveChanges();
                    refreshListaConsultas();
                }

            }
        }
    }
}
