using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmtimkiem : Form
    {
        public frmtimkiem()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Forms.frmTimPhong a = new Forms.frmTimPhong();
            a.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.frmTKKhachHang a = new Forms.frmTKKhachHang();
            a.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmTKNhanVien a = new Forms.frmTKNhanVien();
            a.Show();
            Close();
        }
    }
}
