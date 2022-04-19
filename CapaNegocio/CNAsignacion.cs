using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class CNAsignacion
    {
        CDAsignacion cdAssignments = new CDAsignacion();
        public void CreateAsignationValidated(CEAsignacion cea)
        {
            cdAssignments.CreateAsignation(cea);
        }

        public DataSet ReadAllAssignments()
        {
            return cdAssignments.ReadAllAsignation();
        }
    }
}
