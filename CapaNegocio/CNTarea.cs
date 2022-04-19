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
    public class CNTarea
    {
        CDTarea cdt = new CDTarea();

        public bool ValidateData(CETarea ceTarea)
        {
            if (ceTarea.Id == null && ceTarea.Nombre == null && ceTarea.Descricion == null)
            {
                return false;
            }
            return true;
        }



        public void CreateTaskValidated(CETarea ceTarea)
        {
            try
            {
                if (ValidateData(ceTarea) == true)
                {
                    cdt.CreateTask(ceTarea);
                }
                else
                {
                    MessageBox.Show("Datos Requeridos *", "Debe de llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
           

        }

        public DataSet ReadTaskValidated()
        {
            try
            {
                return cdt.ReadTask();
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Update Task
        public void UpdateTaskValidated(CETarea cE )
        {
            cdt.UpdateTask(cE);
        }

        // Delete Task
        public void DeleteTaskValidate(CETarea cet)
        {
            cdt.DeleteTask(cet);
        }
                    

    }
}
