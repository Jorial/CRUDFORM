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
    public partial class FormAsignaciones : Form
    {
        CNUsuario cnUser = new CNUsuario();
        CEUsuario ceUsuario = new CEUsuario();

        CNTarea cnTarea = new CNTarea();
        CETarea ceTarea = new CETarea(); 
        
        CEAsignacion ceAsignation = new CEAsignacion();
        CNAsignacion cnAsignation = new CNAsignacion();

        public FormAsignaciones()
        {
            InitializeComponent();
            UploadDataToCbxUserAsigned();
            UploadDataToCbxTaskAsigned();
            ReadAllAssignmentClient();
        }


        public void UploadDataToCbxUserAsigned()
        {
            CbxUsuarioAsignacion.DataSource = cnUser.ReadUserValidated().Tables["UserVisualizer"];
            CbxUsuarioAsignacion.DisplayMember = "Nombre y Apellido";
            CbxUsuarioAsignacion.ValueMember = "id";
        }

        public void UploadDataToCbxTaskAsigned()
        {
            CbxTareaAsignacion.DataSource = cnTarea.ReadTaskValidated().Tables["TareaVisualizer"];
            CbxTareaAsignacion.DisplayMember = "Nombre";
            CbxTareaAsignacion.ValueMember = "id";

        }

        private void BtnGuardarAsignacion_Click(object sender, EventArgs e)
        {
            CreateAsignationCliente();
            ReadAllAssignmentClient();
        }
        public void CreateAsignationCliente()
        {
            ceAsignation.UsuarioFk = Convert.ToInt32( CbxUsuarioAsignacion.SelectedValue);
            ceAsignation.TareaFk = Convert.ToInt32( CbxTareaAsignacion.SelectedValue);
            cnAsignation.CreateAsignationValidated(ceAsignation);
        }

        public void ReadAllAssignmentClient()
        {
            TblAssignment.DataSource = cnAsignation.ReadAllAssignments().Tables["AsignacionesVisualizer"];
        }

        private void TblTarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
