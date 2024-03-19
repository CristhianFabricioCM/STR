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
    public partial class Frm_Rpt_Clientes : Form
    {
        public Frm_Rpt_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Clientes_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_clTableAdapter.Fill(this.dS_PuntoVenta.Usp_mostrar_cl, Ctexto: Txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
