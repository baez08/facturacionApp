using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace facturacionApp
{
    public class Class_Facturacion : Class_Conexion
    {
        private string Sql;
        private string _idfactura;
        private string _detallefactura;
        private int _totalapagar;
        private int _efectivo;
        private int _devolucion;
        private string _idusuario;
        private string _fechafactura;

        public string Idfactura { get => _idfactura; set => _idfactura = value; }
        public string Detallefactura { get => _detallefactura; set => _detallefactura = value; }
        public int Totalapagar { get => _totalapagar; set => _totalapagar = value; }
        public int Efectivo { get => _efectivo; set => _efectivo = value; }
        public int Devolucion { get => _devolucion; set => _devolucion = value; }
        public string Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Fechafactura { get => _fechafactura; set => _fechafactura = value; }

        public Boolean NuevaFactura()
        {
            CON.Open();
            Sql = "SP_NuevaFactura";
            CMD = new SqlCommand(Sql, CON);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@Detalles_Factura", Convert.ToString(Detallefactura));
            CMD.Parameters.AddWithValue("@Total_Factura", Totalapagar);
            CMD.Parameters.AddWithValue("@Efectivo_Factura", Efectivo);
            CMD.Parameters.AddWithValue("@Devolucion_Factura", Devolucion);
            CMD.Parameters.AddWithValue("@Id_Usuario", Idusuario);
            CMD.Parameters.AddWithValue("@Fecha_Factura", Fechafactura);

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

        public Boolean BuscarIdFactura()
        {
            CON.Open();
            Sql = "Select * from TB_Factura Where Id_Factura = (Select MAX(Id_Factura) from TB_Factura) ";
            CMD = new SqlCommand(Sql, CON);
            DR = CMD.ExecuteReader();

            DR.Read();

            if (DR.HasRows)
            {
                Idfactura = DR["Id_Factura"].ToString();
                CON.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
