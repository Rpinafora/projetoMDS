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
    public partial class AdicionarDoutorForm : Form
    {
        public Doutores novoDoutor;
        public ModeloContainer container;

        public AdicionarDoutorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            int numTelefone;
            bool erro = false;

            if (!Int32.TryParse(txt_telefone.Text, out numTelefone))
                erro = true;
            if (txt_nome.TextLength == 0 || txt_nif.TextLength == 0)
                erro = true;
            if (!txt_email.Text.Contains("@"))
                erro = true;
            if (clbx_especializacoes.SelectedItems.Cast<Especializacoes>().Count() == 0)
                erro = true;

            if (!erro)
            {
                novoDoutor = new Doutores
                {
                    nome = txt_nome.Text,
                    nif = txt_nif.Text,
                    checkin = dt_checkin.Value,
                    checkout = dt_checkout.Value,
                    funcao = "Doutor",
                    email = txt_email.Text,
                    numTelefone = numTelefone,
                    password = "default",
                    dataNascimento = dt_dataNasc.Value,
                    Especializacoes = clbx_especializacoes.SelectedItems.Cast<Especializacoes>().ToList()
                };
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private void AdicionarDoutorForm_Load(object sender, EventArgs e)
        {
            clbx_especializacoes.Items.AddRange(container.EspecializacoesSet.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
