<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BaiTestB3.aspx.cs" Inherits="DA_Search.Form.BaiTestB3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">HỒ SƠ SINH VIÊN TRONG CSDL</span>
                <br />
                <div class="btn btn-success"><a href="#">Thêm mới</a></div>
                <br />
                <br />
                <asp:TextBox ID="txtTimKiem" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Tìm kiếm" OnClick="Button1_Click" />
            </div>
            <div class="panel-body">
                <table class="table table-bordered table-hover" id="dataTables-example">
                    <thead>
                        <tr class="mau_thead">
                            <th>STT</th>
                            <th>Mã sinh viên</th>
                            <th>Tên sinh viên</th>
                            <th>Giới tính</th>
                            <th>Khóa</th>
                            <th>Chuyên ngành</th>
                            <th>Chi tiết</th>
                            <th>Sửa</th>
                            <th>Xóa</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="ltr_sv" runat="server" Mode="Transform"></asp:Literal>

                        <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
                    </tbody>
                </table>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>