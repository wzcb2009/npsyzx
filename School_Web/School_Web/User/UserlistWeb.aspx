<%@ Page Language="vb" AutoEventWireup="false"   CodeBehind="UserlistWeb.aspx.vb" Inherits="Web.UserlistWeb" %>
<script >
    function ss() {
        $(function () {
            $("#userssform", navTab.getCurrentPanel()
).submit();
        });
    }
</script>
<form id="pagerForm" method="post" action="../user/userlistweb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />

</form>

<div class="pageHeader">
	<form rel="pagerForm" runat="server" id="userssform"  onsubmit="return navTabSearch(this);" action="../user/userlistweb.aspx" method="post">
                	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
        	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />

	<div class="searchBar">
		<ul class="searchContent">
			<li>
				<label>关键字：</label>
				<input type="text" name="keywords" value=""/>
                 
			</li>
            <div >
            <li>
				<label>角色：</label>
                <asp:dropdownlist id="txt_roleid" runat="server" onchange="ss()"></asp:dropdownlist>

			</li>
                     <%--   <li>
				<label>职称：</label>
                <asp:dropdownlist id="txt_zcid" runat="server"></asp:dropdownlist>

			</li>
                        <li>
				<label>学院：</label>
                <asp:dropdownlist id="txt_collegeid" runat="server"></asp:dropdownlist>

			</li>--%>
</div>
			<li>
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
            <asp:literal id="lt_toolbar" runat="server" EnableViewState="False"></asp:literal>
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

