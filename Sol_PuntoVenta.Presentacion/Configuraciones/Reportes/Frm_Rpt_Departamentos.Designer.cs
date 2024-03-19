namespace Sol_PuntoVenta.Presentacion.Configuraciones.Reportes
{
    partial class Frm_Rpt_Departamentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Configuraciones = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_Configuraciones();
            this.uspmostrardeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_mostrar_deTableAdapter = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_ConfiguracionesTableAdapters.Usp_mostrar_deTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrardeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uspmostrardeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.Rpt_Departamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Configuraciones
            // 
            this.dS_Configuraciones.DataSetName = "DS_Configuraciones";
            this.dS_Configuraciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspmostrardeBindingSource
            // 
            this.uspmostrardeBindingSource.DataMember = "Usp_mostrar_de";
            this.uspmostrardeBindingSource.DataSource = this.dS_Configuraciones;
            // 
            // usp_mostrar_deTableAdapter
            // 
            this.usp_mostrar_deTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(12, 39);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 6;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Departamentos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrardeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspmostrardeBindingSource;
        private DS_Configuraciones dS_Configuraciones;
        private DS_ConfiguracionesTableAdapters.Usp_mostrar_deTableAdapter usp_mostrar_deTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}