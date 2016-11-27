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
    public partial class frmHoSoDoAn : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_sql_doan = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', tbl_doan.Tenda AS 'Tên đồ án', tbl_doan.GVHD + '-' + tbl_giangvien.Tengv AS 'GVHD', tbl_doan.GVPB + '-' + (SELECT Tengv FROM tbl_giangvien WHERE Magv = GVPB) AS 'GVPB', tbl_linhvuc.Tenlv AS 'Lĩnh vực', tbl_doan.Diem AS 'Điểm', tbl_doan.Namtn AS 'Năm tốt nghiệp'";
                    st_sql_doan = st_sql_doan + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc ORDER BY tbl_doan.Masv";

                    SqlCommand sqlcm_doan = new SqlCommand(st_sql_doan, clscon.con);

                    SqlDataReader re_da = sqlcm_doan.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                       // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                       //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                    string st_kq_gv = "";
                    byte i = 0;
                    while (re_da.Read())
                    {
                        i++;
                        st_kq_gv = st_kq_gv + "<tr><td>" + i.ToString() + "</td> <td>" + re_da.GetValue(0) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(1) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(2) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(3) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(4) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(5) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(6) + "</td>";

                        st_kq_gv = st_kq_gv + "<td>" + re_da.GetValue(7) + "</td> </tr>";
                    }
                    re_da.Close();
                    ltr_da.Text = st_kq_gv;
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

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
        }
    }
}