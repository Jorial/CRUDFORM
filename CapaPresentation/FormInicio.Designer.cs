namespace CapaPresentation
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuConfiguraciones = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuEstados = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTareas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAsignaciones = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInformacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConfiguraciones,
            this.MenuTareas,
            this.MenuUsuarios,
            this.MenuAsignaciones,
            this.MenuInformacion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1463, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuConfiguraciones
            // 
            this.MenuConfiguraciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuEstados});
            this.MenuConfiguraciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuConfiguraciones.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuConfiguraciones.IconColor = System.Drawing.Color.Black;
            this.MenuConfiguraciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuConfiguraciones.IconSize = 45;
            this.MenuConfiguraciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuConfiguraciones.Name = "MenuConfiguraciones";
            this.MenuConfiguraciones.Size = new System.Drawing.Size(65, 68);
            this.MenuConfiguraciones.Text = "Ajustes";
            this.MenuConfiguraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuConfiguraciones.Click += new System.EventHandler(this.MenuConfiguraciones_Click);
            // 
            // SubMenuEstados
            // 
            this.SubMenuEstados.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.SubMenuEstados.IconColor = System.Drawing.Color.Black;
            this.SubMenuEstados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuEstados.IconSize = 30;
            this.SubMenuEstados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubMenuEstados.Name = "SubMenuEstados";
            this.SubMenuEstados.Size = new System.Drawing.Size(139, 36);
            this.SubMenuEstados.Text = "Estados";
            this.SubMenuEstados.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // MenuTareas
            // 
            this.MenuTareas.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.MenuTareas.IconColor = System.Drawing.Color.Black;
            this.MenuTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuTareas.IconSize = 45;
            this.MenuTareas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuTareas.Name = "MenuTareas";
            this.MenuTareas.Size = new System.Drawing.Size(57, 68);
            this.MenuTareas.Text = "Tareas";
            this.MenuTareas.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MenuTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuTareas.Click += new System.EventHandler(this.MenuTareas_Click);
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 45;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(64, 68);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuAsignaciones
            // 
            this.MenuAsignaciones.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.MenuAsignaciones.IconColor = System.Drawing.Color.Black;
            this.MenuAsignaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAsignaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAsignaciones.Name = "MenuAsignaciones";
            this.MenuAsignaciones.Size = new System.Drawing.Size(89, 68);
            this.MenuAsignaciones.Text = "Asignaciones";
            this.MenuAsignaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuAsignaciones.Click += new System.EventHandler(this.MenuAsignaciones_Click);
            // 
            // MenuInformacion
            // 
            this.MenuInformacion.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.MenuInformacion.IconColor = System.Drawing.Color.Black;
            this.MenuInformacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInformacion.IconSize = 45;
            this.MenuInformacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInformacion.Name = "MenuInformacion";
            this.MenuInformacion.Size = new System.Drawing.Size(71, 68);
            this.MenuInformacion.Text = "Acerca de";
            this.MenuInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInformacion.Click += new System.EventHandler(this.MenuInformacion_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Teal;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1463, 37);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1463, 655);
            this.PanelContenedor.TabIndex = 3;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 655);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuConfiguraciones;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem MenuTareas;
        private FontAwesome.Sharp.IconMenuItem SubMenuEstados;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem MenuAsignaciones;
        private FontAwesome.Sharp.IconMenuItem MenuInformacion;
        private Panel PanelContenedor;
    }
}