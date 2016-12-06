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
    public partial class SinhVienEdit : System.Web.UI.Page
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

                    string st_sql = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Namsinh AS 'Ngày sinh',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  CONVERT (varchar(5), Macn) + '-' + Tencn AS 'Tên chuyên ngành', Email AS 'Email', Dienthoai AS 'Điện thoại',Diachi AS 'Địa chỉ' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn WHERE Masv='" + st_ma + "' ORDER BY Masv ";

                    SqlCommand sqlcm = new SqlCommand();
                    sqlcm.CommandText = st_sql;
                    sqlcm.Connection = clscon.con;

                    SqlDataReader sqlda = sqlcm.ExecuteReader();

                    sqlda.Read();
                    txtMasv.Text = sqlda.GetValue(0).ToString();
                    txtTensv.Text = sqlda.GetValue(1).ToString();
                    txtNgaySinh.Text = sqlda.GetValue(2).ToString();
                    //txtgioiTinh.Text = sqlda.GetValue(3).ToString();
                    if (sqlda.GetValue(3).ToString() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    ddlKhoa.Text = sqlda.GetValue(4).ToString();
                    ddlChuyenNganh.Text = sqlda.GetValue(5).ToString();
                    txtEmail.Text = sqlda.GetValue(6).ToString();
                    txtDienThoai.Text = sqlda.GetValue(7).ToString();
                    txtDiaChi.Text = sqlda.GetValue(8).ToString();

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

        protected void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                clscon.connect_Data();

                SqlCommand sqlcm_sv = new SqlCommand();
                sqlcm_sv.CommandText = "Update_SV";
                sqlcm_sv.CommandType = CommandType.StoredProcedure;

                // truyền tham số vào store

                sqlcm_sv.Parameters.Add("@Masv", SqlDbType.Char).Value = txtMasv.Text.Trim();
                sqlcm_sv.Parameters.Add("@Tensv", SqlDbType.NVarChar).Value = txtTensv.Text.Trim();
                sqlcm_sv.Parameters.Add("@NamSinh", SqlDbType.Date).Value = txtNgaySinh.Text.Trim();
                if (rdNam.Checked == true)
                {
                    sqlcm_sv.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = "1";
                }
                else
                {
                    sqlcm_sv.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = "0";
                }
                sqlcm_sv.Parameters.Add("@Khoa", SqlDbType.TinyInt).Value = ddlKhoa.Text.Trim();
                sqlcm_sv.Parameters.Add("@ChuyenNganh", SqlDbType.Int).Value = ddlChuyenNganh.Text.Substring(0, 1);
                sqlcm_sv.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                sqlcm_sv.Parameters.Add("@DienThoai", SqlDbType.VarChar).Value = txtDienThoai.Text.Trim();
                sqlcm_sv.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                sqlcm_sv.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text.Trim();

                sqlcm_sv.Connection = clscon.con;

                int check = sqlcm_sv.ExecuteNonQuery();

                if (check != 0)
                {
                    lbl_tb.Visible = true;
                    Response.Redirect("BaiTestB3.aspx");
                }
                else
                {
                    lbl_tb.Text = "Lỗi: Sửa dữ liệu không thành công!";
                    lbl_tb.Visible = true;
                }
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