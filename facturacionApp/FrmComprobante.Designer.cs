
namespace facturacionApp
{
    partial class FrmComprobante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobante));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TB_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FACT_BDDataSet = new facturacionApp._FACT_BDDataSet();
            this.Barratitulo = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TB_FacturaTableAdapter = new facturacionApp._FACT_BDDataSetTableAdapters.TB_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FACT_BDDataSet)).BeginInit();
            this.Barratitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_FacturaBindingSource
            // 
            this.TB_FacturaBindingSource.DataMember = "TB_Factura";
            this.TB_FacturaBindingSource.DataSource = this._FACT_BDDataSet;
            // 
            // _FACT_BDDataSet
            // 
            this._FACT_BDDataSet.DataSetName = "_FACT_BDDataSet";
            this._FACT_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Barratitulo
            // 
            this.Barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Barratitulo.Controls.Add(this.BtnCerrar);
            this.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barratitulo.Location = new System.Drawing.Point(0, 0);
            this.Barratitulo.Name = "Barratitulo";
            this.Barratitulo.Size = new System.Drawing.Size(339, 36);
            this.Barratitulo.TabIndex = 2;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(297, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 34);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TB_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacionApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(336, 542);
            this.reportViewer1.TabIndex = 3;
            // 
            // TB_FacturaTableAdapter
            // 
            this.TB_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 578);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Barratitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComprobante";
            this.Text = "FrmComprobante";
            this.Load += new System.EventHandler(this.FrmComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FACT_BDDataSet)).EndInit();
            this.Barratitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barratitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TB_FacturaBindingSource;
        private _FACT_BDDataSet _FACT_BDDataSet;
        private _FACT_BDDataSetTableAdapters.TB_FacturaTableAdapter TB_FacturaTableAdapter;
    }
}