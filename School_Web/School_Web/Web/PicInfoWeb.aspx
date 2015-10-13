<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PicInfoWeb.aspx.vb" Inherits="Web.PicInfoWeb" %>

 <h2 class="contentTitle">网站信息</h2>


<div class="pageContent">
	
	<form id="Form1" runat ="server"  method="post" action="../web/newsdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
				        <asp:hiddenfield id="Hd_action"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_caseid"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_id"  runat="server"></asp:hiddenfield>

        <div class="pageFormContent nowrap" layoutH="97">
           <p><label>标题：</label><asp:TextBox ID="txt_title" runat="server" size="30"   cssclass="required" ></asp:TextBox>
</p>
				 <p>
                      <asp:CheckBox ID="chk_Status" Checked="true" runat="server" Text="审核" />
				 </p>
            <p>
                <label>作者</label>
                <asp:TextBox ID="txt_author" runat="server" Width="50px"  ></asp:TextBox>
            </p>
         <p><asp:CheckBox ID="chk_right" runat="server" text="加密" />

         </p>
           <p>
               <asp:CheckBox ID="chk_cmd" runat="server" text="置顶"/>
           </p>
            <p>
                <label>浏览次数</label>
<asp:TextBox ID="txt_BrowCount" runat="server" Text="0" Width="50px" ></asp:TextBox>
            </p>
             <p>
                 <label>排序</label>
<asp:TextBox ID="txt_pindex" runat="server" Text="1000" Width="50px"></asp:TextBox>
             </p>
             <p>.
                 <label>上传日期</label><asp:TextBox ID="txt_pubdate" runat="server" Width="80px"></asp:TextBox>
             </p>
                                                
       <div style="clear: both"></div>
     <textarea  class="editor" name="txt_content" rows="12" cols="100"
								upLinkUrl="../web/upload.aspx" upLinkExt="zip,rar,txt,doc,docx,ppt,pptx,xls,xlsx" 
								upImgUrl="../web/upload.aspx" upImgExt="jpg,jpeg,gif,png" 
								upFlashUrl="../web/upload.aspx" upFlashExt="swf"
								upMediaUrl="../web/upload.aspx" upMediaExt:"avi,wmv,mpg,rm,rmvb">

		           
			<asp:literal id="lt_content" runat="server"></asp:literal>		</textarea> 
 
    
 
	 
		</div>
		<div class="formBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
	
</div>
