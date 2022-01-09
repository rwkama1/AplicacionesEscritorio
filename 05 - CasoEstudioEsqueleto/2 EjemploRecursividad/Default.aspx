<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            color: #009933;
            font-weight: bold;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="style1">Muestro Recursivamente el contenido de un Archivo XML, 
        dentro de un TextBox</span><br />
        <br />
        <br />
        <asp:TextBox ID="TxtMostrar" runat="server" Height="216px" TextMode="MultiLine" 
            Width="779px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnProcesar" runat="server" onclick="BtnProcesar_Click" 
            Text="Procesar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnAlReves" runat="server" onclick="BtnAlReves_Click" 
            Text="Procesar al Reves" />
        <br />
    
    </div>
    </form>
</body>
</html>
