<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABMAutos.aspx.cs" Inherits="ABMAutos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 174px;
        }
        .style2
        {
            width: 222px;
        }
        .style3
        {
            width: 174px;
            height: 23px;
        }
        .style4
        {
            width: 222px;
            height: 23px;
        }
        .style5
        {
            width: 628px;
        }
        .style6
        {
            width: 628px;
            height: 23px;
        }
        .style7
        {
            width: 174px;
            height: 91px;
        }
        .style8
        {
            width: 222px;
            height: 91px;
        }
        .style9
        {
            width: 628px;
            height: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/BusquedaAutosporNodo.aspx">LinkButton</asp:LinkButton>
    
    </div>
    <table style="width:100%;">
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="Matricula"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtmatricula" runat="server" Width="134px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:Button ID="btnalta" runat="server" Text="Alta" onclick="btnalta_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3">
            </td>
            <td class="style4">
            </td>
            <td class="style6">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtmatricula" ErrorMessage="Matricula incorrecta" 
                    ValidationExpression="[A-Z][A-Z][A-Z][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="Marca"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtmarca" runat="server" Width="134px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:Button ID="btnbaja" runat="server" Text="Baja" onclick="btnbaja_Click" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label3" runat="server" Text="Modelo"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtmodelo" runat="server" Width="134px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:Button ID="btnmodificar" runat="server" Text="Modificar" 
                    onclick="btnmodificar_Click" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnlimpiar" runat="server" onclick="btnlimpiar_Click" 
                    Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label4" runat="server" Text="Dueño"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="DdlDueños" runat="server">
                </asp:DropDownList>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            </td>
            <td class="style8">
            </td>
            <td class="style9">
                <asp:GridView ID="GridView1" runat="server" Height="141px" Width="244px" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label5" runat="server" Text="Precio"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtprecio" runat="server" Width="134px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblerror" runat="server"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
