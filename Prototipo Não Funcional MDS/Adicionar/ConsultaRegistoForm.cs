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
    public partial class ConsultaRegistoForm : Form
    {
        public Pacientes paciente;
        private ModeloContainer container;
        public Consultas novaConsulta;
        private Doutores doutor;

        public ConsultaRegistoForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
        }

        private void ConsultaRegistoForm_Load(object sender, EventArgs e)
        {
            textBox_dadosPaciente.Text = "Nome: " + paciente.nome + "\r\n" + "Idade: " +(DateTime.Now.Year - paciente.dataNascimento.Year) + "\r\n" + "Altura: " + paciente.altura + "\r\n" + "Peso: " + paciente.peso + "\r\n" + "Tipo Sanguineo: " + paciente.tipoSanguineo;
            comboBox_especializacao.Items.AddRange(container.EspecializacoesSet.ToArray());
        }

        private void button_registar_Click(object sender, EventArgs e)
        {
            if (textBox_sintomas.Text.Length != 0 && comboBox_doutoresDisponiveis.SelectedItem != null && comboBox_especializacao.SelectedItem != null)
            {
                doutor = (Doutores)comboBox_doutoresDisponiveis.SelectedItem;
                novaConsulta = new Consultas
                {
                    sintomas = textBox_sintomas.Text,
                    diagonostico = "A preencher pelo doutor",
                    data = dateTimePicker_dataConsulta.Value,
                    DoutoresId = doutor.Id,
                    PacientesId = paciente.Id,
                    hora = dateTimePicker_hora.Value

                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Dados inválidos");
            }            
        }

        private void comboBox_especializacao_SelectedIndexChanged(object sender, EventArgs e)
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
