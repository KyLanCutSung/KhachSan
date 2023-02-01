using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyKhachSan
{
    class modify
    {
        public modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy cap cac cau lenh insert update, delete,...
        SqlDataReader dataReader;//dung de doc du lieu trong bang
        public List<taikhoan> taikhoans(string query)
        {
            List<taikhoan> taikhoans = new List<taikhoan>();
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();

            }
            return taikhoans;
        }
        public void Command(string query)//dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thi truy van
                sqlConnection.Close();
            }
        }
    }
}
