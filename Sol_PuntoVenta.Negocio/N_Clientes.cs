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
    public class N_Clientes
    {
        public static DataTable Mostrar_cl(string Valor)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Mostrar_cl(Valor);
        }

        public static string Guardar_cl(int Nopcion, E_Clientes Oclientes)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Guardar_cl(Nopcion, Oclientes);
        }

        public static string Eliminar_cl(int Ncodigo)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Eliminar_cl(Ncodigo);
        }

        public static string Verifica_duplicado_cl(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Clientes Datos = new D_Clientes();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_cl(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_cl"].ToString();
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
