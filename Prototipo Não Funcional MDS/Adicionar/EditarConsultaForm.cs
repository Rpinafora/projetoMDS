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
        private Doutores doutor;
        private Especializacoes especializacao;
        public Consultas consulta;
        private ModeloContainer container;
        public EditarConsultaForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
        }

        private void EditarConsultaForm_Load(object sender, EventArgs e)
        {
            textBox_dadosPaciente.Text = "Nome: " + consulta.Pacientes.nome + "\r\n" + "Idade: " + (DateTime.Now.Year - consulta.Pacientes.dataNascimento.Year) + "\r\n" + "Altura: " + consulta.Pacientes.altura + "\r\n" + "Peso: " + consulta.Pacientes.peso + "\r\n" + "Tipo Sanguineo: " + consulta.Pacientes.tipoSanguineo;
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
            if (textBox_sintomas.Text.Length != 0 && comboBox_doutoresDisponiveis.SelectedItem != null && comboBox_especializacao.SelectedItem != null)
            {
                doutor = (Doutores)comboBox_doutoresDisponiveis.SelectedItem;
                especializacao = (Especializacoes)comboBox_especializacao.SelectedItem;

                consulta.data = dateTimePicker_dataConsulta.Value;
                consulta.hora = dateTimePicker_hora.Value;
                consulta.sintomas = textBox_sintomas.Text;
                consulta.EspecializacoesId = especializacao.Id;               
                consulta.DoutoresId = doutor.Id;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Dados inválidos");
            }
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

        private void comboBox_especializacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doutoresDisponiveis.Text = "";
            refreshDoutores();
        }
    }
}
