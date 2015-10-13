<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="Web._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>网站管理后台登陆</title>
    <script src="Plugins/fancyBox/lib/jquery-1.8.2.min.js"></script>
    	<script type="text/javascript" src="Plugins/fancyBox/source/jquery.fancybox.js?v=2.1.3"></script>
	<link rel="stylesheet" type="text/css" href="Plugins/fancyBox/source/jquery.fancybox.css?v=2.1.2" media="screen" />

<link href="admin/themes/css/login.css" rel="stylesheet" type="text/css" />
         <script type="text/javascript">
             $(function () {
                 $('.fancybox').fancybox({
                      
                 });
                
                 $(".sub").click(function () {
                     var username, pwd;
                     username = $("#username").val();
                     pwd = $("#password").val();
                     $.post("user/UserLogindo.aspx",
                   { "username": username, "pwd": pwd, action: "login" },
                   function (data) {

                       if (data.result == "ok") {
                           window.location = "admin/default.aspx"
                       } else {

                           alert(data.result);
                       }

                   },
                   "json");


                 }

              );


             })
             $(function(){
                 document.onkeydown = function(e){
                     var ev = document.all ? window.event : e;
                     if(ev.keyCode==13) {
                          
                             var username, pwd;
                             username = $("#username").val();
                             pwd = $("#password").val();
                             $.post("user/UserLogindo.aspx",
                           { "username": username, "pwd": pwd, action: "login" },
                           function (data) {

                               if (data.result == "ok") {
                                   window.location = "admin/default.aspx"
                               } else {

                                   alert(data.result);
                               }

                           },
                           "json");


                         
                         }
                 }
             }); 
</script>
    <style>
        .login_input {
            width:150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<div id="login">
		<div id="login_header">
			<h1 class="login_logo">
				<a href="default.aspx"><img src="admin/themes/default/images/login_logo.gif" /></a>
			</h1>
			<div class="login_headerContent">
				<div class="navList">
					<ul>
						<li><a href="#" onclick="this.style.behavior='url(#default#homepage)';this.setHomePage('http://www.npsyzx.net');" >设为首页</a></li>
						<li><a href="javascript:window.external.AddFavorite('http://www.npsyzx.net', '温州市南浦实验中学')" target="_blank">加入收藏</a></li>
 					 
					</ul>
				</div>
				<h2 class="login_title"><img src="admin/themes/default/images/login_title.png" /></h2>
			</div>
		</div>
		<div id="login_content">
			<div class="loginForm">
				 
					<p>
						<label>管理员：</label>
						<input type="text" name="username"  id="username"  size="20" value="" class="login_input" />
					</p>
					<p>
						<label>密　码：</label>
						<input type="password" name="password" id="password" size="20" value="" class="login_input" />
					</p>
					<!--<p>
						<label>验证码：</label>
						<input class="code" type="text" size="5" />
						<span><img src="themes/default/images/header_bg.png" alt="" width="75" height="24" /></span>
					</p>-->
					<div class="login_bar">
                      　
					<input class="sub" type="button" value=" " />
					</div>
				 
			</div>
			<div class="login_banner"><img src="admin/themes/default/images/login_banner.jpg" /></div>
			<div class="login_main">
				<ul class="helpList">
                    <asp:Literal ID="lt_news" runat="server"></asp:Literal>
  
				</ul>
				<div class="login_inner">
 
					 
				</div>
			</div>
		</div>
		<div id="login_footer">
			Copyright &copy; 2013 www.npsyzx.net Inc. All Rights Reserved.
		</div>
	</div>

    </div>
    </form>
</body>
</html>
