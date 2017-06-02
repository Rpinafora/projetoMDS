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
    public partial class EditarConsultaForm : Form
    {
        public Consultas consulta;
        private ModeloContainer container;
        public EditarConsultaForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
        }

        private void EditarConsultaForm_Load(object sender, EventArgs e)
        {
            comboBox_especializacao.Items.AddRange(container.EspecializacoesSet.ToArray());
            dateTimePicker_dataConsulta.Value = consulta.data;
            dateTimePicker_hora.Value = consulta.hora;
            textBox_sintomas.Text = consulta.sintomas;
            //comboBox_especializacao.SelectedItem = 

        }
    }
}
