using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacionApp
{
     public class Datos
    {
        private string _idfactura;
        private string _detallefactura;
        private int _totalapagar;
        private int _efectivo;
        private int _devolucion;
        private string _idusuario;
        private string _fechafactura;
        private int _valor;

        public string Idfactura { get => _idfactura; set => _idfactura = value; }
        public string Detallefactura { get => _detallefactura; set => _detallefactura = value; }
        public int Totalapagar { get => _totalapagar; set => _totalapagar = value; }
        public int Efectivo { get => _efectivo; set => _efectivo = value; }
        public int Devolucion { get => _devolucion; set => _devolucion = value; }
        public string Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Fechafactura { get => _fechafactura; set => _fechafactura = value; }
        public int Valor { get => _valor; set => _valor = value; }
    }
}
