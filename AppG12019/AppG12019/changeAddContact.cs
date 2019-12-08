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
    public partial class changeAddContact : Form
    {
        public changeAddContact()
        {
            InitializeComponent();
        }

        private void TxtAdd_Click(object sender, EventArgs e)
        {
            string pathData = @"D:\Lập trình\NetFramework\AppG12019\AppG12019\Data\contacts.data";
            using (StreamWriter sw = new StreamWriter(pathData,true))
            {
                sw.Write("\n"+txtAddName.Text+"#"+txtAddName.Text+"#"+txtAddEmail.Text);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
