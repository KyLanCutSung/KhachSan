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
    public partial class frmthuephong : Form
    {
        DataTable tbtkp, tbdl;
        public frmthuephong()
        {
            InitializeComponent();
        }
        private void resetvalue()
        {
            cobdaynha.SelectedIndex = -1;
            cobdaynha.Text = "Tên dãy nhà";
            cobtennhanvien.SelectedIndex = -1;
            cobtennhanvien.Text = "Tên nhân viên";
            cobmakhach.SelectedIndex = -1;
            cobmakhach.Text = "Mã khách";
            txttiendatcoc.Text = "Tiền đặt cọc";
            txtmadachon.Text = "Mã đã chọn";

        }

        private void bttthue_Click(object sender, EventArgs e)
        {
            if (cobdaynha.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn dãy nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cobtennhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cobmakhach.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txttiendatcoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tiền đặt cọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttiendatcoc.Focus();
                return;
            }
            string sql;
            string ma, a, ngay;
            ma = datagridtk.CurrentRow.Cells["maphong"].Value.ToString();
            sql = "select tinhtrang from tblphong where maphong=N'" + ma + "'";
            a = "Full";
            if (Class.Functions.getfilevalue(sql) == a)
            {
                MessageBox.Show("Phòng đã đầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "update tblphong set tinhtrang='" + a + "'";
            Class.Functions.runsql(sql);
            //luu vao thue
            ngay = DateTime.Now.ToShortDateString();
            sql = "insert into tblthuephong(masothue,makhachhang,maphong,ngayden,tiendatcoc,manhanvien,tinhtrang) values(N'" + txtmasothue.Text.Trim() + "',N'" + cobmakhach.SelectedValue + "',N'" + txtmadachon.Text.Trim() + "',N'" + ngay + "',N'" + txttiendatcoc.Text.Trim() + "',N'" + cobtennhanvien.SelectedValue + "',N'" + a + "')";
            Class.Functions.runsql(sql);
            loaddl();
            resetvalue();
            txtmasothue.Text = Class.Functions.sinhma("THUE");
        }

        private void datagridtk_Click(object sender, EventArgs e)
        {
            txtmadachon.Text = datagridtk.CurrentRow.Cells["maphong"].Value.ToString();
        }

        private void frmthuephong_Load(object sender, EventArgs e)
        {
            Class.Functions.fillcombo("select madaynha,tendaynha from tbldaynha", cobdaynha, "madaynha", "tendaynha");
            cobdaynha.SelectedIndex = -1;
            cobdaynha.Text = "--Tên dãy nhà";
            Class.Functions.fillcombo("select manhanvien,tennhanvien from tblnhanvien", cobtennhanvien, "manhanvien", "tennhanvien");
            cobtennhanvien.SelectedIndex = -1;
            cobtennhanvien.Text = "--Tên nhân viên";
            cobmakhach.SelectedIndex = -1;
            Class.Functions.fillcombo("select makhachhang,tenkhachhang from tblkhachhang", cobmakhach, "makhachhang", "tenkhachhang");
            cobmakhach.SelectedIndex = -1;
            cobmakhach.Text = "Mã khách";
            loaddl();
            txtmasothue.Text = Class.Functions.sinhma("THUE");
        }

        private void cobmakhach_TextChanged(object sender, EventArgs e)
        {
            if (cobmakhach.SelectedIndex == -1)
            {
                txttiendatcoc.Text = "Tiền đặt cọc";
            }
            else
            {
                txttiendatcoc.Text = "";
            }
        }

        private void cobdaynha_TextChanged(object sender, EventArgs e)
        {
            loadtk();
        }

        private void btttailai_Click(object sender, EventArgs e)
        {
            txtmasothue.Text = Class.Functions.sinhma("THUE");
            datagridtk.DataSource = "";
            resetvalue();
        }

        private void bttdong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
    System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
            return;
        }

        private void loaddl()
        {
            string sql;
            sql = "select makhachhang,maphong,ngayden,tiendatcoc,manhanvien from tblthuephong";
            tbdl = Class.Functions.getdatatotable(sql);
            datagriddulieu.DataSource = tbdl;
            datagriddulieu.Columns[0].HeaderText = "Mã khách hàng";
            datagriddulieu.Columns[1].HeaderText = "Mã phòng";
            datagriddulieu.Columns[2].HeaderText = "Ngày đến";
            datagriddulieu.Columns[3].HeaderText = "Tiền đặt cọc";
            datagriddulieu.Columns[4].HeaderText = "Mã nhân viên";
        }
        private void loadtk()
        {
            if (cobdaynha.SelectedIndex != -1)
            {
                string sql;
                sql = "select a.maphong,a.tenphong,a.dongiangay,a.tinhtrang,a.ghichu from tblphong as a where a.madaynha=N'" + cobdaynha.SelectedValue + "'";
                tbtkp = Class.Functions.getdatatotable(sql);
                datagridtk.DataSource = tbtkp;
                datagridtk.Columns[0].HeaderText = "Mã phòng";
                datagridtk.Columns[1].HeaderText = "Tên phòng";
                datagridtk.Columns[2].HeaderText = "Đơn giá ngày";
                datagridtk.Columns[3].HeaderText = "Tình trạng";
                datagridtk.Columns[4].HeaderText = "Ghi chú";
            }

        }
    }
}
