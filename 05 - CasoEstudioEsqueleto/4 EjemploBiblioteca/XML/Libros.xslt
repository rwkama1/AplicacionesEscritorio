<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  
    <!-- Determino que el formato se aplica a todo el documento-->
    <xsl:template match="/">
      
         <!--Creo una etiqueta HTML DIV para poder colocar texto dentro de la pagina-->
         <table >
           
                <!--Determino como quiero desplegar cada nodo libro-->
                <xsl:for-each select="Biblioteca/Libro">
                  <!--Para cada libro creo dos renglones de despliegue-->
                  <tr>  
                       <!--Primero despliego el titulo-->
                       <td colspan="2" style="background-color:#008800;padding:4px;font-size:30pt;font-weight:bold;color:white">
                              Titulo: <xsl:value-of select="Titulo" /> 
                       </td>
                  </tr>
                  <!--Segundo despliego el ISBN y la categoria-->
                  <tr>
                      <td style="margin-left:20px;margin-bottom:1em;font-size:15pt">
                        <xsl:value-of select="@Categoria" />
                      </td>
                      <td style="margin-left:20px;margin-bottom:1em;font-size:15pt">
                        ISBN: <xsl:value-of select="ISBN" />
                      </td>
                      </tr>
                </xsl:for-each>
         </table>
    </xsl:template>
</xsl:stylesheet>
