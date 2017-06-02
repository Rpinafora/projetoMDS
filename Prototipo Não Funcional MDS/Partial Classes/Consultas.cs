using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_Não_Funcional_MDS
{
    public partial class Consultas
    {
        public override string ToString()
        {
            return Pacientes.nome + " - " + data.ToString("dd/MM / yyyy") + " " + hora.ToString("HH:mm");
        }
    }
}
