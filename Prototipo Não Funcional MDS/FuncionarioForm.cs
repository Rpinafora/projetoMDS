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
    public partial class FuncionarioForm : Form
    {
        public Utilizadores utilizador;
        public ModeloContainer container;

        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void eventoGestãoConsultas(object sender, EventArgs e)
        {
            GestaoConsultasForm form = new GestaoConsultasForm();
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestaoPacientesForm form = new GestaoPacientesForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestaoDoutoresForm form = new GestaoDoutoresForm();
            form.ShowDialog();
        }

        private void eventoSair(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarConta form = new EditarConta();
            form.conta = utilizador;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                container.SaveChanges();
        }
    }
}
