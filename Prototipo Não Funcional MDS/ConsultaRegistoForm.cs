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

        }

        private void label_sintomas_Click(object sender, EventArgs e)
        {

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
