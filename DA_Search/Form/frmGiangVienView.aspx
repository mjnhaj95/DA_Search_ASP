<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmGiangVienView.aspx.cs" Inherits="DA_Search.Form.frmGiangVienView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">DANH SÁCH GIẢNG VIÊN TRONG CSDL</span>
                <br />

                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="265px"></asp:TextBox>&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Tìm kiếm" CssClass="btn-info active" Height="34px" OnClick="Button1_Click" Width="105px" />
                <div class="btn btn-success"><a href="frmGiangVienAdd.aspx">Thêm mới</a></div>
            </div>
            <div class="panel-body">
                <table class="table table-bordered table-hover" id="dataTables-example">
                    <thead>
                        <tr class="mau_thead">
                            <th>Mã giảng viên</th>
                            <th>Tên giảng viên</th>
                            <th>Điện thoại </th>
                            <th>Địa chỉ</th>
                            <th>Chi tiết</th>
                            <th>Sửa</th>
                            <th>Xóa</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="ltr_sv_gv" runat="server" Mode="Transform"></asp:Literal>

                        <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
                    </tbody>
                </table>
            </div>
            <script type="text/javascript">
                function deleteConfirm() {
                    if (confirm("Bạn có chắc chắn muốn xóa bản ghi này?"))
                        return true;
                    else
                        return false;
                }
            </script>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>