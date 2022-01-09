<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            color: #009900;
            font-weight: bold;
        }
        .style2
        {
            width: 433px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <p class="style1"> PARTE A </p>
        <p> Se obtienen los datos y esquemas desde la base de datos - Se guardan en un DataSet en forma desconectada&nbsp;
            <asp:Button ID="BtnAccion1" runat="server" onclick="BtnAccion1_Click" Text="Ejecutar" />
        </p>

        <hr />

        <p class="style1"> PARTE B </p>
        <p> Utilizando el DataSet de la Parte A, se cargan los datos que hay en el archivo DatosXML.XML&nbsp;
            <asp:Button ID="BtnAccion2" runat="server" onclick="BtnAccion2_Click" 
                Text="Ejecutar" Width="69px" style="height: 26px" />
        </p>

        <table border="1" style="width: 919px" >
                <tr>
                    <td class="style2"> <asp:GridView ID="GVFamilias" runat="server" Width="396px"> </asp:GridView></td> 
                    <td> <asp:GridView ID="GVArticulos" runat="server" Width="437px"></asp:GridView> </td>
                </tr>
        </table>

        <hr />

        <p class="style1"> PARTE C </p>
        <p> Se genera un documento XML unico con el esquema y datos del DataSet (informacion combinada de BD y XML)&nbsp;
            <asp:Button ID="BtnAccion3" runat="server" onclick="BtnAccion3_Click" Text="Ejecutar" />
        </p>
    
          <hr />

    </form>
</body>
</html>
