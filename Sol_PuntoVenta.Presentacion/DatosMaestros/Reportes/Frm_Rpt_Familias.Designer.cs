namespace Sol_PuntoVenta.Presentacion.DatosMaestros.Reportes
{
    partial class Frm_Rpt_Familias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_PuntoVenta = new Sol_PuntoVenta.Presentacion.DatosMaestros.Reportes.DS_PuntoVenta();
            this.uspmostrarfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_mostrar_faTableAdapter = new Sol_PuntoVenta.Presentacion.DatosMaestros.Reportes.DS_PuntoVentaTableAdapters.Usp_mostrar_faTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PuntoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrarfaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DS_Familias";
            reportDataSource3.Value = this.uspmostrarfaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.DatosMaestros.Reportes.Rpt_Familias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_PuntoVenta
            // 
            this.dS_PuntoVenta.DataSetName = "DS_PuntoVenta";
            this.dS_PuntoVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspmostrarfaBindingSource
            // 
            this.uspmostrarfaBindingSource.DataMember = "Usp_mostrar_fa";
            this.uspmostrarfaBindingSource.DataSource = this.dS_PuntoVenta;
            // 
            // usp_mostrar_faTableAdapter
            // 
            this.usp_mostrar_faTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(24, 40);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 6;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Familias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Familias";
            this.Load += new System.EventHandler(this.Frm_Rpt_Familias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_PuntoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrarfaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspmostrarfaBindingSource;
        private DS_PuntoVenta dS_PuntoVenta;
        private DS_PuntoVentaTableAdapters.Usp_mostrar_faTableAdapter usp_mostrar_faTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}