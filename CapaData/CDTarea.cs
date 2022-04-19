using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaData
{
    public class CDTarea: CRUD_SuperClass
    {
        public string? Description { get; set; } = null;
        public int? EstadoF { get; set; } = null;

        
        public void CreateTask(CETarea ceTarea)
        {
            try
            {
                GeneralQuery = "insert into Tarea (nombre,descripcion, estadoF) values('" + ceTarea.Nombre + "',' " + ceTarea.Descricion + "'," + ceTarea.EstadoFk + " );";
                CreateRegister(GeneralQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Error al Registrar la tarea", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }            

        }

        public DataSet ReadTask()
        {
            GeneralQuery = "select t.id as Id, t.nombre as Nombre, t.descripcion as Descripcion, e.nombre as Estado from Tarea t join Estado e on (t.estadoF = e.id); ";
            VisualizerName = "TareaVisualizer";
            dataSet = new DataSet();

            ReadRegister(GeneralQuery, VisualizerName, dataSet);
            return dataSet;
        }

        public void UpdateTask(CETarea cETarea)
        {
            GeneralQuery = " update Tarea set nombre = '" + cETarea.Nombre + "', estadoF = " + cETarea.EstadoFk  + "where id =" + cETarea.Id+ " ;";
            UpdatedRegister(GeneralQuery);
        }

        public void DeleteTask(CETarea cet)
        {
            GeneralQuery = " delete Tarea where id = " + cet.Id + "; ";
            DeleteRegister(GeneralQuery);
        }
                
    }

}
