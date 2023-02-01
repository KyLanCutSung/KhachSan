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
    public partial class frmdichvu : Form
    {
        public frmdichvu()
        {
            InitializeComponent();
        }

        private void txtdongiadichvu_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable tbldv;
        private void txtdongiadichvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void load_datagridview()
        {
            string sql;
            sql = "SELECT madichvu, tendichvu, dongia FROM tbldichvu";
            tbldv = Class.Functions.getdatatotable(sql);
            dgiddichvu.DataSource = tbldv;
            string[] Header = new string[3] { "Mã dịch vụ", "Ten Dịch vụ", "Đơn giá" };
            for (int i = 0; i < Header.Length; i++)
            {
                dgiddichvu.Columns[i].HeaderText = Header[i];
            }
            dgiddichvu.AllowUserToAddRows = false;
            dgiddichvu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void xoatrang()
        {
            txtmadichvu.Clear();
            txttendichvu.Clear();
            txtdongiadichvu.Clear();
        }

        private void frmdichvu_Load(object sender, EventArgs e)
        {
            txtmadichvu.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            Class.Functions.Ketnoi();
            btnhuy.Enabled = false;
            load_datagridview();
            xoatrang();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xoatrang();
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            txtmadichvu.Enabled = true;
            txtmadichvu.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (dgiddichvu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu");
                return;
            }

            if (txtmadichvu.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi!");
                return;
            }

            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                sql = "DELETE tbldichvu WHERE madichvu = N'" + txtmadichvu.Text + "'";
                Class.Functions.runsql(sql);
                load_datagridview();
                xoatrang();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgiddichvu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu");
                return;
            }

            if (txtmadichvu.Text == "")
            {
                MessageBox.Show("Chưa nhập mã dịch vụ");
                txtmadichvu.Focus();
                return;
            }

            if (txttendichvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên dịch vụ");
                txttendichvu.Focus();
                return;
            }


            if (txtdongiadichvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtdongiadichvu.Focus();
                return;
            }

            if (txtdongiadichvu.Text.Contains(','))
            {
                txtdongiadichvu.Text = txtdongiadichvu.Text.Replace(',', '.');
            }
            sql = "UPDATE tbldichvu SET tendichvu = N'" + txttendichvu.Text + "', madichvu = N'" + txtmadichvu.Text + "', dongia = " + txtdongiadichvu.Text + " WHERE madichvu = N'" + txtmadichvu.Text + "'";
            Class.Functions.runsql(sql);
            load_datagridview();
            xoatrang();
            btnhuy.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtmadichvu.Text == "")
            {
                MessageBox.Show("Chưa nhập mã dịch vụ");
                txtmadichvu.Focus();
                return;
            }

            if (txttendichvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên dịch vụ");
                txttendichvu.Focus();
                return;
            }


            if (txtdongiadichvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtdongiadichvu.Focus();
                return;
            }
            sql = "SELECT madichvu FROM tbldichvu WHERE madichvu = N'" + txtmadichvu.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql))
            {
                MessageBox.Show("Mã dịch vụ này đã tồn tại, nhập lại!");
                txtmadichvu.Clear();
                txtmadichvu.Focus();
                return;
            }

            sql = "INSERT INTO tbldichvu VALUES(N'" + txtmadichvu.Text + "', N'" + txttendichvu.Text + "', '" + txtdongiadichvu.Text + "')";
            Class.Functions.runsql(sql);
            load_datagridview();
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txtmadichvu.Enabled = false;
            xoatrang();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            txtmadichvu.Enabled = false;
            xoatrang();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            //DialogResult d = new DialogResult();
            //d = MessageBox.Show("Ban co muon thoat?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (d == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgiddichvu_Click(object sender, EventArgs e)
        {
            if (dgiddichvu.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi");
                return;
            }

            txtmadichvu.Text = dgiddichvu.CurrentRow.Cells["madichvu"].Value.ToString();
            txttendichvu.Text = dgiddichvu.CurrentRow.Cells["tendichvu"].Value.ToString();
            txtdongiadichvu.Text = dgiddichvu.CurrentRow.Cells["dongia"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = true;
        }
    }
}
