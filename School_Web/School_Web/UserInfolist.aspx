<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserInfolist.aspx.vb" Inherits="Web.UserInfolist" %>

  <%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>


<!DOCTYPE html PUBLIC "-//W3C//labelD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/labelD/xhtml1-transitional.labeld">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>发动机原理及汽车理论 </title>
         <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Plugins/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Plugins/bootstrap/css/bootstrap-responsive.css" rel="stylesheet" />
    <!--[if lte IE 6]>
  <link rel="stylesheet" type="text/css" href="Plugins/bootstrap/css/bootstrap-ie6.css"/>
  <link rel="stylesheet" type="text/css" href="Plugins/bootstrap/css/ie.css"/>
  <![endif]-->
    <link href="Style.css" rel="stylesheet" />
       <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="//cdnjs.bootcss.com/ajax/libs/html5shiv/3.6.2/html5shiv.js"></script>
    <![endif]-->

    <link href="subStyle.css" rel="stylesheet" />
     <link href="my.css" rel="stylesheet" />




 
     
    
</head>
 
<body>
    <form id="form1" class="registerform" runat="server" action="user/userjson.aspx">
        <input id="action" type="hidden" name="action" value="modpwd" />
       
        <%--   <script src="js/Alabelop.js" type="text/javascript"></script>--%>
        <div class="container">
            <uc1:head runat="server" ID="head" />
            

                
                  <div class="row">
                      <div class="span12">
                           <ul class="breadcrumb">
    <li><a href="#">首页</a> <span class="divider">/</span></li>
    <li><a href="#">用户中心</a> <span class="divider">/</span></li>
    <li class="active">我的作业</li>
    </ul>
                      </div>
                      <div class="span3">
                              <ul class="nav nav-tabs nav-list nav-stacked bs-docs-sidenav">
                                                                  <li ><a href="userindex.aspx"><h4>用户中心</h4></a></li>
                                  <li class="active"><a href="userinfolist.aspx"><i class="icon-chevron-right"></i>我的作业</a></li>
                                   
                                  <li><a href="userpwd.aspx"><i class="icon-chevron-right"></i>登陆密码设置</a></li>
                                  <li><a href="userinfo.aspx"><i class="icon-chevron-right"></i>个人信息设置</a></li>
                                 <li><a href="userface.aspx"><i class="icon-chevron-right"></i>用户头像</a></li>
    
    </ul>
                      </div>
                      
                      <div class="span9">
                                          

                                                      <div>
                                <div class="clear"></div>
                                <table class=" table" cellspacing="0" cellpadding="0" border="0">
                                    <thead>
                                        <tr>
                                            <th width="30">序号</th>
                                            <th width="300">作业标题</th>

                                            <th width="60" align="center">满分</th>

                                            <th width="80" align="center">截至日期</th>
                                            <th width="80" align="center">上交作业</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Literal ID="lt_infolist" runat="server"></asp:Literal>

                                        <%--		                  <script language="JavaScript" type="text/javascript" src="Js_newslist.aspx?caseid=39&amp;titlelength=46&amp;rowcount=9&amp;time=s&amp;newlen=5"></script>--%>
                                    </tbody>
                                </table>
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" UrlPaging="True" CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" ShowCustomInfoSection="Left" ShowPageIndexBox="Never" CssClass="pages" CurrentPageButtonClass="cpb" CustomInfoSectionWidth="" NumericButtonCount="8"></webdiyer:AspNetPager>

                            </div>

                      </div>
                  </div>

                

             
            <uc1:footer runat="server" ID="footer" />
        </div>

    </form>
    
        <script src="plugins/Validform/Validform_v5.3.2.js"></script>
    <link href="plugins/Validform/Validform_style.css" rel="stylesheet" />
 
    <script type="text/javascript">
        $(function () {
            //$(".registerform").Validform();  //就这一行代码！;

            var demo = $(".registerform").Validform({
                tiptype: 3,
                label: ".label",
                showAllError: true,
                ajaxPost: true,
                callback: function (data) {
                    window.location = "userpwd.aspx"
                }
            });
        });
    </script>

</body>
</html>
