using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyKhachSan.Forms
{
    public partial class frmdangki : Form
    {
        public frmdangki()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac) //check ten tai khoan va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9]{6,24}@gmail.com(.vn|)$");
        }
        modify modify = new modify();
        private void btndangki_Click(object sender, EventArgs e)
        {
            string tentk = txttendangnhap.Text;
            string matkhau = txtmatkhau.Text;
            string xacnhan = txtxacnhanmk.Text;
            string email = txtemail.Text;
            if (!checkAccount(tentk))
            {
                MessageBox.Show("tên đăng nhập có định dạng: a-z; A-Z; 0-9; 6-24 kí tự");
                return;
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("Mật khẩu có định dạng: a-z; A-Z; 0-9; 6-24 kí tự");
                return;
            }
            if (xacnhan != matkhau)
            {
                MessageBox.Show("Không giống mật khẩu ở trên");
                lblxacnhanmk.ForeColor = Color.Red;
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return;
            }
            if (modify.taikhoans("select * from tbltaikhoan where email='" + email + "'").Count != 0)
            {
                MessageBox.Show("Email đã được đăng ký. Hãy đăng nhập");
                return;
            }
            try
            {
                string query = "insert into tbltaikhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
            }
            catch
            {
                MessageBox.Show("Tài khoản được đăng kí thành công!");
            }
        }
    }
}
