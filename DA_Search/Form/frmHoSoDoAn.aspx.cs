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
                    //string st_sql_doan = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', tbl_doan.Tenda AS 'Tên đồ án', tbl_doan.GVHD + '-' + tbl_giangvien.Tengv AS 'GVHD', tbl_doan.GVPB + '-' + (SELECT Tengv FROM tbl_giangvien WHERE Magv = GVPB) AS 'GVPB', tbl_linhvuc.Tenlv AS 'Lĩnh vực', tbl_doan.Diem AS 'Điểm', tbl_doan.Namtn AS 'Năm tốt nghiệp'";
                    //st_sql_doan = st_sql_doan + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc ORDER BY tbl_doan.Masv";
                    //SqlCommand sqlcm_doan = new SqlCommand(st_sql_doan, clscon.con);

                    SqlCommand sqlcm_doan = new SqlCommand();
                    sqlcm_doan.CommandText = "HoSoDoAn_View";
                    sqlcm_doan.CommandType = CommandType.StoredProcedure;
                    sqlcm_doan.Connection = clscon.con;

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
            try
            {
                clscon.connect_Data();
                SqlCommand sqlcm_doan = new SqlCommand();
                sqlcm_doan.CommandText = "HoSoDoAn_Search";
                sqlcm_doan.CommandType = CommandType.StoredProcedure;
                sqlcm_doan.Connection = clscon.con;

                // Truyên tham số vào strored

                SqlParameter pa_ma = new SqlParameter();
                pa_ma.ParameterName = "@search";                    // Tên tham số của Strored
                pa_ma.Value = txtTimKiem.Text.Trim();           // Giá trị cho tham số
                sqlcm_doan.Parameters.Add(pa_ma);           // Thêm tham số cho đối tượng SqlCommand

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

        protected void ddlDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            float diem1, diem2;
            float diem = int.Parse(ddlDiem.SelectedValue.ToString());
            if (diem == 7)
            {
                diem1 = 0;
                diem2 = 7;
            }
            else
            {
                diem1 = diem - 0.9f;
                diem2 = diem;
            }

            clscon.connect_Data();
            string st_sql_doan = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', tbl_doan.Tenda AS 'Tên đồ án', tbl_doan.GVHD + '-' + tbl_giangvien.Tengv AS 'GVHD', tbl_doan.GVPB + '-' + (SELECT Tengv FROM tbl_giangvien WHERE Magv = GVPB) AS 'GVPB', tbl_linhvuc.Tenlv AS 'Lĩnh vực', tbl_doan.Diem AS 'Điểm', tbl_doan.Namtn AS 'Năm tốt nghiệp'";
            st_sql_doan = st_sql_doan + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc";
            st_sql_doan = st_sql_doan + " WHERE tbl_doan.Diem BETWEEN " + diem1 + " AND " + diem2;
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

        protected void ddlGiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string magv = ddlGiaoVien.SelectedValue;
            clscon.connect_Data();
            string st_sql_doan = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', tbl_doan.Tenda AS 'Tên đồ án', tbl_doan.GVHD + '-' + tbl_giangvien.Tengv AS 'GVHD', tbl_doan.GVPB + '-' + (SELECT Tengv FROM tbl_giangvien WHERE Magv = GVPB) AS 'GVPB', tbl_linhvuc.Tenlv AS 'Lĩnh vực', tbl_doan.Diem AS 'Điểm', tbl_doan.Namtn AS 'Năm tốt nghiệp'";
            st_sql_doan = st_sql_doan + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc";
            st_sql_doan = st_sql_doan + " WHERE tbl_doan.GVHD  = '" + magv + "' OR tbl_doan.GVHD  = '" + magv + "'";

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
    }
}