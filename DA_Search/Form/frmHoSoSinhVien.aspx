<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmHoSoSinhVien.aspx.cs" Inherits="DA_Search.Form.frmHoSoSinhVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="page-header">HỒ SƠ SINH VIÊN TRONG CSDL</h2>
        </div>
        <div class="col-lg-12">
            <div class="col-lg-3">
                <asp:TextBox ID="txtInput" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                   <button class="btn btn-success" onclick="Alert()">Tìm kiếm</button>
               <%-- <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn-info active" Height="30px" Width="121px" OnClick="btnTimKiem_Click" />--%>
            </div>
            <div class="col-lg-3">
                <asp:DropDownList ID="ddlKhoa" runat="server" Height="30px" DataSourceID="SqlDataSource3" DataTextField="Tên chuyên ngành" DataValueField="Tên chuyên ngành"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT 'Khóa' + ' ' +  Convert(varchar(5), Makh) AS 'Tên chuyên ngành' FROM tbl_khoahoc ORDER BY Makh"></asp:SqlDataSource>
            </div>
            <div class="col-lg-3">
                <asp:DropDownList ID="ddlChuyenNganh" runat="server" DataSourceID="SqlDataSource1" DataTextField="Tên chuyên ngành" DataValueField="Tên chuyên ngành" Height="30px"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT Convert(varchar(5), Macn)+ '-'+ Tencn AS 'Tên chuyên ngành' FROM tbl_chuyennganh ORDER BY Macn"></asp:SqlDataSource>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <br />
    <div class="row">
        <table class="table table-bordered table-hover" id="dataTables-example">
            <thead>
                <tr class="mau_thead">
                    <th>Mã sinh viên</th>
                    <th>Tên sinh viên</th>
                    <th>Ngày sinh </th>
                    <th>Giới tính</th>
                    <th>Khóa</th>
                    <th>Chuyên ngành</th>
                    <th>Email</th>
                    <th>Điện thoại</th>
                    <th>Địa chỉ</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltr_sv_sv" runat="server" Mode="Transform"></asp:Literal>

                <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
            </tbody>
        </table>
         <script type="text/javascript">
            function Alert() {
                alert("Chưa làm");
            }
        </script>
    </div>
</asp:Content>