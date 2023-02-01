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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void linklblquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmquenmatkhau quenmk = new frmquenmatkhau();
            quenmk.ShowDialog();
        }

        private void linklbldangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdangki dangki = new frmdangki();
            dangki.ShowDialog();
        }
        modify modify = new modify();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu");
            }
            else
            {
                string query = "select * from tbltaikhoan where taikhoan ='" + tentk + "'and matkhau ='" + matkhau + "'";
                if (modify.taikhoans(query).Count > 0)
                {
                    //MessageBox.Show("da dang nhap thanh cong");
                    this.Hide();
                    frmMain homes = new frmMain();
                    homes.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
        }
    }
}
