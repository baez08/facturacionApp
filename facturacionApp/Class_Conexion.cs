using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace facturacionApp
{
    public class Class_Conexion
    {
        public SqlConnection CON = new SqlConnection(Properties.Settings.Default.Conexion);
        public SqlDataAdapter DA = new SqlDataAdapter();
        public SqlDataReader DR;
        public SqlCommand CMD;

        public Class_Conexion()
        {
            
        }
    }
}
