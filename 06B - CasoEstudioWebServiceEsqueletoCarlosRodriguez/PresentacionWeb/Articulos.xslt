<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:template match="/">
      <table>
        <tr style ="background-color: #C0C0C0">
          <td style=" border: thin double #800000"> Codigo </td>
          <td style=" border: thin double #800000"> Nombre </td>
          <td style=" border: thin double #800000"> Precio </td>
          
        </tr>
        <xsl:for-each select="Raiz/Articulo">
          <tr>
            <td>
              <xsl:value-of select="Codigo" />
            </td>
            <td>
              <xsl:value-of select="Nombre" />
            </td>
            <td>
              <xsl:value-of select="Precio" />
            </td>
            

          </tr>
        </xsl:for-each>
      </table>
       
    </xsl:template>
</xsl:stylesheet>

