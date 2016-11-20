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
        <!-- /.col-lg-12 -->
    </div>
    <div class="row">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Mã sinh viên" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style1" Width="1074px">
            <Columns>
                <asp:BoundField DataField="Mã sinh viên" HeaderText="Mã sinh viên" ReadOnly="True" SortExpression="Mã sinh viên" />
                <asp:BoundField DataField="Tên sinh viên" HeaderText="Tên sinh viên" SortExpression="Tên sinh viên" />
                <asp:BoundField DataField="Ngày sinh" HeaderText="Ngày sinh" SortExpression="Ngày sinh" />
                <asp:BoundField DataField="Giới tính" HeaderText="Giới tính" SortExpression="Giới tính" ReadOnly="True" />
                <asp:BoundField DataField="Khóa" HeaderText="Khóa" SortExpression="Khóa" />
                <asp:BoundField DataField="Chuyên ngành" HeaderText="Chuyên ngành" SortExpression="Chuyên ngành" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Điện thoại" HeaderText="Điện thoại" SortExpression="Điện thoại" />
                <asp:BoundField DataField="Địa chỉ" HeaderText="Địa chỉ" SortExpression="Địa chỉ" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Height="50px" HorizontalAlign="Center" Width="150px" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT	Masv AS 'Mã sinh viên', 
		    Tensv AS 'Tên sinh viên',
		    Namsinh AS 'Ngày sinh',
		    Case WHEN Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS 'Giới tính',
		    Khoa AS 'Khóa',
	        tbl_chuyennganh.Tencn AS 'Chuyên ngành',
	        Email AS 'Email', 
	        Dienthoai AS 'Điện thoại', 
	        Diachi AS 'Địa chỉ'
        FROM tbl_sinhvien 
        INNER JOIN tbl_chuyennganh
        ON tbl_sinhvien.Chuyennganh = tbl_chuyennganh.Macn
        ORDER BY Masv "></asp:SqlDataSource>
    </div>
</asp:Content>