<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CommentListWeb.aspx.vb" Inherits="Web.CommentListWeb" %>
 <form id="pagerForm"  method="post" action="../Comment/CommentListWeb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
 </form>

<div class="pageHeader">
	<form rel="pagerForm" runat ="server"  onsubmit="return navTabSearch(this);" action="../Comment/CommentListWeb.aspx" method="post">
                <asp:hiddenfield id="hd_parentid" runat="server"></asp:hiddenfield>
	<div class="searchBar">
        <table class="searchContent">
			<tr>
				<td class="dateRange">
					评论内容:
					<input type="text" name="keywords" value=""/>
				 
				</td>
				 
				<td><div class="buttonActive"><div class="buttonContent"><button type="submit">检索</button></div></div></td>
			</tr>
		</table>
 		 
 	</div>
	</form>
</div>
<div class="pageContent">
	<div class="panelBar">
		<ul class="toolBar">
			<li><a class="add" width="750" rel="commentadd" href="../comment/commentinfoweb.aspx?action=add&parentid=<%=hd_parentid.Value%>" target="dialog"><span>添加</span></a></li>
			<li><a title="确实要删除这些记录吗?" target="selectedTodo" rel="ids" href="../comment/commentdo.aspx?action=multidel" class="delete"><span>批量删除</span></a></li>
			<li><a class="edit" href="../comment/commentinfoweb.aspx?action=mod&id={sid_user}" target="dialog" warn="请选择一个评语"><span>修改</span></a></li>
			<li class="line">line</li>
 		</ul>
	</div>
    <asp:literal id="listl" runat="server"></asp:literal>
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

