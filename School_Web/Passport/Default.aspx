<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Passport._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>温州市南浦实验中学数字化校园统一认证登陆</title>
    <script src="Scripts/jquery-1.7.1.js"></script>   
    <script src="jquery.kinMaxShow-1.0.min.js"></script>

      <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="style.css" rel="stylesheet" />
          <!--[if lte IE 6]>
  <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-ie6.css">
  <![endif]-->
  <!--[if lte IE 7]>
  <link rel="stylesheet" type="text/css" href="bootstrap/css/ie.css">
  <![endif]-->
    <style type="text/css">
*{margin:0;padding:0;list-style-type:none;}
a,img{border:0;}
 
/* kinMaxShow */
#kinMaxShow{display:none;}
#kinMaxShow .sub_1_1{display:block;position:absolute;left:110px;top:136px;}
#kinMaxShow .sub_1_2{display:block;position:absolute;left:110px;top:120px;}

#kinMaxShow .sub_2_1{display:block;position:absolute;left:-160px;bottom:0px;}
#kinMaxShow .sub_2_2{display:block;position:absolute;left:110px;top:20px;}

#kinMaxShow .sub_3_1{display:block;position:absolute;right:180px;bottom:0px;}
#kinMaxShow .sub_3_2{display:block;position:absolute;left:30px;top:40px;}
</style>
<script type="text/javascript">
    $(function () {

        $("#kinMaxShow").kinMaxShow({

            height: 400,
            button: {
                showIndex: false,
                normal: { background: 'url(images/button.png) no-repeat -14px 0', marginRight: '8px', border: '0', right: '44%', bottom: '20px' },
                focus: { background: 'url(images/button.png) no-repeat 0 0', border: '0' }
            },

    


        });


    });

</script>   

</head>
<body style="margin:60px auto">
    <form id="form1" runat="server">
       <div class="header">
	<h1 class="headerLogo">
        <img src="images/logo.png" height="50" />
	</h1>
	

	<nav class="headerNav">
		<a target="_blank" href="../default.aspx">校园网</a> | <a target="_blank" href="../help">帮助</a> | <a target="_blank" href="../guestbook.aspx?caseid=1">在线答疑</a>
	</nav>
</div>
        <div>
            <div class="login">

      <div class="content">
        <div class="row">

          <!--left col-->
          <div class="span6">
    <div  >
   
<div class="item">
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</div>
 
 
 
<div class="item">
<asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
 
</div>
 
 
<div class="item" style="margin-left:145px; height:40px; line-height:40px;">

    <asp:ImageButton ID="Button1" runat="server" ImageUrl="images/loginbt.jpg" />
 
 
</div>
  
 
<div class="controls">
    <asp:Literal ID="lt_msg" runat="server"></asp:Literal>
</div>
</div>

         
    </div>
              </div>
           

          
          </div>
        </div>

      <div id="kinMaxShow">
	 
		<div>
			<img src="images/2.jpg"  />
			

		</div>
		<div>
			<img src="images/3.jpg"   />
			

		</div>
	</div>
      </div>
        <!--kinMaxShow end-->
        
  <footer class="footer" id="footer">
	<div id="footerInner" class="footer-inner">
		 
	 
		<nav class="footerNav">
			<a target="_blank" href="../default.aspx">技术支持：尚长科技</a>|<span class="copyright">温州市南浦实验中学版权所有&copy;2013-2014</span>
		</nav>
	</div>
</footer>
    </form>
</body>
</html>
