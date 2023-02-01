using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Ketnoi();
        }

       

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Ngatketnoi();
            Application.Exit();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang a = new Forms.frmKhachHang();
            a.Show();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien a = new Forms.frmNhanVien();
            a.Show();
        }

        private void mnuBophan_Click(object sender, EventArgs e)
        {
            Forms.frmBoPhan a = new Forms.frmBoPhan();
            a.Show();
        }

        private void mnutkNhanVien_Click(object sender, EventArgs e)
        {
            Forms.frmTKNhanVien a = new Forms.frmTKNhanVien();
            a.Show();
        }

        private void mnuTKKH_Click(object sender, EventArgs e)
        {
            Forms.frmTKKhachHang a = new Forms.frmTKKhachHang();
            a.Show();
        }

        private void mnuTimPhong_Click(object sender, EventArgs e)
        {
            Forms.frmTimPhong a = new Forms.frmTimPhong();
            a.Show();
        }

        private void mnuDichvu_Click(object sender, EventArgs e)
        {
            Forms.frmdichvu a = new Forms.frmdichvu();
            a.Show();
        }

        private void mnuThuedichvu_Click(object sender, EventArgs e)
        {
            Forms.frmThanhtoandv a = new Forms.frmThanhtoandv();
            a.Show();
        }

        private void mnuHDTT_Click(object sender, EventArgs e)
        {
            Forms.frmThanhToanPhong a = new Forms.frmThanhToanPhong();
            a.Show();
        }

        private void mnuHDN_Click(object sender, EventArgs e)
        {
            Forms.frmdoanhthu a = new Forms.frmdoanhthu();
            a.Show();
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            Forms.frmPhong a = new Forms.frmPhong();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.frmPhong a = new Forms.frmPhong();
            a.Show();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmLoaiPhong a = new Forms.frmLoaiPhong();
            a.Show();
        }

        private void loạiGườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmguong a = new Forms.frmguong();
            a.Show();
        }

        private void dãyNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmdaynha a = new Forms.frmdaynha();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien a = new Forms.frmNhanVien();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.frmdichvu a = new Forms.frmdichvu();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.frmtimkiem a = new Forms.frmtimkiem();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms.frmLienhe a = new Forms.frmLienhe();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang a = new Forms.frmKhachHang();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.frmdangnhap a = new Forms.frmdangnhap();
            a.ShowDialog();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmthuephong a = new Forms.frmthuephong();
            a.Show();
        }
    }
}
