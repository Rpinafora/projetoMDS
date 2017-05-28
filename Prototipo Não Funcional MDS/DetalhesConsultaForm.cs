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
        public DetalhesConsultaForm(Consultas consulta_selecionada)
        {
            InitializeComponent();
            detalhes_consulta = consulta_selecionada;
            MostrarDadosConsulta();
        }
       
        private void MostrarDadosConsulta()
        {
            lbx_detalhes_paciente.Items.Add(detalhes_consulta.Pacientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
