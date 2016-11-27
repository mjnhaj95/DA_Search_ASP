<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmGiangVienEdit.aspx.cs" Inherits="DA_Search.Form.frmGiangVienEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            color: #fff;
            background-color: #5bc0de;
            border-color: #46b8da;
            margin-top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Sửa thông tin giảng viên</span>
            </div>
            <div class="panel-body">
                <div><b>Mã giảng viên</b></div>
                <asp:TextBox ID="txtMagv" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div><b>Tên giảng viên</b></div>
                <asp:TextBox ID="txtTengv" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div><b>Năm sinh</b></div>
                <asp:TextBox ID="txtNamSinh" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div>
                    <b>Giới tính</b>
                    <asp:RadioButton ID="rdoNam" runat="server" GroupName="sex" Text="Nam" />
                    <asp:RadioButton ID="rdoNu" runat="server" GroupName="sex" Text="Nữ" />
                </div>

                <div><b>Học vị</b></div>
                <asp:TextBox ID="txtHocVi" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div><b>Email </b></div>
                <asp:TextBox ID="txtEmail" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div><b>Điện thoại </b></div>
                <asp:TextBox ID="txtDienThoai" runat="server" Height="35px" Width="512px"></asp:TextBox>

                <div><b>Địa chỉ</b></div>
                <asp:TextBox ID="txtDiaChi" runat="server" Height="35px" Width="512px"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btlLuu" runat="server" Text="Lưu" CssClass="auto-style1" Height="40px" OnClick="btlLuu_Click" Width="97px" />
                &nbsp;&nbsp;
                <asp:Button ID="btnHuy" runat="server" Text="Hủy" CssClass="btn-danger" Height="40px" OnClick="btnHuy_Click" Width="86px" />
                <br />
                <asp:Label ID="lbl_tb" runat="server" Text="Label"></asp:Label>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>