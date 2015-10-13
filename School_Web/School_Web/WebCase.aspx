<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebCase.aspx.vb" Inherits="Web.WebCase" %>

<%@ Register Src="~/Header2.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>温州市南浦实验中学</title>
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
    <!--[if lt IE 9]>
      <script src="//cdnjs.bootcss.com/ajax/libs/html5shiv/3.6.2/html5shiv.js"></script>
    <![endif]-->

   <style>
       .newslist li {
 height: 35px;
    line-height: 35px;
border-bottom:dashed 1px #E5E5E5;
     overflow:hidden;
     text-overflow:ellipsis;
     white-space:nowrap;
}

   </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div>
                <uc1:Header ID="head1" runat="server" />
                                            <ul class="breadcrumb">
                                <asp:Literal ID="lt_sitenav" runat="server"></asp:Literal>
    </ul>

                <div class="row ">
                    <div class="span4">
                            <div class="well">
                                <ul class="nav nav-list ">

                               <asp:Literal ID="lt_nav" runat="server"></asp:Literal>
                          </ul>
</div>
                   

                        </div>
                    <div class="span16 " id="maincontent" style="margin-left:0px; padding-left:20px; background-color:#ffffff">
                       
                            
                                 <asp:PlaceHolder ID="PH" runat="server"></asp:PlaceHolder>
                                   
               
                        <div class="newscontent">
                            <p>
                        <asp:Literal ID="lt_Continer" runat="server"></asp:Literal></p>
</div>
                    </div>

                </div>
                
            </div>
        </div>
                <uc1:Footer ID="footer1" runat="server" />

    </form>
</body>
</html>
