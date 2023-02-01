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
    public partial class frmPhong : Form
    {
        DataTable tblp;
        public frmPhong()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtmaphong.Clear();
            txttenphong.Clear();
            txtdongiangay.Clear();
            txttinhtrang.Clear();
            cbbmadaynha.Text = "";
            cbbmaloaigiuong.Text = "";
            cbbmaloaiphong.Text = "";
            txtghichu.Clear();
        }
        private void load_datagrid()
        {
            string sql;
            sql = "select maphong, tenphong, madaynha, maloai, magiuong, dongiangay, tinhtrang, ghichu from tblphong";
            tblp = Class.Functions.getdatatotable(sql);
            dgvthongtincacphongkhachsan.DataSource = tblp;
            dgvthongtincacphongkhachsan.Columns[0].HeaderText = "Mã phòng";
            dgvthongtincacphongkhachsan.Columns[1].HeaderText = "Tên phòng";
            dgvthongtincacphongkhachsan.Columns[2].HeaderText = "Mã nhà";
            dgvthongtincacphongkhachsan.Columns[3].HeaderText = "Mã loại phòng";
            dgvthongtincacphongkhachsan.Columns[4].HeaderText = "Mã giường";
            dgvthongtincacphongkhachsan.Columns[5].HeaderText = "Đơn giá ngày";
            dgvthongtincacphongkhachsan.Columns[6].HeaderText = "Tình trạng";
            dgvthongtincacphongkhachsan.Columns[7].HeaderText = "Ghi chú";
            dgvthongtincacphongkhachsan.AllowUserToAddRows = false;
            dgvthongtincacphongkhachsan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            txtmaphong.Enabled = false;
            btnluu.Enabled = false;
            btnluu.Enabled = false;
            load_datagrid();
            Class.Functions.fillcombo("select madaynha, tendaynha from tbldaynha", cbbmadaynha, "madaynha", "tendaynha");
            cbbmadaynha.SelectedIndex = -1;
            Class.Functions.fillcombo("select maloai, tenloai from tblloaiphong", cbbmaloaiphong, "maloai", "tenloai");
            cbbmaloaiphong.SelectedIndex = -1;
            Class.Functions.fillcombo("select magiuong, tengiuong from tblgiuong", cbbmaloaigiuong, "magiuong", "tengiuong");
            cbbmaloaigiuong.SelectedIndex = -1;
            resetvalues();
        }
        private void dgvthongtincacphongkhachsan_Click(object sender, EventArgs e)
        {
            string a, b, c;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvthongtincacphongkhachsan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtmaphong.Text = dgvthongtincacphongkhachsan.CurrentRow.Cells["maphong"].Value.ToString();
            txttenphong.Text = dgvthongtincacphongkhachsan.CurrentRow.Cells["tenphong"].Value.ToString();
            txtdongiangay.Text = dgvthongtincacphongkhachsan.CurrentRow.Cells["dongiangay"].Value.ToString();
            txttinhtrang.Text = dgvthongtincacphongkhachsan.CurrentRow.Cells["tinhtrang"].Value.ToString();
            txtghichu.Text = dgvthongtincacphongkhachsan.CurrentRow.Cells["ghichu"].Value.ToString();
            a = dgvthongtincacphongkhachsan.CurrentRow.Cells["madaynha"].Value.ToString();
            cbbmadaynha.Text = Class.Functions.getfilevalue("select tendaynha from tbldaynha where madaynha =N'" + a + "'");
            b = dgvthongtincacphongkhachsan.CurrentRow.Cells["maloai"].Value.ToString();
            cbbmaloaiphong.Text = Class.Functions.getfilevalue("select tenloai from tblloaiphong where maloai =N'" + b + "'");
            c = dgvthongtincacphongkhachsan.CurrentRow.Cells["magiuong"].Value.ToString();
            cbbmaloaigiuong.Text = Class.Functions.getfilevalue("select tengiuong from tblgiuong where magiuong =N'" + c + "'");
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmaphong.Enabled = true;
            txtmaphong.Focus();
            btnluu.Enabled = true;
        }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtmaphong.Enabled = false;
            btnluu.Enabled = false;
            resetvalues();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphong.Focus();
                return;
            }
            if (txttenphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenphong.Focus();
                return;
            }
            if (txtdongiangay.Text == "")
            {
                MessageBox.Show("Bạn phải đơn giá ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdongiangay.Focus();
                return;
            }
            if (txttinhtrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tình trạng phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttinhtrang.Focus();
                return;
            }
            if (cbbmadaynha.Text == "")
            {
                MessageBox.Show("Bạn phải chọn dãy nhà!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbmadaynha.Focus();
                return;
            }
            if (cbbmaloaigiuong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn loại giường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbmaloaigiuong.Focus();
                return;
            }
            if (cbbmaloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbmaloaiphong.Focus();
                return;
            }
            string sql;
            sql = "select maphong from tblphong where maphong = N'" + txtmaphong.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql))
            {
                MessageBox.Show("Bị trùng mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphong.Clear();
                txtmaphong.Focus();
                return;
            }
            sql = "select maphong from tblphong where tenphong = N'" + txttenphong.Text + "'";
            if (Class.Functions.checkkey(sql))
            {
                MessageBox.Show("Bị trùng tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenphong.Clear();
                txttenphong.Focus();
                return;
            }
            sql = "Insert into tblphong (maphong, tenphong, dongiangay, tinhtrang, ghichu, madaynha, maloai, magiuong) values (N'" + txtmaphong.Text.Trim() + "', N'" + txttenphong.Text.Trim() + "', " + txtdongiangay.Text + ", N'" + txttinhtrang.Text.Trim() + "', N'" + txtghichu.Text.Trim() + "', N'" + cbbmadaynha.SelectedValue.ToString() + "', N'" + cbbmaloaiphong.SelectedValue.ToString() + "', N'" + cbbmaloaigiuong.SelectedValue.ToString() + "' )";
            Class.Functions.runsql(sql);
            load_datagrid();
            resetvalues();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtmaphong.Enabled = false;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenphong.Focus();
                return;
            }
            if (txtdongiangay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongiangay.Focus();
                return;
            }
            if (txttinhtrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tình trạng phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttinhtrang.Focus();
                return;
            }
            if (cbbmadaynha.Text == "")
            {
                MessageBox.Show("Bạn phải chọn dãy nhà!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmadaynha.Focus();
                return;
            }
            if (cbbmaloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmaloaiphong.Focus();
                return;
            }
            if (cbbmaloaigiuong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn loại giường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmaloaigiuong.Focus();
                return;
            }
            sql = "Update tblphong set tenphong = N'" + txttenphong.Text.Trim() + "', dongiangay = " + txtdongiangay.Text + ", ghichu = N'" + txtghichu.Text + "', madaynha = N'" + cbbmadaynha.SelectedValue.ToString() + "', maloai = N'" + cbbmaloaiphong.SelectedValue.ToString() + "', magiuong = N'" + cbbmaloaigiuong.SelectedValue.ToString() + "', tinhtrang = N'" + txttinhtrang.Text.Trim() + "' where maphong = N'" + txtmaphong.Text + "'";
            Class.Functions.runsql(sql);
            load_datagrid();
            resetvalues();
            btnboqua.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblphong where maphong = N'" + txtmaphong.Text + "'";
                Class.Functions.runsql(sql);
                load_datagrid();
                resetvalues();
            }
        }
        private void txtdongiangay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
