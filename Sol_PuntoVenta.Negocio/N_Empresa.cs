using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Empresa
    {
        public static DataTable Mostrar_em(string Valor)
        {
            D_Empresa Datos = new D_Empresa();
            return Datos.Mostrar_em(Valor);
        }

        public static string Guardar_em(int Nopcion, E_Empresa oPro)
        {
            D_Empresa Datos = new D_Empresa();
            return Datos.Guardar_em(Nopcion, oPro);
        }

        public static string Eliminar_em(int Ncodigo)
        {
            D_Empresa Datos = new D_Empresa();
            return Datos.Eliminar_em(Ncodigo);
        }

        public static string Verifica_duplicado_em(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Empresa Datos = new D_Empresa();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_em(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_em"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_tdn(string Valor)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listar_tdn(Valor);
        }

        public static DataTable Listar_di(string Valor)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listar_di(Valor);
        }
    }
}
