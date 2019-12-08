using sinhviens.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhviens
{
    public partial class frmBoSung : Form
    {
        private frmChiTietSinhVien form;
        public frmBoSung(frmChiTietSinhVien frmChiTietSinhVien)
        {
            InitializeComponent();
            this.form = frmChiTietSinhVien;
        }

        private void btBoSungThem_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien
            {
                MSV = (sinhvien.GetSinhVien().Count+1).ToString(),
                HoTen = txtThemHoTen.Text,
                GioiTinh = cbThemGioiTinh.Checked,
                NgaySinh = DateTime.Parse(datetimeThemTime.Value.ToString("dd/MM/yyyy")),
                Diem1 = txtDiem1.Text,
                Diem2= txtDiem2.Text
            };
            if (MessageBox.Show(
               "Bạn có thật sự muốn xóa không?",
               "Thông báo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                sinhvien.Add(sv);
                this.Close();
            }
        }

        private void frmBoSung_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.reloadsinhvien();
        }

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenKhoa.Text.Equals("CNTT"))
            {
                txtTenDiem1.Text = "Lập Trình 1:";
                txtTenDiem2.Text = "Lập Trình 2:";
            }
        }
    }
}
