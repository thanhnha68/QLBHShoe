namespace CS_N12_QLBH_GIAY
{
    partial class Frm_phieuxuatkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_phieuxuatkho));
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_mapx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.lbl_solg = new System.Windows.Forms.Label();
            this.lbl_masp = new System.Windows.Forms.Label();
            this.lbl_pttt = new System.Windows.Forms.Label();
            this.txt_mapx = new System.Windows.Forms.TextBox();
            this.txt_ngayxuat = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_solg = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_px = new System.Windows.Forms.DataGridView();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.dgv_ctpx = new System.Windows.Forms.DataGridView();
            this.btn_xoact = new System.Windows.Forms.Button();
            this.btn_suact = new System.Windows.Forms.Button();
            this.btn_themct = new System.Windows.Forms.Button();
            this.grb_tt = new System.Windows.Forms.GroupBox();
            this.grb_nut = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctpx)).BeginInit();
            this.grb_tt.SuspendLayout();
            this.grb_nut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(52, 16);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(206, 24);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "PHIẾU XUẤT HÀNG";
            // 
            // lbl_mapx
            // 
            this.lbl_mapx.AutoSize = true;
            this.lbl_mapx.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mapx.Location = new System.Drawing.Point(23, 43);
            this.lbl_mapx.Name = "lbl_mapx";
            this.lbl_mapx.Size = new System.Drawing.Size(96, 17);
            this.lbl_mapx.TabIndex = 1;
            this.lbl_mapx.Text = "Mã phiếu xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày xuất:";
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_manv.Location = new System.Drawing.Point(23, 85);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(96, 17);
            this.lbl_manv.TabIndex = 3;
            this.lbl_manv.Text = "Mã nhân viên:";
            // 
            // lbl_solg
            // 
            this.lbl_solg.AutoSize = true;
            this.lbl_solg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_solg.Location = new System.Drawing.Point(23, 174);
            this.lbl_solg.Name = "lbl_solg";
            this.lbl_solg.Size = new System.Drawing.Size(98, 17);
            this.lbl_solg.TabIndex = 5;
            this.lbl_solg.Text = "Số lượng xuất:";
            // 
            // lbl_masp
            // 
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_masp.Location = new System.Drawing.Point(23, 131);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(95, 17);
            this.lbl_masp.TabIndex = 7;
            this.lbl_masp.Text = "Mã sản phẩm:";
            // 
            // lbl_pttt
            // 
            this.lbl_pttt.AutoSize = true;
            this.lbl_pttt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pttt.Location = new System.Drawing.Point(23, 297);
            this.lbl_pttt.Name = "lbl_pttt";
            this.lbl_pttt.Size = new System.Drawing.Size(92, 17);
            this.lbl_pttt.TabIndex = 10;
            this.lbl_pttt.Text = "Đơn giá xuất:";
            // 
            // txt_mapx
            // 
            this.txt_mapx.Location = new System.Drawing.Point(148, 37);
            this.txt_mapx.Name = "txt_mapx";
            this.txt_mapx.Size = new System.Drawing.Size(131, 23);
            this.txt_mapx.TabIndex = 1;
            // 
            // txt_ngayxuat
            // 
            this.txt_ngayxuat.Location = new System.Drawing.Point(148, 253);
            this.txt_ngayxuat.Name = "txt_ngayxuat";
            this.txt_ngayxuat.Size = new System.Drawing.Size(131, 23);
            this.txt_ngayxuat.TabIndex = 6;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(148, 79);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(131, 23);
            this.txt_manv.TabIndex = 2;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(148, 124);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(131, 23);
            this.txt_masp.TabIndex = 3;
            // 
            // txt_solg
            // 
            this.txt_solg.Location = new System.Drawing.Point(148, 167);
            this.txt_solg.Name = "txt_solg";
            this.txt_solg.Size = new System.Drawing.Size(131, 23);
            this.txt_solg.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.Location = new System.Drawing.Point(12, 22);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(86, 32);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.UseVisualStyleBackColor = false;
            //            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.Location = new System.Drawing.Point(105, 22);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(86, 32);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.UseVisualStyleBackColor = false;
            //    this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.Location = new System.Drawing.Point(198, 22);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(86, 32);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.UseVisualStyleBackColor = false;
            //   this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.Location = new System.Drawing.Point(824, 31);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 41);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            //   this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_px
            // 
            this.dgv_px.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_px.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_px.Location = new System.Drawing.Point(332, 339);
            this.dgv_px.Name = "dgv_px";
            this.dgv_px.RowHeadersWidth = 51;
            this.dgv_px.Size = new System.Drawing.Size(577, 223);
            this.dgv_px.TabIndex = 26;
            //   this.dgv_px.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_px_CellContentClick);
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(148, 211);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(131, 23);
            this.txt_makh.TabIndex = 5;
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_makh.Location = new System.Drawing.Point(23, 218);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(108, 17);
            this.lbl_makh.TabIndex = 27;
            this.lbl_makh.Text = "Mã khách hàng:";
            // 
            // dgv_ctpx
            // 
            this.dgv_ctpx.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_ctpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctpx.Location = new System.Drawing.Point(332, 78);
            this.dgv_ctpx.Name = "dgv_ctpx";
            this.dgv_ctpx.RowHeadersWidth = 51;
            this.dgv_ctpx.Size = new System.Drawing.Size(577, 232);
            this.dgv_ctpx.TabIndex = 35;
            //     this.dgv_ctpx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctpx_CellContentClick);
            // 
            // btn_xoact
            // 
            this.btn_xoact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_xoact.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoact.ForeColor = System.Drawing.Color.Black;
            this.btn_xoact.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoact.Image")));
            this.btn_xoact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoact.Location = new System.Drawing.Point(198, 68);
            this.btn_xoact.Name = "btn_xoact";
            this.btn_xoact.Size = new System.Drawing.Size(86, 32);
            this.btn_xoact.TabIndex = 13;
            this.btn_xoact.Text = "Xóa CT";
            this.btn_xoact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoact.UseVisualStyleBackColor = false;
            //   this.btn_xoact.Click += new System.EventHandler(this.btn_xoact_Click);
            // 
            // btn_suact
            // 
            this.btn_suact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_suact.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suact.ForeColor = System.Drawing.Color.Black;
            this.btn_suact.Image = ((System.Drawing.Image)(resources.GetObject("btn_suact.Image")));
            this.btn_suact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suact.Location = new System.Drawing.Point(105, 68);
            this.btn_suact.Name = "btn_suact";
            this.btn_suact.Size = new System.Drawing.Size(86, 32);
            this.btn_suact.TabIndex = 12;
            this.btn_suact.Text = "Sửa CT";
            this.btn_suact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suact.UseVisualStyleBackColor = false;
            //     this.btn_suact.Click += new System.EventHandler(this.btn_suact_Click);
            // 
            // btn_themct
            // 
            this.btn_themct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_themct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themct.ForeColor = System.Drawing.Color.Black;
            this.btn_themct.Image = ((System.Drawing.Image)(resources.GetObject("btn_themct.Image")));
            this.btn_themct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themct.Location = new System.Drawing.Point(12, 68);
            this.btn_themct.Name = "btn_themct";
            this.btn_themct.Size = new System.Drawing.Size(86, 32);
            this.btn_themct.TabIndex = 11;
            this.btn_themct.Text = "Thêm CT";
            this.btn_themct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themct.UseVisualStyleBackColor = false;
            //  this.btn_themct.Click += new System.EventHandler(this.btn_themct_Click);
            // 
            // grb_tt
            // 
            this.grb_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grb_tt.Controls.Add(this.textBox1);
            this.grb_tt.Controls.Add(this.txt_makh);
            this.grb_tt.Controls.Add(this.lbl_makh);
            this.grb_tt.Controls.Add(this.txt_solg);
            this.grb_tt.Controls.Add(this.txt_masp);
            this.grb_tt.Controls.Add(this.txt_manv);
            this.grb_tt.Controls.Add(this.txt_ngayxuat);
            this.grb_tt.Controls.Add(this.txt_mapx);
            this.grb_tt.Controls.Add(this.lbl_pttt);
            this.grb_tt.Controls.Add(this.lbl_masp);
            this.grb_tt.Controls.Add(this.lbl_solg);
            this.grb_tt.Controls.Add(this.lbl_manv);
            this.grb_tt.Controls.Add(this.label1);
            this.grb_tt.Controls.Add(this.lbl_mapx);
            this.grb_tt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_tt.Location = new System.Drawing.Point(17, 59);
            this.grb_tt.Margin = new System.Windows.Forms.Padding(2);
            this.grb_tt.Name = "grb_tt";
            this.grb_tt.Padding = new System.Windows.Forms.Padding(2);
            this.grb_tt.Size = new System.Drawing.Size(300, 382);
            this.grb_tt.TabIndex = 40;
            this.grb_tt.TabStop = false;
            this.grb_tt.Text = "Thông tin";
            // 
            // grb_nut
            // 
            this.grb_nut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grb_nut.Controls.Add(this.btn_them);
            this.grb_nut.Controls.Add(this.btn_sua);
            this.grb_nut.Controls.Add(this.btn_xoact);
            this.grb_nut.Controls.Add(this.btn_xoa);
            this.grb_nut.Controls.Add(this.btn_suact);
            this.grb_nut.Controls.Add(this.btn_themct);
            this.grb_nut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nut.Location = new System.Drawing.Point(17, 446);
            this.grb_nut.Margin = new System.Windows.Forms.Padding(2);
            this.grb_nut.Name = "grb_nut";
            this.grb_nut.Padding = new System.Windows.Forms.Padding(2);
            this.grb_nut.Size = new System.Drawing.Size(300, 116);
            this.grb_nut.TabIndex = 41;
            this.grb_nut.TabStop = false;
            this.grb_nut.Text = "Nút lệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Chi tiết phiếu xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Phiếu xuất";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_hienthi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.ForeColor = System.Drawing.Color.Black;
            this.btn_hienthi.Location = new System.Drawing.Point(692, 35);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(126, 32);
            this.btn_hienthi.TabIndex = 14;
            this.btn_hienthi.Text = "Hiển thị lại bảng";
            this.btn_hienthi.UseVisualStyleBackColor = false;
            //   this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem.Location = new System.Drawing.Point(459, 45);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(216, 22);
            this.txt_timkiem.TabIndex = 43;
            //     this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 31;
            // 
            // Frm_phieuxuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 572);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb_nut);
            this.Controls.Add(this.grb_tt);
            this.Controls.Add(this.dgv_ctpx);
            this.Controls.Add(this.dgv_px);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "Frm_phieuxuatkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất kho";
            //    this.Load += new System.EventHandler(this.Frm_phieuxuatkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctpx)).EndInit();
            this.grb_tt.ResumeLayout(false);
            this.grb_tt.PerformLayout();
            this.grb_nut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_mapx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.Label lbl_solg;
        private System.Windows.Forms.Label lbl_masp;
        private System.Windows.Forms.Label lbl_pttt;
        private System.Windows.Forms.TextBox txt_mapx;
        private System.Windows.Forms.TextBox txt_ngayxuat;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txt_solg;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_px;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.DataGridView dgv_ctpx;
        private System.Windows.Forms.Button btn_xoact;
        private System.Windows.Forms.Button btn_suact;
        private System.Windows.Forms.Button btn_themct;
        private System.Windows.Forms.GroupBox grb_tt;
        private System.Windows.Forms.GroupBox grb_nut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox textBox1;
    }
}