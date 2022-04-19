namespace CapaPresentation
{
    partial class FormTareas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEliminarTarea = new FontAwesome.Sharp.IconButton();
            this.BtnEditarTarea = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarTarea = new FontAwesome.Sharp.IconButton();
            this.TblTarea = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cbxvalues = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.CbxEstadoTarea = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionTara = new System.Windows.Forms.TextBox();
            this.TxtNombreTarea = new System.Windows.Forms.TextBox();
            this.TxtIdTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNuevoTarea = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.TblTarea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminarTarea
            // 
            this.BtnEliminarTarea.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarTarea.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminarTarea.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BtnEliminarTarea.IconColor = System.Drawing.Color.White;
            this.BtnEliminarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarTarea.IconSize = 40;
            this.BtnEliminarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarTarea.Location = new System.Drawing.Point(377, 573);
            this.BtnEliminarTarea.Name = "BtnEliminarTarea";
            this.BtnEliminarTarea.Size = new System.Drawing.Size(158, 49);
            this.BtnEliminarTarea.TabIndex = 12;
            this.BtnEliminarTarea.Text = "Eliminar";
            this.BtnEliminarTarea.UseVisualStyleBackColor = false;
            this.BtnEliminarTarea.Click += new System.EventHandler(this.BtnEliminarTarea_Click);
            // 
            // BtnEditarTarea
            // 
            this.BtnEditarTarea.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditarTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarTarea.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditarTarea.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditarTarea.IconColor = System.Drawing.Color.White;
            this.BtnEditarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditarTarea.IconSize = 40;
            this.BtnEditarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarTarea.Location = new System.Drawing.Point(213, 573);
            this.BtnEditarTarea.Name = "BtnEditarTarea";
            this.BtnEditarTarea.Size = new System.Drawing.Size(158, 49);
            this.BtnEditarTarea.TabIndex = 11;
            this.BtnEditarTarea.Text = "Editar";
            this.BtnEditarTarea.UseVisualStyleBackColor = false;
            this.BtnEditarTarea.Click += new System.EventHandler(this.BtnEditarTarea_Click);
            // 
            // BtnGuardarTarea
            // 
            this.BtnGuardarTarea.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardarTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarTarea.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardarTarea.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardarTarea.IconColor = System.Drawing.Color.White;
            this.BtnGuardarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarTarea.IconSize = 40;
            this.BtnGuardarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarTarea.Location = new System.Drawing.Point(49, 573);
            this.BtnGuardarTarea.Name = "BtnGuardarTarea";
            this.BtnGuardarTarea.Size = new System.Drawing.Size(158, 49);
            this.BtnGuardarTarea.TabIndex = 10;
            this.BtnGuardarTarea.Text = "Guardar";
            this.BtnGuardarTarea.UseVisualStyleBackColor = false;
            this.BtnGuardarTarea.Click += new System.EventHandler(this.BtnGuardarTarea_Click);
            // 
            // TblTarea
            // 
            this.TblTarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TblTarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TblTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblTarea.DefaultCellStyle = dataGridViewCellStyle2;
            this.TblTarea.GridColor = System.Drawing.SystemColors.Control;
            this.TblTarea.Location = new System.Drawing.Point(705, 103);
            this.TblTarea.MinimumSize = new System.Drawing.Size(90, 0);
            this.TblTarea.MultiSelect = false;
            this.TblTarea.Name = "TblTarea";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TblTarea.RowTemplate.Height = 25;
            this.TblTarea.Size = new System.Drawing.Size(747, 460);
            this.TblTarea.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Cbxvalues);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.CbxEstadoTarea);
            this.panel1.Controls.Add(this.TxtDescripcionTara);
            this.panel1.Controls.Add(this.TxtNombreTarea);
            this.panel1.Controls.Add(this.TxtIdTarea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 460);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cbxvalues
            // 
            this.Cbxvalues.FormattingEnabled = true;
            this.Cbxvalues.Location = new System.Drawing.Point(41, 380);
            this.Cbxvalues.Name = "Cbxvalues";
            this.Cbxvalues.Size = new System.Drawing.Size(233, 23);
            this.Cbxvalues.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(41, 156);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(51, 15);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre";
            // 
            // CbxEstadoTarea
            // 
            this.CbxEstadoTarea.FormattingEnabled = true;
            this.CbxEstadoTarea.Location = new System.Drawing.Point(41, 351);
            this.CbxEstadoTarea.Name = "CbxEstadoTarea";
            this.CbxEstadoTarea.Size = new System.Drawing.Size(233, 23);
            this.CbxEstadoTarea.TabIndex = 4;
            // 
            // TxtDescripcionTara
            // 
            this.TxtDescripcionTara.Location = new System.Drawing.Point(41, 232);
            this.TxtDescripcionTara.Multiline = true;
            this.TxtDescripcionTara.Name = "TxtDescripcionTara";
            this.TxtDescripcionTara.Size = new System.Drawing.Size(426, 81);
            this.TxtDescripcionTara.TabIndex = 3;
            // 
            // TxtNombreTarea
            // 
            this.TxtNombreTarea.Location = new System.Drawing.Point(41, 174);
            this.TxtNombreTarea.Name = "TxtNombreTarea";
            this.TxtNombreTarea.Size = new System.Drawing.Size(426, 23);
            this.TxtNombreTarea.TabIndex = 2;
            // 
            // TxtIdTarea
            // 
            this.TxtIdTarea.Location = new System.Drawing.Point(41, 110);
            this.TxtIdTarea.Name = "TxtIdTarea";
            this.TxtIdTarea.Size = new System.Drawing.Size(103, 23);
            this.TxtIdTarea.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(605, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 44);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tareas";
            // 
            // BtnNuevoTarea
            // 
            this.BtnNuevoTarea.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevoTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevoTarea.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevoTarea.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.BtnNuevoTarea.IconColor = System.Drawing.Color.White;
            this.BtnNuevoTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevoTarea.IconSize = 40;
            this.BtnNuevoTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoTarea.Location = new System.Drawing.Point(541, 573);
            this.BtnNuevoTarea.Name = "BtnNuevoTarea";
            this.BtnNuevoTarea.Size = new System.Drawing.Size(158, 49);
            this.BtnNuevoTarea.TabIndex = 16;
            this.BtnNuevoTarea.Text = "Nuevo";
            this.BtnNuevoTarea.UseVisualStyleBackColor = false;
            this.BtnNuevoTarea.Click += new System.EventHandler(this.BtnNuevoTarea_Click);
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 659);
            this.Controls.Add(this.BtnNuevoTarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TblTarea);
            this.Controls.Add(this.BtnEliminarTarea);
            this.Controls.Add(this.BtnEditarTarea);
            this.Controls.Add(this.BtnGuardarTarea);
            this.Name = "FormTareas";
            this.Text = "FormTareas";
            ((System.ComponentModel.ISupportInitialize)(this.TblTarea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnEliminarTarea;
        private FontAwesome.Sharp.IconButton BtnEditarTarea;
        private FontAwesome.Sharp.IconButton BtnGuardarTarea;
        private DataGridView TblTarea;
        private Panel panel1;
        private ComboBox CbxEstadoTarea;
        private TextBox TxtDescripcionTara;
        private TextBox TxtNombreTarea;
        private TextBox TxtIdTarea;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label LblNombre;
        private Label label4;
        private FontAwesome.Sharp.IconButton BtnNuevoTarea;
        private ComboBox Cbxvalues;
    }
}