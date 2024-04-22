using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace facturacionApp
{
    public partial class FrmComprobante : Form
    {
        public List<Datos> datos = new List<Datos>();
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_FACT_BDDataSet.TB_Factura' Puede moverla o quitarla según sea necesario.
            //this.TB_FacturaTableAdapter.Fill(this._FACT_BDDataSet.TB_Factura);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datos));
            this.reportViewer1.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
