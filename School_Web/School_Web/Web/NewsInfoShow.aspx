<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewsInfoShow.aspx.vb" Inherits="Web.NewsInfoShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
     <link href="../File/Style.css" rel="stylesheet" />
</head>
<body style="margin:0px;">
    <form id="form1" runat="server">
    <div style="margin-bottom:30px;">
    <h2><asp:literal id="lt_title" runat="server"></asp:literal></h2>
     <p class="newsinfo"><asp:literal id="lt_info" runat="server"></asp:literal></p>
      <div class="newscontent"><asp:literal id="lt_content" runat="server"></asp:literal></div>
       </div>
                  <asp:literal id="lt_files" runat="server" EnableViewState="False"></asp:literal></div>

    </form>
</body>
</html>
