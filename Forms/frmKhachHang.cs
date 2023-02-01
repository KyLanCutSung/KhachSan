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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtmakh.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_dtgrid();
        }

        DataTable tblkh;
        private void load_dtgrid()
        {
            string sql;
            sql = "select * from tblkhachhang";
            tblkh = Class.Functions.getdatatotable(sql);
            dgridKH.DataSource = tblkh;

            dgridKH.Columns[0].HeaderText = "Mã khách";
            dgridKH.Columns[1].HeaderText = "Tên khách";
            dgridKH.Columns[2].HeaderText = "Địa chỉ";
            dgridKH.Columns[3].HeaderText = "Điện thoại";
            dgridKH.Columns[4].HeaderText = "Hạng";
            dgridKH.Columns[5].HeaderText = "Ngày sinh";
            dgridKH.Columns[6].HeaderText = "Số CCCD";
            dgridKH.AllowUserToAddRows = false;
            dgridKH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgridKH_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
                {
                    MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmakh.Focus();
                    return;
                }
                if (tblkh.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtmakh.Text = dgridKH.CurrentRow.Cells["makhachhang"].Value.ToString();
                txttenkh.Text = dgridKH.CurrentRow.Cells["tenkhachhang"].Value.ToString();
                txtcccd.Text = dgridKH.CurrentRow.Cells["cccd"].Value.ToString();
                txthang.Text = dgridKH.CurrentRow.Cells["hangkh"].Value.ToString();
                mskngaysinh.Text = dgridKH.CurrentRow.Cells["ngaysinhkh"].Value.ToString();
                txtdiachi.Text = dgridKH.CurrentRow.Cells["diachikh"].Value.ToString();
                mskdienthoai.Text = dgridKH.CurrentRow.Cells["dienthoaikh"].Value.ToString();

            }

            private void resetvalue()
            {
                txtmakh.Text = "";
                txttenkh.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
                btnluu.Enabled = false;
                btnboqua.Enabled = false;
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                txtcccd.Text = "";
                mskngaysinh.Text = "";
                txthang.Text = "";
            }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmakh.Enabled = true;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmakh.Focus();
            btnthem.Enabled = false;
            txtcccd.Text = "";
            mskngaysinh.Text = "";
            txthang.Text = "";
            txtmakh.Text = "";
            txtdiachi.Text = "";
            txttenkh.Text = "";
            mskdienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Focus();
                return;
            }
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   ) -")
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "  /  /   ")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (txthang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hạng khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthang.Focus();
                return;
            }
            string sql;
            sql = "select makhachhang from tblkhachhang where makhachhang = N'" + txtmakh.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql) == true)
            {
                MessageBox.Show("Thông tin khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Text = "";
                txtmakh.Focus();
            }
           
            sql = "insert into tblkhachhang values (N'" + txtmakh.Text.Trim() + "', N'" + txttenkh.Text.Trim() + "', N'" + txtdiachi.Text.Trim() + "','" + mskdienthoai.Text.Trim() + "', N'" + txthang.Text.Trim() + "', '" + Class.Functions.vcovertDateTime(mskngaysinh.Text.Trim()) + "' ,N'" + txtcccd.Text.Trim() + "')";
            Class.Functions.runsql(sql);
            load_dtgrid();
            resetvalue();
       
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Focus();
                return;
            }
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa sửa tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa sửa địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   ) -")
            {
                MessageBox.Show("Bạn chưa sửa điện thoại khách hàng", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "  /  /   ")
            {
                MessageBox.Show("Bạn chưa sửa ngày sinh khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (MessageBox.Show("Bạn muốn sửa thông tin khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "update tblkhachhang set tenkhachhang = N'" + txttenkh.Text.Trim() + "', diachikh = N'" + txtdiachi.Text.Trim() + "', dienthoaikh = '" + mskdienthoai.Text.Trim() + "', hangkh = N'" + txthang.Text.Trim() + "', ngaysinhkh = '" + Class.Functions.vcovertDateTime(mskngaysinh.Text.Trim()) + "' , cccd = N'" + txtcccd.Text.Trim() + "' where makh = N'" + txtmakh.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_dtgrid();
                resetvalue();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin khách hàng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete from tblkhachhang where makhachhang = N'" + txtmakh.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_dtgrid();
                resetvalue();
            }
        }
    }
    }

