<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="Username"  ></asp:TextBox>
        </div>
        <div>
            <asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="Label" />
        </div>
        <div>
            <asp:Button ID="Log" runat="server" OnClick="Log_Click" Text="Zaloguj" />
        </div>
    </form>
</body>

</html>
