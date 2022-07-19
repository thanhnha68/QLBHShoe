namespace CS_N12_QLBH_GIAY
{
    partial class FrmReportNCC
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBH_CS_NHA_NGOCDataSet = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSet();
            this.NhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhaCungCapTableAdapter = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSetTableAdapters.NhaCungCapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhaCungCapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CS_N12_QLBH_GIAY.ReportNCC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(674, 295);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBH_CS_NHA_NGOCDataSet
            // 
            this.QLBH_CS_NHA_NGOCDataSet.DataSetName = "QLBH_CS_NHA_NGOCDataSet";
            this.QLBH_CS_NHA_NGOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhaCungCapBindingSource
            // 
            this.NhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.NhaCungCapBindingSource.DataSource = this.QLBH_CS_NHA_NGOCDataSet;
            // 
            // NhaCungCapTableAdapter
            // 
            this.NhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 295);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportNCC";
            this.Text = "FrmReportNCC";
            this.Load += new System.EventHandler(this.FrmReportNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhaCungCapBindingSource;
        private QLBH_CS_NHA_NGOCDataSet QLBH_CS_NHA_NGOCDataSet;
        private QLBH_CS_NHA_NGOCDataSetTableAdapters.NhaCungCapTableAdapter NhaCungCapTableAdapter;
    }
}