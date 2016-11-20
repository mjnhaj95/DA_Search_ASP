using DA_Search.AllClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_Search.Form
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            clsconnect clscon = new clsconnect(); // Khai báo sử dung lớp
            clscon.connect_Data();

            SqlCommand sqlcm = new SqlCommand();
            string st_sql;
            try
            {
                st_sql = "select COUNT(masv) from tbl_sinhvien";// Câu lệnh truy vấn đếm số lượng hồ sơ

                sqlcm.CommandText = st_sql;
                sqlcm.Connection = clscon.con;

                int so_sv;
                so_sv = (int)sqlcm.ExecuteScalar();
                lbl_kq.Text = "Tổng số sinh viên trong CSDL là: " + so_sv.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                clscon.close_Data();
            }
        }
    }
}