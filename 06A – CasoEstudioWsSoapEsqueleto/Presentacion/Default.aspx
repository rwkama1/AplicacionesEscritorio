<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            color: #660066;
            text-decoration: underline;
        }
        .style2
        {
            color: #339933;
            text-decoration: underline;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <table border="1">
        <tr>
            <td colspan="2" class="style1"><strong>Prueba Calculo de Potencia</strong></td>
            <td colspan="2" class="style2"><strong>Prueba Calculo de Factorialorial</strong></td>
         </tr> 
         <tr>
            <td>Base: </td>
            <td><asp:TextBox ID="txtBase" runat="server"></asp:TextBox></td>
            <td>Numero: </td>
            <td><asp:TextBox ID="txtNumero" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
             <td>Exponenete: </td>
             <td><asp:TextBox ID="txtExponente" runat="server"></asp:TextBox></td>
             <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td> &nbsp;</td>
            <td> <asp:Button ID="btnCalculoP" runat="server" Text="Calcular Con WS" onclick="btnCalculoP_Click"/> </td>
            <td> &nbsp;</td>
            <td> <asp:Button ID="btnCalculoF" runat="server"   Text="Calcular Con WS" onclick="btnCalculoF_Click" /> </td>
        </tr> 
        <tr>
            <td colspan="4">  &nbsp; </td>
        </tr>
        <tr>
            <td colspan="2">Resultado: </td>
            <td colspan="2">  <asp:Label ID="lblDespliego" runat="server"></asp:Label> </td>
        </tr>
    </table>

       
    </form>

</body>
</html>
