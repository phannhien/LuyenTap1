using AppG12019.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019
{
    public partial class frmContacts : Form
    {
        //Contacts contact;
        string pathContacts = @"E:\HOCTAP\Lập trình\NetFramework\AppG12019\AppG12019\Data\contacts.data";
        public frmContacts()
        {
            InitializeComponent();
            dgvContact.DataSource = Contacts.getListFromFile(pathContacts);
        }

        private void TxtAdd1_Click(object sender, EventArgs e)
        {
            var k = new changeAddContact();
            k.ShowDialog();
        }
    }
}
