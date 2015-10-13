<%@ Page Language="vb" AutoEventWireup="false" EnableViewState ="false"  CodeBehind="SystemCaseTree.aspx.vb" Inherits="Web.SystemCaseTree" %>

<div class="pageContent">
	<form method="post" runat ="server" action="../system/systemcasedo.aspx?action=rightset" class="pageForm required-validate" onsubmit="return validateCallback(this);">
		<div class="pageFormContent" layoutH="56">
    <asp:Literal ID="treel" runat="server"></asp:Literal>
</div>
		<div class="formBar">
			<ul>
				<!--<li><a class="buttonActive" href="javascript:;"><span>保存</span></a></li>-->
                
                <li><div class="button"><div class="buttonContent"><button type="button" multLookup="ids" warn="请选择部门">选择带回</button></div></div></li>
				<%If Request.QueryString("action") = "" Then%>
                <li><div class="buttonActive"><div class="buttonContent"><button type="submit">保存</button></div></div></li>
				<%End If%>
                <li>
					<div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div>
				</li>
			</ul>
		</div>
	</form>
</div>

