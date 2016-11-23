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
    public partial class frmSinhVienChiTiet : System.Web.UI.Page
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

                    string st_sql = "SELECT	Masv AS 'Mã sinh viên', Tensv AS 'Tên sinh viên',Namsinh AS 'Ngày sinh',Case WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính', Khoa AS 'Khóa',  tbl_chuyennganh.Tencn AS 'Chuyên ngành', Email AS 'Email', Dienthoai AS 'Điện thoại',Diachi AS 'Địa chỉ' FROM tbl_sinhvien INNER JOIN tbl_chuyennganh ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn WHERE Masv='" + st_ma + "' ORDER BY Masv ";

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
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = true;
                    }
                    txtKhoa.Text = sqlda.GetValue(4).ToString();
                    txtChuyenNganh.Text = sqlda.GetValue(5).ToString();
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
    }
}