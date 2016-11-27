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
    public partial class frmGiangVienEdit : System.Web.UI.Page
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

                    string st_sql = "SELECT Magv, Tengv, Namsinh, Case WHEN tbl_giangvien.Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS 'Giới tính',Hocvi, Email, Dienthoai, Diachi   FROM tbl_giangvien WHERE Magv = '" + st_ma + "'";

                    SqlCommand sqlcm = new SqlCommand();
                    sqlcm.CommandText = st_sql;
                    sqlcm.Connection = clscon.con;

                    SqlDataReader sqlda = sqlcm.ExecuteReader();

                    sqlda.Read();
                    txtMagv.Text = sqlda.GetValue(0).ToString();
                    txtTengv.Text = sqlda.GetValue(1).ToString();
                    txtNamSinh.Text = sqlda.GetValue(2).ToString();
                    //txtgioiTinh.Text = sqlda.GetValue(3).ToString();
                    if (sqlda.GetValue(3).ToString() == "Nam")
                    {
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = true;
                    }
                    txtHocVi.Text = sqlda.GetValue(4).ToString();
                    txtEmail.Text = sqlda.GetValue(5).ToString();
                    txtDienThoai.Text = sqlda.GetValue(6).ToString();
                    txtDiaChi.Text = sqlda.GetValue(7).ToString();

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

        protected void btnHuy_Click(object sender, EventArgs e)
        {
        }

        protected void btlLuu_Click(object sender, EventArgs e)
        {
            clscon.connect_Data();
            string Magv = txtMagv.Text;
            string st_magv = txtMagv.Text.Trim();
            string st_tengv = txtTengv.Text.Trim();
            string st_ngaySinh = txtNamSinh.Text.Trim();
            string st_gt;
            if (rdoNam.Checked == true)
            {
                st_gt = "1";
            }
            else
            {
                st_gt = "0";
            }
            string st_hocvi = txtHocVi.Text;
            string st_email = txtEmail.Text;
            string st_dienthoai = txtDienThoai.Text;
            string st_diachi = txtDiaChi.Text;

            string st_sql = "UPDATE tbl_giangvien SET Magv ='" + st_magv + "', Tengv = N'" + st_tengv + "',Namsinh= '" + st_ngaySinh + "', Gioitinh ='" + st_gt + "', Hocvi = N'" + st_hocvi + "', Email ='" + st_email + "',Dienthoai= '" + st_dienthoai + "',Diachi= N'" + st_diachi + "' WHERE Magv = '" + Magv + "'";
            SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
            int check = sqlcm.ExecuteNonQuery();
            if (check != 0)
            {
                //lbl_tb.Text = "Sửa dữ liệu thành công!";
                //lbl_tb.Visible = true;
                Response.Write("<script>alert('Sửa dữ liệu thành công')</script>");
                Response.Redirect("frmGiangVienView.aspx");
            }
            else
            {
                lbl_tb.Text = "Lỗi: Sửa dữ liệu không thành công!";
                lbl_tb.Visible = true;
            }
        }
    }
}