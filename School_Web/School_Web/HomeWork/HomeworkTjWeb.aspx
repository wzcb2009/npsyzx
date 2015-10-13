<%@ Page Language="vb" AutoEventWireup="false" EnableViewStateMac="false"  CodeBehind="HomeworkTjWeb.aspx.vb" Inherits="Web.HomeworkTjWeb" %>

<form id="pagerForm" method="post" action="../homework/HomeworktjWeb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
	<input type="hidden" name="caseid" value="<%=Request.QueryString("caseid")%>" />
</form>

<div class="pageHeader">
	<form rel="pagerForm" runat="server" onsubmit="return navTabSearch(this);" action="../homework/HomeworktjWeb.aspx" method="post">
	<div class="searchBar">
        <table class="searchContent">
			<tr>
				<td class="dateRange">
					关键字:
					 <asp:dropdownlist id="classid" runat="server"></asp:dropdownlist>
				</td>
			 
				<td><div class="buttonActive"><div class="buttonContent"><button type="submit">检索</button></div></div></td>
			</tr>
		</table>
 		 
 	</div>
	</form>
</div>
<div class="pageContent">
	<div class="panelBar">
		<ul class="toolBar">			<li><a class="add" href="../homework/homeworkInfoweb.aspx?action=add&caseid=<%=Request.QueryString("caseid")%>" target="navTab" ><span>添加</span></a></li>

			<li><a title="确实要删除这些记录吗?" target="selectedTodo" rel="ids" href="../homework/homeworkdo.aspx?action=btdel&caseid=<%=Request.QueryString("caseid")%>" class="delete"><span>批量删除</span></a></li>
 			<li><a class="edit" href="../homework/homeworkinfoweb.aspx?action=mod&id={sid_user}&caseid=<%=Request.QueryString("caseid")%>" target="navTab" warn="请选择"><span>修改</span></a></li>
			<li><a class="edit" href="../comment/commentlistweb.aspx?parentid={sid_user}" target="dialog" warn="请选择一条记录"><span>查看评论</span></a></li>
			<li><a class="edit" href="../homework/homeworkdatalist.aspx?caseid=<%=Request.QueryString("caseid")%>&hwid={sid_user}" target="navTab" warn="请选择一条记录"><span>学生作业</span></a></li>
 		</ul>
	</div>
    <asp:literal id="listL" runat="server"></asp:literal>
	
 </div>
