<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmLinhVucChiTiet.aspx.cs" Inherits="DA_Search.Form.frmLinhVucChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">DANH SÁCH ĐỒ ÁN TỐT NGHIỆP THEO LĨNH VỰC</span>
                <br />
            </div>
            <div class="panel-body">
                <table class="table table-bordered table-hover" id="dataTables-example">
                    <thead>
                        <tr class="mau_thead">
                            <th>STT</th>
                            <th>Mã sinh viên</th>
                            <th>Tên sinh viên</th>
                            <th>Tên đồ án</th>
                            <th>GVHD</th>
                            <th>GVPB</th>
                            <th>Lĩnh vực</th>
                            <th>Điểm</th>
                            <th>Năm tốt nghiệp</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="ltr_sv_lv" runat="server" Mode="Transform"></asp:Literal>

                        <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
                    </tbody>
                </table>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->
</asp:Content>