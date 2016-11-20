<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmKhoaHoc_view.aspx.cs" Inherits="DA_Search.Form.frmKhoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="page-header">Danh mục khóa học</h2>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <asp:GridView ID="grvDanhMucKhoaHoc" runat="server" AutoGenerateColumns="False" DataKeyNames="Mã Khoa" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" HorizontalAlign="Left" Width="1074px">
            <Columns>

                <asp:TemplateField HeaderText="STT">
                    <ItemTemplate>
                        <asp:Label ID="numberrow"
                            Text="<%# Container.DataItemIndex + 1 %>"
                            runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="Mã Khoa" HeaderText="Mã Khoa" ReadOnly="True" SortExpression="Mã Khoa" />
                <asp:BoundField DataField="Tên Khoa" HeaderText="Tên Khoa" SortExpression="Tên Khoa" />
                <asp:BoundField DataField="Thời gian" HeaderText="Thời gian" SortExpression="Thời gian" />
                <asp:BoundField DataField="Ghi chú" HeaderText="Ghi chú" SortExpression="Ghi chú" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" HorizontalAlign="Center" Font-Bold="True" ForeColor="White" Height="50px" VerticalAlign="Middle" Width="200px" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="SELECT Makh AS 'Mã Khoa', Tenkhoa AS 'Tên Khoa', Thoigian AS 'Thời gian', Ghichu AS 'Ghi chú' FROM tbl_khoahoc ORDER BY 'Mã Khoa'"></asp:SqlDataSource>
    </div>
</asp:Content>