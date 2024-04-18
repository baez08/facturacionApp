using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace facturacionApp
{
    public class Class_Productos : Class_Conexion
    {
        private string Sql;
        private string _nombreproducto;
        private int _precioproducto;
        private string _idproducto;

        public string Nombreproducto { get => _nombreproducto; set => _nombreproducto = value; }
        public int Precioproducto { get => _precioproducto; set => _precioproducto = value; }
        public string Idproducto { get => _idproducto; set => _idproducto = value; }

        public Boolean NuevoProducto()
        {
            CON.Open();
            Sql = "SP_NuevoProducto";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Nombre_Producto", Nombreproducto);
            CMD.Parameters.AddWithValue("@Precio_Producto", Precioproducto);

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

        public Boolean ActualizarProducto()
        {
            CON.Open();
            Sql = "SP_ActualizarProducto";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Producto", Idproducto);
            CMD.Parameters.AddWithValue("@Nombre_Producto", Nombreproducto);
            CMD.Parameters.AddWithValue("@Precio_Producto", Precioproducto);

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

        public Boolean BuscarProducto()
        {
            CON.Open();
            Sql = "Select * from TB_Producto Where Id_Producto = '" + Idproducto + "' ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();

            if (DR.HasRows)
            {
                Nombreproducto = DR["Nombres_Producto"].ToString();
                Precioproducto = Convert.ToInt32(DR["Precio_Producto"].ToString());
                CON.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean EliminarProducto()
        {
            CON.Open();
            Sql = "SP_EliminarProducto";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Id_Producto", Idproducto);

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
