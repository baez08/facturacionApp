using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace facturacionApp
{
    public class Class_Usuarios : Class_Conexion
    {
        private string _idusuario;
        private string _nomusuario;
        private string _contusuario;
        private string _tipousuario;
        private string Sql;

        public string Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Nomusuario { get => _nomusuario; set => _nomusuario = value; }
        public string Contusuario { get => _contusuario; set => _contusuario = value; }
        public string Tipousuario { get => _tipousuario; set => _tipousuario = value; }

        public Boolean Validar()
        {
            CON.Open();
            Sql = "SELECT * FROM TB_Usuarios where Nombre_Usuario = '"+Nomusuario + "' and Password = '" + Contusuario + "' ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();
            if (DR.HasRows)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public Boolean NuevoUsuario()
        {
            CON.Open();
            Sql = "SP_NuevoUsuario";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Nombre_Usuario", Nomusuario);
            CMD.Parameters.AddWithValue("@Password", Contusuario);

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

        public Boolean ActualizarUsuario()
        {
            CON.Open();
            Sql = "SP_ActualizarUsuario";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Usuario", Idusuario);
            CMD.Parameters.AddWithValue("@Nombre_Usuario", Nomusuario);
            CMD.Parameters.AddWithValue("@Password", Contusuario);

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

        public Boolean BuscarUsuario()
        {
            CON.Open();
            Sql = "Select * from TB_Usuarios Where Id_Usuario = '" + Idusuario + "' ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();

            if (DR.HasRows)
            {
                Nomusuario = DR["Nombre_Usuario"].ToString();
                Contusuario = DR["Password"].ToString();
                CON.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean BuscarUsuarioNombre()
        {
            CON.Open();
            Sql = "Select * from TB_Usuarios Where Nombre_Usuario = '" + Nomusuario + "' ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();

            if (DR.HasRows)
            {
                Idusuario = DR["Id_Usuario"].ToString();
                CON.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EliminarUsuario()
        {
            CON.Open();
            Sql = "SP_EliminarUsuario";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Usuario", Idusuario);

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
