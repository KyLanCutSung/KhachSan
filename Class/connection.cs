using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyKhachSan
{
    class connection
    {
        private static string stringconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Duc Anh\Desktop\QuanLyKhachSan1\QuanLyKhachSan\Nhom_8.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
