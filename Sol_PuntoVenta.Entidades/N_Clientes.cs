using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Entidades
{
    public class E_Clientes
    {
        public int Codigo_cl { get; set; }
        public int Codigo_tdn { get; set; }
        public string Nro_documento_cl { get; set; }
        public string Cliente_cl { get; set; }       
        public string Email_cl { get; set; }
        public int Codigo_di { get; set; }
        public string Direccion_cl { get; set; }
        public string Telefono_cl { get; set; }
        public string Movil_cl { get; set; }
    }
}
