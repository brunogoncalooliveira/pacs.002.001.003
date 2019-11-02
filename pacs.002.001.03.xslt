<xsl:stylesheet version="2.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:t="urn:iso:std:iso:20022:tech:xsd:pacs.002.001.03"
	xpath-default-namespace="urn:iso:std:iso:20022:tech:xsd:pacs.002.001.03"
	>
<xsl:output method="text"/>
<xsl:template match="t:Document">
MsgId                    ###
<xsl:for-each select="t:FIToFIPmtStsRpt/t:GrpHdr">
<xsl:value-of select="substring(concat(t:MsgId, '                         '), 1, 25)"/>###<xsl:value-of select="t:CreDtTm"/>###<xsl:value-of select="t:InstgAgt/t:FinInstnId/t:BIC"/>
<xsl:text>&#xa;</xsl:text>
</xsl:for-each>
</xsl:template>

</xsl:stylesheet>