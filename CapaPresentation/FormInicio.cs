using CapaNegocio;
using CapaEntidades;
using FontAwesome.Sharp;
namespace CapaPresentation
{
    public partial class FormInicio : Form
    {      
        
        
        public FormInicio()
        {
            InitializeComponent();
            OpenForm(MenuTareas, new FormTareas());
            
        }

      

        // **************    Trabajando con los formularios ****************


        // 1. agragar referencias de Fontawesome.sharp
        // 2. Declarar una variable para contener el menu activo de tipo IconMenuItem y una variable tipo form

        private static IconMenuItem? MenuActivo = null;
        private static Form? formularioActivo = null;

        // 3. Crear un metodo para abarir los formularios 

        private void OpenForm(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.WhiteSmoke;
            }
            menu.BackColor = Color.Teal;
            MenuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            PanelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuConfiguraciones_Click(object sender, EventArgs e)
        {

        }

        // 4 llamar al metodo OpenForm y pasar los parametros
        private void MenuTareas_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new FormTareas() );
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender,new FormUsuarios());
        }

        private void MenuAsignaciones_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new FormAsignaciones());
        }

        private void MenuInformacion_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new FormInformacion());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(MenuConfiguraciones, new FormEstadosA());
            
        }
    }
}