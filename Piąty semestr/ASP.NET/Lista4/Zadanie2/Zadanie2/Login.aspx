<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zadanie2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="usrnameLabel" Text="Username: "></asp:Label>
            <asp:TextBox runat="server" ID="username"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="passwordLabel" Text="Password: "></asp:Label>
            <asp:TextBox runat="server" ID="password" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" ID="login" Text ="Login" OnClick="login_Click" />
        </div>
        <div>
            <asp:Button runat="server" ID="register" Text="Register" OnClick="register_Click" />
        </div>
        <div>
            <asp:Label runat ="server" ID="loginLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
