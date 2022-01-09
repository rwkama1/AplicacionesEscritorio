<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="TemaFinal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style4
        {
            width: 837px;
            text-align: center;
            color: #990033;
            font-weight: 700;
            font-style: italic;
            text-decoration: underline;
            font-size: xx-large;
        }
        .style5
        {
            color: #FF3399;
            font-weight: bold;
            font-style: italic;
            text-decoration: underline;
        }
        .style6
        {
            color: #FF3399;
            font-weight: bold;
            font-style: italic;
            text-decoration: underline;
            width: 238px;
        }
        .style7
        {
            width: 238px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"> 
        <div style="height: 981px; width: 1015px" >
            <table align="left" style="width: 100%; height: 115px;">
                <tr>
                    <td class="style4">
                        Ejemplo Final&nbsp; 
                        -
                        Aplicaciones Distribuidas y Moviles<br />
                        Analista Programador</td>
                    <td style="text-align: right">
                        <br />
                        <asp:Login ID="Logueo" runat="server" DisplayRememberMe="False" 
                            LoginButtonText="Login" PasswordLabelText="" RenderOuterTable="False" 
                            TitleText="Ingreso" UserNameLabelText="" 
                            onauthenticate="Logueo_Authenticate">
                        </asp:Login>
                        <br />
                        <asp:Label ID="LblError" runat="server"></asp:Label>
                    </td>
                </tr>
                </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table border="1" style="width:100%;">
                <tr>
                    <td class="style6">
                        Elementos de la Solucion</td>
                    <td class="style5">
                        Funcionalidad Incluida</td>
                </tr>
                <tr>
                    <td class="style7">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style7">
                        Arquitectura<br />
                        Presentacion<br />
                        Tecnologias .Net</td>
                    <td>
                        1.- Capas<br />
                        2.- Sitio Web<br />
                        3.- WinForms<br />
                        4.- ServicioWeb<br />
                        5.- Colas de Mensajes<br />
                        6.- LinQ 
                        <br />
                        7.- Xml - XPath - XSLT</td>
                </tr>
                <tr>
                    <td class="style7">
                        Patrones Aplicados</td>
                    <td>
                        1.- Se aplicaron patrones a Logica y Persistencia<br />
                        2.- Patron Fabrica<br />
                        3.- Patron Singleton<br />
                        4.- Clase que se consume unicamente dentro del paquete - No se toma en cuenta en 
                        los patrones (Persistencia Telefonos)
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Elementos de Diseño</td>
                    <td>
                        1.- Manejo de Herencia a Nivel de Logica y Persistencia (Cuentas Bancarias)<br />
                        2.- Transaccion a&nbsp;Nivel logico (por cada alta/modificacion de cliente, 
                        multiples altas de telefonos)<br />
                        3.- Manejo de Properties Virtuales en Herencia de Clases (Clase Cuentas y sus 
                        Derivadas)<br />
                        4.- Controles a medida<br />
                        5.- User Control en Windows con definicion de eventos </td>
                </tr>
                <tr>
                    <td class="style7">
                        Base de Datos</td>
                    <td>
                        1.- Manejo de SP con y sin transacciones<br />
                        2.- Restricciones definidas a nivel de esquema<br />
                        3.- Manejo Usuarios<br />
                        4.- Creacion y uso de Vistas</td>
                </tr>
                <tr>
                    <td class="style7">
                        Otros</td>
                    <td>
                        1.- Manejo de Excepciones SOAP</td>
                </tr>
                <tr>
                    <td class="style7">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style6"> Pagina Web</td>
                    <td class="style5"> Funcionalidad Incluida</td>
                </tr>
                <tr>
                    <td class="style7"> &nbsp;</td>
                    <td> &nbsp;</td>
                </tr>
                <tr>
                    <td class="style7"> Default</td>
                    <td> 1.- Manejo manual de controles de Logueo<br /> </td>
                </tr>
                <tr>
                    <td class="style7"> Master Page</td>
                    <td>
                        1.- Manejo de Usuarios<br />
                        2.- Control de Navegacion (TreeView - Menu Principal)
                   </td>
                </tr>
                <tr>
                    <td class="style7"> Listado Cuentas</td>
                    <td>
                        1.- Uso de Repeater (muestra de cuentas)<br />
                        2.- Uso de consulta en cascada (dado una 
                        cuenta, se despliegan sus movimientos) </td>
                </tr>
                <tr>
                    <td class="style7"> Listado de Movimientos Xml</td>
                    <td>
                        1.- Manejo de Xpath<br />
                        2.- Manejo Xml<br />
                        3.- Manejo Xslt<br />
                        4.- Control XML</td>
                </tr>
                <tr>
                    <td class="style7"> Listado de Movimientos Linq</td>
                    <td>
                        1.- Manejo de LinQ</td>
                </tr>
                <tr>
                    <td class="style7"> Solicitud de Prestamo</td>
                    <td> 1.- Envio de solicitud pendiente a un server MSMQ</td>
                </tr>
                </table>
            <br />
            </div>
    
    </form>
</body>
</html>
