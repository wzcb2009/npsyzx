<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LinkListWeb.aspx.vb" Inherits="Web.LinkListWeb" %>

<form id="pagerForm" method="post" action="../web/LinkListWeb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
</form>

<div class="pageHeader">
	<form rel="pagerForm" onsubmit="return navTabSearch(this);" action="../web/LinkListWeb.aspx" method="post">
	<div class="searchBar">
		<ul class="searchContent">
			<li>
				<label>关键字：</label>
				<input type="text" name="keywords" value=""/>
			</li>
			 
		</ul>
		 
		<div class="subBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">检索</button></div></div></li>
 			</ul>
		</div>
	</div>
	</form>
</div>
<div class="pageContent">
	<div class="panelBar">
		<ul class="toolBar">
			<li><a class="add" href="../web/linkInfoweb.aspx?action=add&caseid=<%=Request.QueryString("caseid")%>" target="navTab"><span>添加</span></a></li>
			<li><a title="确实要删除这些记录吗?" target="selectedTodo" rel="ids" href="../web/linkdo.aspx?action=btdel" class="delete"><span>批量删除</span></a></li>
 			<li><a class="edit" href="../web/linkinfoweb.aspx?action=mod&id={sid_user}&caseid=<%=Request.QueryString("caseid")%>"" target="navTab" warn="请选择"><span>修改</span></a></li>
  		</ul>
	</div>
    <asp:literal id="listL" runat="server"></asp:literal>
	
	<div class="panelBar">
		<div class="pages">
			<span>显示</span>
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

