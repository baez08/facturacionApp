
namespace facturacionApp
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Barratitulo = new System.Windows.Forms.Panel();
            this.BtnMinLog = new System.Windows.Forms.Button();
            this.BtnCerrarLogin = new System.Windows.Forms.Button();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Barratitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Barratitulo
            // 
            this.Barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Barratitulo.Controls.Add(this.BtnMinLog);
            this.Barratitulo.Controls.Add(this.BtnCerrarLogin);
            this.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barratitulo.Location = new System.Drawing.Point(0, 0);
            this.Barratitulo.Name = "Barratitulo";
            this.Barratitulo.Size = new System.Drawing.Size(358, 36);
            this.Barratitulo.TabIndex = 9;
            this.Barratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barratitulo_Paint);
            this.Barratitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barratitulo_MouseMove);
            // 
            // BtnMinLog
            // 
            this.BtnMinLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnMinLog.FlatAppearance.BorderSize = 0;
            this.BtnMinLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinLog.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinLog.Image")));
            this.BtnMinLog.Location = new System.Drawing.Point(273, 1);
            this.BtnMinLog.Name = "BtnMinLog";
            this.BtnMinLog.Size = new System.Drawing.Size(40, 34);
            this.BtnMinLog.TabIndex = 2;
            this.BtnMinLog.UseVisualStyleBackColor = false;
            this.BtnMinLog.Click += new System.EventHandler(this.BtnMinLog_Click);
            // 
            // BtnCerrarLogin
            // 
            this.BtnCerrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCerrarLogin.FlatAppearance.BorderSize = 0;
            this.BtnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarLogin.Image")));
            this.BtnCerrarLogin.Location = new System.Drawing.Point(316, 1);
            this.BtnCerrarLogin.Name = "BtnCerrarLogin";
            this.BtnCerrarLogin.Size = new System.Drawing.Size(40, 34);
            this.BtnCerrarLogin.TabIndex = 1;
            this.BtnCerrarLogin.UseVisualStyleBackColor = false;
            this.BtnCerrarLogin.Click += new System.EventHandler(this.BtnCerrarLogin_Click);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.LinkLabel1.Location = new System.Drawing.Point(66, 418);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(228, 21);
            this.LinkLabel1.TabIndex = 15;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Ha olvidado su contraseña?";
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAcceder.FlatAppearance.BorderSize = 0;
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAcceder.Location = new System.Drawing.Point(22, 365);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(315, 34);
            this.BtnAcceder.TabIndex = 14;
            this.BtnAcceder.Text = "ACCEDER";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(22, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(22, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 1);
            this.panel1.TabIndex = 12;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContraseña.Location = new System.Drawing.Point(22, 310);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(315, 20);
            this.TxtContraseña.TabIndex = 11;
            this.TxtContraseña.Text = "CONTRASEÑA";
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(22, 255);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(315, 20);
            this.TxtUsuario.TabIndex = 10;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(358, 533);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.Barratitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Barratitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Barratitulo;
        private System.Windows.Forms.Button BtnMinLog;
        private System.Windows.Forms.Button BtnCerrarLogin;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtContraseña;
        public System.Windows.Forms.TextBox TxtUsuario;
    }
}