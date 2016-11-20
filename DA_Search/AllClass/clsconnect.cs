using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DA_Search.AllClass
{
    public class clsconnect
    {
        // Lấy chuỗi kết nối trong webconfig
        public string s_con = WebConfigurationManager.ConnectionStrings["connec_DATN"].ToString();

        // Khai báo biến Sqlconnnection
        public SqlConnection con;

        public void connect_Data() // Thủ tục mở kết nối
        {
            if (con == null)
            {
                con = new SqlConnection(s_con);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void close_Data() //Đóng kết nối
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}