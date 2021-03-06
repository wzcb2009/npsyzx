﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserPwd.aspx.vb" Inherits="Web.UserPwd" %>
 
  

 
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
    <script src="plugins/jquery.js"></script>
    <link href="my.css" rel="stylesheet" />


    <!-- Styles -->

    <link href="plugins/Validform/Validform_style.css" rel="stylesheet" />

 
     
    
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
    <li class="active">密码修改</li>
    </ul>
                      </div>
                      <div class="span3">
                              <ul class="nav nav-tabs nav-list nav-stacked bs-docs-sidenav">
                                <li ><a href="userindex.aspx"><h4>用户中心</h4></a></li>
                                <li><a href="userinfolist.aspx"><i class="icon-chevron-right"></i>我的作业</a></li>
                                   
                                  <li  class="active"><a href="userpwd.aspx" class="active"><i class="icon-chevron-right"></i>登陆密码设置</a></li>
                                  <li><a href="userinfo.aspx"><i class="icon-chevron-right"></i>个人信息设置</a></li>
                                 <li><a href="userface.aspx"><i class="icon-chevron-right"></i>用户头像</a></li>
   
    </ul>
                      </div>
                      
                      <div class="span9">
                                          <div class="row">

                    <!--left col-->
                    <div class="span9 form-horizontal">
                         <div class="formsub">
                               <fieldset>
          <legend>用户密码修改</legend>

                              <div class="control-group">
            <label class="control-label" >用户名</label>
            <div class="controls">
                <%=Session("UserName")%>
              <span class="help-inline Validform_checktip"></span>
            </div>
          </div>
                                                                                       <div class="control-group">
            <label class="control-label" >旧密码</label>
            <div class="controls">
 <input type="text" value="" name="txt_pwdold" class="inputxt" datatype="s6-16" errormsg="密码范围在6~16位之间！" />           
                   <span class="help-inline Validform_checktip">密码范围在6~16位之间</span>
            </div>
          </div>

                                                    <div class="control-group">
            <label class="control-label" >新密码</label>
            <div class="controls">
 <input type="text" value="" name="txt_pwd" class="inputxt" datatype="s6-16" errormsg="密码范围在6~16位之间！" />           
                   <span class="help-inline Validform_checktip">密码范围在6~16位之间</span>
            </div>
          </div>
                                     <div class="control-group">
            <label class="control-label" >再次新密码</label>
            <div class="controls">
                                    <input type="text" value="" name="txt_pwd2" class="inputxt" datatype="*" recheck="txt_pwd" nullmsg="请再输入一次密码！" errormsg="您两次输入的账号密码不一致！" />
                   <span class="help-inline Validform_checktip">两次输入密码需一致</span>
            </div>
          </div>
                                     <div class="form-actions">
            <button type="submit" class="btn btn-warning">保存更改</button>
            <button class="btn" type="reset" >取消</button>
          </div>

</fieldset>
                         

                        </div>
                    </div>
                    
                </div>

                      </div>
                  </div>

                

             
            <uc1:footer runat="server" ID="footer" />
        </div>

    </form>
           <script src="plugins/Validform/Validform_v5.3.2.js"></script>

  
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
