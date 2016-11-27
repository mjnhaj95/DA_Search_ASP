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
    public partial class frmGiangVienView : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    clscon.connect_Data();
                    string st_sql_giangvien = "SELECT Magv, Tengv, Dienthoai, Diachi FROM tbl_giangvien ORDER BY Magv";
                    SqlCommand sqlcm_giangvien = new SqlCommand(st_sql_giangvien, clscon.con);

                    SqlDataReader re_gv = sqlcm_giangvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
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
                        st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'>Xem chi tiết</a></td>";
                        //st_kq_gv = st_kq_gv + "<td><div class='btn btn-sm btn-primary'><a  href='frmGiangVienAdd.aspx'><i class='fa fa-pencil'></i></a></div></td>";
                        st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienEdit.aspx?id=" + re_gv.GetValue(0).ToString() + "'><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-primary'/><i class='fa fa-pencil'></i></a></td>";
                        st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienDelete.aspx?id=" + re_gv.GetValue(0).ToString() + "'><asp:Button ID='Button1' runat='server' OnClick='return deleteConfirm()' Text='Button' class='btn btn-sm btn-danger'/><i class='fa fa-trash'></i></a></td> </tr>";
                    }

                    re_gv.Close();
                    ltr_sv_gv.Text = st_kq_gv;
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
                string search = TextBox1.Text.Trim();
                clscon.connect_Data();
                string st_sql_giangvien = "SELECT Magv, Tengv, Dienthoai, Diachi FROM tbl_giangvien where Magv like N'%" + search + "%' or Tengv like N'%" + search + "%' ORDER BY Magv";
                SqlCommand sqlcm_giangvien = new SqlCommand(st_sql_giangvien, clscon.con);

                SqlDataReader re_gv = sqlcm_giangvien.ExecuteReader();  //Trả về đối tượng SqlDataReader -
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
                    st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'>Xem chi tiết</a></td>";
                    st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-primary'/><i class='fa fa-pencil'></i></a></td>";
                    st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'><asp:Button ID='Button1' runat='server' Text='Button' class='btn btn-sm btn-danger'/><i class='fa fa-trash'></i></a></td></tr>";

                    //st_kq_gv = st_kq_gv + "<td><a href='frmGiangVienChiTiet.aspx?id=" + re_gv.GetValue(0).ToString() + "'>Xóa</a></td></tr>";
                }

                re_gv.Close();
                ltr_sv_gv.Text = st_kq_gv;
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
            }
        }
    }
}