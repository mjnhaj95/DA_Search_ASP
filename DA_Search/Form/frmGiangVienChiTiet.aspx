<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmGiangVienChiTiet.aspx.cs" Inherits="DA_Search.Form.frmGiangVienChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Chi tiết giảng viên</span>
            </div>
            <div class="panel-body">
                <div><b>Mã giảng viên</b></div>
                <asp:TextBox ID="txtMagv" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Tên giảng viên</b></div>
                <asp:TextBox ID="txtTengv" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Năm sinh</b></div>
                <asp:TextBox ID="txtNamSinh" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Giới tính</b></div>
                <asp:TextBox ID="txtgioiTinh" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Học vị</b></div>
                <asp:TextBox ID="txtHocVi" runat="server" Height="27px" Width="512px"></asp:TextBox>

                <div><b>Email </b></div>
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