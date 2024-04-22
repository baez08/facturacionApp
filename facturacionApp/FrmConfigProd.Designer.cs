
namespace facturacionApp
{
    partial class FrmConfigProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigProd));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TxtBuscarProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.BtnNuevoProd = new System.Windows.Forms.Button();
            this.BtnElimProd = new System.Windows.Forms.Button();
            this.TxtIdProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnActuaProd = new System.Windows.Forms.Button();
            this.TxtPrecioProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNomProd = new System.Windows.Forms.TextBox();
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
            this.BtnSalir.Location = new System.Drawing.Point(781, 537);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(182, 37);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabPage4.Controls.Add(this.TxtBuscarProd);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(943, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver productos";
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // TxtBuscarProd
            // 
            this.TxtBuscarProd.Location = new System.Drawing.Point(241, 75);
            this.TxtBuscarProd.Name = "TxtBuscarProd";
            this.TxtBuscarProd.Size = new System.Drawing.Size(670, 27);
            this.TxtBuscarProd.TabIndex = 5;
            this.TxtBuscarProd.TextChanged += new System.EventHandler(this.TxtBuscarProd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del producto :";
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
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.tabPage2.Controls.Add(this.BtnNuevoProd);
            this.tabPage2.Controls.Add(this.BtnElimProd);
            this.tabPage2.Controls.Add(this.TxtIdProd);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnActuaProd);
            this.tabPage2.Controls.Add(this.TxtPrecioProd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtNomProd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar o Modificar Producto";
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
            this.BtnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // BtnNuevoProd
            // 
            this.BtnNuevoProd.BackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoProd.FlatAppearance.BorderSize = 0;
            this.BtnNuevoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnNuevoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoProd.Image")));
            this.BtnNuevoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoProd.Location = new System.Drawing.Point(277, 247);
            this.BtnNuevoProd.Name = "BtnNuevoProd";
            this.BtnNuevoProd.Size = new System.Drawing.Size(262, 37);
            this.BtnNuevoProd.TabIndex = 23;
            this.BtnNuevoProd.Text = "AÑADIR";
            this.BtnNuevoProd.UseVisualStyleBackColor = false;
            this.BtnNuevoProd.Click += new System.EventHandler(this.BtnNuevoProd_Click);
            // 
            // BtnElimProd
            // 
            this.BtnElimProd.BackColor = System.Drawing.Color.LightGray;
            this.BtnElimProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElimProd.FlatAppearance.BorderSize = 0;
            this.BtnElimProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnElimProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnElimProd.Image")));
            this.BtnElimProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElimProd.Location = new System.Drawing.Point(277, 333);
            this.BtnElimProd.Name = "BtnElimProd";
            this.BtnElimProd.Size = new System.Drawing.Size(262, 37);
            this.BtnElimProd.TabIndex = 22;
            this.BtnElimProd.Text = "ELIMINAR";
            this.BtnElimProd.UseVisualStyleBackColor = false;
            this.BtnElimProd.Click += new System.EventHandler(this.BtnElimProd_Click);
            // 
            // TxtIdProd
            // 
            this.TxtIdProd.Location = new System.Drawing.Point(228, 92);
            this.TxtIdProd.Name = "TxtIdProd";
            this.TxtIdProd.Size = new System.Drawing.Size(360, 27);
            this.TxtIdProd.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(56, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Buscar producto :";
            // 
            // BtnActuaProd
            // 
            this.BtnActuaProd.BackColor = System.Drawing.Color.LightGray;
            this.BtnActuaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActuaProd.FlatAppearance.BorderSize = 0;
            this.BtnActuaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnActuaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActuaProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuaProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnActuaProd.Image")));
            this.BtnActuaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActuaProd.Location = new System.Drawing.Point(277, 290);
            this.BtnActuaProd.Name = "BtnActuaProd";
            this.BtnActuaProd.Size = new System.Drawing.Size(262, 37);
            this.BtnActuaProd.TabIndex = 18;
            this.BtnActuaProd.Text = "ACTUALIZAR";
            this.BtnActuaProd.UseVisualStyleBackColor = false;
            this.BtnActuaProd.Click += new System.EventHandler(this.BtnActuaProd_Click);
            // 
            // TxtPrecioProd
            // 
            this.TxtPrecioProd.Location = new System.Drawing.Point(228, 196);
            this.TxtPrecioProd.Name = "TxtPrecioProd";
            this.TxtPrecioProd.Size = new System.Drawing.Size(360, 27);
            this.TxtPrecioProd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(84, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio o valor :";
            // 
            // TxtNomProd
            // 
            this.TxtNomProd.Location = new System.Drawing.Point(228, 143);
            this.TxtNomProd.Name = "TxtNomProd";
            this.TxtNomProd.Size = new System.Drawing.Size(360, 27);
            this.TxtNomProd.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(8, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre del producto :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(322, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "CONFIGURACIÓN PRODUCTOS";
            // 
            // FrmConfigProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(991, 624);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigProd";
            this.Text = "FrmConfigProd";
            this.Load += new System.EventHandler(this.FrmConfigProd_Load);
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
        private System.Windows.Forms.TextBox TxtBuscarProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.Button BtnNuevoProd;
        private System.Windows.Forms.Button BtnElimProd;
        private System.Windows.Forms.TextBox TxtIdProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnActuaProd;
        private System.Windows.Forms.TextBox TxtPrecioProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNomProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}