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
    public partial class FrmConfigEmp : Form
    {
        public FrmConfigEmp()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            Class_Conexion CC = new Class_Conexion();
            string Sql;
            DataTable dt = new DataTable();
            CC.CON.Open();
            Sql = "Select * from TB_Empleado ";
            CC.DA = new SqlDataAdapter(Sql, CC.CON);
            CC.DA.Fill(dt);
            DtgDatosEmp.DataSource = dt;
            CC.CON.Close();
        }

        public void Limpiar()
        {
            TxtIdEmpleado.Text = "";
            TxtNomEmp.Text = "";
            TxtApelEmp.Text = "";
            CbbPuestoEmp.Text = "";
        }

        private void FrmConfigEmp_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoEmp_Click(object sender, EventArgs e)
        {
            if (TxtApelEmp.Text == "" || TxtNomEmp.Text == "" || CbbPuestoEmp.Text == "")
            {
                MessageBox.Show("Debe llenar los campos requeridos");
            }
            else
            {
                Class_Empleados CE = new Class_Empleados();
                CE.Nombreempleado = TxtNomEmp.Text;
                CE.Apellidosempleado = TxtApelEmp.Text;
                CE.Puestoempleado = CbbPuestoEmp.Text;
                if (CE.NuevoEmpleado())
                {
                    MessageBox.Show("Empleado registrado");
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
            if (TxtIdEmpleado.Text == "")
            {
                MessageBox.Show("Debe introducir un Id a buscar");
            }
            else
            {
                Class_Empleados CE = new Class_Empleados();
                CE.Idempleado = TxtIdEmpleado.Text;

                if (CE.BuscarEmpleado())
                {
                    TxtNomEmp.Text = CE.Nombreempleado;
                    TxtApelEmp.Text = CE.Apellidosempleado;
                    CbbPuestoEmp.Text = CE.Puestoempleado;
                    BtnNuevoEmp.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Id incorrecto o no registrado");
                }
            }
        }

        private void BtnActuaEmp_Click(object sender, EventArgs e)
        {
            if (TxtIdEmpleado.Text == "")
            {
                MessageBox.Show("Debe primero buscar el usuario");
            }
            else
            {
                if (TxtNomEmp.Text == "" || TxtApelEmp.Text == "" || CbbPuestoEmp.Text == "")
                {
                    MessageBox.Show("No Puede dejar Campos vacios");
                }
                else
                {
                    Class_Empleados CE = new Class_Empleados();
                    CE.Idempleado = TxtIdEmpleado.Text;
                    CE.Nombreempleado = TxtNomEmp.Text;
                    CE.Apellidosempleado = TxtApelEmp.Text;
                    CE.Puestoempleado = CbbPuestoEmp.Text;
                    if (CE.ActualizarEmpleado())
                    {
                        MessageBox.Show("Usuario actualizado");
                        BtnNuevoEmp.Enabled = true;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
            }
        }

        private void BtnElimEmp_Click(object sender, EventArgs e)
        {
            if (TxtIdEmpleado.Text == "")
            {
                MessageBox.Show("Debe buscar un empleado el cual eliminar");
            }
            else
            {
                Class_Empleados CE = new Class_Empleados();
                CE.Idempleado = TxtIdEmpleado.Text;

                if (CE.EliminarEmpleado())
                {
                    MessageBox.Show("Usuario eliminado");
                    BtnNuevoEmp.Enabled = true;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }

        private void DtgDatosEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TxtIdEmpleado.Text = DtgDatosEmp.CurrentRow.Cells[0].Value.ToString();
            this.TxtNomEmp.Text = DtgDatosEmp.CurrentRow.Cells[1].Value.ToString();
            this.TxtApelEmp.Text = DtgDatosEmp.CurrentRow.Cells[2].Value.ToString();
            this.CbbPuestoEmp.Text = DtgDatosEmp.CurrentRow.Cells[3].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void TxtBuscarEmp_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarEmp.Text == "")
            {
                MostrarDatos();
            }
            else
            {
                Class_Conexion CC = new Class_Conexion();
                string Sql;
                DataTable dt = new DataTable();
                CC.CON.Open();
                Sql = "Select * from TB_Empleado Where Nombres_Empleado Like '" + TxtBuscarEmp.Text + "%' ";
                CC.DA = new SqlDataAdapter(Sql, CC.CON);
                CC.DA.Fill(dt);
                DtgDatosEmp.DataSource = dt;
                CC.CON.Close();
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            Limpiar();
            MostrarDatos();
        }
    }
}
