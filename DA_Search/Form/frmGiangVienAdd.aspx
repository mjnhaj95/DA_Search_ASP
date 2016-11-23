<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmGiangVienAdd.aspx.cs" Inherits="DA_Search.Form.frmGiangVienAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 794px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading success">
                <span class="tieude_thead">Thêm mới giảng viên</span>
            </div>
            <div class="panel-body">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Mã giảng viên(*):" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtMagv" runat="server" CssClass="khung"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMagv" CssClass="error" ErrorMessage="Lỗi: Vui lòng nhập mã giảng viên"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Họ tên giảng viên(*):" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtTengv" runat="server" CssClass="khung"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTengv" CssClass="error" ErrorMessage="Lỗi: Vui lòng nhập tên giảng viên"></asp:RequiredFieldValidator>
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
                            <asp:Label ID="Label8" runat="server" Text="Học vị:" CssClass="chu"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="ddlHocVi" runat="server">
                                <asp:ListItem>Sinh viên</asp:ListItem>
                                <asp:ListItem>Kỹ sư</asp:ListItem>
                                <asp:ListItem Selected="True">Thạc sĩ</asp:ListItem>
                                <asp:ListItem>Tiến sĩ</asp:ListItem>
                                <asp:ListItem>Phó giáo sư</asp:ListItem>
                                <asp:ListItem>Giáo sư</asp:ListItem>
                            </asp:DropDownList>
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
                        <td></td>
                        <td class="auto-style1">
                            <asp:Button ID="btnThem" runat="server" Text="Cập nhật" OnClick="btnThem_Click" />
                            <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" />
                            <asp:Label ID="lbl_tb" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>

    <!-- /.row -->
</asp:Content>