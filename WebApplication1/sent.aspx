<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sent.aspx.cs" Inherits="WebApplication1.sent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtcontent" runat="server" Width="580"></asp:TextBox>&nbsp
        <asp:Button ID="Button1" runat="server" Text="发送" OnClick="Button1_Click" />&nbsp
        <asp:Button ID="Button2" runat="server" Text="退出" OnClick="Button2_Click" OnLoad="Button2_Load" />
    </div>
    </form>
</body>
</html>
