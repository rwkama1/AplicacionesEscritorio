<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusquedaAutosporNodo.aspx.cs" Inherits="BusquedaAutosporNodo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 149px;
        }
        .style2
        {
            width: 194px;
        }
        .style3
        {
            width: 364px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                <asp:Label ID="lblbusqueda" runat="server" Text="Busqueda"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="DdlBuscar" runat="server">
                    <asp:ListItem Value="/Biblioteca/Auto[Matricula">Matricula</asp:ListItem>
                    <asp:ListItem Value="/Biblioteca/Auto[Modelo='">Modelo</asp:ListItem>
                    <asp:ListItem Value="/Biblioteca/Auto[Precio='">Precio</asp:ListItem>
                    <asp:ListItem Value="/Biblioteca/Auto[Marca='">Marca</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style3">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ABMAutos.aspx">LinkButton</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lbldato" runat="server" Text="Datos"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtdato" runat="server"></asp:TextBox>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
                    Text="Busqueda" />
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:GridView ID="GVBusqueda" runat="server" Height="162px" Width="264px">
                </asp:GridView>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblerror" runat="server"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
