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
    public class N_Provincias
    {
        public static DataTable Mostrar_po(string Valor)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Mostrar_po(Valor);
        }

        public static string Guardar_po(int Nopcion, E_Provincias oPro)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Guardar_po(Nopcion, oPro);
        }

        public static string Eliminar_po(int Ncodigo)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Eliminar_po(Ncodigo);
        }

        public static string Verifica_duplicado_po(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Provincias Datos = new D_Provincias();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_po(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_pr"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_de(string Valor)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Listar_de(Valor);
        }
    }
}
