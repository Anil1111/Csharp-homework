<?xml version="1.0" encoding = "UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
				<head>
						<title>Orders</title>
				</head>
				<body>
					<xsl:for-each select="ArrayOfOrder/Order">
						<ul>
							<br/>
							<li>订单号：<xsl:value-of select="Number" /></li>
							<li>客户姓名：<xsl:value-of select="Customer" /></li>
              <li>客户电话：<xsl:value-of select="Phone" /></li>
							<li>总商品：<xsl:value-of select="AllGoods" /></li>
              <li>订单价格：<xsl:value-of select="AllPrice" /></li>
							<br/>
							<li>商品</li>
							<xsl:for-each select="goodsList/OrderDetails">
							<li>商品名称：<xsl:value-of select="Name" /></li>
							<li>商品单价：<xsl:value-of select="Price" /></li>
              <li>商品个数：<xsl:value-of select="Quantity" /></li>
							<br/>
							<br/>
							</xsl:for-each>
						</ul>
					</xsl:for-each>
				</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
