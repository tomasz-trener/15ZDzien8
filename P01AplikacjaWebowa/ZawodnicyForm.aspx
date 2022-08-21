<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyForm.aspx.cs" Inherits="P01AplikacjaWebowa.ZawodnicyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <div style="float: left">
            <asp:ListBox ID="lbDane" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged"  Height="250" runat="server"></asp:ListBox>
        </div>
        <div style="float: left">

            <asp:Label ID="Label1" runat="server" Text="Filtr"></asp:Label>
            <asp:TextBox ID="txtFiltr" runat="server"></asp:TextBox>

            <br />
            Sortowanie
            <asp:Panel ID="pnSortowanie" runat="server">
                <asp:RadioButton ID="rbImie" GroupName="grupa1" Text="Imie" runat="server" />
                <asp:RadioButton ID="rbNazwisko" GroupName="grupa1"  Text="Nazwisko" runat="server" />
                <asp:RadioButton ID="rbWzrost" GroupName="grupa1"  Text="Wzrost" runat="server" />
            </asp:Panel>

            <br />
            <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" />
            <br />
            <asp:Button ID="btnZapisz" OnClick="btnZapisz_Click" runat="server" Text="Zapisz" />
            <br />
            <asp:Button ID="btnUsun" OnClick="btnUsun_Click" runat="server" Text="Usuń" />
            <br />
            <asp:Button ID="btnNowy" OnClick="btnNowy_Click" runat="server" Text="Nowy" />
            
        
        </div>
        <div style="float:left">

            <table>
                <tr>
                    <td>Imie</td>
                    <td><asp:TextBox ID="txtImie" runat="server"></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Nazwisko</td>
                    <td><asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Kraj</td>
                    <td><asp:TextBox ID="txtKraj" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Miasto</td>
                    <td><asp:TextBox ID="txtMiasto" runat="server"></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Data Ur</td>
                    <td><asp:TextBox ID="txtDataUr" runat="server"></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Waga</td>
                    <td><asp:TextBox ID="txtWaga" runat="server"></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Wzrost</td>
                    <td><asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox> </td>
                </tr>
            </table>

        </div>



    </form>
</body>
</html>
