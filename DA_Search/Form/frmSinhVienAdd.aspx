﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmSinhVienAdd.aspx.cs" Inherits="DA_Search.Form.frmSinhVienAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading success">
                <span class="tieude_thead">Thêm mới sinh viên</span>
                <asp:Label ID="lbl_tb" runat="server" Text="" CssClass="alert-danger"></asp:Label>
            </div>
            <div class="panel-body">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Mã sinh viên(*):" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtMasv" runat="server" CssClass="khung"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMasv" CssClass="error" ErrorMessage="Lỗi: Vui lòng nhập mã sinh viên"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Họ tên sinh viên(*):" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtTensv" runat="server" CssClass="khung"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTensv" CssClass="error" ErrorMessage="Lỗi: Vui lòng nhập tên sinh viên"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Ngày sinh(*):" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:Label ID="Label1" runat="server" Text="Ngày"></asp:Label>
                            <asp:DropDownList ID="ddlNgay" runat="server"></asp:DropDownList>
                            <asp:Label ID="Label2" runat="server" Text="Tháng"></asp:Label>
                            <asp:DropDownList ID="ddlThang" runat="server"></asp:DropDownList>
                            <asp:Label ID="Label3" runat="server" Text="Năm"></asp:Label>
                            <asp:DropDownList ID="ddlNam" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Giới tính:" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="rdNam" runat="server" GroupName="sex" Text="Nam" Checked="True" />
                            <asp:RadioButton ID="rdNu" runat="server" GroupName="sex" Text="Nữ" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text="Khóa:" CssClass="chu"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlKhoa" runat="server" DataSourceID="SqlDataSource1" DataTextField="Makh" DataValueField="Makh">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT [Makh] FROM [tbl_khoahoc]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label13" runat="server" Text="Chuyên ngành:" CssClass="chu"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlChuyenNganh" runat="server" CssClass="khung" DataSourceID="SqlDataSource2" DataTextField="Tên chuyên ngành" DataValueField="Tên chuyên ngành">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT CONVERT (varchar(5), Macn) + '-' + Tencn AS 'Tên chuyên ngành' FROM tbl_chuyennganh ORDER BY Macn"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Email:" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="khung"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" CssClass="error" ErrorMessage="Lỗi: Vui lòng nhập địa chỉ Email"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" CssClass="error" ErrorMessage="Lỗi: Email không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="Điện thoại:" CssClass="chu"></asp:Label></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtDienThoai" runat="server" CssClass="khung"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text="Địa chỉ:" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="khung"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Ghi chú:" CssClass="chu"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtGhiChu" runat="server" Height="79px" TextMode="MultiLine" Width="498px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style1">
                            <asp:Button ID="btnThem" runat="server" Text="Cập nhật" OnClick="btnThem_Click" />
                            <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" />
                        </td>
                    </tr>
                </table>
            </div>

            <!-- /.panel-body -->
        </div>
    </div>

    <!-- /.row -->
</asp:Content>