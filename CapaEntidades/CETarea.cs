using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CETarea: CESuperClase1
    {
        // id, nombre = datos heredados
        public string Descricion { get; set; } = string.Empty;
        public int EstadoFk { get; set; }
    }
}
