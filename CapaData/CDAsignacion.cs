using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaData
{
    public class CDAsignacion: CRUD_SuperClass
    {
        
         public void CreateAsignation(CEAsignacion cea)
        {
            GeneralQuery = "insert into Asignaciones(usuarioF, tareaF) values (" +cea.UsuarioFk+","+cea.TareaFk + ");";
            CreateRegister(GeneralQuery);
        }

        public DataSet ReadAllAsignation()
        {
            GeneralQuery = "select  u.nombre as Usuario, t.nombre As Nombre, a.fecha, a.hora, e.nombre as Estado   from Asignaciones a join Tarea t on (a.tareaF = t.id) join Estado e on (t.estadoF = e.id) join Usuario u on (a.usuarioF = u.id); ";
            VisualizerName = "AsignacionesVisualizer";
            dataSet = new DataSet();

            ReadRegister(GeneralQuery, VisualizerName, dataSet);

            return dataSet;

        }

        public void UpdateAssignments()
        {
            GeneralQuery = " ";
            UpdatedRegister(GeneralQuery);

        }


    }
}
