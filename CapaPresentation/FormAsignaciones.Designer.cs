namespace CapaPresentation
{
    partial class FormAsignaciones
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
            this.BtnNuevaAsignacion = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxUsuarioAsignacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.CbxTareaAsignacion = new System.Windows.Forms.ComboBox();
            this.TxtIdAsignacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TblAssignment = new System.Windows.Forms.DataGridView();
            this.BtnEliminarAsignacion = new FontAwesome.Sharp.IconButton();
            this.BtnEditarAsignacion = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarAsignacion = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevaAsignacion
            // 
            this.BtnNuevaAsignacion.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevaAsignacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevaAsignacion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevaAsignacion.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.BtnNuevaAsignacion.IconColor = System.Drawing.Color.White;
            this.BtnNuevaAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevaAsignacion.IconSize = 40;
            this.BtnNuevaAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevaAsignacion.Location = new System.Drawing.Point(506, 539);
            this.BtnNuevaAsignacion.Name = "BtnNuevaAsignacion";
            this.BtnNuevaAsignacion.Size = new System.Drawing.Size(158, 49);
            this.BtnNuevaAsignacion.TabIndex = 23;
            this.BtnNuevaAsignacion.Text = "Nuevo";
            this.BtnNuevaAsignacion.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 44);
            this.label4.TabIndex = 22;
            this.label4.Text = "Asignaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.CbxUsuarioAsignacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.CbxTareaAsignacion);
            this.panel1.Controls.Add(this.TxtIdAsignacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 442);
            this.panel1.TabIndex = 21;
            // 
            // CbxUsuarioAsignacion
            // 
            this.CbxUsuarioAsignacion.FormattingEnabled = true;
            this.CbxUsuarioAsignacion.Location = new System.Drawing.Point(41, 174);
            this.CbxUsuarioAsignacion.Name = "CbxUsuarioAsignacion";
            this.CbxUsuarioAsignacion.Size = new System.Drawing.Size(233, 23);
            this.CbxUsuarioAsignacion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarea";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(41, 156);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 15);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Usuario";
            // 
            // CbxTareaAsignacion
            // 
            this.CbxTareaAsignacion.FormattingEnabled = true;
            this.CbxTareaAsignacion.Location = new System.Drawing.Point(41, 232);
            this.CbxTareaAsignacion.Name = "CbxTareaAsignacion";
            this.CbxTareaAsignacion.Size = new System.Drawing.Size(233, 23);
            this.CbxTareaAsignacion.TabIndex = 4;
            // 
            // TxtIdAsignacion
            // 
            this.TxtIdAsignacion.Location = new System.Drawing.Point(41, 110);
            this.TxtIdAsignacion.Name = "TxtIdAsignacion";
            this.TxtIdAsignacion.Size = new System.Drawing.Size(103, 23);
            this.TxtIdAsignacion.TabIndex = 1;
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
            // TblAssignment
            // 
            this.TblAssignment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TblAssignment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TblAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblAssignment.DefaultCellStyle = dataGridViewCellStyle5;
            this.TblAssignment.GridColor = System.Drawing.SystemColors.Control;
            this.TblAssignment.Location = new System.Drawing.Point(670, 87);
            this.TblAssignment.MinimumSize = new System.Drawing.Size(90, 0);
            this.TblAssignment.MultiSelect = false;
            this.TblAssignment.Name = "TblAssignment";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblAssignment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TblAssignment.RowTemplate.Height = 25;
            this.TblAssignment.Size = new System.Drawing.Size(747, 442);
            this.TblAssignment.TabIndex = 20;
            this.TblAssignment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblTarea_CellContentClick);
            // 
            // BtnEliminarAsignacion
            // 
            this.BtnEliminarAsignacion.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarAsignacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarAsignacion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminarAsignacion.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BtnEliminarAsignacion.IconColor = System.Drawing.Color.White;
            this.BtnEliminarAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarAsignacion.IconSize = 40;
            this.BtnEliminarAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarAsignacion.Location = new System.Drawing.Point(342, 539);
            this.BtnEliminarAsignacion.Name = "BtnEliminarAsignacion";
            this.BtnEliminarAsignacion.Size = new System.Drawing.Size(158, 49);
            this.BtnEliminarAsignacion.TabIndex = 19;
            this.BtnEliminarAsignacion.Text = "Eliminar";
            this.BtnEliminarAsignacion.UseVisualStyleBackColor = false;
            // 
            // BtnEditarAsignacion
            // 
            this.BtnEditarAsignacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditarAsignacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarAsignacion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditarAsignacion.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditarAsignacion.IconColor = System.Drawing.Color.White;
            this.BtnEditarAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditarAsignacion.IconSize = 40;
            this.BtnEditarAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarAsignacion.Location = new System.Drawing.Point(178, 539);
            this.BtnEditarAsignacion.Name = "BtnEditarAsignacion";
            this.BtnEditarAsignacion.Size = new System.Drawing.Size(158, 49);
            this.BtnEditarAsignacion.TabIndex = 18;
            this.BtnEditarAsignacion.Text = "Editar";
            this.BtnEditarAsignacion.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarAsignacion
            // 
            this.BtnGuardarAsignacion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardarAsignacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarAsignacion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardarAsignacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardarAsignacion.IconColor = System.Drawing.Color.White;
            this.BtnGuardarAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarAsignacion.IconSize = 40;
            this.BtnGuardarAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarAsignacion.Location = new System.Drawing.Point(14, 539);
            this.BtnGuardarAsignacion.Name = "BtnGuardarAsignacion";
            this.BtnGuardarAsignacion.Size = new System.Drawing.Size(158, 49);
            this.BtnGuardarAsignacion.TabIndex = 17;
            this.BtnGuardarAsignacion.Text = "Guardar";
            this.BtnGuardarAsignacion.UseVisualStyleBackColor = false;
            this.BtnGuardarAsignacion.Click += new System.EventHandler(this.BtnGuardarAsignacion_Click);
            // 
            // FormAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 687);
            this.Controls.Add(this.BtnNuevaAsignacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TblAssignment);
            this.Controls.Add(this.BtnEliminarAsignacion);
            this.Controls.Add(this.BtnEditarAsignacion);
            this.Controls.Add(this.BtnGuardarAsignacion);
            this.Name = "FormAsignaciones";
            this.Text = "FormAsignaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnNuevaAsignacion;
        private Label label4;
        private Panel panel1;
        private ComboBox CbxUsuarioAsignacion;
        private Label label2;
        private Label LblNombre;
        private ComboBox CbxTareaAsignacion;
        private TextBox TxtIdAsignacion;
        private Label label1;
        private DataGridView TblAssignment;
        private FontAwesome.Sharp.IconButton BtnEliminarAsignacion;
        private FontAwesome.Sharp.IconButton BtnEditarAsignacion;
        private FontAwesome.Sharp.IconButton BtnGuardarAsignacion;
    }
}