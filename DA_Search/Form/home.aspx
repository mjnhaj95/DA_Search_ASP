<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="DA_Search.Form.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="page-header">Tổng hợp dữ liệu hệ thống</h2>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-users fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">
                                <asp:Label ID="lbl_sumsv" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div>Sinh viên</div>
                        </div>
                    </div>
                </div>
                <a href="frmHoSoSinhVien.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Hồ sơ sinh viên</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-green">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-user-times fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">
                                <asp:Label ID="lbl_sumgv" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div>Giáo viên</div>
                        </div>
                    </div>
                </div>
                <a href="frmHoSoGiangVien.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Hồ sơ giáo viên</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-yellow">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa  fa-home  fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">
                                <asp:Label ID="lbl_sumda" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div>Đồ án</div>
                        </div>
                    </div>
                </div>
                <a href="frmHoSoDoAn.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Đồ án tốt nghiệp</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-red">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-lock fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">
                                <asp:Label ID="lbl_sumcn" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div>Chuyên ngành</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Tổng số chuyên ngành</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
    </div>
    <!-- /.row -->
    <%--Thống kê sinh viên theo chuyên ngành--%>
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Thống kê sinh viên theo chuyên ngành</span>
            </div>
            <div class="panel-body">
                <table class="table table-bordered table-hover" id="dataTables-example">
                    <thead>
                        <tr class="mau_thead">
                            <th>STT</th>
                            <th>Chuyên ngành</th>
                            <th>Số sinh viên</th>
                            <th>Danh sách</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="ltr_sv_cn" runat="server" Mode="Transform"></asp:Literal>
                        <%--  Sử dụng control để hiện mã chuyển đổi HTML--%>
                    </tbody>
                </table>
            </div>
            <!-- /.panel-body -->
        </div>
    </div>
    <!-- /.row -->

    <%--Thống kê sinh viên theo lĩnh vực--%>
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                <span class="tieude_thead">Thống kê sinh viên theo lĩnh vực</span>
            </div>
            <div class="panel-body">
                <table class="table table-striped table-bordered table-hover">
                    <thead>
                        <tr class="mau_thead">
                            <th>STT</th>
                            <th>Lĩnh vực </th>
                            <th>Số đồ án</th>
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
    <div class="row">
        <div class="panel panel-default">
            <div class="panel-heading">
                Thống kê đồ án theo điểm
            </div>
            <div class="panel-body">
                <div class="alert alert-success alert-dismissable">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                    Điểm đồ án <= 7 :<asp:Label ID="lblDoAn7" runat="server" Text="Label"></asp:Label>
                    đồ án
                </div>
                <div class="alert alert-info alert-dismissable">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                    Điểm đồ án từ 7.1 đến 8.0 :<asp:Label ID="lblDoAn8" runat="server" Text="Label"></asp:Label>
                    đồ án
                </div>
                <div class="alert alert-warning alert-dismissable">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                    Điểm đồ án từ 8.1 đến 9.0 :<asp:Label ID="lblDoAn9" runat="server" Text="Label"></asp:Label>
                    đồ án
                </div>
                <div class="alert alert-danger alert-dismissable">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                    Điểm đồ án từ 9.1 đến 10 :<asp:Label ID="lblDoAn10" runat="server" Text="Label"></asp:Label>
                    đồ án
                </div>
            </div>
        </div>
        <%--panel panel-default--%>
    </div>
    <%--row--%>
</asp:Content>