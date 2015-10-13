<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SystemCaseListWeb.aspx.vb" Inherits="Web.SystemCaseListWeb" %>
 <script>
   

     // Drag & Drop Example Code
     $("table.treetable .file, table.treetable .folder" ).draggable({
         helper: "clone",
         opacity: .75,
         refreshPositions: true,
         revert: "invalid",
         revertDuration: 300,
         scroll: true
     });

     $("table.treetable .folder,table.treetable .file" ).each(function () {
         $(this).parents("tr").droppable({
             accept: ".file, .folder",
             drop: function (e, ui) {
                 var droppedEl = ui.draggable.parents("tr");
                 var obj1, obj2;
                 obj1 = droppedEl.data("ttId");
                 obj2 = $(this).data("ttId");
                 $.post("../system/systemcasedo.aspx?action=move",
                     { "caseid": droppedEl.data("ttId"), "parentid": obj2 },
                     function (json) {
                         DWZ.ajaxDone(json);

                         if (json.statusCode == DWZ.statusCode.ok) {
                             $("table.treetable").treetable("move", obj1, obj2);

                         }


                     }, "json")
             },
             hoverClass: "accept",
             over: function (e, ui) {
                 //var droppedEl = ui.draggable.parents("tr");
                 //if (this != droppedEl[0] && !$(this).is(".expanded")) {
                 //    $("table.treetable").treetable("expandNode", $(this).data("ttId"));
                 //}
             }
         });
     });
 </script>
<form id="pagerForm" method="post"action="../system/systemcaselistweb.aspx">
	<input type="hidden" name="pageNum" value="<%=pi.PageIndex%>" />
	<input type="hidden" name="numPerPage" value="<%=pi.PageSize%>" />
	<input type="hidden" name="orderField" value="<%=pi.orderField%>" />
	<input type="hidden" name="orderDirection" value="<%=pi.orderDirection%>" />
	<input type="hidden" name="caseid" value="<%=Request("caseid")%>" />
	<input type="hidden" name="parentid" value="<%=Request("parentid")%>" />
</form>
<div class="pageHeader">
	<form rel="pagerForm" onsubmit="return navTabSearch(this);"  runat="server"  action="../system/systemcaselistweb.aspx" method="post">
	<div class="searchBar">
		<ul class="searchContent">
			<li>
				<label>名称：</label>
				<input type="text" name="keywords" value=""/>
			</li>
			<li>
			
			</li>
		</ul>
        <input   name="caseid" value ="<%=Request("caseid")%>" type="hidden" />
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
            <asp:literal runat="server" id="lt_toolbar" EnableViewState="False"></asp:literal>
			 </ul>
	</div>
    <asp:literal id="listl" runat="server" EnableViewState="False"></asp:literal>
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
