
namespace facturacionApp
{
    partial class FrmConfigUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigUsu));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TxtBuscarUsua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.BtnNuevoUsu = new System.Windows.Forms.Button();
            this.BtnElimUsu = new System.Windows.Forms.Button();
            this.TxtIdUsua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnActuaUsu = new System.Windows.Forms.Button();
            this.TxtContUsu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNomUsu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.BtnSalir.Location = new System.Drawing.Point(789, 557);
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
            this.tabControl1.Location = new System.Drawing.Point(20, 84);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 459);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabPage4.Controls.Add(this.TxtBuscarUsua);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(943, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver usuarios";
            // 
            // TxtBuscarUsua
            // 
            this.TxtBuscarUsua.Location = new System.Drawing.Point(218, 74);
            this.TxtBuscarUsua.Name = "TxtBuscarUsua";
            this.TxtBuscarUsua.Size = new System.Drawing.Size(693, 27);
            this.TxtBuscarUsua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del usuario :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(886, 299);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCTOS";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.BtnBuscar2);
            this.tabPage2.Controls.Add(this.BtnNuevoUsu);
            this.tabPage2.Controls.Add(this.BtnElimUsu);
            this.tabPage2.Controls.Add(this.TxtIdUsua);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnActuaUsu);
            this.tabPage2.Controls.Add(this.TxtContUsu);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtNomUsu);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar o Modificar Usuarios";
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
            this.BtnBuscar2.Location = new System.Drawing.Point(594, 88);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(108, 37);
            this.BtnBuscar2.TabIndex = 24;
            this.BtnBuscar2.Text = "       BUSCAR";
            this.BtnBuscar2.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoUsu
            // 
            this.BtnNuevoUsu.BackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoUsu.FlatAppearance.BorderSize = 0;
            this.BtnNuevoUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnNuevoUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoUsu.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoUsu.Image")));
            this.BtnNuevoUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoUsu.Location = new System.Drawing.Point(279, 227);
            this.BtnNuevoUsu.Name = "BtnNuevoUsu";
            this.BtnNuevoUsu.Size = new System.Drawing.Size(262, 37);
            this.BtnNuevoUsu.TabIndex = 23;
            this.BtnNuevoUsu.Text = "AÑADIR";
            this.BtnNuevoUsu.UseVisualStyleBackColor = false;
            // 
            // BtnElimUsu
            // 
            this.BtnElimUsu.BackColor = System.Drawing.Color.LightGray;
            this.BtnElimUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElimUsu.FlatAppearance.BorderSize = 0;
            this.BtnElimUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnElimUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimUsu.Image = ((System.Drawing.Image)(resources.GetObject("BtnElimUsu.Image")));
            this.BtnElimUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElimUsu.Location = new System.Drawing.Point(279, 313);
            this.BtnElimUsu.Name = "BtnElimUsu";
            this.BtnElimUsu.Size = new System.Drawing.Size(262, 37);
            this.BtnElimUsu.TabIndex = 22;
            this.BtnElimUsu.Text = "ELIMINAR";
            this.BtnElimUsu.UseVisualStyleBackColor = false;
            // 
            // TxtIdUsua
            // 
            this.TxtIdUsua.Location = new System.Drawing.Point(228, 92);
            this.TxtIdUsua.Name = "TxtIdUsua";
            this.TxtIdUsua.Size = new System.Drawing.Size(360, 27);
            this.TxtIdUsua.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(50, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Buscar Id Usuario :";
            // 
            // BtnActuaUsu
            // 
            this.BtnActuaUsu.BackColor = System.Drawing.Color.LightGray;
            this.BtnActuaUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActuaUsu.FlatAppearance.BorderSize = 0;
            this.BtnActuaUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnActuaUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActuaUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuaUsu.Image = ((System.Drawing.Image)(resources.GetObject("BtnActuaUsu.Image")));
            this.BtnActuaUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActuaUsu.Location = new System.Drawing.Point(279, 270);
            this.BtnActuaUsu.Name = "BtnActuaUsu";
            this.BtnActuaUsu.Size = new System.Drawing.Size(262, 37);
            this.BtnActuaUsu.TabIndex = 18;
            this.BtnActuaUsu.Text = "ACTUALIZAR";
            this.BtnActuaUsu.UseVisualStyleBackColor = false;
            // 
            // TxtContUsu
            // 
            this.TxtContUsu.Location = new System.Drawing.Point(228, 168);
            this.TxtContUsu.Name = "TxtContUsu";
            this.TxtContUsu.Size = new System.Drawing.Size(360, 27);
            this.TxtContUsu.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(92, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contraseña :";
            // 
            // TxtNomUsu
            // 
            this.TxtNomUsu.Location = new System.Drawing.Point(228, 130);
            this.TxtNomUsu.Name = "TxtNomUsu";
            this.TxtNomUsu.Size = new System.Drawing.Size(360, 27);
            this.TxtNomUsu.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(23, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre del Usuario :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(347, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "CONFIGURACIÓN USUARIOS";
            // 
            // FrmConfigUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(991, 624);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigUsu";
            this.Text = "FrmConfigUsu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TxtBuscarUsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.Button BtnNuevoUsu;
        private System.Windows.Forms.Button BtnElimUsu;
        private System.Windows.Forms.TextBox TxtIdUsua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnActuaUsu;
        private System.Windows.Forms.TextBox TxtContUsu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNomUsu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}