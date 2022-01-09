<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 63px;
        }
        .style3
        {}
        .style4
        {
            width: 63px;
            height: 23px;
        }
        .style5
        {
            height: 23px;
        }
    </style>
</head>
<body bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
    
        ABM DE ARTICULOS-CONSUMO WCF</div>
    <table style="width: 100%; height: 121px;">
        <tr>
            <td class="style2">
                Codigo:</td>
            <td class="style3">
                <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnbuscarart" runat="server" onclick="btnbuscarart_Click" 
                    Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Nombre:</td>
            <td class="style3">
                <asp:TextBox ID="txtnobmre" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Precio</td>
            <td class="style3">
                <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="btnaltaart" runat="server" onclick="btnaltaart_Click" 
                    Text="Alta" />
            </td>
            <td class="style3">
                <asp:Button ID="btnbajaart" runat="server" onclick="btnbajaart_Click" 
                    Text="Baja" />
            </td>
            <td>
                <asp:Button ID="btnmodart" runat="server" onclick="btnmodart_Click" 
                    Text="Modificar" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnlistarart" runat="server" onclick="btnlistarart_Click" 
                    Text="Listar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:GridView ID="GVarticulos" runat="server" AutoGenerateColumns="False" 
                    Height="134px" Width="256px">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style5" colspan="2">
                <asp:Label ID="lblerror" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
