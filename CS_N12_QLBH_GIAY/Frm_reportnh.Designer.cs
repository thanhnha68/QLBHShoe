
namespace CS_N12_QLBH_GIAY
{
    partial class Frm_reportnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reportnh));
            this.sp_thongtinnhaphangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CS_N12_5601_QLBH_GIAYDataSet = new CS_N12_QLBH_GIAY.QLDUOCPHAM();
            this.dtp_ngaynhapsp = new System.Windows.Forms.DateTimePicker();
            this.btn_taobc = new System.Windows.Forms.Button();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.rpv_nhaphang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_thongtinnhaphangTableAdapter = new CS_N12_QLBH_GIAY.QLBH_CS_NHA_NGOCDataSetLastTableAdapters.sp_thongtinnhaphangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_thongtinnhaphangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_N12_5601_QLBH_GIAYDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_thongtinnhaphangBindingSource
            // 
            this.sp_thongtinnhaphangBindingSource.DataMember = "sp_thongtinnhaphang";
            this.sp_thongtinnhaphangBindingSource.DataSource = this.CS_N12_5601_QLBH_GIAYDataSet;
            // 
            // CS_N12_5601_QLBH_GIAYDataSet
            // 
            this.CS_N12_5601_QLBH_GIAYDataSet.DataSetName = "CS_N12_5601_QLBH_GIAYDataSet";
            this.CS_N12_5601_QLBH_GIAYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtp_ngaynhapsp
            // 
            this.dtp_ngaynhapsp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaynhapsp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaynhapsp.Location = new System.Drawing.Point(315, 36);
            this.dtp_ngaynhapsp.Name = "dtp_ngaynhapsp";
            this.dtp_ngaynhapsp.Size = new System.Drawing.Size(133, 23);
            this.dtp_ngaynhapsp.TabIndex = 5;
            // 
            // btn_taobc
            // 
            this.btn_taobc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_taobc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taobc.ForeColor = System.Drawing.Color.Black;
            this.btn_taobc.Location = new System.Drawing.Point(481, 27);
            this.btn_taobc.Name = "btn_taobc";
            this.btn_taobc.Size = new System.Drawing.Size(116, 32);
            this.btn_taobc.TabIndex = 4;
            this.btn_taobc.Text = "Tạo báo cáo";
            this.btn_taobc.UseVisualStyleBackColor = false;
            this.btn_taobc.Click += new System.EventHandler(this.btn_taobc_Click);
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap.Location = new System.Drawing.Point(206, 36);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(111, 17);
            this.lbl_ngaynhap.TabIndex = 3;
            this.lbl_ngaynhap.Text = "Ngày nhập hàng:";
            // 
            // rpv_nhaphang
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_thongtinnhaphangBindingSource;
            this.rpv_nhaphang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_nhaphang.Location = new System.Drawing.Point(6, 84);
            this.rpv_nhaphang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rpv_nhaphang.Name = "rpv_nhaphang";
            this.rpv_nhaphang.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rpv_nhaphang.ServerReport.BearerToken = null;
            this.rpv_nhaphang.Size = new System.Drawing.Size(880, 416);
            this.rpv_nhaphang.TabIndex = 7;
            // 
            // sp_thongtinnhaphangTableAdapter
            // 
            this.sp_thongtinnhaphangTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_reportnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 507);
            this.Controls.Add(this.rpv_nhaphang);
            this.Controls.Add(this.dtp_ngaynhapsp);
            this.Controls.Add(this.btn_taobc);
            this.Controls.Add(this.lbl_ngaynhap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_reportnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập hàng";
            this.Load += new System.EventHandler(this.Frm_reportnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_thongtinnhaphangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_N12_5601_QLBH_GIAYDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ngaynhapsp;
        private System.Windows.Forms.Button btn_taobc;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_nhaphang;
        private System.Windows.Forms.BindingSource sp_thongtinnhaphangBindingSource;
        private QLDUOCPHAM CS_N12_5601_QLBH_GIAYDataSet;
        private QLBH_CS_NHA_NGOCDataSetLastTableAdapters.sp_thongtinnhaphangTableAdapter sp_thongtinnhaphangTableAdapter;
    }
}