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
    public partial class frmGiangVienChiTiet : System.Web.UI.Page

    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_ma = Request.QueryString.Get("id").ToString();

                    string st_sql = "SELECT Magv, Tengv, Namsinh, Case WHEN tbl_giangvien.Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính',Hocvi, Email, Dienthoai, Diachi   FROM tbl_giangvien WHERE Magv = '" + st_ma + "'";

                    SqlCommand sqlcm = new SqlCommand();
                    sqlcm.CommandText = st_sql;
                    sqlcm.Connection = clscon.con;

                    SqlDataReader sqlda = sqlcm.ExecuteReader();

                    sqlda.Read();
                    txtMagv.Text = sqlda.GetValue(0).ToString();
                    txtTengv.Text = sqlda.GetValue(1).ToString();
                    txtNamSinh.Text = sqlda.GetValue(2).ToString();
                    txtgioiTinh.Text = sqlda.GetValue(3).ToString();
                    txtHocVi.Text = sqlda.GetValue(4).ToString();
                    txtEmail.Text = sqlda.GetValue(5).ToString();
                    txtDienThoai.Text = sqlda.GetValue(6).ToString();
                    txtDiaChi.Text = sqlda.GetValue(7).ToString();

                    sqlda.Close();
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
}