<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="SolicitarPrestamo.aspx.cs" Inherits="SolicitarPrestamo" Theme="TemaFinal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <p>
    <em><strong>SOLICITAR PRESTAMO<br />
    </strong></em>
    <table align="center" border="1" style="width: 51%;">
        <tr>
            <td class="style8" colspan="1">
                Monto:</td>
            <td>
                <asp:TextBox ID="TxtMonto" runat="server"></asp:TextBox>
            </td>
            <td class="style9" colspan="1">
            &nbsp;<asp:Button ID="BtnSolicitar" runat="server" 
                     Text="Solicitar" onclick="BtnSolicitar_Click" />
                <br />
                </td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <asp:Label ID="LblError" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style8" colspan="2">
                &nbsp;</td>
            <td class="style9">
                <asp:Button ID="BtnRefresh" runat="server" onclick="BtnRefresh_Click" 
                    Text="Limpiar Pantalla" />
            </td>
        </tr>
    </table>
    <p style="text-align: center">
        &nbsp;</p>
     <strong><em>VERIFICAR PRESTAMOS SOLICITADOS</em></strong><p>
                <asp:Button ID="BtnConsultar" runat="server" 
                    Text="Consultar" onclick="BtnConsultar_Click" />
            </p>
     <p>
         <asp:GridView ID="GVPrestamos" runat="server" BackColor="White" 
             BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
             GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
             <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
             <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
             <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
             <SortedAscendingCellStyle BackColor="#F4F4FD" />
             <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
             <SortedDescendingCellStyle BackColor="#D8D8F0" />
             <SortedDescendingHeaderStyle BackColor="#3E3277" />
         </asp:GridView>
     </p>
     <p>
         &nbsp;</p>
<br />
</asp:Content>

