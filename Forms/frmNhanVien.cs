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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtmanv.Enabled = false;
            Load_dtgridview();
            Class.Functions.fillcombo("select mabophan, tenbophan from tblbophan", cbomabp, "mabophan", "tenbophan");
            cbomabp.SelectedIndex = -1;
       
        }

       
            DataTable tblnv;
            private void Load_dtgridview()
            {
                string sql;
                sql = "select * from tblnhanvien ";
                tblnv = Class.Functions.getdatatotable(sql);
                dgridNV.DataSource = tblnv;
                dgridNV.Columns[0].HeaderText = "Mã nhân viên";
                dgridNV.Columns[1].HeaderText = "Tên nhân viên";
                dgridNV.Columns[2].HeaderText = "Mã bộ phận";
                dgridNV.Columns[3].HeaderText = "Địa chỉ";
                dgridNV.Columns[4].HeaderText = "Điện thoại";
                dgridNV.Columns[5].HeaderText = "Ngày sinh";
                dgridNV.Columns[6].HeaderText = "Giới Tính";

                dgridNV.AllowUserToResizeRows = false;
                dgridNV.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        private void dgridNV_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu nhan vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtmanv.Text = dgridNV.CurrentRow.Cells["manhanvien"].Value.ToString();
            txttennv.Text = dgridNV.CurrentRow.Cells["tennhanvien"].Value.ToString();
            if (dgridNV.CurrentRow.Cells["gioitinhnv"].Value.ToString() == "Nam")
                chknam.Checked = true;
            else
                chknam.Checked = false;
            txtdiachi.Text = dgridNV.CurrentRow.Cells["diachinv"].Value.ToString();
            mskdienthoai.Text = dgridNV.CurrentRow.Cells["dienthoainv"].Value.ToString();
            mskngaysinh.Text = dgridNV.CurrentRow.Cells["ngaysinhnv"].Value.ToString();
            string ma;
            ma = dgridNV.CurrentRow.Cells["mabophan"].Value.ToString();
            cbomabp.Text = Class.Functions.getfilevalue("select tenbophan from tblbophan where mabophan = N'" + ma + "'");
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset()
        {
            txtmanv.Text = "";
            txtmanv.Enabled = false;
            txttennv.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            mskngaysinh.Text = "";
            cbomabp.Text = "";
            chknam.Checked = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btndong.Enabled = true;
        }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btndong.Enabled = false;
            txtmanv.Enabled = true;
            txtmanv.Focus();
            txtmanv.Text = "";
            txttennv.Text = "";
            cbomabp.Text = "";
            //chknam.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            mskngaysinh.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttennv.Focus();
                return;
            }
            if (cbomabp.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã bộ phận trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbomabp.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạnchưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            string gioitinh;
            if (chknam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            if (mskngaysinh.Text == "  /  /   ")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (mskdienthoai.Text == " (   )    -     ")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
            string sql;
            sql = "select manhanvien from tblnhanvien where manhanvien = N'" + txtmanv.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql) == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Text = "";
                txtmanv.Focus();
                return;
            }

            sql = "insert into tblnhanvien(manhanvien, tennhanvien, mabophan, diachinv, dienthoainv, ngaysinhnv, gioitinhnv) values(N'" + txtmanv.Text.Trim() + "', N'" + txttennv.Text.Trim() + "', N'" + cbomabp.SelectedValue.ToString() + "', N'" + txtdiachi.Text.Trim() + "', '" + mskdienthoai.Text.Trim() + "', '" + Class.Functions.vcovertDateTime(mskngaysinh.Text.Trim()) + "' , N'" + gioitinh + "')";
            Class.Functions.runsql(sql);
            Load_dtgridview();
            reset();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttennv.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -    ")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "  /  /    ")
            {
                MessageBox.Show("Ban chua nhap ngay sinh de sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            string gioitinh;
            if (chknam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            string sql;
            sql = "update tblnhanvien set tennhanvien = N'" + txttennv.Text.Trim() + "', gioitinhnv = N'" + gioitinh + "', diachinv = N'" + txtdiachi.Text.Trim() + "', dienthoainv = '" + mskdienthoai.Text.Trim() + "', ngaysinhnv = '" + Class.Functions.vcovertDateTime(mskngaysinh.Text.Trim()) + "', mabophan = N'" + cbomabp.SelectedValue.ToString() + "' where manv = N'" + txtmanv.Text.Trim() + "'";
            Class.Functions.runsql(sql);
            Load_dtgridview();
            reset();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete from tblnhanvien where manhanvien = N'" + txtmanv.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                Load_dtgridview();
                reset();
            }
        }

        private void mskngaysinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chknam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
