using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;



namespace CapaData
{
    public class CDEstado: CRUD_SuperClass
    {

        public void CreateState(CEEstado ceEstado)
        {
            try
            {
                GeneralQuery = "insert into Estado (nombre) values ('" + ceEstado.Nombre + "');";
                CreateRegister(GeneralQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "Se ha producido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
                    
            
        }

        public DataSet ReadState()
        {
            try
            {
                GeneralQuery = "select * from Estado;";
                VisualizerName = "EstadoVisualizer";
                ReadRegister(GeneralQuery, VisualizerName, dataSet = new DataSet());
                return dataSet;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Cargar los datos" + e.Message);
                throw;
            }
                       
        }

        public void UpdateState(CEEstado ceEstado)
        {
            try
            {
                GeneralQuery = "update Estado set nombre ='" + ceEstado.Nombre + "' where id =" + ceEstado.Id + ";";
                UpdatedRegister(GeneralQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Actualizar el Estado"+ e.Message, " Error ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
           
        }

        public void DeleteState(CEEstado ceEstado)
        {
            try
            {
                GeneralQuery = "delete Estado where id =" + ceEstado.Id + ";";
                DeleteRegister(GeneralQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error" + e.Message);
                throw;
            }
        }


      
              

    }
}
