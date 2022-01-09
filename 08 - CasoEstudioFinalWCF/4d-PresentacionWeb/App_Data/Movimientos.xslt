<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

  <!-- Determino que el formato se aplica a todo el documento-->
  <xsl:template match="/">

    <!--Creo una tabla para poder desplegar prolijamente-->
    <table >

          <!--Cabezales de las columnas-->
          <tr style ="background-color: #C0C0C0">
            <td style=" border: thin double #800000"> Numero </td>
            <td style=" border: thin double #800000"> Cuenta </td>
            <td style=" border: thin double #800000"> Fecha </td>
            <td style=" border: thin double #800000"> Monto </td>
            <td style=" border: thin double #800000"> Tipo </td>
          </tr>
              
          <!--Determino como quiero desplegar cada nodo Movimiento-->
          <xsl:for-each select="Raiz/Movimiento">
                <tr>
                    <td> <xsl:value-of select="IdMov" /> </td>
                    <td> <xsl:value-of select="NumCta" /> </td>
                    <td> <xsl:value-of select="FechaMov" /> </td>
                    <td style="background-color: #CCFFFF"> <xsl:value-of select="MontoMov" /> </td>
                    <td style="background-color: #FFFF99"> <xsl:value-of select="TipoMov" /> </td>

                </tr>
          </xsl:for-each>
    </table>
  </xsl:template>
  
</xsl:stylesheet>
