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
    public partial class GestaoConsultasAgendadasForm : Form
    {
        ModeloContainer container;
        public GestaoConsultasAgendadasForm()
        {
            InitializeComponent();
            container = new ModeloContainer();
            refreshlistaConsultasAgendadas();
            
        }
        //ESTE EVENTO CHAMA O FORMULARIO "DETALHESCONSULTA" POREM RECEBE COMO PARAMETROS UMA CONSULTA SELECIONADA PARA QUE SEJAM CARREGADOS OS DADOS DESSA CONSULTA.
        //ESTE EVENTO ESTARA ASSOCIADO AO DOUBLE_CLICK NA LIST_BOX_CONSULTAS
        private void EventoMostrarDadosConsulta(object sender, EventArgs e)
        {
            DetalhesConsultaForm form = new DetalhesConsultaForm((Consultas)lbx_consultas.SelectedItem);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                container.SaveChanges();
            }
        }

        //ESTE EVENTO PROCURA NA BASE DE DADOS A CONSULTA QUE TEM O MESMO ID QUE A CONSULTA SELECIONADA E ELEMINA-A
        //DANDO EM SEGUIDA SAVE AO CONTAINER E POSTERIORMENTE ATUALIZA A LISTA DE CONSULTAS
        private void EventoEliminarConsulta(object sender, EventArgs e)
        {
            string id_consulta = lbx_consultas.SelectedItem.ToString();

            foreach (Consultas consulta in container.ConsultasSet)
            {
                if (id_consulta == consulta.Id.ToString())
                {
                    container.ConsultasSet.Remove(consulta);
                }
            }
            container.SaveChanges();
            refreshlistaConsultasAgendadas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestao_Arquivo form = new Gestao_Arquivo();
            form.ShowDialog();
        }

        //AO SER CHAMADO, ESTE METODO CARREGA PARA A LIST_BOX_CONSULTAS, AS CONSULTAS GUARDADAS NA BASE DE DADOS.
        //FAZENDO CLEAR AOS DADOS QUE ESTIVEREM INSERIDOS E CARREGANDO OS NOVOS DADOS.
        //SEM O CLEAR E SIMPLESMENTE COMO O ADDRANGE, APARECERIAM DADOS REPETIDOS.
        private void refreshlistaConsultasAgendadas()
        {
            lbx_consultas.Items.Clear();
            lbx_consultas.Items.AddRange(container.ConsultasSet.ToArray());
        }
    }
}
