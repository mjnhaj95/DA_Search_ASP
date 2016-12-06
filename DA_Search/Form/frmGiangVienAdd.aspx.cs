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
    public partial class frmGiangVienAdd : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 31; i++)
                {
                    ddlNgay.Items.Add(i.ToString());
                }
                for (int i = 1; i <= 12; i++)
                {
                    ddlThang.Items.Add(i.ToString());
                }
                for (int i = 1970; i <= 2016; i++)
                {
                    ddlNam.Items.Add(i.ToString());
                }
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            clscon.connect_Data();
            string st_magv = txtMagv.Text.Trim();
            string st_tengv = txtTengv.Text.Trim();
            string st_ngaySinh = ddlNgay.Text + "-" + ddlThang.Text + "-" + ddlNam.Text;
            string st_gt;
            if (rdNam.Checked == true)
            {
                st_gt = "1";
            }
            else
            {
                st_gt = "0";
            }
            string st_hocvi = ddlHocVi.Text;
            string st_email = txtEmail.Text;
            string st_dienthoai = txtDienThoai.Text;
            string st_diachi = txtDiaChi.Text;

            string sql = "SELECT COUNT(Magv) FROM tbl_giangvien WHERE Magv = '" + st_magv + "'";
            SqlCommand sqlcmsql = new SqlCommand(sql, clscon.con);

            int kiemtra = (int)sqlcmsql.ExecuteScalar();
            if (kiemtra == 1)
            {
                lbl_tb.Text = "Lỗi: Mã giảng viên đã có trong CSDL";
            }
            else
            {
                string st_sql = "INSERT INTO tbl_giangvien VALUES('" + st_magv + "', N'" + st_tengv + "', '" + st_ngaySinh + "', '" + st_gt + "', N'" + st_hocvi + "', '" + st_email + "', '" + st_dienthoai + "', N'" + st_diachi + "')";
                SqlCommand sqlcm = new SqlCommand(st_sql, clscon.con);
                int check = sqlcm.ExecuteNonQuery();
                if (check != 0)
                {
                    lbl_tb.Visible = true;
                    Response.Redirect("frmGiangVienView.aspx");
                }
                else
                {
                    lbl_tb.Text = "Lỗi: Thêm mới dữ liệu không thành công!";
                    lbl_tb.Visible = true;
                }
            }
        }
    }
}