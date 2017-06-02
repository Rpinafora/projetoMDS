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
    public partial class EditarDoutorForm : Form
    {
        public Doutores doutor;
        public ModeloContainer container;

        public EditarDoutorForm()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int numTelefone;
            bool erro = false;

            if (!Int32.TryParse(txt_telefone.Text, out numTelefone))
                erro = true;
            if (txt_nome.TextLength == 0 || txt_nif.TextLength == 0)
                erro = true;
            if (!txt_email.Text.Contains("@"))
                erro = true;
            if (clbx_especializacoes.CheckedItems.Cast<Especializacoes>().Count() == 0)
                erro = true;

            if (!erro)
            {
                doutor.nome = txt_nome.Text;
                doutor.nif = txt_nif.Text;
                doutor.checkin = dt_checkin.Value;
                doutor.checkout = dt_checkout.Value;
                doutor.email = txt_email.Text;
                doutor.numTelefone = numTelefone;
                doutor.dataNascimento = dt_dataNasc.Value;
                doutor.Especializacoes.Clear();
                doutor.Especializacoes = clbx_especializacoes.CheckedItems.Cast<Especializacoes>().ToList();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private void EditarDoutorForm_Load(object sender, EventArgs e)
        {
            clbx_especializacoes.Items.AddRange(doutor.Especializacoes.ToArray());

            for (int i = 0; i < clbx_especializacoes.Items.Count; i++)
            {
                clbx_especializacoes.SetItemChecked(i, true);
            }

            foreach(Especializacoes esp in container.EspecializacoesSet.ToArray())
            {
                if (!clbx_especializacoes.Items.Contains(esp))
                    clbx_especializacoes.Items.Add(esp);
            }

            txt_nome.Text = doutor.nome;
            txt_nif.Text = doutor.nif;
            dt_checkin.Value = doutor.checkin;
            dt_checkout.Value = doutor.checkout;
            txt_email.Text = doutor.email;
            txt_telefone.Text = doutor.numTelefone.ToString();
            dt_dataNasc.Value = doutor.dataNascimento;           
        }

        private void clbx_especializacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
