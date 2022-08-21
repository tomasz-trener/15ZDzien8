<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01AplikacjaWebowa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <asp:Button ID="btnPowitanie" OnClick="btnPowitanie_Click" runat="server" Text="Powitanie" />

        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>

        <asp:Label ID="lblTekst" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
