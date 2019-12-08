using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sinhviens.DAL.Entity;

namespace sinhviens
{
    public partial class frmChinhSua : Form
    {
        private frmChiTietSinhVien frmChiTietSinhVien;
        sinhvien sv;
        public frmChinhSua(frmChiTietSinhVien frmChiTietSinhVien, sinhvien sv)
        {
            InitializeComponent();
            this.sv = sv;
            this.frmChiTietSinhVien = frmChiTietSinhVien;
            txtChinhSuaHoTen.Text = sv.HoTen;
            if (sv.GioiTinh.ToString().Equals("True"))
            {
                cbChinhSuaGioiTinh.Checked = true;
                cbChinhSuaGioiTinh.Text = "Nam";
            }
            else
            {
                cbChinhSuaGioiTinh.Checked = false;
                cbChinhSuaGioiTinh.Text = "Nam";
            }
            datetimeChinhSua.Value = DateTime.Parse(sv.NgaySinh.ToString("MM/dd/yyyy"));
            txtChinhSuaKhoa.Text = sv.TenKhoa.ToString();

            if (txtChinhSuaKhoa.Text.Equals("CNTT"))
            {
                lbtendiem1capnhat.Text = "Java Nâng Cao:";
                lbtendiem2capnhat.Text = "Mẫu Thiết Kế:";
            }
        }

        private void btChinhSua_Click(object sender, EventArgs e)
        {
            sv.HoTen = txtChinhSuaHoTen.Text;
            if (MessageBox.Show(
               "Bạn có thật sự muốn xóa không?",
               "Thông báo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                sinhvien.Edit(sv);
                this.Close();
            }
        }
    }
}
