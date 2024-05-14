using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectKPMOOP
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JRB2BL74\\SQLEXPRESS;Initial Catalog=CinemaTKPMOOP;Integrated Security=True;Pooling=False");
        SqlCommand comm = null; //Đối tượng truy vấn và cập nhật vào SQL Serverwd
        SqlDataAdapter da = null; //Đối tượng đưa dữ liệu vào DataTable
        public SqlConnection getSqlConn //Lấy chuỗi kết nối
        {
            get
            {
                return conn;
            }
        }

        public DBConnection() // Hàm khởi tạo: khởi tạo chuỗi kết nối và đối tượng truy vấn
        {
            comm = conn.CreateCommand();
        }

        public void openConnection() //Mở kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        public void closeConnection() //Đóng kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Close();
            }
        }

    }
}
