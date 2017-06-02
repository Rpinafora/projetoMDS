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

            int numero;
            int numeroNIF;
            bool result = Int32.TryParse(textBox_numTelefone.Text, out numero);
            bool resultNIF = Int32.TryParse(textBox_nif.Text, out numeroNIF);

            if (textBox_nome.Text != null && textBox_numTelefone.Text != null && textBox_nif.Text != null && numericUpDown_altura.Value == 0 && numericUpDown_peso.Value == 0 && comboBox_tipoSanguineo.SelectedIndex != -1)
            {
                if (result && resultNIF)
                {
                    novoPaciente = new Pacientes
                    {
                        nome = textBox_nome.Text,
                        dataNascimento = dateTimePicker_dataNascimento.Value,
                        numTelefone = numero,
                        nif = textBox_nif.Text,
                        peso = numericUpDown_peso.Value,
                        altura = numericUpDown_altura.Value,
                        tipoSanguineo = (string)comboBox_tipoSanguineo.SelectedItem
                    };
                    DialogResult = DialogResult.OK;
                }
                else if (!result)
                {
                    MessageBox.Show("Numero de telefone inválido");
                }
                else
                {
                    MessageBox.Show("NIF inválido");
                }
            }
            
            
        }
    }
}
