namespace CapaPresentation
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TxtConsenaUsuario = new System.Windows.Forms.TextBox();
            this.TxtUsuarioUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.BtnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            this.BtnEditarUsuario = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TblUsuario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoUsuario
            // 
            this.BtnNuevoUsuario.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevoUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevoUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.BtnNuevoUsuario.IconColor = System.Drawing.Color.White;
            this.BtnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevoUsuario.IconSize = 40;
            this.BtnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(344, 305);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(158, 49);
            this.BtnNuevoUsuario.TabIndex = 23;
            this.BtnNuevoUsuario.Text = "Nuevo";
            this.BtnNuevoUsuario.UseVisualStyleBackColor = false;
            this.BtnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(580, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 44);
            this.label4.TabIndex = 22;
            this.label4.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.BtnNuevoUsuario);
            this.panel1.Controls.Add(this.TxtConsenaUsuario);
            this.panel1.Controls.Add(this.TxtUsuarioUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtApellidoUsuario);
            this.panel1.Controls.Add(this.BtnEliminarUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnGuardarUsuario);
            this.panel1.Controls.Add(this.BtnEditarUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.TxtNombreUsuario);
            this.panel1.Controls.Add(this.TxtIdUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 460);
            this.panel1.TabIndex = 21;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(277, 411);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TxtConsenaUsuario
            // 
            this.TxtConsenaUsuario.Location = new System.Drawing.Point(41, 331);
            this.TxtConsenaUsuario.Name = "TxtConsenaUsuario";
            this.TxtConsenaUsuario.Size = new System.Drawing.Size(233, 23);
            this.TxtConsenaUsuario.TabIndex = 12;
            this.TxtConsenaUsuario.UseSystemPasswordChar = true;
            // 
            // TxtUsuarioUsuario
            // 
            this.TxtUsuarioUsuario.Location = new System.Drawing.Point(41, 274);
            this.TxtUsuarioUsuario.Name = "TxtUsuarioUsuario";
            this.TxtUsuarioUsuario.Size = new System.Drawing.Size(233, 23);
            this.TxtUsuarioUsuario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // TxtApellidoUsuario
            // 
            this.TxtApellidoUsuario.Location = new System.Drawing.Point(41, 223);
            this.TxtApellidoUsuario.Name = "TxtApellidoUsuario";
            this.TxtApellidoUsuario.Size = new System.Drawing.Size(233, 23);
            this.TxtApellidoUsuario.TabIndex = 9;
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BtnEliminarUsuario.IconColor = System.Drawing.Color.White;
            this.BtnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarUsuario.IconSize = 40;
            this.BtnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(344, 251);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(158, 49);
            this.BtnEliminarUsuario.TabIndex = 19;
            this.BtnEliminarUsuario.Text = "Eliminar";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = false;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contrasena";
            // 
            // BtnGuardarUsuario
            // 
            this.BtnGuardarUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardarUsuario.IconColor = System.Drawing.Color.White;
            this.BtnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarUsuario.IconSize = 40;
            this.BtnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarUsuario.Location = new System.Drawing.Point(344, 141);
            this.BtnGuardarUsuario.Name = "BtnGuardarUsuario";
            this.BtnGuardarUsuario.Size = new System.Drawing.Size(158, 49);
            this.BtnGuardarUsuario.TabIndex = 17;
            this.BtnGuardarUsuario.Text = "Guardar";
            this.BtnGuardarUsuario.UseVisualStyleBackColor = false;
            this.BtnGuardarUsuario.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditarUsuario.IconColor = System.Drawing.Color.White;
            this.BtnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditarUsuario.IconSize = 40;
            this.BtnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarUsuario.Location = new System.Drawing.Point(344, 196);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(158, 49);
            this.BtnEditarUsuario.TabIndex = 18;
            this.BtnEditarUsuario.Text = "Editar";
            this.BtnEditarUsuario.UseVisualStyleBackColor = false;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(41, 147);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(51, 15);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(41, 165);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(233, 23);
            this.TxtNombreUsuario.TabIndex = 2;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(41, 110);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(103, 23);
            this.TxtIdUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // TblUsuario
            // 
            this.TblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TblUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TblUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblUsuario.DefaultCellStyle = dataGridViewCellStyle5;
            this.TblUsuario.GridColor = System.Drawing.SystemColors.Control;
            this.TblUsuario.Location = new System.Drawing.Point(557, 116);
            this.TblUsuario.MinimumSize = new System.Drawing.Size(90, 0);
            this.TblUsuario.MultiSelect = false;
            this.TblUsuario.Name = "TblUsuario";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TblUsuario.RowTemplate.Height = 25;
            this.TblUsuario.Size = new System.Drawing.Size(870, 460);
            this.TblUsuario.TabIndex = 20;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 659);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TblUsuario);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnNuevoUsuario;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private TextBox TxtApellidoUsuario;
        private Label label3;
        private Label label2;
        private Label LblNombre;
        private TextBox TxtNombreUsuario;
        private TextBox TxtIdUsuario;
        private Label label1;
        private DataGridView TblUsuario;
        private FontAwesome.Sharp.IconButton BtnEliminarUsuario;
        private FontAwesome.Sharp.IconButton BtnEditarUsuario;
        private FontAwesome.Sharp.IconButton BtnGuardarUsuario;
        private TextBox TxtConsenaUsuario;
        private TextBox TxtUsuarioUsuario;
        private RadioButton radioButton1;
    }
}