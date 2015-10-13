<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewsListWeb.aspx.vb" Inherits="Web.NewsListWeb" %>
 
<script >
    function ss() {
        $(function () {
            $("#userssform", navTab.getCurrentPanel()
).submit();
        });
    }
</script>
<form id="pagerForm" method="post" action="../web/newslistweb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
 
</form>

<div class="pageHeader">
	<form rel="pagerForm" runat="server" id="userssform"  onsubmit="return navTabSearch(this);" action="../web/newslistweb.aspx" method="post">
                	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
        	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />

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
		<ul class="toolBar">			<li><a class="add" href="../web/newsInfoweb.aspx?action=add&caseid=<%=Request.QueryString("caseid")%>" target="navTab" ><span>添加</span></a></li>

			<li><a title="确实要删除这些记录吗?" target="selectedTodo" rel="ids" href="../web/newsdo.aspx?action=btdel&caseid=<%=Request.QueryString("caseid")%>" class="delete"><span>批量删除</span></a></li>
 			<li><a class="edit" href="../web/NewsInfoWeb.aspx?action=mod&id={sid_user}&caseid=<%=Request.QueryString("caseid")%>" target="navTab" warn="请选择"><span>修改</span></a></li>
			<li><a class="edit" href="../comment/commentlistweb.aspx?parentid={sid_user}" target="dialog" warn="请选择一条记录"><span>查看评论</span></a></li>
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


