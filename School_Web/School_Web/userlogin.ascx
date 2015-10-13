<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="userlogin.ascx.vb" Inherits="Web.userlogin" %>
<link href="JS/jquery_dialog.css" rel="stylesheet" type="text/css" />
<script src="JS/jquery_dialog.js" type="text/javascript"></script>
<script type="text/javascript">
    function openwin(url, title) {
        JqueryDialog.Open(title, url, 460, 450);

    }
 </script>
<asp:Panel ID="Panel1" runat="server"   CssClass="userinfo" >
<div class="form-horizontal">
 <div class="control-group">
<label class="control-label" for="UserName">用户名</label>
<div class="controls">
<asp:TextBox ID="UserName" runat="server" class="span3" Wrap="false"></asp:TextBox>
</div>
</div>
<div class="control-group">
<label class="control-label" for="Pwd">密码</label>
<div class="controls">
 <asp:TextBox ID="Pwd" runat="server" class="span3" TextMode="Password"></asp:TextBox>

</div>
</div>
<div class="control-group">
<div class="controls">
 <button type="submit" class="btn">登陆</button>
</div>
</div>
</div>
  </asp:Panel>
<asp:Panel ID="Panel2" runat="server"  Width="205px"><asp:Label ID="Label1"   Class="userinfo" runat="server" Text="Label"></asp:Label>
    
   <a href="javascript: JqueryDialog.Open('密码修改', 'admin/th_pwdmod.aspx', 400, 170);">修改密码</a>
   
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" CausesValidation="False">【安全退出】</asp:LinkButton> 
    <div>  <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="ActiveCaption">【进入管理中心】</asp:HyperLink></div>  
 </asp:Panel>
