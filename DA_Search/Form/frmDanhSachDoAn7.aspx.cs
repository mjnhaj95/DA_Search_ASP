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
            if (!IsPostBack)
                try
                {
                    Int32 id = Int32.Parse(Request.QueryString.Get("id"));
                    clscon.connect_Data();
                    string st_sql_ds = "";
                    string st_sqlcount = "";
                    switch (id)
                    {
                        case 1:
                            {
                                st_sql_ds = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', Tenda AS 'Tên đồ án', tbl_giangvien.Magv + '-' + tbl_giangvien.Tengv AS 'GVHD', Diem AS 'Điểm'";
                                st_sql_ds = st_sql_ds + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE tbl_doan.Diem <= 7 ORDER BY tbl_doan.Masv";

                                st_sqlcount = "SELECT  COUNT(tbl_doan.Masv) ";
                                st_sqlcount = st_sqlcount + " FROM tbl_doan WHERE tbl_doan.Diem <= 7";
                                break;
                            }
                        case 2:
                            {
                                st_sql_ds = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', Tenda AS 'Tên đồ án', tbl_giangvien.Magv + '-' + tbl_giangvien.Tengv AS 'GVHD', Diem AS 'Điểm'";
                                st_sql_ds = st_sql_ds + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE tbl_doan.Diem BETWEEN 7.1 AND 8.0 ORDER BY tbl_doan.Masv";
                                st_sqlcount = "SELECT  COUNT(tbl_doan.Masv) ";
                                st_sqlcount = st_sqlcount + " FROM tbl_doan WHERE tbl_doan.Diem BETWEEN 7.1 AND 8.0";
                                break;
                            }
                        case 3:
                            {
                                st_sql_ds = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', Tenda AS 'Tên đồ án', tbl_giangvien.Magv + '-' + tbl_giangvien.Tengv AS 'GVHD', Diem AS 'Điểm'";
                                st_sql_ds = st_sql_ds + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE tbl_doan.Diem BETWEEN 8.1 AND 9.0 ORDER BY tbl_doan.Masv";
                                st_sqlcount = "SELECT  COUNT(tbl_doan.Masv) ";
                                st_sqlcount = st_sqlcount + " FROM tbl_doan WHERE tbl_doan.Diem BETWEEN 8.1 AND 9.0";
                                break;
                            }
                        case 4:
                            {
                                st_sql_ds = "SELECT  tbl_doan.Masv AS 'Mã sinh viên', tbl_sinhvien.Tensv AS 'Tên sinh viên', Tenda AS 'Tên đồ án', tbl_giangvien.Magv + '-' + tbl_giangvien.Tengv AS 'GVHD', Diem AS 'Điểm'";
                                st_sql_ds = st_sql_ds + " FROM tbl_doan INNER JOIN tbl_sinhvien ON tbl_doan.Masv = tbl_sinhvien.Masv INNER JOIN tbl_giangvien ON tbl_doan.GVHD = tbl_giangvien.Magv INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc WHERE tbl_doan.Diem BETWEEN 9.1 AND 10 ORDER BY tbl_doan.Masv";
                                st_sqlcount = "SELECT  COUNT(tbl_doan.Masv) ";
                                st_sqlcount = st_sqlcount + " FROM tbl_doan WHERE tbl_doan.Diem BETWEEN 9.1 AND 10";
                                break;
                            }
                    }
                    SqlCommand sqlcm_ds = new SqlCommand(st_sql_ds, clscon.con);
                    SqlDataReader re_da = sqlcm_ds.ExecuteReader();
                    string st_kq_da = "";
                    byte i = 0;
                    while (re_da.Read())
                    {
                        i++;
                        st_kq_da = st_kq_da + "<tr> <td>" + i.ToString() + "</td> <td>" + re_da.GetValue(0).ToString() + "</td> <td>" + re_da.GetValue(1).ToString() + "</td>";
                        st_kq_da = st_kq_da + "<td>" + re_da.GetValue(3).ToString() + "</td> <td>" + re_da.GetValue(2).ToString() + "</td> <td>" + re_da.GetValue(4).ToString() + "</td></tr>";
                    }
                    re_da.Close();

                    ltr_da.Text = st_kq_da;

                    SqlCommand sqlcommand = new SqlCommand(st_sqlcount, clscon.con);
                    Int32 total = (Int32)(sqlcommand.ExecuteScalar());
                    lblBanghi.Text = total + "";
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