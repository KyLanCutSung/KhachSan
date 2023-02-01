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
    public partial class frmquenmatkhau : Form
    {
        public frmquenmatkhau()
        {
            InitializeComponent();
            lblketqua.Text = "";
        }
        modify modify = new modify();
        private void btnlaylaimk_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập email");
            }
            else
            {
                string query = "select * from tbltaikhoan where email='" + email + "'";
                if (modify.taikhoans(query).Count != 0)
                {
                    lblketqua.ForeColor = Color.Blue;
                    lblketqua.Text = "Mat khau: " + modify.taikhoans(query)[0].Matkhau;
                }
                else
                {
                    lblketqua.ForeColor = Color.Red;
                    lblketqua.Text = "Email chưa được đăng ký!";
                }
            }
        }
    }
}
