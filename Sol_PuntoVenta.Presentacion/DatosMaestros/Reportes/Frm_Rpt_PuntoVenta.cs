using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.DatosMaestros.Reportes
{
    public partial class Frm_Rpt_PuntoVenta : Form
    {
        public Frm_Rpt_PuntoVenta()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_PuntoVenta_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_pvTableAdapter.Fill(this.dS_PuntoVenta.Usp_mostrar_pv, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
