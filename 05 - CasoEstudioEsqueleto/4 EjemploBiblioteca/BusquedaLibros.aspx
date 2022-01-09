<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="BusquedaLibros.aspx.cs" Inherits="BusquedaLibros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <table style="width: 773px" >
            <tr>
                <td colspan="2" class="style2" style="text-align: center"> Busqueda de Libros</td>
            </tr>
            <tr>
                <td class="style4">Tipo de Busqueda:</td>
                <td><asp:DropDownList ID="DdlTipo" runat="server" Height="24px" Width="126px">
                    <asp:ListItem Value="/Biblioteca/Libro[ISBN">ISBN</asp:ListItem>
                    <asp:ListItem Value="/Biblioteca/Libro[Titulo='">Titulo</asp:ListItem>
                    <asp:ListItem Value="/Biblioteca/Libro[@Categoria='">Categoria</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="style4">Introduzca dato</td>
                <td><asp:TextBox ID="txtDato" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" 
                        onclick="BtnBuscar_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnconsulta" runat="server" onclick="btnconsulta_Click" 
                        Text="Consulta" />
                    <br />
                    <br />
                    <asp:ListBox ID="ListBox1" runat="server" Height="93px" Width="197px">
                    </asp:ListBox>
                    <br />
                    <br />
                    <br />
                    <asp:GridView ID="GVDatos" runat="server" Height="165px" Width="306px">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td class="style4">Resultado:</td>
                <td><asp:Label ID="lblBusqueda" runat="server"></asp:Label></td>
            </tr>
        </table>
</asp:Content>

