<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmDanhSachDoAn7.aspx.cs" Inherits="DA_Search.Form.frmDanhSachDoAn7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <%--Thống kê danh sách sinh viên có điểm đồ án nhỏ hơn 7--%>
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Danh sách sinh viên có điểm đồ án nhỏ hơn 7</span>
            </div>
            <div class="panel-body">
                <table class="table table-striped table-bordered table-hover">
                    <thead>
                        <tr class="mau_thead">
                            <th>STT</th>
                            <th>Mã sinh viên </th>
                            <th>Tên sinh viên</th>
                            <th>Tên đồ án</th>
                            <th>Giáo viên hướng dẫn</th>
                            <th>Điểm</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="ltr_da7" runat="server" Mode="Transform"></asp:Literal>
                        <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
                    </tbody>
                </table>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>