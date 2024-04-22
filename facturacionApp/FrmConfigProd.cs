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
    public partial class FrmConfigProd : Form
    {
        public FrmConfigProd()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            Class_Conexion CC = new Class_Conexion();
            string Sql;
            DataTable dt = new DataTable();
            CC.CON.Open();
            Sql = "Select * from TB_Producto ";
            CC.DA = new SqlDataAdapter(Sql, CC.CON);
            CC.DA.Fill(dt);
            dataGridView1.DataSource = dt;
            CC.CON.Close();
        }

        public void Limpiar()
        {
            TxtIdProd.Text = "";
            TxtNomProd.Text = "";
            TxtPrecioProd.Text = "";
        }

        private void FrmConfigProd_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoProd_Click(object sender, EventArgs e)
        {
            if (TxtNomProd.Text == "" || TxtPrecioProd.Text == "")
            {
                MessageBox.Show("Debe llenar los campos requeridos");
            }
            else
            {
                Class_Productos CP = new Class_Productos();
                CP.Nombreproducto = TxtNomProd.Text;
                CP.Precioproducto = Convert.ToInt32(TxtPrecioProd.Text);
                if (CP.NuevoProducto())
                {
                    MessageBox.Show("Producto registrado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Registrar");
                }
            }
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            if (TxtIdProd.Text == "")
            {
                MessageBox.Show("Debe introducir un Id a buscar");
            }
            else
            {
                Class_Productos CP = new Class_Productos();
                CP.Idproducto = TxtIdProd.Text;

                if (CP.BuscarProducto())
                {
                    TxtNomProd.Text = CP.Nombreproducto;
                    TxtPrecioProd.Text = CP.Precioproducto.ToString();
                    BtnNuevoProd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Id incorrecto o no registrado");
                }
            }
        }

        private void BtnActuaProd_Click(object sender, EventArgs e)
        {
            if (TxtIdProd.Text == "")
            {
                MessageBox.Show("Debe primero buscar el usuario");
            }
            else
            {
                if (TxtNomProd.Text == "" || TxtPrecioProd.Text == "")
                {
                    MessageBox.Show("No Puede dejar Campos vacios");
                }
                else
                {
                    Class_Productos CP = new Class_Productos();
                    CP.Idproducto = TxtIdProd.Text;
                    CP.Nombreproducto = TxtNomProd.Text;
                    CP.Precioproducto = Convert.ToInt32(TxtPrecioProd.Text);
                    if (CP.ActualizarProducto())
                    {
                        MessageBox.Show("Usuario actualizado");
                        BtnNuevoProd.Enabled = true;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
            }
        }

        private void BtnElimProd_Click(object sender, EventArgs e)
        {
            if (TxtIdProd.Text == "")
            {
                MessageBox.Show("Debe buscar un producto el cual eliminar");
            }
            else
            {
                Class_Productos CP = new Class_Productos();
                CP.Idproducto = TxtIdProd.Text;

                if (CP.EliminarProducto())
                {
                    MessageBox.Show("Usuario eliminado");
                    BtnNuevoProd.Enabled = true;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            Limpiar();
            MostrarDatos();
        }

        private void TxtBuscarProd_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarProd.Text == "")
            {
                MostrarDatos();
            }
            else
            {
                Class_Conexion CC = new Class_Conexion();
                string Sql;
                DataTable dt = new DataTable();
                CC.CON.Open();
                Sql = "Select * from TB_Producto Where Nombre_Producto Like '" + TxtBuscarProd.Text + "%' ";
                CC.DA = new SqlDataAdapter(Sql, CC.CON);
                CC.DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CC.CON.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TxtIdProd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.TxtNomProd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.TxtPrecioProd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
