using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentation
{
    public partial class FormEstadosA : Form
    {
        CNEstado capaNegocioEstado = new CNEstado();
        public FormEstadosA()
        {
            InitializeComponent();
            ReadAllStates();
        }

        private void BtnGuardarEstado_Click(object sender, EventArgs e)
        {
            SaveState();
            ReadAllStates();
        }

        //  Method Save State
        public void SaveState()
        {
            CEEstado ceEstado = new CEEstado();
            ceEstado.Nombre = TxtNombreEstado.Text;

            capaNegocioEstado.CreateStateValidated(ceEstado);
            ReadAllStates();
            //MessageBox.Show("Estado Registrado", "Se ha insertado un nuevo registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // REad States
        public void ReadAllStates()
        {

            TblEstado.DataSource = capaNegocioEstado.ReadStateValidated().Tables["EstadoVisualizer"];

            
        }


        // Update States
        public void UpdateStatePresentation()
        {
            try
            {
                if (TxtNombreEstado.Text == string.Empty && TxtIdEstado.Text == string.Empty)
                {
                    MessageBox.Show("El Id y el Nombre son requeridos para la actualizacion");
                }
                else
                {
                    CEEstado ceEstado = new CEEstado();
                    ceEstado.Nombre = TxtNombreEstado.Text;
                    ceEstado.Id = Convert.ToInt32(TxtIdEstado.Text);

                    capaNegocioEstado.UpdateStateValidated(ceEstado);
                    ReadAllStates();

                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                throw;
            }

        }

        private void BtnEditarEstado_Click(object sender, EventArgs e)
        {
            UpdateStatePresentation();
        }

        public void DeleteStatePresentation()
        {
            try
            {
                CEEstado ceEstado = new CEEstado();
                ceEstado.Id = Convert.ToInt32(TxtIdEstado.Text);
                capaNegocioEstado.DeleteStateValidated(ceEstado);
                ReadAllStates();
                // MessageBox.Show("Se ha eliminado Satisfactoriamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }

        private void BtnEliminarEstado_Click(object sender, EventArgs e)
        {
            DeleteStatePresentation();
        }

        private void TblEstado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public void FillTableState()
        {
            
            
        }
    }
}
