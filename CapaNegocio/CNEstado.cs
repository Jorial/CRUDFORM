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
    public class CNEstado
    {        
        public bool ValidateState(CEEstado estado)
        {
            if (estado.Nombre == String.Empty)
            {
                MessageBox.Show("El Nombre del Estado es Requerido");
                return false;
            }
            return true;
        }
        public bool FieldValidated(CEEstado ceEstado)
        {
           
            if (ceEstado.Nombre == String.Empty)
            {
                MessageBox.Show("Campo Requerido");
                return false;
            }

            
            return true;

        }

        CDEstado cd = new CDEstado();
        public void CreateStateValidated(CEEstado ceEstado)
        {
            try
            {
                if (ValidateState(ceEstado) == true)
                {
                    cd.CreateState(ceEstado);
                    MessageBox.Show("Registro Creado exitosamente");

                }
                else
                {
                    MessageBox.Show("No se ha podido crear el registro");
                }
                    
               
            }
            catch (Exception)
            {


                throw;
            }
            
        }

        public DataSet ReadStateValidated()
        {
            return cd.ReadState();
        }

      

        public void UpdateStateValidated(CEEstado ceEstado)
        {
            
            if (FieldValidated(ceEstado) ==  true)
            {
                cd.UpdateState(ceEstado);
                MessageBox.Show("Estado Actualizado", "Se ha Actualizado un registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Campos Requeridos *");
            } 

           
            
            
        }

        public void DeleteStateValidated(CEEstado ceEstado)
        {
            try
            {
                if (ceEstado.Id != null)
                {
                    cd.DeleteState(ceEstado);
                    MessageBox.Show("Estado Eliminado", "Se ha Eliminado un registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Campos Requeridos *");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
                throw;
            }
            
        }


    }

}
