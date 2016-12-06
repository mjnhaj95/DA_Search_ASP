﻿using DA_Search.AllClass;
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
    public partial class frmSinhVienAdd : System.Web.UI.Page
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
            try
            {
                clscon.connect_Data();

                SqlCommand sqlcm_sv = new SqlCommand();
                sqlcm_sv.CommandText = "Insert_SV";
                sqlcm_sv.CommandType = CommandType.StoredProcedure;

                // truyền tham số vào store

                sqlcm_sv.Parameters.Add("@Masv", SqlDbType.Char).Value = txtMasv.Text.Trim();
                sqlcm_sv.Parameters.Add("@Tensv", SqlDbType.NVarChar).Value = txtTensv.Text.Trim();
                sqlcm_sv.Parameters.Add("@NamSinh", SqlDbType.Date).Value = ddlNgay.Text + "-" + ddlThang.Text + "-" + ddlNam.Text;
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
                    lbl_tb.Text = "Lỗi: Thêm mới dữ liệu không thành công!";
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