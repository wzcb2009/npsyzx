<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IndexLinkWeb.aspx.vb" Inherits="Web.IndexLinkWeb" %>
    <script src="../Plugins/ueditor/editor_config.js"></script>
    <script src="../Plugins/ueditor/editor_all.js"></script>

 <h2 class="contentTitle">网站信息</h2>


<div class="pageContent">
	
	<form id="Form1" runat ="server"  method="post" action="../web/contentdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
				        <asp:hiddenfield id="Hd_action"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_caseid"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_id"  runat="server"></asp:hiddenfield>
				       

        <div class="pageFormContent nowrap" layoutH="97">
   
            <p>
                <label>链接地址</label>
<asp:TextBox ID="txt_content" runat="server" Text=""  size="60" ></asp:TextBox>
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