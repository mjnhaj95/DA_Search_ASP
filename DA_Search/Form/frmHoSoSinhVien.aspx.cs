﻿using DA_Search.AllClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_Search.Form
{
    public partial class frmHoSoSinhVien : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_sql_sinhvien = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Namsinh AS 'Ngày sinh',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  tbl_chuyennganh.Tencn AS 'Chuyên ngành', Email AS 'Email', Dienthoai AS 'Điện thoại',Diachi AS 'Địa chỉ' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn ORDER BY Masv";

                    SqlCommand sqlcm_sinhvien = new SqlCommand(st_sql_sinhvien, clscon.con);

                    SqlDataReader re_gv = sqlcm_sinhvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                           // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                           //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                    string st_kq_gv = "";
                    //byte i = 0;
                    while (re_gv.Read())
                    {
                        st_kq_gv = st_kq_gv + "<tr> <td>" + re_gv.GetValue(0) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(1) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(2) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(3) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(4) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(5) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(6) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(7) + "</td>";
                        st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(8) + "</td> </tr>";
                    }
                    re_gv.Close();
                    ltr_sv_sv.Text = st_kq_gv;
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
                string search = txtInput.Text.Trim();
                string khoa = ddlKhoa.Text.Trim();
                string chuyennganh = ddlChuyenNganh.Text.Trim();
                clscon.connect_Data();
                string st_sql_sinhvien = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Namsinh AS 'Ngày sinh',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  tbl_chuyennganh.Tencn AS 'Chuyên ngành', Email AS 'Email', Dienthoai AS 'Điện thoại',Diachi AS 'Địa chỉ' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn  Where (Masv LIKE N'%" + search + "%' OR Tensv LIKE N'%" + search + "%') AND tbl_sinhvien.Khoa = " + khoa + " AND tbl_chuyennganh.Tencn = N'" + chuyennganh + "' ORDER BY Masv";

                SqlCommand sqlcm_sinhvien = new SqlCommand(st_sql_sinhvien, clscon.con);

                SqlDataReader re_gv = sqlcm_sinhvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
                                                                       // thường dùng cho việc đọc kết quả trả về của câu lệnh
                                                                       //SQL là 1 tập hợp gồm nhiều hàng, nhiều cột
                string st_kq_gv = "";
                //byte i = 0;
                while (re_gv.Read())
                {
                    st_kq_gv = st_kq_gv + "<tr> <td>" + re_gv.GetValue(0) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(1) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(2) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(3) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(4) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(5) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(6) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(7) + "</td>";
                    st_kq_gv = st_kq_gv + "<td>" + re_gv.GetValue(8) + "</td> </tr>";
                }
                re_gv.Close();
                ltr_sv_sv.Text = st_kq_gv;
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