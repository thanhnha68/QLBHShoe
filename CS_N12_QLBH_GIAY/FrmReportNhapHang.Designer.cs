namespace CS_N12_QLBH_GIAY
{
    partial class FrmReportNhapHang
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
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.btn_taobc = new System.Windows.Forms.Button();
            this.dtp_ngaynhapsp = new System.Windows.Forms.DateTimePicker();
            this.rpv_nhaphang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grp_baocao = new System.Windows.Forms.GroupBox();
            this.QLBH_CS_NHA_NGOCDataSet = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSet();
            this.sp_thongtinnhaphangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_thongtinnhaphangTableAdapter = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSetTableAdapters.sp_thongtinnhaphangTableAdapter();
            this.grp_baocao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_thongtinnhaphangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Location = new System.Drawing.Point(56, 21);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(89, 13);
            this.lbl_ngaynhap.TabIndex = 0;
            this.lbl_ngaynhap.Text = "Ngày nhập hàng:";
            // 
            // btn_taobc
            // 
            this.btn_taobc.Location = new System.Drawing.Point(331, 19);
            this.btn_taobc.Name = "btn_taobc";
            this.btn_taobc.Size = new System.Drawing.Size(107, 24);
            this.btn_taobc.TabIndex = 1;
            this.btn_taobc.Text = "Tạo báo cáo";
            this.btn_taobc.UseVisualStyleBackColor = true;
            this.btn_taobc.Click += new System.EventHandler(this.btn_taobc_Click);
            // 
            // dtp_ngaynhapsp
            // 
            this.dtp_ngaynhapsp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaynhapsp.Location = new System.Drawing.Point(166, 21);
            this.dtp_ngaynhapsp.Name = "dtp_ngaynhapsp";
            this.dtp_ngaynhapsp.Size = new System.Drawing.Size(133, 20);
            this.dtp_ngaynhapsp.TabIndex = 2;
            // 
            // rpv_nhaphang
            // 
            this.rpv_nhaphang.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_thongtinnhaphangBindingSource;
            this.rpv_nhaphang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_nhaphang.LocalReport.ReportEmbeddedResource = "CS_N12_QLBH_GIAY.ReportNhapHang.rdlc";
            this.rpv_nhaphang.Location = new System.Drawing.Point(3, 16);
            this.rpv_nhaphang.Name = "rpv_nhaphang";
            this.rpv_nhaphang.ServerReport.BearerToken = null;
            this.rpv_nhaphang.Size = new System.Drawing.Size(902, 371);
            this.rpv_nhaphang.TabIndex = 3;
            // 
            // grp_baocao
            // 
            this.grp_baocao.Controls.Add(this.rpv_nhaphang);
            this.grp_baocao.Location = new System.Drawing.Point(1, 71);
            this.grp_baocao.Name = "grp_baocao";
            this.grp_baocao.Size = new System.Drawing.Size(908, 390);
            this.grp_baocao.TabIndex = 4;
            this.grp_baocao.TabStop = false;
            this.grp_baocao.Text = "Thông tin báo cáo";
            // 
            // QLBH_CS_NHA_NGOCDataSet1
            // 
            this.QLBH_CS_NHA_NGOCDataSet.DataSetName = "QLBH_CS_NHA_NGOCDataSet1";
            this.QLBH_CS_NHA_NGOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_thongtinnhaphangBindingSource
            // 
            this.sp_thongtinnhaphangBindingSource.DataMember = "sp_thongtinnhaphang";
            this.sp_thongtinnhaphangBindingSource.DataSource = this.QLBH_CS_NHA_NGOCDataSet;
            // 
            // sp_thongtinnhaphangTableAdapter
            // 
            this.sp_thongtinnhaphangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.grp_baocao);
            this.Controls.Add(this.dtp_ngaynhapsp);
            this.Controls.Add(this.btn_taobc);
            this.Controls.Add(this.lbl_ngaynhap);
            this.Name = "FrmReportNhapHang";
            this.Text = "FrmReportNhapHang";
            this.Load += new System.EventHandler(this.FrmReportNhapHang_Load);
            this.grp_baocao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_CS_NHA_NGOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_thongtinnhaphangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.Button btn_taobc;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhapsp;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_nhaphang;
        private System.Windows.Forms.BindingSource sp_thongtinnhaphangBindingSource;
        private QLBH_CS_NHA_NGOCDataSet QLBH_CS_NHA_NGOCDataSet;
        private System.Windows.Forms.GroupBox grp_baocao;
        private QLBH_CS_NHA_NGOCDataSetTableAdapters.sp_thongtinnhaphangTableAdapter sp_thongtinnhaphangTableAdapter;
    }
}