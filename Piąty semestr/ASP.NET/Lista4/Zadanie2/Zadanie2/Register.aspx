<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Zadanie2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="registerNameLabel" Text="Name: "></asp:Label>
            <asp:TextBox runat="server" ID="registerName" ></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="registerEmailLabel" Text="Email: "></asp:Label>
            <asp:TextBox runat="server" ID="registerEmail" ></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="registerPasswordLabel" Text="Password: "></asp:Label>
            <asp:TextBox runat="server" ID="registerPassword" TextMode="Password" ></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" ID="registerConfirm" Text="Confirm" OnClick="registerConfirm_Click" />
        </div>
    </form>
</body>
</html>
