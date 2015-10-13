<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GuestBookInfoWeb.aspx.vb" Inherits="Web.GuestBookInfoWeb" %>

<!DOCTYPE html>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="margin:0px;">
     <h2 class="contentTitle">问题反馈</h2>


<div class="pageContent">
	
	<form id="Form1" runat="server">
				        <asp:hiddenfield id="Hd_action"  runat="server"></asp:hiddenfield>
				        <asp:hiddenfield id="hd_caseid"  runat="server"></asp:hiddenfield>
                <div class="pageFormContent nowrap" layoutH="97">
           <p><label>您的问题 </label><asp:TextBox ID="txt_title" runat="server" size="30"   cssclass="required" ></asp:TextBox>
</p>
            <p>
                <label>联系姓名</label>
                <asp:TextBox ID="txt_author" runat="server"></asp:TextBox>

            </p>
            <p>
                <label>联系电话</label>
                <asp:TextBox ID="txt_tel" runat="server"></asp:TextBox>
             </p>
                <p>
   <asp:TextBox ID="txt_content" runat="server" Height="92px" TextMode="MultiLine" Width="416px"></asp:TextBox>

                </p>  
                    <p>
<asp:Button ID="Button1" runat="server" Text="提交问题" />
                    </p>  
                    
    
 
	 
		</div>
	 
	</form>
	
</div>
   
</body>
</html>
