<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LoginWeb.aspx.vb" Inherits="Web.LoginWeb" %>

<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>发动机原理及汽车理论 </title>
      <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Plugins/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Plugins/bootstrap/css/bootstrap-responsive.css" rel="stylesheet" />
 <!--[if lte IE 6]>
     <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap-ie6.css" rel="stylesheet" />
     <link href="Plugins/ddouble-bsie/bootstrap/css/ie.css" rel="stylesheet" />
   <![endif]-->
            <link href="Style.css" rel="stylesheet" />
    <link href="subStyle.css" rel="stylesheet" />
        <link href="plugins/Validform/Validform_style.css" rel="stylesheet" />



    <!-- Le HTML5 shim, for IE6-8 support of HTML elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Styles -->


  
    <!--[if lt IE 9]>
  <link rel="stylesheet" type="text/css" href="css/custom-theme/jquery.ui.1.9.2.ie.css"/>
  <![endif]-->
    <style>
       

        .formsub label {
            display: inline-block;
            width: 100px;
        }

        .action {
            padding-left: 92px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" action="user/userjson.aspx?action=login" class="registerform">
                
        <div class="container">
        <uc1:head runat="server" ID="head" />   
             <div>
                <div class="page-header">
                    <h2>用户登陆</h2>
                </div>
                <div class="row">

                    <!--left col-->
                    <div class="span6">
                         <div class="formsub">
                            <ul>
                                <li>
                                    <label>  用户名：</label>
                                    <input type="text" value="" name="txt_username" class="inputxt"   datatype="*" errormsg="请输入用户名" />

                                    
                                </li>
                                <li>
                                    <label>  密码：</label>

                                    <input type="password" value="" name="txt_pwd" class="inputxt" datatype="*" errormsg="请输入密码" />
                                   
                                </li>
                                <li>
                                    <label>   </label>
 
                                <input type="submit" value="提 交" class="btn btn-warning" />
                                <input type="reset" value="重 置" class="btn" />
                             
                                   
                                   
                                </li>

                            </ul>
                           

                        </div>
                    </div>
                    <div class="span4">用户为学号，密码与学号相同！</div>
                </div>
            </div>
          <uc1:footer runat="server" ID="footer" />
      </div>
       
     </form>
           
     <script src="Plugins/Validform/Validform_v5.3.2.js"></script>
 
    <script type="text/javascript">
        $(function () {
            //$(".registerform").Validform();  //就这一行代码！;
            var relUrl = "<%=urlstr%>";
            var other = "<%=otherPage%>" ;
            var demo = $(".registerform").Validform({
                tiptype: 1,
                label: ".label",
                showAllError: true,
                ajaxPost: true,
                callback: function (data) {
                    if (data.status == "y") {
                        if (relUrl == "") {
                            window.location = "userindex.aspx"

                        } else {
                            if (other=="True"  ) {
                                window.location = relUrl;
                            
                            }else{
                                  window.location = "userindex.aspx"
                      
                            }

                        }
                    } 
                   
                }
            });
        });
    </script>
</body>
</html>
