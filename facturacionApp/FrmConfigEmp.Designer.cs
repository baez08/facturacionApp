
namespace facturacionApp
{
    partial class FrmConfigEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigEmp));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtnBuscar1 = new System.Windows.Forms.Button();
            this.TxtBuscarEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtgDatosEmp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CbbPuestoEmp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.BtnNuevoEmp = new System.Windows.Forms.Button();
            this.BtnElimEmp = new System.Windows.Forms.Button();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnActuaEmp = new System.Windows.Forms.Button();
            this.TxtApelEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNomEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosEmp)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(781, 537);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(182, 37);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 459);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabPage4.Controls.Add(this.BtnBuscar1);
            this.tabPage4.Controls.Add(this.TxtBuscarEmp);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.DtgDatosEmp);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(943, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver empleados";
            // 
            // BtnBuscar1
            // 
            this.BtnBuscar1.Location = new System.Drawing.Point(716, 12);
            this.BtnBuscar1.Name = "BtnBuscar1";
            this.BtnBuscar1.Size = new System.Drawing.Size(92, 36);
            this.BtnBuscar1.TabIndex = 6;
            this.BtnBuscar1.Text = "Buscar";
            this.BtnBuscar1.UseVisualStyleBackColor = true;
            this.BtnBuscar1.Visible = false;
            // 
            // TxtBuscarEmp
            // 
            this.TxtBuscarEmp.Location = new System.Drawing.Point(246, 75);
            this.TxtBuscarEmp.Name = "TxtBuscarEmp";
            this.TxtBuscarEmp.Size = new System.Drawing.Size(665, 27);
            this.TxtBuscarEmp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del empleado :";
            // 
            // DtgDatosEmp
            // 
            this.DtgDatosEmp.AllowUserToAddRows = false;
            this.DtgDatosEmp.AllowUserToDeleteRows = false;
            this.DtgDatosEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDatosEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosEmp.Location = new System.Drawing.Point(25, 117);
            this.DtgDatosEmp.Name = "DtgDatosEmp";
            this.DtgDatosEmp.ReadOnly = true;
            this.DtgDatosEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgDatosEmp.Size = new System.Drawing.Size(886, 299);
            this.DtgDatosEmp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMPLEADOS";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.CbbPuestoEmp);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnBuscar2);
            this.tabPage2.Controls.Add(this.BtnNuevoEmp);
            this.tabPage2.Controls.Add(this.BtnElimEmp);
            this.tabPage2.Controls.Add(this.TxtIdEmpleado);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnActuaEmp);
            this.tabPage2.Controls.Add(this.TxtApelEmp);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtNomEmp);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar o Modificar Empleados";
            // 
            // CbbPuestoEmp
            // 
            this.CbbPuestoEmp.FormattingEnabled = true;
            this.CbbPuestoEmp.Items.AddRange(new object[] {
            "Barbero",
            "Cobrador"});
            this.CbbPuestoEmp.Location = new System.Drawing.Point(165, 204);
            this.CbbPuestoEmp.Name = "CbbPuestoEmp";
            this.CbbPuestoEmp.Size = new System.Drawing.Size(360, 29);
            this.CbbPuestoEmp.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(78, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Puesto :";
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.BackColor = System.Drawing.Color.LightGray;
            this.BtnBuscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar2.FlatAppearance.BorderSize = 0;
            this.BtnBuscar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar2.Image")));
            this.BtnBuscar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar2.Location = new System.Drawing.Point(531, 81);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(108, 37);
            this.BtnBuscar2.TabIndex = 24;
            this.BtnBuscar2.Text = "       BUSCAR";
            this.BtnBuscar2.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoEmp
            // 
            this.BtnNuevoEmp.BackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoEmp.FlatAppearance.BorderSize = 0;
            this.BtnNuevoEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnNuevoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoEmp.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoEmp.Image")));
            this.BtnNuevoEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoEmp.Location = new System.Drawing.Point(219, 254);
            this.BtnNuevoEmp.Name = "BtnNuevoEmp";
            this.BtnNuevoEmp.Size = new System.Drawing.Size(262, 37);
            this.BtnNuevoEmp.TabIndex = 23;
            this.BtnNuevoEmp.Text = "AÑADIR";
            this.BtnNuevoEmp.UseVisualStyleBackColor = false;
            // 
            // BtnElimEmp
            // 
            this.BtnElimEmp.BackColor = System.Drawing.Color.LightGray;
            this.BtnElimEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElimEmp.FlatAppearance.BorderSize = 0;
            this.BtnElimEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnElimEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimEmp.Image = ((System.Drawing.Image)(resources.GetObject("BtnElimEmp.Image")));
            this.BtnElimEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElimEmp.Location = new System.Drawing.Point(219, 340);
            this.BtnElimEmp.Name = "BtnElimEmp";
            this.BtnElimEmp.Size = new System.Drawing.Size(262, 37);
            this.BtnElimEmp.TabIndex = 22;
            this.BtnElimEmp.Text = "ELIMINAR";
            this.BtnElimEmp.UseVisualStyleBackColor = false;
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(165, 88);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(360, 27);
            this.TxtIdEmpleado.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(22, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Id Empleado :";
            // 
            // BtnActuaEmp
            // 
            this.BtnActuaEmp.BackColor = System.Drawing.Color.LightGray;
            this.BtnActuaEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActuaEmp.FlatAppearance.BorderSize = 0;
            this.BtnActuaEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnActuaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActuaEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuaEmp.Image = ((System.Drawing.Image)(resources.GetObject("BtnActuaEmp.Image")));
            this.BtnActuaEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActuaEmp.Location = new System.Drawing.Point(219, 297);
            this.BtnActuaEmp.Name = "BtnActuaEmp";
            this.BtnActuaEmp.Size = new System.Drawing.Size(262, 37);
            this.BtnActuaEmp.TabIndex = 18;
            this.BtnActuaEmp.Text = "ACTUALIZAR";
            this.BtnActuaEmp.UseVisualStyleBackColor = false;
            // 
            // TxtApelEmp
            // 
            this.TxtApelEmp.Location = new System.Drawing.Point(165, 164);
            this.TxtApelEmp.Name = "TxtApelEmp";
            this.TxtApelEmp.Size = new System.Drawing.Size(360, 27);
            this.TxtApelEmp.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(56, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Apellidos :";
            // 
            // TxtNomEmp
            // 
            this.TxtNomEmp.Location = new System.Drawing.Point(165, 126);
            this.TxtNomEmp.Name = "TxtNomEmp";
            this.TxtNomEmp.Size = new System.Drawing.Size(360, 27);
            this.TxtNomEmp.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(57, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(289, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "CONFIGURACIÓN EMPLEADOS";
            // 
            // FrmConfigEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(991, 624);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigEmp";
            this.Text = "FrmConfigEmp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosEmp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnBuscar1;
        private System.Windows.Forms.TextBox TxtBuscarEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DtgDatosEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CbbPuestoEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.Button BtnNuevoEmp;
        private System.Windows.Forms.Button BtnElimEmp;
        private System.Windows.Forms.TextBox TxtIdEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnActuaEmp;
        private System.Windows.Forms.TextBox TxtApelEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNomEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}