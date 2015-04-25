<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!-- http://jstl.java.net/ tuleb tommata ja WEB-INF/lib kataloogi et yloemine rida toimiks -->
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="idu0080.veebitoorik.web.data.*"  %>    
<%@ page import="java.util.*"  %>   
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Invoice page</title>
</head>
<body>
<a href=index.html>index</a><br><br>
<script>
function select_product(product_id)
{
	document.forms[0].selected_product_id.value=product_id;
	document.forms[0].s_product_name.value="";
	document.forms[0].submit();
	}
	

</script>



<form action=invoice method="post">
<% 

String s_product_name = null;
String s_customer_name = null;
String selected_product_id = null;
String selected_customer_id = null;
Product selected_product = null;



if (request.getAttribute("selected_product_id")!=null)
{
	selected_product_id = (String) request.getAttribute("selected_product_id");
}
else
{
	selected_product_id = "";
}


if (request.getAttribute("selected_customer_id")!=null)
{
	selected_customer_id = (String) request.getAttribute("selected_customer_id");
}
else
{
	selected_customer_id = "";
}


if (request.getAttribute("s_product_name")!=null)
{
	s_product_name = (String) request.getAttribute("s_product_name");
}
else
{
	s_product_name = "";
}
if (request.getAttribute("s_customer_name")!=null)
{
	s_customer_name = (String)  request.getAttribute("s_customer_name");
}
else
{
	s_customer_name = "";
}


%>
<table border=0 cellpadding=0 cellspacing=0>
<tr><td bgcolor=#ccccccc colspan=2>Otsinguvorm (toode, klient)</td><tr>
<tr><td bgcolor=#ccccccc>Toote nimi:</td><td><input type=text name=s_product_name value="<%=s_product_name%>"> [sisesta: ükskõik mida, kui sisestad 'no' siis ei leita midagi]</td></tr>
<tr><td bgcolor=#ccccccc>Kliendi nimi:</td><td><input type=text name=s_customer_name value="<%=s_customer_name%>"> [sisesta: Axelor, Agrolait, Maxtor või ASUStek]</td></tr>
<tr><td bgcolor=#ccccccc colspan=2><input type=submit value="Otsi"></td></tr>
</table>

<input type=hidden name=selected_product_id value="<%=selected_product_id%>">
<input type=hidden name=what_to_do value="">

<table>
<c:if test="${not empty received_products}">
<tr><td colspan=2>Toote otsingu tulemused:</td></tr>
</c:if>
<c:forEach var="product" items="${received_products}">
 <tr><td><c:out value="${product.id}"/></td><td><a href="<c:out value="javascript:select_product(${product.id})"/>"><c:out value="${product.name}"/></a></td></tr>
 </c:forEach>
 </table>


<br><br><br>
<hr>
<%
out.println("<table><tr><td bgcolor=#ccccccc colspan=3 align=center>Uus arve</td></tr>");
if (request.getAttribute("selected_product")!=null)
{
	
	selected_product = (Product) request.getAttribute("selected_product");
	out.println("<tr><td bgcolor=#ccccccc>Valitud toode:</td><td>" + selected_product.getName() + "</td><td></td>" );

}



if (request.getAttribute("received_customer") != null)
{
	Customer received_customer = (Customer) request.getAttribute("received_customer");
    out.println("<tr><td bgcolor=#ccccccc>Valitud klient:</td><td colspan=3>[id: " + Integer.toString(received_customer.getId()) +  "] name:" + received_customer.getName() );
	out.println("</td></tr>");
}

if ((request.getAttribute("selected_product")!=null) && (request.getAttribute("received_customer")!=null))
{




	out.println("<tr><td colpsan=2>Product ja Customer on mõlemad valitud - siia joonistan arve tegemise vormi ülejäänud osa</td></tr>");


    

}

out.println("</table>");	

%>
<hr>

 
</form>


</body>
</html>