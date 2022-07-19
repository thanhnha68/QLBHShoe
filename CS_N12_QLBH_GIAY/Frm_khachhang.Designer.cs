namespace CS_N12_QLBH_GIAY
{
    partial class Frm_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_khachhang));
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_hienthilai = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.grp_gioitinh = new System.Windows.Forms.GroupBox();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_dienthoai = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_cmnd = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_tenkh = new System.Windows.Forms.Label();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.grp_gioitinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kh
            // 
            this.dgv_kh.AllowUserToOrderColumns = true;
            this.dgv_kh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kh.Location = new System.Drawing.Point(25, 244);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.RowHeadersWidth = 51;
            this.dgv_kh.Size = new System.Drawing.Size(923, 259);
            this.dgv_kh.TabIndex = 19;
            //            this.dgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellContentClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(829, 37);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(119, 50);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            //     this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_hienthilai
            // 
            this.btn_hienthilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_hienthilai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthilai.ForeColor = System.Drawing.Color.Black;
            this.btn_hienthilai.Image = ((System.Drawing.Image)(resources.GetObject("btn_hienthilai.Image")));
            this.btn_hienthilai.Location = new System.Drawing.Point(734, 183);
            this.btn_hienthilai.Name = "btn_hienthilai";
            this.btn_hienthilai.Size = new System.Drawing.Size(184, 50);
            this.btn_hienthilai.TabIndex = 14;
            this.btn_hienthilai.Text = "Hiển thị lại bảng";
            this.btn_hienthilai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hienthilai.UseVisualStyleBackColor = false;
            //     this.btn_hienthilai.Click += new System.EventHandler(this.btn_hienthilai_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(724, 121);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(194, 32);
            this.txt_timkiem.TabIndex = 13;
            //    this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tieude.Location = new System.Drawing.Point(325, 2);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(161, 25);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "KHÁCH HÀNG";
            //     this.lbl_tieude.Click += new System.EventHandler(this.lbl_tieude_Click);
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(721, 102);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(120, 17);
            this.lbl_timkiem.TabIndex = 24;
            this.lbl_timkiem.Text = "Tìm kiếm tên KH:";
            // 
            // grp_gioitinh
            // 
            this.grp_gioitinh.Controls.Add(this.rdo_nu);
            this.grp_gioitinh.Controls.Add(this.rdo_nam);
            this.grp_gioitinh.ForeColor = System.Drawing.Color.Black;
            this.grp_gioitinh.Location = new System.Drawing.Point(326, 128);
            this.grp_gioitinh.Name = "grp_gioitinh";
            this.grp_gioitinh.Size = new System.Drawing.Size(193, 56);
            this.grp_gioitinh.TabIndex = 41;
            this.grp_gioitinh.TabStop = false;
            this.grp_gioitinh.Text = "Giới tính:";
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(151, 28);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(43, 21);
            this.rdo_nu.TabIndex = 9;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(60, 28);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(54, 21);
            this.rdo_nam.TabIndex = 8;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(386, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(174, 23);
            this.txt_email.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(386, 65);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(174, 23);
            this.txt_diachi.TabIndex = 6;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh.Location = new System.Drawing.Point(386, 28);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(174, 23);
            this.txt_ngaysinh.TabIndex = 5;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(117, 142);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(172, 23);
            this.txt_cmnd.TabIndex = 4;
            // 
            // txt_dt
            // 
            this.txt_dt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dt.Location = new System.Drawing.Point(117, 104);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(172, 23);
            this.txt_dt.TabIndex = 3;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(566, 142);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(105, 54);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(117, 65);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(172, 23);
            this.txt_tenkh.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(566, 21);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 53);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(117, 28);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(172, 23);
            this.txt_makh.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(304, 106);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 17);
            this.lbl_email.TabIndex = 33;
            this.lbl_email.Text = "Email:";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(221)))), ((int)(((byte)(253)))));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(566, 84);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(105, 56);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // lbl_dienthoai
            // 
            this.lbl_dienthoai.AutoSize = true;
            this.lbl_dienthoai.Location = new System.Drawing.Point(4, 111);
            this.lbl_dienthoai.Name = "lbl_dienthoai";
            this.lbl_dienthoai.Size = new System.Drawing.Size(77, 17);
            this.lbl_dienthoai.TabIndex = 32;
            this.lbl_dienthoai.Text = "Điện thoại:";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(304, 72);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(56, 17);
            this.lbl_diachi.TabIndex = 31;
            this.lbl_diachi.Text = "Địa chỉ:";
            // 
            // lbl_cmnd
            // 
            this.lbl_cmnd.AutoSize = true;
            this.lbl_cmnd.Location = new System.Drawing.Point(4, 146);
            this.lbl_cmnd.Name = "lbl_cmnd";
            this.lbl_cmnd.Size = new System.Drawing.Size(98, 17);
            this.lbl_cmnd.TabIndex = 30;
            this.lbl_cmnd.Text = "CMND/CCCD:";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(304, 36);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(73, 17);
            this.lbl_ngaysinh.TabIndex = 29;
            this.lbl_ngaysinh.Text = "Ngày sinh:";
            // 
            // lbl_tenkh
            // 
            this.lbl_tenkh.AutoSize = true;
            this.lbl_tenkh.Location = new System.Drawing.Point(4, 72);
            this.lbl_tenkh.Name = "lbl_tenkh";
            this.lbl_tenkh.Size = new System.Drawing.Size(111, 17);
            this.lbl_tenkh.TabIndex = 28;
            this.lbl_tenkh.Text = "Tên khách hàng:";
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Location = new System.Drawing.Point(4, 36);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(108, 17);
            this.lbl_makh.TabIndex = 27;
            this.lbl_makh.Text = "Mã khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grp_gioitinh);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.txt_dt);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.lbl_dienthoai);
            this.groupBox1.Controls.Add(this.lbl_diachi);
            this.groupBox1.Controls.Add(this.lbl_cmnd);
            this.groupBox1.Controls.Add(this.lbl_ngaysinh);
            this.groupBox1.Controls.Add(this.lbl_tenkh);
            this.groupBox1.Controls.Add(this.lbl_makh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(688, 202);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(916, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(958, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_hienthilai);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgv_kh);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.lbl_tieude);
            this.Controls.Add(this.lbl_timkiem);
            this.Name = "Frm_khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            //   this.Load += new System.EventHandler(this.Frm_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.grp_gioitinh.ResumeLayout(false);
            this.grp_gioitinh.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_hienthilai;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_timkiem;
        private System.Windows.Forms.GroupBox grp_gioitinh;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_dienthoai;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_cmnd;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_tenkh;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}