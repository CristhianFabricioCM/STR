using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Configuraciones.Reportes
{
    public partial class Frm_Rpt_Departamentos : Form
    {
        public Frm_Rpt_Departamentos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Departamentos_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_deTableAdapter.Fill(this.dS_Configuraciones.Usp_mostrar_de, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
