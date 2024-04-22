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
    public partial class FrmConfigUsu : Form
    {
        public FrmConfigUsu()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            Class_Conexion CC = new Class_Conexion();
            string Sql;
            DataTable dt = new DataTable();
            CC.CON.Open();
            Sql = "Select * from TB_Usuarios ";
            CC.DA = new SqlDataAdapter(Sql, CC.CON);
            CC.DA.Fill(dt);
            dataGridView1.DataSource = dt;
            CC.CON.Close();
        }
        public void Limpiar()
        {
            TxtIdUsua.Text = "";
            TxtNomUsu.Text = "";
            TxtContUsu.Text = "";

        }

        private void FrmConfigUsu_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            if (TxtIdUsua.Text == "")
            {
                MessageBox.Show("Debe introducir un Id a buscar");
            }
            else
            {
                Class_Usuarios CU = new Class_Usuarios();
                CU.Idusuario = TxtIdUsua.Text;

                if (CU.BuscarUsuario())
                {
                    TxtNomUsu.Text = CU.Nomusuario;
                    TxtContUsu.Text = CU.Contusuario;
                    BtnNuevoUsu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Id incorrecto o no registrado");
                }
            }
        }

        private void BtnNuevoUsu_Click(object sender, EventArgs e)
        {
            if (TxtNomUsu.Text == "" || TxtContUsu.Text == "")
            {
                MessageBox.Show("No Puede dejar campos vacios");
            }
            else
            {
                Class_Usuarios CU = new Class_Usuarios();
                CU.Nomusuario = TxtNomUsu.Text;
                CU.Contusuario = TxtContUsu.Text;

                if (CU.NuevoUsuario())
                {
                    MessageBox.Show("Usuario Registrado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Registrar");
                }

            }
        }

        private void BtnActuaUsu_Click(object sender, EventArgs e)
        {
            if (TxtIdUsua.Text == "")
            {
                MessageBox.Show("Debe primero buscar el usuario");
            }
            else
            {
                if (TxtNomUsu.Text == "" || TxtContUsu.Text == "")
                {
                    MessageBox.Show("No Puede dejar Campos vacios");
                }
                else
                {
                    Class_Usuarios CU = new Class_Usuarios();
                    CU.Idusuario = TxtIdUsua.Text;
                    CU.Nomusuario = TxtNomUsu.Text;
                    CU.Contusuario = TxtContUsu.Text;

                    if (CU.ActualizarUsuario())
                    {
                        MessageBox.Show("Usuario actualizado");
                        BtnNuevoUsu.Enabled = true;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
            }
        }

        private void BtnElimUsu_Click(object sender, EventArgs e)
        {
            if (TxtIdUsua.Text == "")
            {
                MessageBox.Show("Debe buscar un usuario el cual eliminar");
            }
            else
            {
                Class_Usuarios CU = new Class_Usuarios();
                CU.Idusuario = TxtIdUsua.Text;
                if (CU.EliminarUsuario())
                {
                    MessageBox.Show("Usuario eliminado");
                    BtnNuevoUsu.Enabled = true;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscarUsua_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarUsua.Text == "")
            {
                MostrarDatos();
            }
            else
            {
                Class_Conexion CC = new Class_Conexion();
                string Sql;
                DataTable dt = new DataTable();
                CC.CON.Open();
                Sql = "Select * from TB_Usuarios Where Nombre_Usuario Like '" + TxtBuscarUsua.Text + "%' ";
                CC.DA = new SqlDataAdapter(Sql, CC.CON);
                CC.DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CC.CON.Close();
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            Limpiar();
            MostrarDatos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TxtIdUsua.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.TxtNomUsu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.TxtContUsu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
