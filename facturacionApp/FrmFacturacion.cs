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
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

        }

        public void Cajero()
        {
            DataTable dt = new DataTable();
            string Sql;
            Class_Conexion C = new Class_Conexion();

            C.CON.Open();
            Sql = "Select * from TB_Empleado Where Puesto_Empleado ='Cajero' ";

            C.DA = new SqlDataAdapter(Sql, C.CON);
            C.DA.Fill(dt);

            CbbBarbero.DataSource = dt;
            CbbBarbero.DisplayMember = "Nombre_Empleado";
            CbbBarbero.ValueMember = "Id_Empleado";
        }
        public void SeleccionarProducto()
        {
            DataTable dt = new DataTable();
            string Sql;
            Class_Conexion C = new Class_Conexion();

            C.CON.Open();
            Sql = "Select * from TB_Producto ";

            C.DA = new SqlDataAdapter(Sql, C.CON);
            C.DA.Fill(dt);

            CbbProducto.DataSource = dt;
            CbbProducto.DisplayMember = "Nombre_Producto";
            CbbProducto.ValueMember = "Id_Producto";
        }

        private void BtnSalirFacturación_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbbBarbero_Enter(object sender, EventArgs e)
        {
            Cajero();
        }

        private void CbbProducto_Enter(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }

        private void BtnAñadirProducto_Click(object sender, EventArgs e)
        {
            if (CbbBarbero.Text == "" || CbbProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un barbero y un producto");
            }
            else
            {
                string Sql;
                int Precio;
                int Suma = int.Parse(TxtTotal.Text);
                Class_Conexion C = new Class_Conexion();
                C.CON.Open();
                Sql = "Select * from TB_Producto Where Nombre_Producto = '" + CbbProducto.Text + "' ";
                C.CMD = new SqlCommand(Sql, C.CON);
                C.DR = C.CMD.ExecuteReader();

                C.DR.Read();

                Precio = Convert.ToInt32(C.DR["Precio_Producto"].ToString());
                C.CON.Close();

                DtgDetalles.Rows.Add(CbbBarbero.Text, CbbProducto.Text, Precio.ToString());
                Suma += Precio;
                TxtTotal.Text = Suma.ToString();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (DtgDetalles.CurrentRow is null)
            {
                MessageBox.Show("Debe a ver algun producto en la lista");
            }
            else
            {
                string Sql;
                int Precio;
                int Resta = int.Parse(TxtTotal.Text);
                Class_Conexion C = new Class_Conexion();
                C.CON.Open();
                Sql = "Select * from TB_Producto Where Nombres_Producto = '" + CbbProducto.Text + "' ";
                C.CMD = new SqlCommand(Sql, C.CON);
                C.DR = C.CMD.ExecuteReader();

                C.DR.Read();

                Precio = Convert.ToInt32(C.DR["Precio_Producto"].ToString());
                C.CON.Close();

                DtgDetalles.Rows.RemoveAt(DtgDetalles.CurrentRow.Index);
                Resta -= Precio;
                TxtTotal.Text = Resta.ToString();
            }
        }

        private void BtnFacturarProductos_Click(object sender, EventArgs e)
        {
            FrmContenedorAdmin FA = new FrmContenedorAdmin();
            Class_Facturacion CF = new Class_Facturacion();
            Class_Usuarios CU = new Class_Usuarios();
            CU.Nomusuario = label7.Text;
            if (CbbBarbero.Text == "" || CbbProducto.Text == "")
            {
                MessageBox.Show("Debe de agregar por lo menos un producto a la factura");
            }
            else if (int.Parse(TxtEfectivo.Text) < int.Parse(TxtTotal.Text))
            {
                MessageBox.Show("El monto a pagar no puede ser menos que el total de la factura");
            }
            else
            {
                if (CU.BuscarUsuarioNombre())
                {
                    foreach (DataGridViewRow rows in DtgDetalles.Rows)
                    {
                        CF.Detallefactura += Convert.ToString(rows.Cells["Productos"].Value) + ",";
                        CF.Totalapagar = Convert.ToInt32(TxtTotal.Text);
                        CF.Efectivo = Convert.ToInt32(TxtEfectivo.Text);
                        CF.Devolucion = Convert.ToInt32(TxtDevolucion.Text);
                        CF.Idusuario = CU.Idusuario;
                        CF.Fechafactura = DateTime.Now.ToString("dd/MM/yyyy");
                    }

                    CF.Detallefactura = CF.Detallefactura.Remove(CF.Detallefactura.Length - 1);
                    if (CF.NuevaFactura())
                    {
                        MessageBox.Show("Factura registrada");
                        CF.BuscarIdFactura();
                        FrmComprobante FC = new FrmComprobante();
                        for (int i = 0; i < DtgDetalles.RowCount; i++)
                        {
                            Datos datos = new Datos();
                            datos.Detallefactura = DtgDetalles.Rows[i].Cells[1].Value.ToString();
                            datos.Valor = int.Parse(DtgDetalles.Rows[i].Cells[2].Value.ToString());

                            if (i == DtgDetalles.RowCount - 1)
                            {
                                datos.Totalapagar = int.Parse(TxtTotal.Text);
                                datos.Efectivo = int.Parse(TxtEfectivo.Text);
                                datos.Devolucion = int.Parse(TxtDevolucion.Text);
                            }
                            datos.Fechafactura = DateTime.Now.ToString("dd/MM/yyyy");
                            datos.Idusuario = label7.Text;
                            datos.Idfactura = CF.Idfactura;
                            FC.datos.Add(datos);
                        }
                        CbbBarbero.Text = "";
                        CbbProducto.Text = "";
                        TxtTotal.Text = "0";
                        TxtEfectivo.Text = "0";
                        TxtDevolucion.Text = "0";
                        DtgDetalles.Rows.Clear();
                        FC.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Error al generar la factura");
                }
            }
        }

        private void TxtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (TxtEfectivo.Text == "")
            {
                TxtEfectivo.Text = "0";
                TxtDevolucion.Text = "0";
            }
            else
            {
                int A, B, C;
                A = int.Parse(TxtTotal.Text);
                B = int.Parse(TxtEfectivo.Text);
                C = B - A;
                TxtDevolucion.Text = C.ToString();
            }
        }
    }
}
