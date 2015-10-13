<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm4.aspx.vb" Inherits="Web.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>jQuery图片在浏览器窗口飘动</title>
 <style type="text/css">
   #img{
        position: absolute;
        background:url(http://img.blog.csdn.net/20130614153212421) no-repeat;
        width:275px;
        height:160px;
 }
 #img a{
 text-decoration: none;
 color:green;
 display:block;
 text-align: center;
 line-height: 20px;
   padding:55px 5px;
 }
 #img .reset{
    position: absolute;
    top:5px;
    right:5px;
    font-size: 11px;
 }
 </style>

<script language="javascript" type="text/javascript">
    /*
    *   jQuery Plugins imgFloat v1011
    * 使用说明：
    *   speed //元素移动速度
    *   xPos  //元素一开始左距离
    *   yPos  //元素一开始上距离
    *   $('#div1').imgFloat({speed:30,xPos:10,yPos:10});  
    *   $('#div2').imgFloat();   //不给参数默认（speed:15,xPos:0,yPos:0）                     
    */

    (function ($) {

        jQuery.fn.imgFloat = function (options) {
            var own = this;
            var xD = 0;
            var yD = 0;
            var i = 1;
            var settings = {
                speed: 15,
                xPos: 0,
                yPos: 0
            };
            jQuery.extend(settings, options);
            var ownTop = settings.xPos;
            var ownLeft = settings.yPos;
            own.css({
                position: "absolute",
                cursor: "pointer"
            });
            function imgPosition() {
                var winWidth = $(window).width() - own.width();
                var winHeight = $(window).height() - own.height();
                if (xD == 0) {
                    ownLeft += i;
                    own.css({
                        left: ownLeft
                    });
                    if (ownLeft >= winWidth) {
                        ownLeft = winWidth;
                        xD = 1;
                    }
                }
                if (xD == 1) {
                    ownLeft -= i;
                    own.css({
                        left: ownLeft
                    });
                    if (ownLeft <= 0) xD = 0;
                }
                if (yD == 0) {
                    ownTop += i;
                    own.css({
                        top: ownTop
                    });
                    if (ownTop >= winHeight) {
                        ownTop = winHeight;
                        yD = 1;
                    }
                }
                if (yD == 1) {
                    ownTop -= i;
                    own.css({
                        top: ownTop
                    });
                    if (ownTop <= 0) yD = 0;
                }
            }
            var imgHover = setInterval(imgPosition, settings.speed);
            own.hover(function () {
                clearInterval(imgHover);
            },
            function () {
                imgHover = setInterval(imgPosition, settings.speed);
            });
        }
    })(jQuery);
</script>
</head>
 
<body>
<div id="img">
 <a href="" target="_blank">高新城创建设投资有限公司专业技术人员招聘简章 </a>
    <div class="reset">关闭&times;</div>
</div>

<script language="javascript" type="text/javascript">
    //$("#img").imgFloat();   //不给参数默认（speed:10,xPos:0,yPos:0） 
    $("#img").imgFloat({ speed: 15, xPos: 10, yPos: 10 });
    $(".reset").click(function () {
        $("#img").css("display", "none");
    });
</script> 
</body>
</html>
