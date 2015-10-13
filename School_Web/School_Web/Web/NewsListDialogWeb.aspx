<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewsListDialogWeb.aspx.vb" Inherits="Web.NewsListDialogWeb" %>
 <style>
  .pageContent div.newscontent, .pageContent div.newscontent p {
        line-height:120%;
        font-size:14px;
        margin:10px; 

    
    
    }
     .pageContent p.newsinfo {
        margin-left:10px;
    
    
    }
</style>

<div class="pageContent"  style="padding:10px;"  layoutH="0">

    <ul  class="newslist">
     <asp:Literal ID="lt_newsbox" runat="server"></asp:Literal>  
   </ul>
   	
</div>
 