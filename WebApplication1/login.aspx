<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    登陆页面
        <p>登录名:<asp:TextBox ID="txtname" runat="server"></asp:TextBox></p>
        <p>密&nbsp码:<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox></p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" /></p>
    </div>
    </form>
</body>
</html>
