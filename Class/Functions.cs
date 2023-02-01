using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan.Class
{
    class Functions
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void Ketnoi()
        {
            connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Duc Anh\Desktop\QuanLyKhachSan1\QuanLyKhachSan\Nhom_8.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection();
            conn = new SqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
        }

        public static void Ngatketnoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        // đổ dữ liệu vào bảng, dùng cho nhiều bảng
        public static DataTable getdatatotable(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = conn;
            a.SelectCommand.CommandText = sql;
            DataTable bang = new DataTable();
            a.Fill(bang);
            return bang;
        }

        // check trùng lặp dữ liệu thêm mới, dùng chung
        public static bool checkkey(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            a.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        // update dữ liệu
        public static void runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        // fill combo box
        public static void fillcombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter a = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            a.Fill(table);

            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

        // dgrid_click_ combobox
        public static string getfilevalue(string sql)
        {
            string ma = "";
            SqlCommand a = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = a.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        // check date hợp lệ
        public static bool isDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1)
                && (Convert.ToInt32(parts[0]) <= 31)
                && (Convert.ToInt32(parts[1]) >= 1)
                && (Convert.ToInt32(parts[1]) <= 12)
                && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }

        // chuyen du lieu ngay sinh _ datetime
        public static string vcovertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;

        }
        public static string chuyengio(string gio)
        {
            string h = "";
            switch (gio)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public static string chuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mươi ", "linh ");
            //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
        public static string sinhma(string t)
        {
            string key = t;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = chuyengio(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            partsTime[2] = partsTime[2].Remove(2, 3);
            string a;
            a = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + a;
            return key;
        }
    }
}
