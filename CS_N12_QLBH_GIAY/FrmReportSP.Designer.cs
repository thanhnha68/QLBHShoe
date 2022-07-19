namespace CS_N12_QLBH_GIAY
{
    partial class FrmReportSP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBH_CS_NHA_NGOCDataSet = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamTableAdapter = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSetTableAdapters.SanPhamTableAdapter();
            this.reportExecutionService1 = new Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.QLBH_CS_NHA_NGOCDataSet;
            // 
            // QLBH_CS_NHA_NGOCDataSet
            // 
            this.QLBH_CS_NHA_NGOCDataSet.DataSetName = "QLBH_CS_NHA_NGOCDataSet";
            this.QLBH_CS_NHA_NGOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CS_N12_QLBH_GIAY.ReportSP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(669, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // reportExecutionService1
            // 
            this.reportExecutionService1.Credentials = null;
            this.reportExecutionService1.ExecutionHeaderValue = null;
            this.reportExecutionService1.ServerInfoHeaderValue = null;
            this.reportExecutionService1.TrustedUserHeaderValue = null;
            this.reportExecutionService1.Url = "http://localhost/ReportServer/ReportExecution2005.asmx";
            this.reportExecutionService1.UseDefaultCredentials = false;
            // 
            // FrmReportSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportSP";
            this.Text = "FrmReportSP";
            this.Load += new System.EventHandler(this.FrmReportSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private QLBH_CS_NHA_NGOCDataSet QLBH_CS_NHA_NGOCDataSet;
        private QLBH_CS_NHA_NGOCDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService reportExecutionService1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}