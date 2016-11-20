<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DA_Search.Form.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="../BS_Admin2/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../AllCss/login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: block;
            margin-top: 10px;
            margin-bottom: 10px;
            left: 0px;
            top: 0px;
            width: 955px;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section id="main">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 col-md-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>HỆ THỐNG QUẢN LÝ THÔNG TIN</h4>
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label for="username">Tên đăng nhập</label>
                                    <input type="text" class="form-control" placeholder="Mời bạn nhập tên đăng nhập" />
                                </div>
                                <div class="form-group">
                                    <label for="username">Username</label>
                                    <input type="password" class="form-control" placeholder="Mời bạn nhập mật khẩu" />
                                </div>
                                <button type="submit" class="btn btn-primary btn-block">Đăng nhập hệ thống</button>
                                <div class="row">
                                    <div class="auto-style1">
                                        <label>
                                            <asp:CheckBox ID="ckbNhoMatKhau" runat="server" Text="Nhớ mật khẩu !" />
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-footer">
                                <div class="box-footer">

                                    <button type="submit" class="btn btn-danger">Hủy bỏ</button>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                     <asp:HyperLink ID="HyperLink1" runat="server">Quên mật khẩu ?</asp:HyperLink>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>

    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.js"></script>
</body>
</html>