using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Não_Funcional_MDS
{
    public partial class EditarConta : Form
    {

        public Utilizadores conta;

        public EditarConta()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (!txt_email.Text.Contains("@"))
                MessageBox.Show("Introduza um email válido");
            else
            {
                if (sha512(txt_oldpass.Text) == conta.password)
                {
                    if (txt_pass.TextLength > 0)
                    {
                        conta.email = txt_email.Text;
                        conta.password = sha512(txt_pass.Text);
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Introduzia uma password");

                }
                else
                    MessageBox.Show("Introduziu a password errada");
            }
        }

        private string sha512(string texto)
        {
            var pass = Encoding.UTF8.GetBytes(texto);
            using (SHA512 shaM = new SHA512Managed())
            {
                var passEncr = shaM.ComputeHash(pass);
                return Encoding.UTF8.GetString(passEncr);
            }
        }
    }
}
