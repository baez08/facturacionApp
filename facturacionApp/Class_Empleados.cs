using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace facturacionApp
{
    public class Class_Empleados : Class_Conexion
    {
        private string Sql;
        private string _idempleado;
        private string _nombreempleado;
        private string _apellidosempleado;
        private string _puestoempleado;

        public string Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Nombreempleado { get => _nombreempleado; set => _nombreempleado = value; }
        public string Apellidosempleado { get => _apellidosempleado; set => _apellidosempleado = value; }
        public string Puestoempleado { get => _puestoempleado; set => _puestoempleado = value; }

        public Boolean NuevoEmpleado()
        {
            CON.Open();
            Sql = "SP_NuevoEmpleado";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Nombre_Empleado", Nombreempleado);
            CMD.Parameters.AddWithValue("@Apellido_Empleado", Apellidosempleado);
            CMD.Parameters.AddWithValue("@Puesto_Empleado", Puestoempleado);

            int i = CMD.ExecuteNonQuery();
            CON.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ActualizarEmpleado()
        {
            CON.Open();
            Sql = "SP_ActualizarEmpleado";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Empleado", Idempleado);
            CMD.Parameters.AddWithValue("@Nombre_Empleado", Nombreempleado);
            CMD.Parameters.AddWithValue("@Apellido_Empleado", Apellidosempleado);
            CMD.Parameters.AddWithValue("@Puesto_Empleado", Puestoempleado);

            int i = CMD.ExecuteNonQuery();
            CON.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean BuscarEmpleado()
        {
            CON.Open();
            Sql = "Select * from TB_Empleado Where Id_Empleado = '" + Idempleado + "' ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();

            if (DR.HasRows)
            {
                Nombreempleado = DR["Nombres_Empleado"].ToString();
                Apellidosempleado = DR["Apellidos_Empleado"].ToString();
                Puestoempleado = DR["Puesto_Empleado"].ToString();
                CON.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean EliminarEmpleado()
        {
            CON.Open();
            Sql = "SP_EliminarEmpleado";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Empleado", Idempleado);

            int i = CMD.ExecuteNonQuery();
            CON.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
