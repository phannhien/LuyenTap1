namespace sinhviens
{
    partial class frmChiTietSinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btBoSung = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabpageVatLy = new System.Windows.Forms.TabPage();
            this.txtVatLy2 = new System.Windows.Forms.TextBox();
            this.txtVatLy1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabpageCNTT = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabpageVanHoc = new System.Windows.Forms.TabPage();
            this.datetimeNamSinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabpageVatLy.SuspendLayout();
            this.tabpageCNTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 23);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(57, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(285, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtXoa);
            this.panel2.Controls.Add(this.btCapNhat);
            this.panel2.Controls.Add(this.btBoSung);
            this.panel2.Location = new System.Drawing.Point(367, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 23);
            this.panel2.TabIndex = 1;
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(192, 1);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(75, 23);
            this.txtXoa.TabIndex = 2;
            this.txtXoa.Text = "XÓA";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(101, 0);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 1;
            this.btCapNhat.Text = "CẬP NHẬT";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btBoSung
            // 
            this.btBoSung.Location = new System.Drawing.Point(10, 1);
            this.btBoSung.Name = "btBoSung";
            this.btBoSung.Size = new System.Drawing.Size(75, 23);
            this.btBoSung.TabIndex = 0;
            this.btBoSung.Text = "BỔ SUNG";
            this.btBoSung.UseVisualStyleBackColor = true;
            this.btBoSung.Click += new System.EventHandler(this.btBoSung_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSinhVien);
            this.panel3.Location = new System.Drawing.Point(13, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 412);
            this.panel3.TabIndex = 2;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.TenKhoa,
            this.Diem1,
            this.Diem2});
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 4);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(342, 408);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // MSV
            // 
            this.MSV.DataPropertyName = "MSV";
            this.MSV.HeaderText = "MSV";
            this.MSV.Name = "MSV";
            this.MSV.ReadOnly = true;
            this.MSV.Visible = false;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HỌ VÀ TÊN";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 400;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Visible = false;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Visible = false;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "TenKhoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Visible = false;
            // 
            // Diem1
            // 
            this.Diem1.DataPropertyName = "Diem1";
            this.Diem1.HeaderText = "Diem1";
            this.Diem1.Name = "Diem1";
            this.Diem1.ReadOnly = true;
            this.Diem1.Visible = false;
            // 
            // Diem2
            // 
            this.Diem2.DataPropertyName = "Diem2";
            this.Diem2.HeaderText = "Diem2";
            this.Diem2.Name = "Diem2";
            this.Diem2.ReadOnly = true;
            this.Diem2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(367, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 400);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabPage);
            this.groupBox1.Controls.Add(this.datetimeNamSinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabpageVatLy);
            this.tabPage.Controls.Add(this.tabpageCNTT);
            this.tabPage.Controls.Add(this.tabpageVanHoc);
            this.tabPage.Location = new System.Drawing.Point(10, 223);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(302, 156);
            this.tabPage.TabIndex = 5;
            // 
            // tabpageVatLy
            // 
            this.tabpageVatLy.Controls.Add(this.txtVatLy2);
            this.tabpageVatLy.Controls.Add(this.txtVatLy1);
            this.tabpageVatLy.Controls.Add(this.label7);
            this.tabpageVatLy.Controls.Add(this.label6);
            this.tabpageVatLy.Location = new System.Drawing.Point(4, 22);
            this.tabpageVatLy.Name = "tabpageVatLy";
            this.tabpageVatLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageVatLy.Size = new System.Drawing.Size(294, 130);
            this.tabpageVatLy.TabIndex = 0;
            this.tabpageVatLy.Text = "Vật Lý";
            // 
            // txtVatLy2
            // 
            this.txtVatLy2.Location = new System.Drawing.Point(108, 71);
            this.txtVatLy2.Name = "txtVatLy2";
            this.txtVatLy2.Size = new System.Drawing.Size(100, 20);
            this.txtVatLy2.TabIndex = 3;
            // 
            // txtVatLy1
            // 
            this.txtVatLy1.Location = new System.Drawing.Point(108, 27);
            this.txtVatLy1.Name = "txtVatLy1";
            this.txtVatLy1.Size = new System.Drawing.Size(100, 20);
            this.txtVatLy1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vật Lý 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vật Lý 1:";
            // 
            // tabpageCNTT
            // 
            this.tabpageCNTT.Controls.Add(this.textBox4);
            this.tabpageCNTT.Controls.Add(this.label9);
            this.tabpageCNTT.Controls.Add(this.label8);
            this.tabpageCNTT.Controls.Add(this.textBox3);
            this.tabpageCNTT.Location = new System.Drawing.Point(4, 22);
            this.tabpageCNTT.Name = "tabpageCNTT";
            this.tabpageCNTT.Size = new System.Drawing.Size(294, 130);
            this.tabpageCNTT.TabIndex = 1;
            this.tabpageCNTT.Text = "CNTT";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lập Trình 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lập Trình 1:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // tabpageVanHoc
            // 
            this.tabpageVanHoc.Location = new System.Drawing.Point(4, 22);
            this.tabpageVanHoc.Name = "tabpageVanHoc";
            this.tabpageVanHoc.Size = new System.Drawing.Size(294, 130);
            this.tabpageVanHoc.TabIndex = 2;
            this.tabpageVanHoc.Text = "Văn Học";
            // 
            // datetimeNamSinh
            // 
            this.datetimeNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNamSinh.Location = new System.Drawing.Point(10, 184);
            this.datetimeNamSinh.Name = "datetimeNamSinh";
            this.datetimeNamSinh.Size = new System.Drawing.Size(200, 20);
            this.datetimeNamSinh.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(10, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(302, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.AutoSize = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(10, 108);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(77, 17);
            this.cbGioiTinh.TabIndex = 2;
            this.cbGioiTinh.Text = "GIỚI TÍNH";
            this.cbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NĂM SINH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "HỌ VÀ TÊN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ĐTB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ĐTB";
            // 
            // frmChiTietSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChiTietSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN CHI TIẾT - PHAN XUÂN NHIÊN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabpageVatLy.ResumeLayout(false);
            this.tabpageVatLy.PerformLayout();
            this.tabpageCNTT.ResumeLayout(false);
            this.tabpageCNTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btBoSung;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabpageVatLy;
        private System.Windows.Forms.DateTimePicker datetimeNamSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.CheckBox cbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabpageCNTT;
        private System.Windows.Forms.TabPage tabpageVanHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem2;
        private System.Windows.Forms.TextBox txtVatLy2;
        private System.Windows.Forms.TextBox txtVatLy1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
    }
}

