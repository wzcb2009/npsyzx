<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="StuBatchAddweb.aspx.vb" EnableViewStateMac="false"  Inherits="Web.StuBatchAddweb" %>
<div class="pageContent">
	<form method="post" id="bt1" runat="server" action="../user/stuBatchaddDo.aspx" enctype="multipart/form-data" class="pageForm required-validate" onsubmit="return iframeCallback(this);">
		<div class="pageFormContent" layoutH="56">
			<p>
				<label>Excel：</label>
				<input name="Filedata" type="file" />
			</p>
 			<p>
				<label>名单类型：</label>
                 <asp:dropdownlist runat="server" id="typeid">
                     <asp:ListItem Value="1">新增或换班名单</asp:ListItem>
                     <asp:ListItem Value="2">休学</asp:ListItem>
                </asp:dropdownlist>
			</p>
            <p>
                字段包括： 学号、姓名、性别、班级、年级
                
            </p>
            <p>
<a href='../user/userTempelte2.xls'>模板文件下载</a>
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
