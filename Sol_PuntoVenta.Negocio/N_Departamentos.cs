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
    public class N_Departamentos
    {
        public static DataTable Mostrar_de(string Valor)
        {
            D_Departamentos Datos = new D_Departamentos();
            return Datos.Mostrar_de(Valor);
        }

        public static string Guardar_de(int Nopcion, E_Departamentos oPro)
        {
            D_Departamentos Datos = new D_Departamentos();
            return Datos.Guardar_de(Nopcion, oPro);
        }

        public static string Eliminar_de(int Ncodigo)
        {
            D_Departamentos Datos = new D_Departamentos();
            return Datos.Eliminar_de(Ncodigo);
        }

        public static string Verifica_duplicado_de(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Departamentos Datos = new D_Departamentos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_de(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_de"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
