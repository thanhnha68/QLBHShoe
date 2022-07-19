
namespace CS_N12_QLBH_GIAY
{
    partial class Frm_reportDT
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
            this.f_doanhthuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_baocao = new System.Windows.Forms.Button();
            this.dtp_nam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rpv_dt = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.f_doanhthuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_baocao
            // 
            this.btn_baocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_baocao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocao.ForeColor = System.Drawing.Color.Black;
            this.btn_baocao.Location = new System.Drawing.Point(426, 49);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(104, 27);
            this.btn_baocao.TabIndex = 4;
            this.btn_baocao.Text = "Tạo báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = false;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // dtp_nam
            // 
            this.dtp_nam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nam.Location = new System.Drawing.Point(297, 52);
            this.dtp_nam.Name = "dtp_nam";
            this.dtp_nam.Size = new System.Drawing.Size(98, 20);
            this.dtp_nam.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "BÁO CÁO DOANH THU";
            // 
            // rpv_dt
            // 
            reportDataSource1.Name = "DT";
            reportDataSource1.Value = this.f_doanhthuBindingSource;
            this.rpv_dt.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_dt.LocalReport.ReportEmbeddedResource = "CS_N12_QLBH_GIAY.ReportDthu.rdlc";
            this.rpv_dt.Location = new System.Drawing.Point(7, 81);
            this.rpv_dt.Margin = new System.Windows.Forms.Padding(2);
            this.rpv_dt.Name = "rpv_dt";
            this.rpv_dt.ServerReport.BearerToken = null;
            this.rpv_dt.Size = new System.Drawing.Size(878, 481);
            this.rpv_dt.TabIndex = 8;
            // 
            // Frm_reportDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 573);
            this.Controls.Add(this.rpv_dt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_baocao);
            this.Controls.Add(this.dtp_nam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_reportDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.Frm_reportDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f_doanhthuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.DateTimePicker dtp_nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_dt;
        private System.Windows.Forms.BindingSource f_doanhthuBindingSource;
    }
}