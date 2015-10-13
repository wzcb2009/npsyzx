<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebShow.aspx.vb" Inherits="Web.WebShow" %>

<%@ Register Src="~/Header2.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
 
        
    <link href="subStyle.css" rel="stylesheet" />       <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="//cdnjs.bootcss.com/ajax/libs/html5shiv/3.6.2/html5shiv.js"></script>
    <![endif]-->
   
    <link href="File/Style.css" rel="stylesheet" />
    <link href="Plugins/StarCss/StarStyle.css" rel="stylesheet" />
    <script src="Plugins/jwplayer6.5/jwplayer.js"></script>
    <script src="Plugins/swfobject/swfobject.js"></script>

     <script type="text/javascript">jwplayer.key = "JhoU+Cv8Ipm7fcSZKycXhX71c55TzKDoLUda4Q==";</script>


    <style>
        #mediaplayer {
       
        margin-left:auto;
         margin-right:auto;
         text-align:center;

        

        }
        .newscontent{
            padding:20px;
        }
        .newscontent img{
            clear: both;
display: block;
margin:auto; 

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
           
                <uc1:Header ID="Header1" runat="server" />
                                        <ul class="breadcrumb">
                            <asp:Literal ID="lt_sitenav" runat="server"></asp:Literal>
                        </ul>

                <div class="row">
                    <div class="span4">
                        <div class="well">
                            <ul class="nav nav-list">
                                
                                <asp:Literal ID="lt_nav" runat="server"></asp:Literal>
                            </ul>
                        </div>         

                    </div>
                    <div class="span16" id="maincontent" style="margin-left:0px; padding-left:20px; background-color:#ffffff">
                        <h3 class="text-center"  >
                            <asp:Literal ID="lt_title" runat="server"></asp:Literal></h3>
                        <p  class="text-center">
                            <small> <asp:Literal ID="lt_info" runat="server"></asp:Literal></small></p>
                        <div class="divider"></div>
                        <div class="newscontent"><p>
                            <asp:Literal ID="lt_content" runat="server"></asp:Literal>
                             </p>

                        </div>
                        <div>
                            <asp:Literal ID="lt_files" runat="server" EnableViewState="False"></asp:Literal>
                        </div>




                      




                    <asp:Literal ID="lt_Continer" runat="server"></asp:Literal>

                </div>

            </div>

        </div>
                <uc1:Footer ID="footer1" runat="server" />
    
    </form>
    <script src="plugins/raty-2.5.2/lib/jquery.raty.js"></script>
     <script>
         $(document).ready(function () {
             $(".well").height($("#maincontent").height());
             $('#myTab a').click(function (e) {
                 e.preventDefault();
                 $(this).tab('show');
             })
             $('.carousel').carousel()
  $('#star').raty({
             path: 'plugins/raty-2.5.2/lib/img/',
             click: function (score, evt) {
                 $("#txt_cent").val(score);

             }
         });
         });
       
        </script>

</body>
</html>
