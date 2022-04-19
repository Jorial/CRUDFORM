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
    public partial class FormUsuarios : Form
    {
        CEUsuario ceUser = new CEUsuario();
        CNUsuario cnUser = new CNUsuario(); 
        
        public FormUsuarios()
        {
            InitializeComponent();
            ReadUsers();
        }

        private void BtnGuardarUsuario_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        public void SaveUser()
        {
            ceUser.Nombre = TxtNombreUsuario.Text;
            ceUser.Apellido = TxtApellidoUsuario.Text;  
            ceUser.NombreUsuario = TxtUsuarioUsuario.Text;
            ceUser.Contrasena = TxtConsenaUsuario.Text;
            cnUser.CrateUserValidated(ceUser);
            ReadUsers();
        }

        public void ReadUsers()
        {
            TblUsuario.DataSource = cnUser.ReadUserValidated().Tables["UserVisualizer"];
        }

        public void UpdateUserClient()
        {
            ceUser.Nombre = TxtNombreUsuario.Text;
            ceUser.Apellido= TxtApellidoUsuario.Text;
            ceUser.NombreUsuario= TxtUsuarioUsuario.Text;
            ceUser.Contrasena = TxtConsenaUsuario.Text;
            ceUser.Id = Convert.ToInt32(TxtIdUsuario.Text);
            cnUser.UpdateUserValidated(ceUser);
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            UpdateUserClient();
            ReadUsers();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DeleteUserCliente();
            ReadUsers();
            
        }

        public void DeleteUserCliente()
        {
            ceUser.Id = Convert.ToInt32(TxtIdUsuario.Text);
                     cnUser.DeleteUserValidated(ceUser);
        }

    

        public void ClearUserClient()
        {
            TxtNombreUsuario.Text = string.Empty;
            TxtApellidoUsuario.Text= string.Empty;
            TxtIdUsuario.Text = string.Empty;
            TxtConsenaUsuario.Text=string.Empty;
            TxtUsuarioUsuario.Text = string.Empty;
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            ClearUserClient();
        }
    }
}
