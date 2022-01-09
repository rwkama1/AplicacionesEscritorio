<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.</title>
    <style type="text/css">
        .style1
        {
            color: #660066;
            text-decoration: underline;
            text-align: center;
        }
    </style>
</head>
<body bgcolor="#ffe1c1">
    <form id="form1" runat="server">
    <table border="1">
        <tr>
            <td colspan="3" class="style1"><strong>Generar Pedido - Se envia a un MSMQ Server</strong></td>
        </tr>    
        <tr>
            <td> Articulo: </td>
            <td><asp:TextBox ID="txtArticulo" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" onclick="BtnBuscar_Click" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="LblArticulo" runat="server" ForeColor="Red" Width="386px"></asp:Label></td>
            <td>&nbsp;</td>        
        </tr>
        <tr>
            <td> Nombre: </td>
            <td>  <asp:TextBox ID="txtNombre" runat="server" Width="250px"></asp:TextBox> </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td> Direccion: </td>
            <td> <asp:TextBox ID="txtDir" runat="server" Width="250px"></asp:TextBox> </td>
            <td>  &nbsp; </td>        
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td><asp:Button ID="BtnEnviar" runat="server" Text="Enviar Pedido" Enabled="False" 
                    onclick="BtnEnviar_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">  &nbsp; </td>
        </tr>
        <tr>
            <td colspan="3"> <asp:Label ID="lblError" runat="server" ForeColor="Red" Width="386px"></asp:Label> </td>
        </tr>
    </table>
    </form>
</body>
</html>
