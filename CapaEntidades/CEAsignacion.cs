using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEAsignacion
    {
        public int id{ get; set; }
        public int UsuarioFk { get; set; }
        public int TareaFk { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }

    }
}
