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

        public ConsultaRegistoForm()
        {
            InitializeComponent();
        }

        private void ConsultaRegistoForm_Load(object sender, EventArgs e)
        {
            textBox_dadosPaciente.Text = "Nome: " + paciente.nome + "\r\n" + "Idade: " +(DateTime.Now.Year - paciente.dataNascimento.Year);
        }

        private void button_registar_Click(object sender, EventArgs e)
        {

        }
    }
}
