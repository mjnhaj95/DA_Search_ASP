<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmHoSoDoAn.aspx.cs" Inherits="DA_Search.Form.frmHoSoDoAn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="page-header">HỒ SƠ ĐỒ ÁN TỐT NGHIỆP TRONG CSDL</h2>
        </div>
        <div class="col-lg-12">
            <div class="col-lg-3">
                <asp:TextBox ID="txtInput" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </div>
            <div class="col-lg-3">
               <button class="btn btn-success" onclick="Alert()">Tìm kiếm</button>
               <%-- <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn-info active" Height="30px" Width="121px" OnClick="btnTimKiem_Click" />--%>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <br />
    <div class="row">
        <table class="table table-bordered table-hover" id="dataTables-example">
            <thead>
                <tr class="mau_thead">
                    <th>STT</th>
                    <th>Mã SV</th>
                    <th>Tên sinh viên</th>
                    <th>Tên đồ án </th>
                    <th>GVHD</th>
                    <th>GVPB</th>
                    <th>Lĩnh vực</th>
                    <th>Điểm</th>
                    <th>Năm tốt nghiệp</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltr_da" runat="server" Mode="Transform"></asp:Literal>

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