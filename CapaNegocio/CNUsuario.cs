using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using CapaData;

namespace CapaNegocio
{
    public class CNUsuario
    {
        CEUsuario ceUsuario = new CEUsuario();
        CDUsuario cDUsuario = new CDUsuario();

        
        public void CrateUserValidated(CEUsuario ceu)
        {
            try
            {
                cDUsuario.CreateUser(ceu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
            
        }

        public DataSet ReadUserValidated()
        {
            return cDUsuario.ReadUser();
        }

        public void UpdateUserValidated(CEUsuario ceu)
        {
            cDUsuario.UpdateUser(ceu);
        }

        public void DeleteUserValidated(CEUsuario ceU)
        {
            cDUsuario.DeleteUser(ceU);
        }


    }
}
