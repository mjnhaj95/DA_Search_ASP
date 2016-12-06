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
    public partial class BaiTestB3 : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    //string st_sql_sinhvien = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  tbl_chuyennganh.Tencn AS 'Chuyên ngành' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn ORDER BY Masv";

                    //SqlCommand sqlcm_sinhvien = new SqlCommand(st_sql_sinhvien, clscon.con);

                    SqlCommand sqlcm_sinhvien = new SqlCommand();
                    sqlcm_sinhvien.CommandText = "View_SV";
                    sqlcm_sinhvien.CommandType = CommandType.StoredProcedure;
                    sqlcm_sinhvien.Connection = clscon.con;

                    SqlDataReader re_gv = sqlcm_sinhvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                           // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                           //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                    string st_kq_gv = "";
                    byte i = 0;
                    while (re_gv.Read())
                    {
                        i++;
                        st_kq_gv = st_kq_gv + "<tr> <td>" + i.ToString() + "</td>  <td>" + re_gv.GetValue(0) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(1) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(2) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(3) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(4) + "</td>";
                        st_kq_gv = st_kq_gv + "<td><a href='frmSinhVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'>Xem chi tiết</a></td>";
                        st_kq_gv = st_kq_gv + "<td><a href='frmSinhVienEdit.aspx?id=" + re_gv.GetValue(0).ToString() + "''><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-primary'/><i class='fa fa-pencil'></i></a></td>";
                        st_kq_gv = st_kq_gv + "<td><a href='#'><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-danger'/><i class='fa fa-trash'></i></a></td></tr>";
                    }
                    re_gv.Close();
                    ltr_sv.Text = st_kq_gv;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string search = txtTimKiem.Text.Trim();
                clscon.connect_Data();
                //string st_sql_sinhvien = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  tbl_chuyennganh.Tencn AS 'Chuyên ngành' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn where Masv like N'%" + search + "%' or Tensv like N'%" + search + "%' ORDER BY Masv";

                //SqlCommand sqlcm_sinhvien = new SqlCommand(st_sql_sinhvien, clscon.con);

                SqlCommand sqlcm_sinhvien = new SqlCommand();
                sqlcm_sinhvien.CommandText = "Search_SV";         //Tên của Strored
                sqlcm_sinhvien.CommandType = CommandType.StoredProcedure;
                sqlcm_sinhvien.Connection = clscon.con;

                // Truyên tham số vào strored

                SqlParameter pa_ma = new SqlParameter();
                pa_ma.ParameterName = "@search";                    // Tên tham số của Strored
                pa_ma.Value = txtTimKiem.Text.Trim();           // Giá trị cho tham số
                sqlcm_sinhvien.Parameters.Add(pa_ma);           // Thêm tham số cho đối tượng SqlCommand

                SqlDataReader re_gv = sqlcm_sinhvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                       // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                       //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                string st_kq_gv = "";
                byte i = 0;
                while (re_gv.Read())
                {
                    i++;
                    st_kq_gv = st_kq_gv + "<tr> <td>" + i.ToString() + "</td>  <td>" + re_gv.GetValue(0) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(1) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(2) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(3) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(4) + "</td>";
                    st_kq_gv = st_kq_gv + "<td><a href='frmSinhVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'>Xem chi tiết</a></td>";
                    st_kq_gv = st_kq_gv + "<td><a href='frmSinhVienEdit.aspx?id=" + re_gv.GetValue(0).ToString() + "''><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-primary'/><i class='fa fa-pencil'></i></a></td>";
                    st_kq_gv = st_kq_gv + "<td><a href='frmSinhVienEdit.aspx?id=" + re_gv.GetValue(0).ToString() + "''><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-danger'/><i class='fa fa-trash'></i></a></td></tr>";
                }
                re_gv.Close();
                ltr_sv.Text = st_kq_gv;
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