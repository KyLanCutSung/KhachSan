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
    public partial class frmLoaiPhong : Form
    {
        DataTable tblLoaiPhong;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        public void load()
        {
            string sql;
            sql = "select maloai,tenloai from tblloaiphong";
            tblLoaiPhong = Class.Functions.getdatatotable(sql);
            dgridloaiphong.DataSource = tblLoaiPhong;
        }
        public void reset()
        {
            txtmaloaiphong.Text = "";
            txttenloaiphong.Text = "";
        }
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            txtmaloaiphong.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            load();
            dgridloaiphong.DataSource = tblLoaiPhong;
            dgridloaiphong.Columns[0].HeaderText = "Mã loại phòng";
            dgridloaiphong.Columns[1].HeaderText = "Tên loại phòng";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmaloaiphong.Enabled = true;
            txtmaloaiphong.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLoaiPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloaiphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloaiphong.Focus();
                return;
            }
            sql = "update tblloaiphong set tenloai=N'" + txttenloaiphong.Text.Trim() + "' where maloai=N'" + txtmaloaiphong.Text.Trim() + "'";
            Class.Functions.runsql(sql);
            load();
            reset();
            btnhuy.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLoaiPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloaiphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblloaiphong where maloai = N'" + txtmaloaiphong.Text + "'";
                Class.Functions.runsql(sql);
                load();
                reset();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloaiphong.Focus();
                return;
            }
            if (txttenloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloaiphong.Focus();
                return;
            }
            sql = "SELECT maloai FROM tblloaiphong WHERE maloai=N'" + txtmaloaiphong.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql))
            {
                MessageBox.Show("Mã phòng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloaiphong.Focus();
                txtmaloaiphong.Text = "";
                return;
            }
            sql = "insert into tblloaiphong(maloai,tenloai) values (N'" + txtmaloaiphong.Text.Trim() + "',N'" + txttenloaiphong.Text.Trim() + "')";
            Class.Functions.runsql(sql);
            load();
            reset();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmaloaiphong.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaloaiphong.Enabled = false;
            reset();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgridloaiphong_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Ban đang ở chế độ thêm mới ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblLoaiPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaloaiphong.Text = dgridloaiphong.CurrentRow.Cells["Maloai"].Value.ToString();
            txttenloaiphong.Text = dgridloaiphong.CurrentRow.Cells["Tenloai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = true;
        }
    }
}
