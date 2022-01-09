<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="ListadoCuentas.aspx.cs" Inherits="ListadoCuentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="App_Themes/TemaFinal/Estilo2.css" rel="stylesheet" 
        type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <p>
    <table>
        <tr>
            <td colspan="3">
                <asp:Label ID="LblError" runat="server"></asp:Label>            
            </td>
        </tr>
        <tr>
            <td>
                <strong><em>Cuentas</em></strong></td>
            <td>
                &nbsp;  
            </td>
            <td>
                <strong><em>Movimientos de la Cuenta Seleccionada</em></strong>            
            </td>
        </tr>
        <tr>
            <td> &nbsp;&nbsp;</td>
            <td> &nbsp; </td>
            <td> &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Repeater ID="RpCuentas" runat="server" 
            onitemcommand="RpCuentas_ItemCommand" >
           
          <ItemTemplate>
                        <table>
                            <tr bgcolor="#6666FF">
                                  <td> Num: <br />  <asp:TextBox ID="TxtNumero" runat="server" Text = '<%# Bind("NumCta") %>'></asp:TextBox> <br /> </td>
                                 <td> Saldo: <br />    <asp:TextBox ID="TxtNombre" runat="server" Text='<%# Bind("SaldoCuenta") %>'></asp:TextBox> <br /> </td>
                                 <td> <br /><asp:Button ID="Button2" runat="server" CommandName="Listar" style="text-align: center" Text="Listar Movimientos" />  </td>
                              </tr>
                        </table>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <table>
                            <tr bgcolor="#333377">
                                  <td> Num: <br />  <asp:TextBox ID="TxtNumero" runat="server" Text = '<%# Bind("NumCta") %>'></asp:TextBox> <br /> </td>
                                 <td> Saldo: <br />    <asp:TextBox ID="TxtNombre" runat="server" Text='<%# Bind("SaldoCuenta") %>'></asp:TextBox> <br /> </td>
                                 <td> <br /><asp:Button ID="Button2" runat="server" CommandName="Listar" style="text-align: center" Text="Listar Movimientos" /> </td>
                           </tr>
                        </table>
                    </AlternatingItemTemplate>
        </asp:Repeater>
            </td>
            <td> . </td>
            <td>  
                 <asp:GridView ID="s" runat="server" AutoGenerateColumns="False" 
            Width="264px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" 
            BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="FechaMov" HeaderText="Fecha" />
                <asp:BoundField DataField="MontoMov" HeaderText="Monto" />
                <asp:BoundField DataField="TipoMov" HeaderText="Tipo" />
            </Columns>
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
            </td>
        </tr>
    </table>
           
 
</asp:Content>

