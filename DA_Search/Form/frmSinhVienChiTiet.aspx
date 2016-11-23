<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmSinhVienChiTiet.aspx.cs" Inherits="DA_Search.Form.frmSinhVienChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Chi tiết sinh viên viên</span>
            </div>
            <div class="panel-body">
                <div><b>Mã sinh viên</b></div>
                <asp:TextBox ID="txtMasv" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Tên sinh viên</b></div>
                <asp:TextBox ID="txtTensv" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Ngày sinh</b></div>
                <asp:TextBox ID="txtNgaySinh" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Giới tính</b></div>
                <asp:RadioButton ID="rdoNam" runat="server" GroupName="sex" Text="Nam" /><asp:RadioButton ID="rdoNu" runat="server" GroupName="sex" Text="Nữ" />
                <asp:TextBox ID="txtgioiTinh" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Khóa</b></div>
                <asp:TextBox ID="txtKhoa" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Chuyên ngành</b></div>
                <asp:TextBox ID="txtChuyenNganh" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Email</b></div>
                <asp:TextBox ID="txtEmail" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Điện thoại </b></div>
                <asp:TextBox ID="txtDienThoai" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Địa chỉ</b></div>
                <asp:TextBox ID="txtDiaChi" runat="server" Height="27px" Width="512px"></asp:TextBox>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>