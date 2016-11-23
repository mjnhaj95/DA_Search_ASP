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
    public partial class frmLinhVucChiTiet : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_ma = Request.QueryString.Get("Malv").ToString();
                    string st_sql = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', tbl_doan.Tenda AS 'Tên đồ án', tbl_doan.GVHD + '-' + tbl_giangvien.Tengv AS 'GVHD', tbl_doan.GVPB + '-' + (SELECT Tengv FROM tbl_giangvien WHERE Magv = GVPB) AS 'GVPB', tbl_linhvuc.Tenlv AS 'Lĩnh vực', tbl_doan.Diem AS 'Điểm', tbl_doan.Namtn AS 'Năm tốt nghiệp'";
                    st_sql = st_sql + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE Malv = '" + st_ma + "' ORDER BY tbl_doan.Masv";

                    SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
                    SqlDataReader sqlda = sqlcm.ExecuteReader();

                    string st_kq_lv = "";
                    byte i = 0;
                    while (sqlda.Read())
                    {
                        i++;
                        st_kq_lv = st_kq_lv + "<tr> <td>" + i.ToString() + "</td> <td>" + sqlda.GetValue(0).ToString() + "</td> <td>" + sqlda.GetValue(1).ToString() + "</td>  <td>" + sqlda.GetValue(2).ToString() + "</td>  <td>" + sqlda.GetValue(3).ToString() + "</td> ";
                        st_kq_lv = st_kq_lv + "<td>" + sqlda.GetValue(4).ToString() + "</td> <td>" + sqlda.GetValue(5).ToString() + "</td> <td>" + sqlda.GetValue(6).ToString() + "</td> <td>" + sqlda.GetValue(7).ToString() + "</td> </tr>";
                    }
                    sqlda.Close();
                    ltr_sv_lv.Text = st_kq_lv;

                    //Hiện thị mã HTML sử dụng control Literal
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