﻿using System;
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
    public partial class Frm_Rpt_Productos : Form
    {
        public Frm_Rpt_Productos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_prTableAdapter.Fill(this.dS_PuntoVenta.Usp_mostrar_pr, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
