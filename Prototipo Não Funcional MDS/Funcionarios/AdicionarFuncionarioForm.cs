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
    public partial class AdicionarFuncionarioForm : Form
    {
        public Utilizadores novoUser;
        public AdicionarFuncionarioForm()
        {
            InitializeComponent();

            
        }

        private void EventoAdicionarUtilizador(object sender, EventArgs e)
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
                novoUser = new Utilizadores();

                novoUser.nome = nome;
                novoUser.email = tbx_email.Text;
                novoUser.password = "Default";
                novoUser.funcao = "Funcionario";
                novoUser.dataNascimento = dateTimePicker_dataNascimento.Value;
                novoUser.numTelefone = numero;
                novoUser.nif = textBox_nif.Text;

                DialogResult = DialogResult.OK;
            }
        }

       
    }
}
