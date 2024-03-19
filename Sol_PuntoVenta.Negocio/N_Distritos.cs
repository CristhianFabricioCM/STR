using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Datos;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Distritos
    {
        public static DataTable Mostrar_di(string Valor)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Mostrar_di(Valor);
        }

        public static string Guardar_di(int Nopcion, E_Distritos oPro)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Guardar_di(Nopcion, oPro);
        }

        public static string Eliminar_di(int Ncodigo)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Eliminar_di(Ncodigo);
        }

        public static string Verifica_duplicado_di(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Distritos Datos = new D_Distritos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_di(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_di"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_po(string Valor)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listar_po(Valor);
        }
    }
}
