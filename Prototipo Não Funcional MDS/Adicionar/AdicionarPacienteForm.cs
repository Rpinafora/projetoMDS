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
    
    public partial class AdicionarPacienteForm : Form
    {
        public Pacientes novoPaciente;
        public AdicionarPacienteForm()
        {
            InitializeComponent();
        }

        private void button_registar_Click(object sender, EventArgs e)
        {
            novoPaciente = new Pacientes
            {
                nome = textBox_nome.Text,
                dataNascimento = dateTimePicker_dataNascimento.Value,
                numTelefone = Int32.Parse(textBox_numTelefone.Text),
                nif = textBox_nif.Text,
                peso = numericUpDown_peso.Value,
                altura = numericUpDown_altura.Value,
                tipoSanguineo = (string)comboBox_tipoSanguineo.SelectedItem
            };
            DialogResult = DialogResult.OK;
        }
    }
}
