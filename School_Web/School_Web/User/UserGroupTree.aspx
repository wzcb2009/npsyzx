<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserGroupTree.aspx.vb" Inherits="Web.UserGroupTree" %>
<script>
    $(function () {
            var id;
            id = $("#txt_typeid").val();
            $("#evallink").html("<a rel='w_dialog' target='navTab' href='../eval/evalview.aspx?evalid="+ id +"'>预览</a>")

        $("#txt_typeid").change(function () {
            var id;
            id = $(this).val();
            $("#evallink").html("<a rel= target='navTab' href=\"javascript:navTab.openTab('w_dialog' ,\'../eval/evalview.aspx?evalid="+ id +"\', { title:\'预览量规表\', fresh:false, data:{} });\">预览</a>")
        });
    });
</script>
<div class="pageContent">
	<form id="Form1" method="post" runat ="server" action="../project/userprojectdo.aspx?action=rightset" class="pageForm required-validate" onsubmit="return validateCallback(this,dialogAjaxDone);">
        <h2 class="contentTitle">
    <asp:literal id="lt_title" runat="server"></asp:literal>
    评价量规表：<asp:literal id="txt_typeid" runat="server"></asp:literal><span id="evallink"></span></h2>
		<div class="pageFormContent" layoutH="96">
            <asp:hiddenfield id="ids" runat="server"></asp:hiddenfield>
            <asp:hiddenfield id="pindex" runat="server"></asp:hiddenfield>
            <asp:hiddenfield id="objid" runat="server"></asp:hiddenfield>
            <asp:hiddenfield id="EventCaseId" runat="server"></asp:hiddenfield>
    <asp:Literal ID="treel" runat="server"></asp:Literal>
</div>
		<div class="formBar">
			<ul>
				<!--<li><a class="buttonActive" href="javascript:;"><span>保存</span></a></li>-->
				<%If Request.QueryString("action") = "" Then%>
                <li><div class="buttonActive"><div class="buttonContent"><button type="submit">保存</button></div></div></li>
               <%Else%> 

                
                <li><div class="button"><div class="buttonContent"><button type="button" multLookup="ids" warn="请选择">选择带回</button></div></div></li>
				<%End If%>
                <li>
					<div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div>
				</li>
			</ul>
		</div>

	</form>
</div>

