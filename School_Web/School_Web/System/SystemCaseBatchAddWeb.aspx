<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SystemCaseBatchAddWeb.aspx.vb" Inherits="Web.SystemCaseBatchAddWeb" %>
<div class="pageContent">
	<form method="post"  runat="server" action="../system/systemcasedo.aspx" enctype="multipart/form-data" class="pageForm required-validate" onsubmit="return iframeCallback(this);">
		<div class="pageFormContent" layoutH="56">
            <input id="parentid" name="parentid" type="hidden" value="<%= ap.ID%>" />
            <input id="action" name="action" type="hidden" value="batchadd" />

			<p>
				<label>父类名称：</label>
                <asp:literal id="lt_casename" runat="server"></asp:literal>
			</p>
			<p>
				<label>Excel文件：</label>
				<input name="Filedata" type="file" />
			</p>
			<p>
                字段包括栏目名称、备注、状态
			</p>
		</div>
		<div class="formBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
</div>
