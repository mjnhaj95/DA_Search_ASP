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
    public partial class home : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect(); // Khai báo sử dung lớp

        // Đổ số lượng sinh viên
        public void Data_sosv()
        {
            try
            {
                clscon.connect_Data();
                string st_sql = "select COUNT(masv) from tbl_sinhvien";// Câu lệnh truy vấn đếm số lượng hồ sơ
                SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
                int so_sv = (int)sqlcm.ExecuteScalar();

                lbl_sumsv.Text = so_sv.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                // clscon.close_Data();
            }
        }

        // Đổ ra số lượng giáo viên
        public void Data_sogv()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountgv = "select COUNT(magv) from tbl_giangvien";
                SqlCommand sqlcm_countgv = new SqlCommand(st_sqlCountgv, clscon.con);
                int so_gv = (int)sqlcm_countgv.ExecuteScalar();
                lbl_sumgv.Text = so_gv.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kê số đồ án
        public void Data_soda()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountda = "SELECT COUNT(masv) FROM tbl_doan";
                SqlCommand sqlcm_countda = new SqlCommand(st_sqlCountda, clscon.con);
                int so_da = (int)sqlcm_countda.ExecuteScalar();
                lbl_sumda.Text = so_da.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kê số chuyên ngành
        public void Data_socn()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountcn = "SELECT COUNT(macn) FROM tbl_chuyennganh";
                SqlCommand sqlcm_countcn = new SqlCommand(st_sqlCountcn, clscon.con);
                int so_cn = (int)sqlcm_countcn.ExecuteScalar();
                lbl_sumcn.Text = so_cn.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kê đồ án có điểm nhỏ hơn 7
        public void Data_Doan7()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountDoAn7 = "SELECT COUNT(masv) FROM tbl_doan WHERE Diem <= 7";
                SqlCommand sqlcm_CountDoAn7 = new SqlCommand(st_sqlCountDoAn7, clscon.con);
                int so_da7 = (int)sqlcm_CountDoAn7.ExecuteScalar();
                lblDoAn7.Text = so_da7.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kê đồ án có điểm từ 7.1 đến 8
        public void Data_Doan8()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountDoAn8 = "SELECT COUNT(masv) FROM tbl_doan WHERE Diem BETWEEN 7.1 AND 8";
                SqlCommand sqlcm_CountDoAn8 = new SqlCommand(st_sqlCountDoAn8, clscon.con);
                int so_da8 = (int)sqlcm_CountDoAn8.ExecuteScalar();
                lblDoAn8.Text = so_da8.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kê đồ án có điểm từ 8.1 đến 9
        public void Data_Doan9()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountDoAn9 = "SELECT COUNT(masv) FROM tbl_doan WHERE Diem BETWEEN 8.1 AND 9";
                SqlCommand sqlcm_CountDoAn9 = new SqlCommand(st_sqlCountDoAn9, clscon.con);
                int so_da9 = (int)sqlcm_CountDoAn9.ExecuteScalar();
                lblDoAn9.Text = so_da9.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        // Thống kế đồ án có điểm từ 9.1 đến 10
        public void Data_Doan10()
        {
            try
            {
                clscon.connect_Data();
                string st_sqlCountDoAn10 = "SELECT COUNT(masv) FROM tbl_doan WHERE Diem BETWEEN 9.1 AND 10";
                SqlCommand sqlcm_CountDoAn10 = new SqlCommand(st_sqlCountDoAn10, clscon.con);
                int so_da10 = (int)sqlcm_CountDoAn10.ExecuteScalar();
                lblDoAn10.Text = so_da10.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        //  Thống kế sinh viên theo chuyên ngành
        public void Data_sv_cn()
        {
            try
            {
                clscon.connect_Data();
                string st_sql_sv_cn = "SELECT tencn as 'cn',COUNT(masv) as 'sv', Macn FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON chuyennganh = macn GROUP BY tencn, macn"; // câu lệnh truy vấn thống kê sinh viên
                SqlCommand sqlcm_sv_cn = new SqlCommand(st_sql_sv_cn, clscon.con);
                SqlDataReader re_cn = sqlcm_sv_cn.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                    // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                    //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                string st_kq_cn = "";
                byte i = 0;
                while (re_cn.Read())
                {
                    i++;
                    st_kq_cn = st_kq_cn + "<tr> <td>" + i.ToString() + "</td> <td>" + re_cn.GetValue(0).ToString() + "</td> <td>" + re_cn.GetValue(1).ToString() + "</td>";
                    st_kq_cn = st_kq_cn + "<td><a href='frmChuyenNganhChiTiet.aspx?macn=" + re_cn.GetValue(2).ToString() + "'><i class='fa fa-search'></i>Danh sách</a></td></tr>";
                }
                re_cn.Close();
                ltr_sv_cn.Text = st_kq_cn;

                // Hiện thị mã HTML sử dụng control Literal
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        //  Thống kế sinh viên theo lĩnh vực
        public void Data_v_lv()
        {
            try
            {
                clscon.connect_Data();
                string st_sql_sv_lv = "SELECT tbl_linhvuc.Tenlv AS 'Lĩnh vực', COUNT(tbl_doan.Masv)AS 'Số sinh viên', LinhVuc FROM tbl_doan INNER JOIN tbl_linhvuc ON tbl_linhvuc.Malv = tbl_doan.Linhvuc GROUP BY tbl_linhvuc.Tenlv, tbl_doan.Linhvuc";
                SqlCommand sqlcm_sv_lv = new SqlCommand(st_sql_sv_lv, clscon.con);
                SqlDataReader re_lv = sqlcm_sv_lv.ExecuteReader();
                string st_kq_lv = "";
                byte j = 0;
                while (re_lv.Read())
                {
                    j++;
                    st_kq_lv = st_kq_lv + "<tr> <td>" + j.ToString() + "</td> <td> " + re_lv.GetValue(0).ToString() + " </td> <td>" + re_lv.GetValue(1).ToString() + "</td>";
                    st_kq_lv = st_kq_lv + "<td><a href='frmLinhVucChiTiet.aspx?malv=" + re_lv.GetValue(2).ToString() + "'><i class='fa fa-search'></i>Danh sách</a></td></tr>";
                }
                re_lv.Close();
                ltr_sv_lv.Text = st_kq_lv;
                // Hiện thị mã HTML sử dụng control Literal
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        public void Close()
        {
            clscon.close_Data();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Data_sosv();
                Data_sogv();
                Data_soda();
                Data_socn();
                Data_Doan7();
                Data_Doan8();
                Data_Doan9();
                Data_Doan10();
                Data_sv_cn();
                Data_v_lv();
            }
        }
    }
}