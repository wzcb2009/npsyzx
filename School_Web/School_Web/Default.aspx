
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="Web.Index" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register src="~/userlogin.ascx" tagname="userlogin" tagprefix="uc3" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>温州市南浦实验中学</title>
        <meta name="description" content=""/>
    <meta name="author" content=""/>
     <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
     <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap.css" rel="stylesheet" />
      <!--[if lte IE 6]>
 <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap-ie6.css" rel="stylesheet" />
  <![endif]-->
    <!--[if lte IE 7]><link rel="stylesheet" type="text/css" href="bootstrap/css/ie.css">
  
  <![endif]-->
    <link href="Style.css" rel="stylesheet" />
 
        
    <link href="subStyle.css" rel="stylesheet" />
 
    <style type="text/css">
#banner {position:relative; width:340px; height:230px; border:1px solid #666; overflow:hidden; font-size:16px} 
#banner_list img {border:0px;} 
#banner_bg {position:absolute; bottom:0;background-color:#000;height:30px;filter: Alpha(Opacity=30);opacity:0.3;z-index:1000;cursor:pointer; width:478px; } 
#banner_info{position:absolute; bottom:4px; left:5px;height:22px;color:#fff;z-index:1001;cursor:pointer} 
#banner_text {position:absolute;width:120px;z-index:1002; right:3px; bottom:3px;} 
#banner ul {position:absolute;list-style-type:none;filter: Alpha(Opacity=80);opacity:0.8; z-index:1002; 
margin:0; padding:0; bottom:3px; right:5px; height:20px} 
#banner ul li { padding:0 8px; line-height:18px;float:left;display:block;color:#FFF;border:#e5eaff 1px solid;background-color:#6f4f67;cursor:pointer; margin:0; font-size:16px;} 
#banner_list a{position:absolute;}

    </style> 
    <link href="Plugins/Slider.css" rel="stylesheet" />
    <link href="Plugins/jquery.slideBox.css" rel="stylesheet" />
     <style type="text/css">
*{margin:0; padding:0;}
li{list-style:none;}
 .scrollNews{
 width:260px;
 height:200px;
 line-height:100px;
 overflow:hidden;
 
}
.scrollNews ul{width:260px; margin-top:10px; height:200px }
 .scrollNews li{
 height:100px;  margin-right:5px; display:inline;
 text-align:center;
}
  .scrollNews li img{
      width:260px;
      height:190px;
      margin:5px;
  }
</style>

 <style type="text/css">
     #img{
        position: absolute;
        background:url(images/ad.png) no-repeat;
        width:243px;
        height:115px;
        z-index:9999;
         top: 0px;
         left: 0px;
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

</head>
<body>
 <%--<div id="img"  style="display" >
 <a href="/zs" target="_blank" style="display:block; width:243px; height:100px;">  </a>
    <div class="reset">关闭&times;</div>
</div>--%>
    <form id="form1" runat="server">
    <div class="container">
        <uc1:Header runat="server" ID="Header" />
 
        <div class="row">
      <div class="span15">
          <div style="margin-bottom:10px;"></div>
                   <div class="row">
                    <div class="span7">
                    <%Web.flog_class.Debug("lt_hotnews")%>
                        <asp:Literal ID="lt_hotnews" runat="server"></asp:Literal>
                      <script type="text/javascript">




	var focus_width = 335
	var focus_height = 230
	var text_height = 18
	var swf_height = focus_height + text_height




	document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + focus_width + '" height="' + swf_height + '">');
	document.write('<param name="allowScriptAccess" value="sameDomain"><param name="movie" value="focus.swf"><param name="quality" value="high"><param name="bgcolor" value="#F0F0F0">');
	document.write('<param name="menu" value="false"><param name=wmode value="opaque">');
	document.write('<param name="FlashVars" value="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '">');
	document.write('<embed src="focus.swf" wmode="opaque" FlashVars="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '" menu="false" bgcolor="#ffffff" quality="high" width="' + focus_width + '" height="' + swf_height + '" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />'); document.write('</object>');
                      </script>
                     </div>
                    <div class="span7  ">
                        <div class="" style="height:230px;">
                        <%Web.flog_class.Debug("myTab")%>
                             <ul id="myTab" class="nav nav-tabs">
              <li class="active"><a href="#home" data-toggle="tab">校园快讯</a></li>
              <li><a href="#profile" data-toggle="tab">校务公开</a></li>
               

            
            </ul>
                       
                        
                         <div id="myTabContent" class="tab-content" style="padding:5px;">
              <div class="tab-pane fade in active" id="home">
                                           <div class="newslist" style="border:none">
                                   <asp:Literal ID="lt_xykx" runat="server"></asp:Literal>
                                </div>

               </div>
              <div class="tab-pane fade" id="profile">
                                    <asp:Literal ID="lt_xwgk" runat="server"></asp:Literal>
              </div>
         

            </div>
                            </div>
                    </div>
                       
                    </div>
          <div class="row">

          <div class="span15">
                                           


                <div class="row boxspace"> 
                    <div class="span7" style="width:345px;"  >
                        
                             <ul id="myTab2" class="nav nav-tabs">
              <li class="active"><a href="#home1" data-toggle="tab">教育科研</a></li>
              <li><a href="#profile1" data-toggle="tab">德育星空</a></li>
                   <li><a href="#dropdown1" data-toggle="tab">党建之窗</a></li> 
            
            </ul>
                        
                        
                         <div id="myTabContent2" class="tab-content" style="padding:5px;">
              <div class="tab-pane fade in active" id="home1">
                                           <div class="newslist" style="border:none">
                                    <asp:Literal ID="lt_jyky" runat="server"></asp:Literal>
                                </div>

               </div>
              <div class="tab-pane fade" id="profile1">
                                  <asp:Literal ID="lt_dyzx" runat="server"></asp:Literal>
              </div>
             <div class="tab-pane fade" id="dropdown1">
                                    <asp:Literal ID="lt_xydj" runat="server"></asp:Literal>
              </div> 
              
            </div>
                    </div>
                                        <div class="span7"  style="width:355px;" >
                        
                             <ul id="myTab3" class="nav nav-tabs">
              <li class="active"><a href="#home2" data-toggle="tab">学生天地</a></li>
              <li><a href="#profile2" data-toggle="tab">光荣升旗手</a></li>
                   <li><a href="#dropdown3" data-toggle="tab">城市少年宫</a></li> 
            
            </ul>
                      
                        
                         <div id="myTabContent3" class="tab-content" style="padding:5px;">
              <div class="tab-pane fade in active" id="home2">
                                           <div class="newslist" style="border:none">
                                    <asp:Literal ID="lt_xstd" runat="server"></asp:Literal>
                                </div>

               </div>
              <div class="tab-pane fade" id="profile2">
                                 
                   
  <div class="scrolllist" style="width:290px;" id="s2">
		<a class="abtn aleft" href="#left" title="左移"></a>
		<div class="imglist_w" style="height:200px; width:250px;">
			<ul class="imglist">
				     <asp:Literal ID="lt_xyhd" runat="server"></asp:Literal>
			</ul><!--imglist end-->
		</div>
		<a class="abtn aright" href="#right" title="右移"></a>
	</div><!--scrolllist end-->


 </div>

              
             <div class="tab-pane fade" id="dropdown3">
                                   <asp:Literal ID="lt_twst" runat="server"></asp:Literal>
              </div> 
              
            </div>
                    </div>

               

                </div>
                      
             </div>
               </div>


            </div>

                                           <div  class="span5 ">
                <div class="row">
                  
                    <div class="login" >
                        <div class="box" >
                            <div class="title"> 用户登录 </div>
                        </div>
                            <div class="form-horizontal" style="margin-top: 20px">
                                <%If Session("username") = "" Then%>
                                <table style="padding:5px; margin-left:20px;">
                                    <tr><td><input type="text" id="Username" class="span2"></td><td width="60" rowspan="2"> <img src="images/login_btn_blue.png" id="loginbt" style ="cursor:pointer" /></td></tr>
                                    <tr><td> <input type="password" class="span2" id="pwd"></td></tr>
                                   
                                </table>
                              
                                
                                <%else %>
                                                                <table style="padding:5px; margin-left:20px;">
                                    <tr><td width="60">用户名</td><td>    <%=Session("username")%></td></tr>
                                    <tr><td>密　码</td><td>   <%=Session("truename")%> </td></tr>
                                    <tr><td></td><td>   <a type="button"     href="userexit.aspx" class="btn">安全退出</a>  </td></tr>
                              </table>
                              

 
                          
                            
                                <%End If%>
                            </div>

                        
                    </div>
                       <% 
                           Dim tk As String = ""
                           If Session("token") <> "" Then
                               tk = "?token=" & Session("token")
                           End If
                                       %>
                                        

                        <div class="text-center boxspace"  >
                            <div class="link">
<%--                                <div class="link1-1">实验预约</div>
                                <div class="link1-2">购置维修</div>
                                <div class="link1-3">成长档案</div>
                                <div class="link2-1">校本资源</div>
                                <div class="link2-2">视频会议</div>
                                <div class="link2-3">教育OA</div>
                                <div class="link3-1">校讯通</div>
                                <div class="link3-2"></div>
                                <div class="link3-3"></div>



                            </div>--%>
                               <a href="GuestbookWeb.aspx"> <img src="images/xzxx_blue.png" /></a>
                            <img  src="images/link.png" usemap="#Map"   style="text-align:center" />
                            <map  id ="Map" name="Map">
                              <area shape="rect" coords="12, 7, 77, 80"  target ="_blank"  href="lab/LablistWeb.aspx<%=tk%>" />
                              <area shape="rect" coords="91, 6, 149, 79"  target ="_blank" href="event/eventlistweb.aspx<%=tk%>">
                              <area shape="rect" coords="159, 6, 230, 82" target ="_blank"  href="eport/StubaseInfoweb.aspx<%=tk%>">
                                       <area shape="rect" coords="163, 88, 230, 151" target ="_blank"  href="http://document.net-g.cn/" />
                                        <area shape="rect" coords="87, 161, 159, 227" target ="_blank"  href="hy/default.aspx<%=tk%>">
                                          <area shape="rect" coords="166, 167, 237, 230" target ="_blank"  href="qj/default.aspx<%=tk%>">
                                 <area shape="rect" coords="6, 234, 79, 297" target ="_blank"  href="xk/CourseOrderListWeb.aspx<%=tk%>">
                </map>
                        </div>
 
                </div>  
               
               
 

                     
                
                 
                

 
 

            </div>
           </div>

 </div>

        
    </div>
 <uc1:Footer runat="server" ID="Footer" />

    </form>
        <script src="Plugins/jq_scroll.js"></script>
     <script src="Plugins/KinSlideshow/js/jquery.KinSlideshow-1.2.1.min.js"></script>	
 <script>

     $(function () {
         $("#KinSlideshow2").KinSlideshow();
        //多行应用@Mr.Think
        var _wrap = $('div.mulitline');//定义滚动区域
        var _interval = 3000;//定义滚动间隙时间
        var _moving;//需要清除的动画
        _wrap.hover(function () {
            clearInterval(_moving);//当鼠标在滚动区域中时,停止滚动
        }, function () {
            _moving = setInterval(function () {
                var _field = _wrap.find('div:first');//此变量不可放置于函数起始处,li:first取值是变化的
                var _h = _field.height();//取得每次滚动高度
                _field.animate({ marginTop: -_h + 'px' }, 600, function () {//通过取负margin值,隐藏第一行
                    _field.css('marginTop', 0).appendTo(_wrap);//隐藏后,将该行的margin值置零,并插入到最后,实现无缝滚动
                })
            }, _interval)//滚动间隔时间取决于_interval
        }).trigger('mouseleave');//函数载入时,模拟执行mouseleave,即自动滚动
    });
</script> 
 <script type="text/javascript">// <![CDATA[ 
     var t = n = 0, count;
     $(document).ready(function () {
         count = $("#banner_list a").length;
         $("#banner_list a:not(:first-child)").hide();
         $("#banner_info").html($("#banner_list a:first-child").find("img").attr('alt'));
         $("#banner_info").click(function () { window.open($("#banner_list a:first-child").attr('href'), "_blank") });
         $("#banner li").click(function () {
             var i = $(this).text() - 1;//获取Li元素内的值，即1，2，3，4 
             n = i;
             if (i >= count) return;
             $("#banner_info").html($("#banner_list a").eq(i).find("img").attr('alt'));
             $("#banner_info").unbind().click(function () { window.open($("#banner_list a").eq(i).attr('href'), "_blank") })
             $("#banner_list a").filter(":visible").fadeOut(500).parent().children().eq(i).fadeIn(1000);
             $(this).css({ "background": "#be2424", 'color': '#000' }).siblings().css({ "background": "#6f4f67", 'color': '#fff' });
         });
         t = setInterval("showAuto()", 4000);
         $("#banner").hover(function () { clearInterval(t) }, function () { t = setInterval("showAuto()", 4000); });
     })

     function showAuto() {
         n = n >= (count - 1) ? 0 : ++n;
         $("#banner li").eq(n).trigger('click');
     }
     // ]]></script> 
    <script type="text/javascript">
        $(function () {
            var $this = $(".scrollNews");
            var scrollTimer;
            $this.hover(function () {
                clearInterval(scrollTimer);
            }, function () {
                scrollTimer = setInterval(function () {
                    scrollNews($this);
                }, 3000);
            }).trigger("mouseleave");
        });
        function scrollNews(obj) {
            var $self = obj.find("ul:first");
            var lineHeight = $self.find("li:first").height(); //获取宽度，向上滚动则需要获取高度.height()
            $self.animate({ "marginTop": -lineHeight + "px" }, 600, function () { //向左滚动，向上滚动则需要改为marginTop,其他方向类似，下同
                $self.css({ marginTop: 0 }).find("li:first").appendTo($self); //appendTo能直接移动元素
            })
        }
</script>
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


<script language="javascript" type="text/javascript">
    //$("#img").imgFloat();   //不给参数默认（speed:10,xPos:0,yPos:0） 
    $("#img").imgFloat({ speed: 15, xPos: 10, yPos: 10 });
    $(".reset").click(function () {
        $("#img").css("display", "none");
    });
</script> 
</body>
</html>
