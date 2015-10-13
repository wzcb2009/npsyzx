<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LinkInfoWeb.aspx.vb" Inherits="Web.LinkInfoWeb" %>
 <h2 class="contentTitle">网站信息</h2>


<div class="pageContent">
	
	<form id="Form1" runat ="server"  method="post" action="../web/linkdo.aspx" enctype="multipart/form-data" class="pageForm required-validate" onsubmit="return iframeCallback(this);">
				        <asp:hiddenfield id="Hd_action"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_caseid"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_id"  runat="server"></asp:hiddenfield>
				       

        <div class="pageFormContent nowrap" layoutH="97">
           <p><label>标题：</label><asp:TextBox ID="txt_title" runat="server" size="30"   cssclass="required" ></asp:TextBox>
</p>
	           <p><label>网址：</label><asp:TextBox ID="txt_content"   runat="server" size="30"   cssclass="required url" ></asp:TextBox>
</p>			
                <p>
                 <label>排序：</label><asp:TextBox ID="txt_pindex" runat="server" Text="1000" Width="50px"></asp:TextBox>
             </p>
            <p>
				<label>图标：</label><input name="file1" type="file" /><asp:literal id="lt_file" runat="server"></asp:literal>
			</p>
 
             <p>
                      <asp:CheckBox ID="chk_Status" Checked="true" runat="server" Text="审核" />
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
