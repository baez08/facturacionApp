
namespace facturacionApp
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnSalirFacturación = new System.Windows.Forms.Button();
            this.BtnFacturarProductos = new System.Windows.Forms.Button();
            this.BtnAñadirProducto = new System.Windows.Forms.Button();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.TxtDevolucion = new System.Windows.Forms.TextBox();
            this.TxtEfectivo = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CbbProducto = new System.Windows.Forms.ComboBox();
            this.CbbBarbero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(450, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 33);
            this.label8.TabIndex = 35;
            this.label8.Text = "Lista de productos a facturar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // BtnRemover
            // 
            this.BtnRemover.BackColor = System.Drawing.Color.LightGray;
            this.BtnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemover.FlatAppearance.BorderSize = 0;
            this.BtnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemover.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemover.Image")));
            this.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemover.Location = new System.Drawing.Point(150, 266);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(269, 37);
            this.BtnRemover.TabIndex = 33;
            this.BtnRemover.Text = "ELIMINAR";
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnSalirFacturación
            // 
            this.BtnSalirFacturación.BackColor = System.Drawing.Color.LightGray;
            this.BtnSalirFacturación.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirFacturación.FlatAppearance.BorderSize = 0;
            this.BtnSalirFacturación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSalirFacturación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirFacturación.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirFacturación.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalirFacturación.Image")));
            this.BtnSalirFacturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalirFacturación.Location = new System.Drawing.Point(150, 506);
            this.BtnSalirFacturación.Name = "BtnSalirFacturación";
            this.BtnSalirFacturación.Size = new System.Drawing.Size(269, 37);
            this.BtnSalirFacturación.TabIndex = 32;
            this.BtnSalirFacturación.Text = "SALIR";
            this.BtnSalirFacturación.UseVisualStyleBackColor = false;
            this.BtnSalirFacturación.Click += new System.EventHandler(this.BtnSalirFacturación_Click);
            // 
            // BtnFacturarProductos
            // 
            this.BtnFacturarProductos.BackColor = System.Drawing.Color.LightGray;
            this.BtnFacturarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturarProductos.FlatAppearance.BorderSize = 0;
            this.BtnFacturarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnFacturarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturarProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturarProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturarProductos.Image")));
            this.BtnFacturarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturarProductos.Location = new System.Drawing.Point(150, 454);
            this.BtnFacturarProductos.Name = "BtnFacturarProductos";
            this.BtnFacturarProductos.Size = new System.Drawing.Size(269, 37);
            this.BtnFacturarProductos.TabIndex = 31;
            this.BtnFacturarProductos.Text = "FACTURAR";
            this.BtnFacturarProductos.UseVisualStyleBackColor = false;
            this.BtnFacturarProductos.Click += new System.EventHandler(this.BtnFacturarProductos_Click);
            // 
            // BtnAñadirProducto
            // 
            this.BtnAñadirProducto.BackColor = System.Drawing.Color.LightGray;
            this.BtnAñadirProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAñadirProducto.FlatAppearance.BorderSize = 0;
            this.BtnAñadirProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAñadirProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadirProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnAñadirProducto.Image")));
            this.BtnAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAñadirProducto.Location = new System.Drawing.Point(150, 218);
            this.BtnAñadirProducto.Name = "BtnAñadirProducto";
            this.BtnAñadirProducto.Size = new System.Drawing.Size(269, 37);
            this.BtnAñadirProducto.TabIndex = 30;
            this.BtnAñadirProducto.Text = "AÑADIR";
            this.BtnAñadirProducto.UseVisualStyleBackColor = false;
            this.BtnAñadirProducto.Click += new System.EventHandler(this.BtnAñadirProducto_Click);
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDetalles.BackgroundColor = System.Drawing.Color.White;
            this.DtgDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Productos,
            this.Costo});
            this.DtgDetalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DtgDetalles.Location = new System.Drawing.Point(456, 173);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DtgDetalles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgDetalles.Size = new System.Drawing.Size(501, 363);
            this.DtgDetalles.TabIndex = 29;
            // 
            // TxtDevolucion
            // 
            this.TxtDevolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDevolucion.Location = new System.Drawing.Point(150, 411);
            this.TxtDevolucion.Name = "TxtDevolucion";
            this.TxtDevolucion.Size = new System.Drawing.Size(269, 27);
            this.TxtDevolucion.TabIndex = 28;
            this.TxtDevolucion.Text = "0";
            this.TxtDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEfectivo
            // 
            this.TxtEfectivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfectivo.Location = new System.Drawing.Point(150, 367);
            this.TxtEfectivo.Name = "TxtEfectivo";
            this.TxtEfectivo.Size = new System.Drawing.Size(269, 27);
            this.TxtEfectivo.TabIndex = 27;
            this.TxtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEfectivo.TextChanged += new System.EventHandler(this.TxtEfectivo_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(150, 323);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(269, 27);
            this.TxtTotal.TabIndex = 26;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbbProducto
            // 
            this.CbbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbbProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbProducto.FormattingEnabled = true;
            this.CbbProducto.Location = new System.Drawing.Point(150, 173);
            this.CbbProducto.Name = "CbbProducto";
            this.CbbProducto.Size = new System.Drawing.Size(269, 29);
            this.CbbProducto.TabIndex = 25;
            this.CbbProducto.Enter += new System.EventHandler(this.CbbProducto_Enter);
            // 
            // CbbBarbero
            // 
            this.CbbBarbero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbBarbero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbbBarbero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbBarbero.FormattingEnabled = true;
            this.CbbBarbero.Location = new System.Drawing.Point(150, 130);
            this.CbbBarbero.Name = "CbbBarbero";
            this.CbbBarbero.Size = new System.Drawing.Size(269, 29);
            this.CbbBarbero.TabIndex = 24;
            this.CbbBarbero.Enter += new System.EventHandler(this.CbbBarbero_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(19, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Devolución :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(49, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Efectivo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(81, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(39, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Producto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(51, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cajero :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "AREA DE FACTURACIÓN";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Cajero";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(977, 585);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnSalirFacturación);
            this.Controls.Add(this.BtnFacturarProductos);
            this.Controls.Add(this.BtnAñadirProducto);
            this.Controls.Add(this.DtgDetalles);
            this.Controls.Add(this.TxtDevolucion);
            this.Controls.Add(this.TxtEfectivo);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.CbbProducto);
            this.Controls.Add(this.CbbBarbero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacion";
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnSalirFacturación;
        private System.Windows.Forms.Button BtnFacturarProductos;
        private System.Windows.Forms.Button BtnAñadirProducto;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.TextBox TxtDevolucion;
        private System.Windows.Forms.TextBox TxtEfectivo;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.ComboBox CbbProducto;
        private System.Windows.Forms.ComboBox CbbBarbero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}