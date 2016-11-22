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
    public partial class frmChuyenNganhChiTiet : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_ma = Request.QueryString.Get("Macn").ToString();

                    string st_sql = "SELECT   Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',  Namsinh AS 'Ngày sinh',Case WHEN Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS 'Giới tính',Khoa AS 'Khóa',  Tencn AS 'Chuyên ngành', Email AS 'Email', Dienthoai AS 'Điện thoại', Diachi AS 'Địa chỉ' ";
                    st_sql = st_sql + " FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_chuyennganh.Macn = tbl_sinhvien.Chuyennganh Where Macn = '" + st_ma + "'";

                    SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
                    SqlDataReader sqlda = sqlcm.ExecuteReader();

                    string st_kq_cn = "";
                    byte i = 0;
                    while (sqlda.Read())
                    {
                        i++;
                        st_kq_cn = st_kq_cn + "<tr> <td>" + i.ToString() + "</td> <td>" + sqlda.GetValue(0).ToString() + "</td> <td>" + sqlda.GetValue(1).ToString() + "</td>  <td>" + sqlda.GetValue(2).ToString() + "</td>  <td>" + sqlda.GetValue(3).ToString() + "</td> ";
                        st_kq_cn = st_kq_cn + "<td>" + sqlda.GetValue(4).ToString() + "</td> <td>" + sqlda.GetValue(5).ToString() + "</td> <td>" + sqlda.GetValue(6).ToString() + "</td> <td>" + sqlda.GetValue(7).ToString() + "</td> <td>" + sqlda.GetValue(8).ToString() + "</td></tr>";
                    }
                    sqlda.Close();
                    ltr_sv_cn.Text = st_kq_cn;

                    // Hiện thị mã HTML sử dụng control Literal
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