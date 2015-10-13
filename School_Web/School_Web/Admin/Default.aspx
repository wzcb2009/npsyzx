<%@ Page Language="vb" AutoEventWireup="false" enableEventValidation="false" enableViewStateMac="false"  CodeBehind="Default.aspx.vb" Inherits="Web._Default1" %>
<!DOCTYPE HTML>

<html>
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
    <title></title>
<link href="themes/default/style.css" rel="stylesheet" type="text/css" media="screen"/>

<link href="themes/css/core.css" rel="stylesheet" type="text/css" media="screen"/>
<link href="themes/css/print.css" rel="stylesheet" type="text/css" media="print"/>
    <link href="themes/default/MyStyle.css" rel="stylesheet" />
<link href="uploadify/css/uploadify.css" rel="stylesheet" type="text/css" media="screen"/>
<!--[if IE]>
<link href="themes/css/ieHack.css" rel="stylesheet" type="text/css" media="screen"/>
<![endif]-->

<script src="js/speedup.js" type="text/javascript"></script>
 
<%--    <script src="../Js/jquery-1.9.0.min.js"></script>--%>
<script src="js/jquery-1.7.2.js" type="text/javascript"></script>
      <script src="treetable/vendor/jquery-ui-1.7.2.custom.min.js"></script>  

    <%-- <script src="treetable/vendor/jquery.js"></script>--%>
 <script src="js/jquery.cookie.js" type="text/javascript"></script>
<script src="js/jquery.validate.js" type="text/javascript"></script>
<script src="js/jquery.bgiframe.js" type="text/javascript"></script>
    <script src="xheditor/xheditor-1.1.14-zh-cn.min.js"></script>
        <script src="uploadify/scripts/swfobject.js" type="text/javascript"></script>
    <script src="uploadify/scripts/jquery.uploadify.v2.1.0.js" type="text/javascript"></script>
  
<!-- svg图表  supports Firefox 3.0+, Safari 3.0+, Chrome 5.0+, Opera 9.5+ and Internet Explorer 6.0+ -->
<script type="text/javascript" src="chart/raphael.js"></script>
<script type="text/javascript" src="chart/g.raphael.js"></script>
<script type="text/javascript" src="chart/g.bar.js"></script>
<script type="text/javascript" src="chart/g.line.js"></script>
<script type="text/javascript" src="chart/g.pie.js"></script>
<script type="text/javascript" src="chart/g.dot.js"></script>

<script src="js/dwz.core.js" type="text/javascript"></script>
<script src="js/dwz.util.date.js" type="text/javascript"></script>
<script src="js/dwz.validate.method.js" type="text/javascript"></script>
<script src="js/dwz.regional.zh.js" type="text/javascript"></script>
<script src="js/dwz.barDrag.js" type="text/javascript"></script>
<script src="js/dwz.drag.js" type="text/javascript"></script>
<script src="js/dwz.tree.js" type="text/javascript"></script>
<script src="js/dwz.accordion.js" type="text/javascript"></script>
<script src="js/dwz.ui.js" type="text/javascript"></script>
<script src="js/dwz.theme.js" type="text/javascript"></script>
<script src="js/dwz.switchEnv.js" type="text/javascript"></script>
<script src="js/dwz.alertMsg.js" type="text/javascript"></script>
<script src="js/dwz.contextmenu.js" type="text/javascript"></script>
<script src="js/dwz.navTab.js" type="text/javascript"></script>
<script src="js/dwz.tab.js" type="text/javascript"></script>
<script src="js/dwz.resize.js" type="text/javascript"></script>
<script src="js/dwz.dialog.js" type="text/javascript"></script>
<script src="js/dwz.dialogDrag.js" type="text/javascript"></script>
<script src="js/dwz.sortDrag.js" type="text/javascript"></script>
<script src="js/dwz.cssTable.js" type="text/javascript"></script>
<script src="js/dwz.stable.js" type="text/javascript"></script>
<script src="js/dwz.taskBar.js" type="text/javascript"></script>
<script src="js/dwz.ajax.js" type="text/javascript"></script>
<script src="js/dwz.pagination.js" type="text/javascript"></script>
<script src="js/dwz.database.js" type="text/javascript"></script>
<script src="js/dwz.datepicker.js" type="text/javascript"></script>
<script src="js/dwz.effects.js" type="text/javascript"></script>
<script src="js/dwz.panel.js" type="text/javascript"></script>
<script src="js/dwz.checkbox.js" type="text/javascript"></script>
<script src="js/dwz.history.js" type="text/javascript"></script>
<script src="js/dwz.combox.js" type="text/javascript"></script>
<script src="js/dwz.print.js" type="text/javascript"></script>
<!--
<script src="bin/dwz.min.js" type="text/javascript"></script>
-->
    <link href="treetable/stylesheets/jquery.treetable.css" rel="stylesheet" />
    <link href="treetable/stylesheets/jquery.treetable.theme.default.css" rel="stylesheet" />
   <link href="../Plugins/TagsInput/jquery.tagsinput.css" rel="stylesheet" />
<script src="../Plugins/TagsInput/jquery.tagsinput.js"></script>
    <script src="../Plugins/TagsInput/jquery.autocomplete.js"></script>
     <link href="../Plugins/TagsInput/jquery.autocomplete.css" rel="stylesheet" />

<script src="js/dwz.regional.zh.js" type="text/javascript"></script>
   
    <script src="treetable/javascripts/src/jquery.treetable.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        DWZ.init("dwz.frag.xml", {
            loginUrl: "../user/userloginweb.aspx", loginTitle: "登录",	// 弹出登录对话框
            //		loginUrl:"login.html",	// 跳到登录页面
            statusCode: { ok: 200, error: 300, timeout: 301 }, //【可选】
            pageInfo: { pageNum: "pageNum", numPerPage: "numPerPage", orderField: "orderField", orderDirection: "orderDirection" }, //【可选】
            debug: false,	// 调试模式 【true|false】
            callback: function () {
                initEnv();
                $("#themeList").theme({ themeBase: "themes" }); // themeBase 相对于index页面的主题base路径
            }
        });
    });

</script>
    <style>
       ul.newslist li {
            line-height:22px;
            
            font-size:13px;
            font-family:Arial;
            border-bottom:dashed 1px #808080;
            

        }
        ul.newslist li a {
        
                   line-height:22px;
            
            font-size:13px;
            font-family:Arial;
            
 }
        div .userinfo .left,div .userinfo img {
            width:50px;
            height:50px;
            margin:2px;
        
        }
        div .userinfo .left,div .userinfo .right {
            float:left;
            text-align:left;
          
        
        }
        div .userinfo .right {
            margin-left:10px;
        }
        div.newsbox {
            width:260px;
            height:200px;
            min-height:100px;  float:left;margin-right:10px;
        
        }
            div.newsbox .main {
            
            }
    </style>
</head>
<body scroll="no">
    <form id="form1" runat="server">
    <div id="layout">
        <div id="header">
            <div class="headerNav">
               

                
                 <a class="logo" href="../default.aspx">温州市南浦实验中学</a>
               
                        
                
               
                <ul class="nav">
                    <!--<li id="switchEnvBox"><a href="javascript:">（<span>北京</span>）切换城市</a>
						<ul>
							<li><a href="sidebar_1.html">北京</a></li>
							<li><a href="sidebar_2.html">上海</a></li>
							<li><a href="sidebar_2.html">南京</a></li>
							<li><a href="sidebar_2.html">深圳</a></li>
							<li><a href="sidebar_2.html">广州</a></li>
							<li><a href="sidebar_2.html">天津</a></li>
							<li><a href="sidebar_2.html">杭州</a></li>
						</ul>
					</li>-->
                  <%--  <li><a href="changepwd.html" target="dialog" width="600">设置</a></li>--%>
                    <li><a href="../default.aspx"  external=""true"" rel="indexp"  target=""navTab"" >网站首页</a></li>
                    <!--<li><a href="http://weibo.com/dwzui" target="_blank">微博</a></li>
					<li><a href="http://bbs.dwzjs.com" target="_blank">论坛</a></li>-->
<li><a    rel="modt" target="dialog" href="changepwd.html">登录密码修改</a></li>
                    <li><a  href="exit.aspx">退出</a></li>
                </ul>
                <ul class="themeList" id="themeList">
                    <li theme="default">
                        <div class="selected">
                            蓝色</div>
                    </li>
                    <li theme="green">
                        <div>
                            绿色</div>
                    </li>
                    <!--<li theme="red"><div>红色</div></li>-->
                    <li theme="purple">
                        <div>
                            紫色</div>
                    </li>
                    <li theme="silver">
                        <div>
                            银色</div>
                    </li>
                    <li theme="azure">
                        <div>
                            天蓝</div>
                    </li>
                </ul>
            </div>
            <!-- navMenu -->
        </div>
        <div id="leftside">
            <div id="sidebar_s">
                <div class="collapse">
                    <div class="toggleCollapse">
                        <div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="sidebar">
                <div class="toggleCollapse">
                    <h2>
                        主菜单</h2>
                    <div>
                        收缩</div>
                </div>

                <div class="accordion" fillspace="sidebar">
                   
                   <asp:Literal ID="lit_menu" runat="server"></asp:Literal>
                     
                </div>
            </div>
        </div>
        <div id="container">
            <div id="navTab" class="tabsPage">
                <div class="tabsPageHeader">
                    <div class="tabsPageHeaderContent">
                        <!-- 显示左右控制时添加 class="tabsPageHeaderMargin" -->
                        <ul class="navTab-tab">
                            <li tabid="main" class="main"><span><span class="home_icon">我的主页</span></span></li>
                        </ul>
                    </div>
                    <div class="tabsLeft">
                        left</div>
                    <!-- 禁用只需要添加一个样式 class="tabsLeft tabsLeftDisabled" -->
                    <div class="tabsRight">
                        right</div>
                    <!-- 禁用只需要添加一个样式 class="tabsRight tabsRightDisabled" -->
                    <div class="tabsMore">
                        more</div>
                </div>
                <ul class="tabsMoreList">
                    <li>我的主页</li>
                </ul>
                <div class="navTab-panel tabsPageContent layoutBox">
                    <div class="page unitBox">
                        <div class="accountInfo">
                            <div class="alertInfo">
                                <asp:Literal ID="lt_userinfo" runat="server"></asp:Literal>

                            </div>
                            <div class="right">
                               
                               
                            </div>
                            <p>
                                <span>  
                                    <asp:Literal ID="lt_schoolname" runat="server"></asp:Literal>
                                   
                                </span></p>
                            <p>
                                网站地址:<a href="../default.aspx" target="_blank">http://www.npsyzx.net</a></p>
                        </div>
                        <div class="pageFormContent" layouth="80" style="margin-right: 230px">
                            <asp:Literal ID="lt_newsbox" runat="server"></asp:Literal>                         
                        </div>
                       <div style="width: 230px; position: absolute; top: 60px; right: 0" layouth="80">
                           
                          
<%--                            <iframe width="100%" height="430" class="share_self"  frameborder="0" scrolling="no" src="../Plugins/jwplayer/flv.aspx"></iframe>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="footer">
        <a href="http://www.wzsckj.com" target="navTab" external="true">尚长科技&nbsp; 技术支持</a></div>
      
    </form>

</body>
</html>
