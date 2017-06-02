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
    public partial class DetalhesConsultaForm : Form
    {
        Consultas detalhes_consulta;
        Pacientes paciente;
        public DetalhesConsultaForm(Consultas consulta_selecionada)
        {
            InitializeComponent();
            detalhes_consulta = consulta_selecionada;
            paciente = consulta_selecionada.Pacientes;
            MostrarDadosConsulta();
        }
       
        private void MostrarDadosConsulta()
        {
            tbx_detalhes_paciente.Text = "Nome: " + paciente.nome + "\r\n" + "Idade: " + (DateTime.Now.Year - paciente.dataNascimento.Year) + "\r\n" + "Altura: " + paciente.altura + "\r\n" + "Peso: " + paciente.peso + "\r\n" + "Tipo Sanguineo: " + paciente.tipoSanguineo;
            tbx_data.Text = detalhes_consulta.data.ToString();
            tbx_sintomas.Text = detalhes_consulta.sintomas;
            tbx_obs.Text = detalhes_consulta.obs;
            tbx_diagn_medico.Text = detalhes_consulta.diagonostico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            detalhes_consulta.sintomas = tbx_sintomas.Text;
            detalhes_consulta.diagonostico = tbx_diagn_medico.Text;
            detalhes_consulta.obs = tbx_obs.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
