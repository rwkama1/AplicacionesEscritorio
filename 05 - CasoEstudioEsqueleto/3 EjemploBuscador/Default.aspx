<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style2
        {
            color: #CC0066;
            font-weight: bold;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:60%;">
            <tr>
                <td class="style2" colspan="3" style="text-align: center">
                    Ejemplo de Buscador de Datos Sobre un Archivo XML bien Formado</td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    Documento Xml:</td>
                <td >
                    <asp:FileUpload ID="FileUpXML" runat="server" style="margin-right: 26px" 
                        Width="321px" />
                </td>
                <td >
        <asp:Button ID="btnCargar" runat="server"  
            Text="Cargar" onclick="btnCargar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style2" >
                    Realizar Consultas</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    Seleccione Campo donde buscar</td>
                <td >
        <asp:DropDownList ID="DdlCampo" runat="server" AutoPostBack="True" 
             Width="119px">
        </asp:DropDownList>
                </td>
                <td >
                    <asp:Button ID="btnconsultados" runat="server" Height="26px" 
                        onclick="btnconsultados_Click" Text="Nueva Consulta" Width="124px" />
                </td>
            </tr>
            <tr>
                <td >
                    Selecciones Operacion de Filtro</td>
                <td >
        <asp:DropDownList ID="DdlOperacion" runat="server">
            <asp:ListItem Value="=">igual a</asp:ListItem>
            <asp:ListItem Value="!=">distinto de</asp:ListItem>
            <asp:ListItem Value="&gt;">mayor a</asp:ListItem>
            <asp:ListItem Value="&lt;">menor a</asp:ListItem>
            <asp:ListItem Value="&gt;=">mayor o igual a</asp:ListItem>
            <asp:ListItem Value="&lt;=">menor o igual a</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    Determine Valor</td>
                <td >
        <asp:TextBox ID="txtConsulta" runat="server" Width="207px" Height="25px"></asp:TextBox>
                </td>
                <td >
        <asp:Button ID="btnQuery" runat="server"  
            Text="Consultar" onclick="btnQuery_Click" />
                </td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style2" >
                    Resultados</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td  >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td  >
                    <asp:TextBox ID="TxtResultado" runat="server" Height="169px" 
                        TextMode="MultiLine" Width="399px"></asp:TextBox>
                </td>
                <td >
                    &nbsp;</td>
            </tr>
        </table>

    
    </div>
    </form>
</body>
</html>
