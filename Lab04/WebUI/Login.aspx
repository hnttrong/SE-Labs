<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Login - SE Lab 4</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body class="login-page">
    <form id="form1" runat="server" class="login-card">
        <h1>School &amp; Store Management</h1>
        <p class="subtitle">ASP.NET Web Forms - 3-Tier Architecture</p>
        <label>Username</label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="input" />
        <label>Password</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input" />
        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button primary full" OnClick="btnLogin_Click" />
        <asp:Label ID="lblMessage" runat="server" CssClass="message error" />
        <p class="hint">Demo account: admin / 123456</p>
    </form>
</body>
</html>
