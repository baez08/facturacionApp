using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace facturacionApp
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MostrarDatos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("G");
        }

        public void MostrarDatos()
        {
            Class_Conexion CC = new Class_Conexion();
            string Sql;
            DataTable dt = new DataTable();
            CC.CON.Open();
            Sql = "Select * from TB_Factura";
            CC.DA = new SqlDataAdapter(Sql, CC.CON);
            CC.DA.Fill(dt);
            dataGridView1.DataSource = dt;
            CC.CON.Close();
        }
    }
}
