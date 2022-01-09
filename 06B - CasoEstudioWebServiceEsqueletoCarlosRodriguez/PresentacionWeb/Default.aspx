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
            <td colspan="3" class="style1"><strong>ABM de Articulos - Consumo Web Service</strong></td>
        </tr>    
        <tr>
            <td> Codigo: </td>
            <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" 
                    onclick="BtnBuscar_Click" /></td>
        </tr>
        <tr>
            <td> Nombre: </td>
            <td>  <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td> Precio: </td>
            <td> <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox> 
                <br />
            </td>
            <td>  &nbsp; </td>        
        </tr>
        <tr>
            <td> Fecha</td>
            <td> <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox> </td>
            <td>  &nbsp;</td>        
        </tr>
        <tr>
            <td><asp:Button ID="BtnAlta" runat="server" Text="Alta" Enabled="False" 
                    onclick="BtnAlta_Click" /></td>
            <td><asp:Button ID="BtnBaja" runat="server" Text="Baja" Enabled="False" /></td>
            <td><asp:Button ID="BtnModificar" runat="server" Text="Modificar" Enabled="False" /></td>
        </tr>
        <tr>
            <td colspan="3">  &nbsp; </asp:Label> </td>
        </tr>
        <tr>
            <td colspan="3"> <asp:Label ID="lblError" runat="server" ForeColor="Red" Width="386px"></asp:Label> </td>
        </tr>
        <tr>
            <td colspan="3">  &nbsp; </asp:Label> </td>
        </tr>
        <tr>
            <td colspan="3"><asp:Button ID="BtnListar" runat="server" 
                    Text="Listar Todos los Articulos" onclick="BtnListar_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False" Height="197px"  Width="456px">
                  <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                  </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
