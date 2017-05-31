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
    public partial class EditarPacienteForm : Form
    {
        public Pacientes paciente;

        public EditarPacienteForm()
        {
            InitializeComponent();
        }

        private void EditarPacienteForm_Load(object sender, EventArgs e)
        {
            textBox_nif.Text = paciente.nif;
            textBox_nome.Text = paciente.nome;
            textBox_numTelefone.Text = paciente.numTelefone.ToString();
            comboBox_tipoSanguineo.SelectedItem = paciente.tipoSanguineo;
            dateTimePicker_dataNascimento.Value = paciente.dataNascimento;
            numericUpDown_altura.Value = paciente.altura;
            numericUpDown_peso.Value = paciente.peso;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            int numero;
            bool result = Int32.TryParse(textBox_numTelefone.Text, out numero);

            if (result)
            {
                paciente.nif = textBox_nif.Text;
                paciente.nome = textBox_nome.Text;
                paciente.numTelefone = numero;
                paciente.tipoSanguineo = comboBox_tipoSanguineo.SelectedItem.ToString();
                paciente.dataNascimento = dateTimePicker_dataNascimento.Value;
                paciente.altura = numericUpDown_altura.Value;
                paciente.peso = numericUpDown_peso.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Numero de telefone inválido");
            }
            
        }
    }
}
