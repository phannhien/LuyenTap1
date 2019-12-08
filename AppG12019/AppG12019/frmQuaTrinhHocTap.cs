using AppG12019.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019
{
    public partial class frmQuaTrinhHocTap : Form
    {
        QuaTrinhHocTap quaTrinhHocTap;
        //private object pathData;

        public frmQuaTrinhHocTap(QuaTrinhHocTap quaTrinhHocTap = null)
        {
            InitializeComponent();
            this.quaTrinhHocTap = quaTrinhHocTap;
            if (quaTrinhHocTap == null)
            {
                this.Text = "Thêm mới quá trình học tập";
            }
            else
            {
                this.Text = "Chỉnh sửa quá trình học tập";
                //numTuNam.Value = quaTrinhHocTap.TuNam;
                //numDenNam.Value = quaTrinhHocTap.DenNam;
                //txtHocTai.Text = quaTrinhHocTap.HocTai;
            }
        }

        private void BtDongY_Click(object sender, EventArgs e)
        {
            if(quaTrinhHocTap != null)
            {
                MessageBox.Show("Viet cap nhat tai day");
            }
            else
            {
                string pathData = @"D:\Lập trình\NetFramework\AppG12019\AppG12019\Data\learninghistory.data";
                using (StreamWriter sw = File.AppendText(pathData))
                {
                    string text = numTuNam.Value.ToString() + "#" + numDenNam.Value.ToString() + "#" + txtHocTai.Text;
                    sw.WriteLine( "\n"+text + Environment.NewLine);
                }
                MessageBox.Show("Dã cập nhật thành công");
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
