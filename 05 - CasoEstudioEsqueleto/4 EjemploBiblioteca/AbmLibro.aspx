<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="AbmLibro.aspx.cs" Inherits="AbmLibro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <table style="width: 773px" >
            <tr>
                <td colspan="3" class="style4" style="text-align: center"> <strong>ABM Libros </strong> </td>
            </tr>
            <tr>
                <td>ISBN</td>
                <td><asp:TextBox ID="TxtIsbn" runat="server"></asp:TextBox></td>
                <td rowspan="5"> <asp:GridView ID="GVLibros" runat="server" Width="530px" 
                        AutoGenerateSelectButton="True" 
                        onselectedindexchanged="GVLibros_SelectedIndexChanged"></asp:GridView> </td>           
            </tr>
            <tr>
                <td>Titulo</td>
                <td><asp:TextBox ID="TxtTitulo" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td>Categoria</td>
                <td><asp:TextBox ID="TxtCategoria" runat="server"></asp:TextBox></td>
           </tr>
           <tr>
                <td>Autor</td>
                <td><asp:DropDownList ID="DdlAutor" runat="server"></asp:DropDownList></td>
           </tr>
           <tr>
                <td><asp:Button id="BtnAlta" runat="server" Text="Agregar" 
                        onclick="BtnAlta_Click" /> </td>
                <td><asp:Button id="BtnBaja" runat="server" Text="Borrar" onclick="BtnBaja_Click" />
                    <asp:Button id="BtnModificar" runat="server" Text="Modificar" 
                        onclick="BtnModificar_Click" />
                </td>
           </tr>
            <tr>
                <td colspan="3"><asp:Label ID="LblError" runat="server"></asp:Label> </td>
            </tr>
      </table>
</asp:Content>

