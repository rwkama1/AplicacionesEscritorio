<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="ListadoMovimientosLinq.aspx.cs" Inherits="ListadoMovimientosLinq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            text-decoration: underline;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <p>
        <br />
        <span class="style5"><strong><em>Sus Movimientos </em></strong></span>
    </p>
    <table>
        <tr>
            <td> <asp:Button ID="BtnTodos"   runat="server" Text="Todos           " 
                    onclick="BtnTodos_Click" /> </td>
            <td> <asp:Button ID="BtnRetiros" runat="server" Text="Solo Los Retiros" 
                    onclick="BtnRetiros_Click" /> </td>
            <td> 
                <asp:Button ID="BtnMonto"   runat="server" Text="Solo Mayores a 10000 pesos" 
                    onclick="BtnMonto_Click" /> </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="LblError" runat="server" />
            </td>
        </tr>
    </table>
    <p>
        <asp:Xml ID="XmlListar" runat="server" 
            TransformSource="~/App_Data/Movimientos.xslt"></asp:Xml>
    </p>
    <p>
    </p>

</asp:Content>

