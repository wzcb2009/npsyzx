<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebSearch.aspx.vb" Inherits="Web.WebSearch" %>
<%@ Register Src="~/Header2.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="description" content="" />
    <meta name="author" content="" />
     <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
     <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap.css" rel="stylesheet" />
      <!--[if lte IE 6]>
 <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap-ie6.css" rel="stylesheet" />
  <![endif]-->
    <!--[if lte IE 7]><link rel="stylesheet" type="text/css" href="bootstrap/css/ie.css">
  
  <![endif]-->
    <link href="Style.css" rel="stylesheet" />
 
        
    <link href="subStyle.css" rel="stylesheet" />    
       <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
       <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="//cdnjs.bootcss.com/ajax/libs/html5shiv/3.6.2/html5shiv.js"></script>
    <![endif]-->


 </head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div>
                <uc1:Header ID="head1" runat="server" />
                                   <ul class="breadcrumb">
                                <li><a href="default.aspx">首页</a> <span class="divider">/</span></li>
                                 <li class="active"> <asp:Literal ID="lt_sitenav" runat="server"></asp:Literal></li>
                               
    </ul>         <div class="row">
                    <div class="span20">

                       
                            
                        <div class="newscontent">
                            
                            <asp:Literal ID="lt_list" runat="server"></asp:Literal>
                            
                            
</div><webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="pages" CurrentPageButtonClass="cpb" CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" CustomInfoSectionWidth="" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" NumericButtonCount="8" PrevPageText="上一页" ShowCustomInfoSection="Left" ShowPageIndexBox="Never" UrlPaging="True">
                            </webdiyer:AspNetPager>
                    </div>

                </div>
                
            </div>
        </div>
                <uc1:Footer ID="footer1" runat="server" />

    </form>
    



</body>
</html>
