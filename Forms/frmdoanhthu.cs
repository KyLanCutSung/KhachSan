using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan.Forms
{
    public partial class frmdoanhthu : Form
    {
        public frmdoanhthu()
        {
            InitializeComponent();
        }
        DataTable tbldoanhthu;
        private void resetvalue()
        {
            cboNam.SelectedIndex = -1;
            cboThang.SelectedIndex = -1;
            cboThang.Enabled = true;
            cboNam.Enabled = true;
            txtTong.Text = "0";
            btnIn.Enabled = false;
        }
        private void load()
        {
            string sql;
            sql = "select a.makhachhang, a.masothue, a.ngayden, b.ngaytraphong, b.tienthuephong, c.tongtien, (b.tienthuephong + c.tongtien) from tblthuephong a, tbltraphong b, tblhoadonthuedv c where a.masothue = b.masothue and a.makhachhang = c.makhachhang";
            tbldoanhthu = Class.Functions.getdatatotable(sql);
            dgridDoanhthu.DataSource = tbldoanhthu;
            dgridDoanhthu.Columns[0].HeaderText = "Mã khách hàng";
            dgridDoanhthu.Columns[1].HeaderText = "Mã số thuê ";
            dgridDoanhthu.Columns[2].HeaderText = "Ngày đến";
            dgridDoanhthu.Columns[3].HeaderText = "Ngày trả";
            dgridDoanhthu.Columns[4].HeaderText = "Tiền thuê phòng";
            dgridDoanhthu.Columns[5].HeaderText = "Tiền dịch vụ";
            dgridDoanhthu.Columns[6].HeaderText = "Tổng tiền";
        }
        private void frmdoanhthu_Load(object sender, EventArgs e)
        {
            txtTong.Enabled = false;
            btnIn.Enabled = false;
            //load();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            string sql, sql1;
            if ((cboThang.Text == "") && (cboNam.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            sql1 = "select sum(a.tienthuephong + tongtien) from tbltraphong a, tblhoadonthuedv b,tblthuephong c,tblphong d  where a.masothue = c.masothue and c.makhachhang = b.makhachhang and d.maphong = c.maphong";
            if (cboThang.Text != "")
                sql1 = sql1 + " and MONTH(a.ngaytraphong) =" + cboThang.Text;
            if (cboNam.Text != "")
                sql1 = sql1 + " and YEAR(a.ngaytraphong) =" + cboNam.Text;
            txtTong.Text = Class.Functions.getfilevalue(sql1);
            sql = "select a.makhachhang, a.masothue, a.ngayden, b.ngaytraphong, b.tienthuephong, c.tongtien, b.tienthuephong+c.tongtien from tblthuephong a, tbltraphong b, tblhoadonthuedv c,tblphong d where a.masothue = b.masothue and a.makhachhang = c.makhachhang and d.maphong = a.maphong";
            if (cboThang.Text != "")
                sql = sql + " and MONTH(b.ngaytraphong) =" + cboThang.Text;
            if (cboNam.Text != "")
                sql = sql + " and YEAR(b.ngaytraphong) =" + cboNam.Text;
            tbldoanhthu = Class.Functions.getdatatotable(sql);
            dgridDoanhthu.DataSource = tbldoanhthu;
            dgridDoanhthu.Columns[0].HeaderText = "Mã khách hàng";
            dgridDoanhthu.Columns[1].HeaderText = "Mã số thuê ";
            dgridDoanhthu.Columns[2].HeaderText = "Ngày đến";
            dgridDoanhthu.Columns[3].HeaderText = "Ngày trả";
            dgridDoanhthu.Columns[4].HeaderText = "Tiền thuê phòng";
            dgridDoanhthu.Columns[5].HeaderText = "Tiền dịch vụ";
            dgridDoanhthu.Columns[6].HeaderText = "Tổng tiền";
            tbldoanhthu = Class.Functions.getdatatotable(sql);
            if (tbldoanhthu.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                resetvalue();
            }
            else
            {
                MessageBox.Show("Có " + tbldoanhthu.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgridDoanhthu.DataSource = tbldoanhthu;
                load();
            }
            btnThongke.Enabled = false;
            btnIn.Enabled = true;
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            btnThongke.Enabled = true;
            resetvalue();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql, sql1;
            int hang = 0, cot = 0;
            DataTable DS;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["C2:E2"].Font.Size = 12;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO DOANH THU";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "select a.makhachhang, a.masothue, a.ngayden, b.ngaytraphong, b.tienthuephong, c.tongtien, b.tienthuephong+c.tongtien from tblthuephong a, tbltraphong b, tblhoadonthuedv c where a.masothue = b.masothue and a.makhachhang = c.makhachhang";
            sql1 = "select sum(a.tienthuephong + b.tongtien) from tbltraphong a, tblhoadonthuedv b,tblthuephong c where a.masothue = c.masothue and c.makhachhang = b.makhachhang";

            DS = Class.Functions.getdatatotable(sql);

            string TT = Class.Functions.getfilevalue(sql1);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:J5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 20;
            exRange.Range["D5:D5"].ColumnWidth = 12;
            exRange.Range["E5:E5"].ColumnWidth = 22;
            exRange.Range["F5:F5"].ColumnWidth = 11;
            exRange.Range["G5:G5"].ColumnWidth = 11;


            exRange.Range["C4:C4"].Font.Bold = true;
            exRange.Range["C4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;


            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã khách hàng";
            exRange.Range["D5:D5"].Value = "Mã số thuê";
            exRange.Range["E5:E5"].Value = "Ngày đến";
            exRange.Range["F5:F5"].Value = "Ngày trả";
            exRange.Range["G5:G5"].Value = "Tiền thuê phòng";
            exRange.Range["H5:H5"].Value = "Tiền dịch vụ";
            exRange.Range["I5:I5"].Value = "Tổng tiền";
            exRange.Range["C4:C4"].Value = "Tổng tiền";
            exRange.Range["D4:D4"].Value = TT;



            for (hang = 0; hang < DS.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < DS.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = DS.Rows[hang][cot].ToString();
                }
            }
            //exRange = exSheet.Cells[2][hang + 8];

            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();

            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
