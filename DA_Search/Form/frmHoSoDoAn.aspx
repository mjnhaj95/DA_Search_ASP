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
                <asp:TextBox ID="txtTimKiem" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn-info active" Height="30px" Width="121px" OnClick="btnTimKiem_Click" />
            </div>
            <div class="col-lg-3">
                <asp:DropDownList ID="ddlGiaoVien" runat="server" DataSourceID="SqlDataSource1" DataTextField="Tên chuyên ngành" DataValueField="Magv" AutoPostBack="True" OnSelectedIndexChanged="ddlGiaovien_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" SelectCommand="Select_GVHD" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </div>
            <div class="col-lg-3">
                <asp:DropDownList ID="ddlDiem" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDiem_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="7">Điểm &lt; = 7</asp:ListItem>
                    <asp:ListItem Value="8">Điểm từ 7.1 đến 8</asp:ListItem>
                    <asp:ListItem Value="9">Điểm từ 8.1 đến 9</asp:ListItem>
                    <asp:ListItem Value="10">Điểm từ 9.1 đến 10</asp:ListItem>
                </asp:DropDownList>
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

                <%-- <script type="text/javascript">
            function Alert() {
                alert("Chưa làm");
            }
        </script>--%>
            </tbody>
        </table>
        <%-- <script type="text/javascript">
            function Alert() {
                alert("Chưa làm");
            }
        </script>--%>
    </div>
</asp:Content>