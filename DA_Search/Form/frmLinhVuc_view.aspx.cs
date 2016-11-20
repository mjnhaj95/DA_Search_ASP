using DA_Search.AllClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_Search.Form
{
    public partial class frmLinhVuc_view : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public void Data_all() // thủ tục hiện thị dữ liệu
        {
            string sql = "";
            SqlCommand sqlcm = new SqlCommand();
            try
            {
                clscon.connect_Data();  // Khai báo sử dụng thủ tục mở CSDL
                sqlcm.Connection = clscon.con;
                sql = "SELECT Malv AS 'Mã lĩnh vực', Tenlv AS 'Tên lĩnh vực', Ghichu AS 'Ghi chú' FROM tbl_linhvuc";
                sqlcm.CommandText = sql;
                sqlcm.CommandType = CommandType.Text;
                da.SelectCommand = sqlcm;
                da.Fill(dt);
                grvDanhMucLinhVuc.DataSource = dt; // Đổ dữ liệu vào grv
                grvDanhMucLinhVuc.DataBind();
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Data_all();
            }
        }
    }
}