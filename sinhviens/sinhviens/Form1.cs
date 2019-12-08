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
    public partial class frmChiTietSinhVien : Form
    {
        public frmChiTietSinhVien()
        {
            InitializeComponent();
            Load();
            dgvSinhVien.Refresh();
        }
        public void Load()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.DataSource = sinhvien.GetSinhVien();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                DataGridViewRow selectRow = dgvSinhVien.Rows[index];
                string hoTen = selectRow.Cells["HoTen"].Value.ToString();
                string gioiTinh = selectRow.Cells["GioiTinh"].Value.ToString();
                datetimeNamSinh.Value = DateTime.Parse(selectRow.Cells["NgaySinh"].Value.ToString());
                txtHoTen.Text = hoTen.ToString();
                if (gioiTinh.Equals("True")){
                    cbGioiTinh.Checked = true;
                    cbGioiTinh.Text = "Nam";
                }
                else
                {
                    cbGioiTinh.Checked = false;
                }
                    
                string tenKhoa = selectRow.Cells["TenKhoa"].Value.ToString();
                if (tenKhoa.Equals("CNTT"))
                {
                    tabPage.SelectedTab=tabpageCNTT;
                    txtVatLy1.Text = selectRow.Cells["Diem1"].Value.ToString();
                    txtVatLy2.Text = selectRow.Cells["Diem2"].Value.ToString();
                }
            }
        }
        public void reloadsinhvien()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.DataSource = sinhvien.GetSinhVien();
            dgvSinhVien.Refresh();
        }
        private void btBoSung_Click(object sender, EventArgs e)
        {
            var bosung = new frmBoSung(this);
            bosung.Show();
        }
        private void txtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có thực sự muốn xóa?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                dgvSinhVien.CurrentRow.Selected = true;
                sinhvien sv = new sinhvien
                {
                    MSV = dgvSinhVien.SelectedCells[0].Value.ToString(),
                    HoTen = dgvSinhVien.SelectedCells[1].Value.ToString(),
                    GioiTinh =  Boolean.Parse(dgvSinhVien.SelectedCells[2].Value.ToString()),
                    NgaySinh = DateTime.Parse(dgvSinhVien.SelectedCells[3].Value.ToString()),
                    TenKhoa = dgvSinhVien.SelectedCells[4].Value.ToString(),
                    Diem1 = dgvSinhVien.SelectedCells[5].Value.ToString(),
                    Diem2 = dgvSinhVien.SelectedCells[6].Value.ToString()

                };
                sinhvien.Remove(sv);
                MessageBox.Show("Đã xóa thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Load();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            dgvSinhVien.CurrentRow.Selected = true;
            sinhvien sv = new sinhvien
            {
                MSV = dgvSinhVien.SelectedCells[0].Value.ToString(),
                HoTen = dgvSinhVien.SelectedCells[1].Value.ToString(),
                GioiTinh = Boolean.Parse(dgvSinhVien.SelectedCells[2].Value.ToString()),
                NgaySinh = DateTime.Parse(dgvSinhVien.SelectedCells[3].Value.ToString()),
                TenKhoa = dgvSinhVien.SelectedCells[4].Value.ToString(),
                Diem1 = dgvSinhVien.SelectedCells[5].Value.ToString(),
                Diem2 = dgvSinhVien.SelectedCells[6].Value.ToString()

            };
            if (sv != null)
            {
                var _f = new frmChinhSua(this, sv);
                _f.ShowDialog();
            }
        }
    }
}
