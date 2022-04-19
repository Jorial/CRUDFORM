using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaData
{
    public class CDUsuario: CRUD_SuperClass
    {

        public void CreateUser(CEUsuario ceu)
        {
            GeneralQuery = " insert into Usuario (nombre, apellido, usuarioN, contrasena) values ('" + ceu.Nombre + "','" +ceu.Apellido +"','" + ceu.NombreUsuario +"','"+ ceu.Contrasena + "'); ";
            CreateRegister(GeneralQuery);
        }

        public DataSet ReadUser()
        {
            try
            {
                dataSet = new DataSet();
                GeneralQuery = " select id as Id, concat(nombre,' ', apellido) as 'Nombre y Apellido', usuarioN as 'Nombre de usuario', contrasena as Contrasena from Usuario; ";
                VisualizerName = "UserVisualizer";
                ReadRegister(GeneralQuery, VisualizerName, dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error" + ex.Message);
                throw;
            }
          
        }

        public void UpdateUser(CEUsuario ceu)
        {
            GeneralQuery = "update Usuario set nombre = '" + ceu.Nombre + "', apellido = '" + ceu.Apellido+"', usuarioN = '" + ceu.NombreUsuario +  "', contrasena = '"  + ceu.Contrasena + "' where id =" + ceu.Id + "; ";
            UpdatedRegister(GeneralQuery);
        }
         public void DeleteUser(CEUsuario cee)
        {
            GeneralQuery = "delete usuario where id =" + cee.Id + ";";
            DeleteRegister(GeneralQuery);
        }
    }
}
