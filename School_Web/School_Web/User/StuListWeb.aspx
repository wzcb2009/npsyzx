﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="StuListWeb.aspx.vb" EnableEventValidation="false" Inherits="Web.StuListWeb" %>
<script >
    function ss() {
        $(function () {
            $("#ssform", navTab.getCurrentPanel()
).submit();
        });
    }
</script>
<form id="pagerForm" method="post" action="../user/StuListWeb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />

</form>

<div class="pageHeader">
	<form rel="pagerForm" id="ssform" runat="server"  onsubmit="return navTabSearch(this);" action="../user/StuListWeb.aspx" method="post">
                	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
        	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />

	<div class="searchBar">
		<table class="searchContent">
			<tr>
				<td>关键字：</td>
				<td><input type="text" name="keywords" value=""/></td>
<td>年级：</td>
                <td><asp:dropdownlist id="txt_gradeid" runat="server" onchange=" ss()"></asp:dropdownlist></td>

                <td>班级：</td>
                <td><asp:dropdownlist id="txt_classid" runat="server" onchange=" ss()"></asp:dropdownlist></td>
                <td><div class="buttonActive"><div class="buttonContent"><button type="submit">检索</button></div></div></td>
			</tr>
          
           
           
		</table>
		 
	 
	</div>
	</form>
</div>
<div class="pageContent">
	<div class="panelBar">
		<ul class="toolBar">
            <asp:literal id="lt_toolbar" runat="server" EnableViewState="False"></asp:literal>
 		</ul>
	</div>
    <asp:literal id="listL" runat="server" EnableViewState="False"></asp:literal>
	
	<div class="panelBar">
		<div class="pages">
			<span>显示</span>
            <script>
                $(document).ready(function () {
                    $("select[name='numPerPage']").val(<%=pi.PageSize%>);
                });
            </script>
			<select class="combox" name="numPerPage" onchange="navTabPageBreak({numPerPage:this.value})">
				<option value="20">20</option>
				<option value="50">50</option>
				<option value="100">100</option>
				<option value="200">200</option>
			</select>
			<span>条，共<%=pi.TotalCount%>条</span>
		</div>
		
		<div class="pagination" targetType="navTab" totalCount="<%=pi.TotalCount%>" numPerPage="<%=pi.PageSize%>" pageNumShown="10" currentPage="<%=pi.PageIndex%>"></div>

	</div>
</div>

