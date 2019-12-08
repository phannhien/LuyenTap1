namespace sinhviens
{
    partial class frmBoSung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDiem1 = new System.Windows.Forms.Label();
            this.txtTenDiem2 = new System.Windows.Forms.Label();
            this.txtThemHoTen = new System.Windows.Forms.TextBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.cbThemGioiTinh = new System.Windows.Forms.CheckBox();
            this.datetimeThemTime = new System.Windows.Forms.DateTimePicker();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.btBoSungThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa";
            // 
            // txtTenDiem1
            // 
            this.txtTenDiem1.AutoSize = true;
            this.txtTenDiem1.Location = new System.Drawing.Point(55, 203);
            this.txtTenDiem1.Name = "txtTenDiem1";
            this.txtTenDiem1.Size = new System.Drawing.Size(40, 13);
            this.txtTenDiem1.TabIndex = 4;
            this.txtTenDiem1.Text = "Điểm 1";
            // 
            // txtTenDiem2
            // 
            this.txtTenDiem2.AutoSize = true;
            this.txtTenDiem2.Location = new System.Drawing.Point(55, 244);
            this.txtTenDiem2.Name = "txtTenDiem2";
            this.txtTenDiem2.Size = new System.Drawing.Size(40, 13);
            this.txtTenDiem2.TabIndex = 5;
            this.txtTenDiem2.Text = "Điểm 2";
            // 
            // txtThemHoTen
            // 
            this.txtThemHoTen.Location = new System.Drawing.Point(181, 37);
            this.txtThemHoTen.Name = "txtThemHoTen";
            this.txtThemHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtThemHoTen.TabIndex = 6;
            // 
            // txtDiem1
            // 
            this.txtDiem1.Location = new System.Drawing.Point(181, 203);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(200, 20);
            this.txtDiem1.TabIndex = 7;
            // 
            // txtDiem2
            // 
            this.txtDiem2.Location = new System.Drawing.Point(181, 244);
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(200, 20);
            this.txtDiem2.TabIndex = 8;
            // 
            // cbThemGioiTinh
            // 
            this.cbThemGioiTinh.AutoSize = true;
            this.cbThemGioiTinh.Location = new System.Drawing.Point(181, 71);
            this.cbThemGioiTinh.Name = "cbThemGioiTinh";
            this.cbThemGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.cbThemGioiTinh.TabIndex = 9;
            this.cbThemGioiTinh.Text = "Nam";
            this.cbThemGioiTinh.UseVisualStyleBackColor = true;
            // 
            // datetimeThemTime
            // 
            this.datetimeThemTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.datetimeThemTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeThemTime.Location = new System.Drawing.Point(181, 110);
            this.datetimeThemTime.Name = "datetimeThemTime";
            this.datetimeThemTime.Size = new System.Drawing.Size(200, 20);
            this.datetimeThemTime.TabIndex = 10;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Items.AddRange(new object[] {
            "CNTT"});
            this.cbbTenKhoa.Location = new System.Drawing.Point(181, 155);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(200, 21);
            this.cbbTenKhoa.TabIndex = 11;
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTenKhoa_SelectedIndexChanged);
            // 
            // btBoSungThem
            // 
            this.btBoSungThem.Location = new System.Drawing.Point(218, 290);
            this.btBoSungThem.Name = "btBoSungThem";
            this.btBoSungThem.Size = new System.Drawing.Size(75, 23);
            this.btBoSungThem.TabIndex = 12;
            this.btBoSungThem.Text = "Thêm";
            this.btBoSungThem.UseVisualStyleBackColor = true;
            this.btBoSungThem.Click += new System.EventHandler(this.btBoSungThem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btBoSungThem);
            this.Controls.Add(this.cbbTenKhoa);
            this.Controls.Add(this.datetimeThemTime);
            this.Controls.Add(this.cbThemGioiTinh);
            this.Controls.Add(this.txtDiem2);
            this.Controls.Add(this.txtDiem1);
            this.Controls.Add(this.txtThemHoTen);
            this.Controls.Add(this.txtTenDiem2);
            this.Controls.Add(this.txtTenDiem1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBoSung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBoSung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBoSung_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTenDiem1;
        private System.Windows.Forms.Label txtTenDiem2;
        private System.Windows.Forms.TextBox txtThemHoTen;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtDiem2;
        private System.Windows.Forms.CheckBox cbThemGioiTinh;
        private System.Windows.Forms.DateTimePicker datetimeThemTime;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Button btBoSungThem;
        private System.Windows.Forms.Button button2;
    }
}