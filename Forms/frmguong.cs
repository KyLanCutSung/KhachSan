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
    public partial class frmguong : Form
    {
        DataTable tblgi;
        public frmguong()
        {
            InitializeComponent();
        }
        private void load_datagrid()//lấy dữ liệu bảng khách hàng cho vào bảng data gridview ở from design
        {
            string sql;
            sql = "select magiuong,tengiuong from tblgiuong";
            //hàm dùng chung viết trong functions.cs 
            tblgi = Class.Functions.getdatatotable(sql);
            dataGridViewGiuong.DataSource = tblgi;
            dataGridViewGiuong.Columns[0].HeaderText = "Mã giường";
            dataGridViewGiuong.Columns[1].HeaderText = "Tên giường";
        }
        private void ressetvalue()
        {
            txtmagiuong.Text = "";
            txttengiuong.Text = "";
        }

        private void frmguong_Load(object sender, EventArgs e)
        {
            txtmagiuong.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_datagrid();
        }

        private void dataGridViewGiuong_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("đang ở chế độ thêm mới", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblgi.Rows.Count == 0)
            {
                MessageBox.Show("ko có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //hiển thị dữ liệu ở hàng được chọn 
            txtmagiuong.Text = dataGridViewGiuong.CurrentRow.Cells["magiuong"].Value.ToString();
            txttengiuong.Text = dataGridViewGiuong.CurrentRow.Cells["tengiuong"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmagiuong.Text == "")
            {
                MessageBox.Show("Chưa nhập mã giường", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagiuong.Focus();
                return;
            }
            if (txttengiuong.Text == "")
            {
                MessageBox.Show("Chưa nhập tên giường", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttengiuong.Focus();
                return;
            }

            string sql;
            sql = "select magiuong from tblgiuong where magiuong=N'" + txtmagiuong.Text.Trim() + "'";
            //kiểm tra trùng mã hay không , viết chung ở functions
            if (Class.Functions.checkkey(sql))
            {
                MessageBox.Show("Bị trùng mã ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagiuong.Text = "";
                txtmagiuong.Focus();
                return;
            }
            sql = "insert into tblgiuong(magiuong,tengiuong)values" + "(N'" + txtmagiuong.Text.Trim() + "',N'" + txttengiuong.Text.Trim() + "')";
            //gọi hàm runsql để chạy câu lệnh trên ...viết chung ở functinon
            Class.Functions.runsql(sql);
            load_datagrid();
            ressetvalue();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtmagiuong.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblgi.Rows.Count == 0)
            {
                MessageBox.Show("ko có dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmagiuong.Text == "")
            {
                MessageBox.Show("chưa có dl được chọn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "update tblgiuong set tengiuong=N'" + txttengiuong.Text.Trim() + "' where magiuong=N'" + txtmagiuong.Text.Trim() + "'";
            Class.Functions.runsql(sql);
            load_datagrid();
            ressetvalue();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblgi.Rows.Count == 0)
            {
                MessageBox.Show("ko có dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmagiuong.Text == "")
            {
                MessageBox.Show("chưa có dl được chọn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string sql;
                sql = "delete tblgiuong where magiuong=N'" + txtmagiuong.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_datagrid();
                ressetvalue();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
                btnboqua.Enabled = false;
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
                btnluu.Enabled = false;
                txtmagiuong.Enabled = false;
                ressetvalue();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            txtmagiuong.Focus();
            txtmagiuong.Enabled = true;
            ressetvalue();
        }
    }
}
