namespace CapaPresentation
{
    partial class FormEstadosA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEliminarEstado = new FontAwesome.Sharp.IconButton();
            this.BtnEditarEstado = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarEstado = new FontAwesome.Sharp.IconButton();
            this.TblEstado = new System.Windows.Forms.DataGridView();
            this.TxtIdEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.BtnEliminarEstado);
            this.groupBox1.Controls.Add(this.BtnEditarEstado);
            this.groupBox1.Controls.Add(this.BtnGuardarEstado);
            this.groupBox1.Controls.Add(this.TblEstado);
            this.groupBox1.Controls.Add(this.TxtIdEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombreEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(79, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 363);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Estado";
            // 
            // BtnEliminarEstado
            // 
            this.BtnEliminarEstado.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarEstado.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEstado.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BtnEliminarEstado.IconColor = System.Drawing.Color.White;
            this.BtnEliminarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarEstado.IconSize = 40;
            this.BtnEliminarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarEstado.Location = new System.Drawing.Point(14, 298);
            this.BtnEliminarEstado.Name = "BtnEliminarEstado";
            this.BtnEliminarEstado.Size = new System.Drawing.Size(190, 49);
            this.BtnEliminarEstado.TabIndex = 9;
            this.BtnEliminarEstado.Text = "Eliminar";
            this.BtnEliminarEstado.UseVisualStyleBackColor = false;
            this.BtnEliminarEstado.Click += new System.EventHandler(this.BtnEliminarEstado_Click);
            // 
            // BtnEditarEstado
            // 
            this.BtnEditarEstado.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditarEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarEstado.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditarEstado.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditarEstado.IconColor = System.Drawing.Color.White;
            this.BtnEditarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditarEstado.IconSize = 40;
            this.BtnEditarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarEstado.Location = new System.Drawing.Point(14, 243);
            this.BtnEditarEstado.Name = "BtnEditarEstado";
            this.BtnEditarEstado.Size = new System.Drawing.Size(190, 49);
            this.BtnEditarEstado.TabIndex = 8;
            this.BtnEditarEstado.Text = "Editar";
            this.BtnEditarEstado.UseVisualStyleBackColor = false;
            this.BtnEditarEstado.Click += new System.EventHandler(this.BtnEditarEstado_Click);
            // 
            // BtnGuardarEstado
            // 
            this.BtnGuardarEstado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardarEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarEstado.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardarEstado.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardarEstado.IconColor = System.Drawing.Color.White;
            this.BtnGuardarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarEstado.IconSize = 40;
            this.BtnGuardarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEstado.Location = new System.Drawing.Point(14, 188);
            this.BtnGuardarEstado.Name = "BtnGuardarEstado";
            this.BtnGuardarEstado.Size = new System.Drawing.Size(190, 49);
            this.BtnGuardarEstado.TabIndex = 7;
            this.BtnGuardarEstado.Text = "Guardar";
            this.BtnGuardarEstado.UseVisualStyleBackColor = false;
            this.BtnGuardarEstado.Click += new System.EventHandler(this.BtnGuardarEstado_Click);
            // 
            // TblEstado
            // 
            this.TblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TblEstado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblEstado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TblEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblEstado.DefaultCellStyle = dataGridViewCellStyle2;
            this.TblEstado.GridColor = System.Drawing.SystemColors.Control;
            this.TblEstado.Location = new System.Drawing.Point(210, 22);
            this.TblEstado.MultiSelect = false;
            this.TblEstado.Name = "TblEstado";
            this.TblEstado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblEstado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TblEstado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TblEstado.RowTemplate.Height = 25;
            this.TblEstado.Size = new System.Drawing.Size(450, 325);
            this.TblEstado.TabIndex = 3;
            this.TblEstado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TblEstado_CellMouseDoubleClick);
            // 
            // TxtIdEstado
            // 
            this.TxtIdEstado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtIdEstado.Location = new System.Drawing.Point(14, 73);
            this.TxtIdEstado.Name = "TxtIdEstado";
            this.TxtIdEstado.Size = new System.Drawing.Size(59, 23);
            this.TxtIdEstado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // TxtNombreEstado
            // 
            this.TxtNombreEstado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreEstado.Location = new System.Drawing.Point(14, 138);
            this.TxtNombreEstado.Name = "TxtNombreEstado";
            this.TxtNombreEstado.Size = new System.Drawing.Size(190, 23);
            this.TxtNombreEstado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // FormEstadosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEstadosA";
            this.Text = "FormAjustes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox TxtIdEstado;
        private Label label2;
        private TextBox TxtNombreEstado;
        private Label label3;
        private DataGridView TblEstado;
        private FontAwesome.Sharp.IconButton BtnEliminarEstado;
        private FontAwesome.Sharp.IconButton BtnEditarEstado;
        private FontAwesome.Sharp.IconButton BtnGuardarEstado;
    }
}