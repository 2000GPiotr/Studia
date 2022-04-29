<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Zadanie2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </div>
        <div>
           <asp:Button ID="Create" runat="server" Text="Stwórz" OnClick="Create_Click" />
        </div>
        <div>
            <asp:Button ID="Remove" runat="server" Text="Usuń" OnClick="Remove_Click" />
        </div>
        <div>
            <asp:Button ID="Show" runat="server" Text="Pokaż" OnClick="Show_Click" />
        </div>
        <div>
            <asp:Label ID="lb" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
