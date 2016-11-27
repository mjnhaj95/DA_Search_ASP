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
    public partial class frmGiangVienDelete : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            clscon.connect_Data();
            string st_ma = Request.QueryString.Get("id").ToString();
            string st_sql = "DELETE FROM tbl_giangvien WHERE Magv = '" + st_ma + "'";
            SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
            int check = sqlcm.ExecuteNonQuery();
            if (check != 0)
            {
                lbl_tb.Text = "Xóa dữ liệu thành công!";
            }
            else
            {
                lbl_tb.Text = "Lỗi: Xóa  dữ liệu không thành công!";
            }
        }
    }
}