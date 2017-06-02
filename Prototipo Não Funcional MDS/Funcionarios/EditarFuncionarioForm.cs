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
    public partial class EditarFuncionarioForm : Form
    {
        public Utilizadores funcionario;
        public ModeloContainer container;

        public EditarFuncionarioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool erro = false;
            int numero;
            int numeroNIF;
            string nome = tbx_nome.Text;
            if (!tbx_email.Text.Contains("@"))
                erro = true;
            bool result = Int32.TryParse(textBox_numTelefo.Text, out numero);
            bool resultNIF = Int32.TryParse(textBox_nif.Text, out numeroNIF);

            if (nome.Length > 0 && !erro)
            {
                funcionario.nome = nome;
                funcionario.email = tbx_email.Text;
                funcionario.dataNascimento = dateTimePicker_dataNascimento.Value;
                funcionario.numTelefone = numero;
                funcionario.nif = textBox_nif.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void EditarFuncionarioForm_Load(object sender, EventArgs e)
        {

            tbx_nome.Text = funcionario.nome;
            tbx_email.Text = funcionario.email;
            dateTimePicker_dataNascimento.Value = funcionario.dataNascimento;
            textBox_numTelefo.Text = funcionario.numTelefone.ToString();
            textBox_nif.Text = funcionario.nif;        
        }
    }
}
