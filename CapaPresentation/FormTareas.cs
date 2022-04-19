using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace CapaPresentation
{
    public partial class FormTareas : Form
    {
        CNEstado cnEstado = new CNEstado();
        CNTarea cnTarea = new CNTarea();
        CETarea ceTarea = new CETarea();
        public FormTareas()
        {
            InitializeComponent();
            UploadCBXEstado();
            ReadAllTask();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Save Method       
        public void SaveTask()
        {
            CETarea cet = new CETarea();
            cet.Nombre = TxtNombreTarea.Text;
            cet.Descricion = TxtDescripcionTara.Text;
            cet.EstadoFk = Convert.ToInt32(CbxEstadoTarea.SelectedValue);
            cnTarea.CreateTaskValidated(cet);
            ReadAllTask();
        }
        private void BtnGuardarTarea_Click(object sender, EventArgs e)
        {
            SaveTask();
            clearForm();
        }

        public void UploadCBXEstado()
        {
            CbxEstadoTarea.DataSource = cnEstado.ReadStateValidated().Tables["EstadoVisualizer"];
            CbxEstadoTarea.DisplayMember = "nombre";
            CbxEstadoTarea.ValueMember = "id";
            Cbxvalues.DataSource = cnEstado.ReadStateValidated().Tables["EstadoVisualizer"];
            Cbxvalues.DisplayMember = "id";
        }

        // Read data
        public void ReadAllTask()
        {
            
            TblTarea.DataSource = cnTarea.ReadTaskValidated().Tables["TareaVisualizer"];
        }

        // Update Task
        public void UploadTaskClient()
        {
            ceTarea.Id = Convert.ToInt32(TxtIdTarea.Text);
            ceTarea.Nombre = TxtNombreTarea.Text;
            ceTarea.Descricion = TxtDescripcionTara.Text;
            ceTarea.EstadoFk = Convert.ToInt16(CbxEstadoTarea.SelectedValue);

            cnTarea.UpdateTaskValidated(ceTarea);
            ReadAllTask();
            clearForm();
        }

        private void BtnEditarTarea_Click(object sender, EventArgs e)
        {
            UploadTaskClient();
        }

        public void clearForm()
        {
            TxtIdTarea.Text = null;
            TxtDescripcionTara.Text = null;
            TxtNombreTarea.Text =null;
            
        }

        private void BtnNuevoTarea_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        public void DeleteTaskcClient()
        {
            ceTarea.Id = Convert.ToInt32(TxtIdTarea.Text);
            cnTarea.DeleteTaskValidate(ceTarea);
            
        }

        private void BtnEliminarTarea_Click(object sender, EventArgs e)
        {
            DeleteTaskcClient();
            ReadAllTask();
            clearForm();
        }
    }
}
