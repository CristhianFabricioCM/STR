namespace Sol_PuntoVenta.Presentacion.Configuraciones.Reportes
{
    partial class Frm_Rpt_Empresa
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
            this.dS_Configuraciones = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_Configuraciones();
            this.uspmostraremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_mostrar_emTableAdapter = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_ConfiguracionesTableAdapters.Usp_mostrar_emTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostraremBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uspmostraremBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.Rpt_Empresa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1168, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Configuraciones
            // 
            this.dS_Configuraciones.DataSetName = "DS_Configuraciones";
            this.dS_Configuraciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspmostraremBindingSource
            // 
            this.uspmostraremBindingSource.DataMember = "Usp_mostrar_em";
            this.uspmostraremBindingSource.DataSource = this.dS_Configuraciones;
            // 
            // usp_mostrar_emTableAdapter
            // 
            this.usp_mostrar_emTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(24, 50);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 11;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 548);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Empresa";
            this.Load += new System.EventHandler(this.Frm_Rpt_Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostraremBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspmostraremBindingSource;
        private DS_Configuraciones dS_Configuraciones;
        private DS_ConfiguracionesTableAdapters.Usp_mostrar_emTableAdapter usp_mostrar_emTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}