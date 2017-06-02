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
    public partial class EditarConsultaForm : Form
    {
        public Consultas consulta;
        private ModeloContainer container;
        public EditarConsultaForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
        }

        private void EditarConsultaForm_Load(object sender, EventArgs e)
        {
            comboBox_especializacao.Items.AddRange(container.EspecializacoesSet.ToArray());
            dateTimePicker_dataConsulta.Value = consulta.data;
            dateTimePicker_hora.Value = consulta.hora;
            textBox_sintomas.Text = consulta.sintomas;
            comboBox_especializacao.SelectedItem = consulta.Especializacoes;
            comboBox_especializacao.Text = consulta.Especializacoes.nome;
            refreshDoutores();
            comboBox_doutoresDisponiveis.SelectedItem = consulta.Doutores;
            comboBox_doutoresDisponiveis.Text = consulta.Doutores.nome;

        }

        private void button_editar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_doutoresDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDoutores();
        }

        private void refreshDoutores()
        {
            comboBox_doutoresDisponiveis.Items.Clear();
            foreach (Doutores doutor in container.PessoasSet.OfType<Doutores>())
            {
                if (doutor.Especializacoes.Contains(comboBox_especializacao.SelectedItem))
                {
                    comboBox_doutoresDisponiveis.Items.Add(doutor);
                }
            }
        }
    }
}
