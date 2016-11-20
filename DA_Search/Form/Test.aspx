<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DA_Search.Form.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

    <br />
    <asp:Label ID="lbl_kq" runat="server" Text="Label"></asp:Label>
</asp:Content>