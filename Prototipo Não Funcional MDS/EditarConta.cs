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
                if (txt_oldpass.Text == conta.password)
                {  
                    if (txt_pass.TextLength > 0)
                    {
                        conta.email = txt_email.Text;
                        conta.password = txt_pass.Text;
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Introduzia uma password");

                }
                else
                    MessageBox.Show("Introduziu a password errada");
            }
        }
    }
}
