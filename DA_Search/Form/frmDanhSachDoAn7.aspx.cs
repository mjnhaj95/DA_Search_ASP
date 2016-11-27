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
    public partial class frmDanhSachDoAn7 : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                clscon.connect_Data();
                string st_sql_ds7 = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', Tenda AS 'Tên đồ án', tbl_giangvien.Magv + '-' + tbl_giangvien.Tengv AS 'GVHD', Diem AS 'Điểm'";
                st_sql_ds7 = st_sql_ds7 + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE tbl_doan.Diem <= 7 ORDER BY tbl_doan.Masv";
                SqlCommand sqlcm_ds7 = new SqlCommand(st_sql_ds7, clscon.con);
                SqlDataReader re_da7 = sqlcm_ds7.ExecuteReader(); //Trả về đối tượng SqlDataReader -
                                                                  // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                  //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                string st_kq_da7 = "";
                byte i = 0;
                while (re_da7.Read())
                {
                    i++;
                    st_kq_da7 = st_kq_da7 + "<tr> <td>" + i.ToString() + "</td> <td>" + re_da7.GetValue(0).ToString() + "</td> <td>" + re_da7.GetValue(1).ToString() + "</td>";
                    st_kq_da7 = st_kq_da7 + "<td>" + re_da7.GetValue(3).ToString() + "</td> <td>" + re_da7.GetValue(2).ToString() + "</td> <td>" + re_da7.GetValue(4).ToString() + "</td></tr>";
                }
                re_da7.Close();

                ltr_da7.Text = st_kq_da7;
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