<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P03Wstawki.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <p><%= Napis %></p>


        <div>
            <p>
                <% 
                    string s = "ala ma kota";
                    Response.Write(s);
                   %></p>
        </div>

        <%
            for (int i = 0; i < 10; i++)
            { %>
               
             <p><% Response.Write("heej"); %></p> 
             <p><%= "halo" %></p>
       
        <%   }


            %>





    </form>
</body>
</html>
