﻿using System;
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
    public partial class Frm_Rpt_Provincias : Form
    {
        public Frm_Rpt_Provincias()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Provincias_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_poTableAdapter.Fill(this.dS_Configuraciones.Usp_mostrar_po, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
