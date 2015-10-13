<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserFace.aspx.vb" Inherits="Web.UserFace" %>

 
<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Plugins/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Plugins/bootstrap/css/bootstrap-responsive.css" rel="stylesheet" />
 <!--[if lte IE 6]>
     <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap-ie6.css" rel="stylesheet" />
     <link href="Plugins/ddouble-bsie/bootstrap/css/ie.css" rel="stylesheet" />
   <![endif]-->
            <link href="Style.css" rel="stylesheet" />
    <link href="subStyle.css" rel="stylesheet" />

     <link href="plugins/ZoomImage/css/main.css" rel="stylesheet" />

        <!-- Le HTML5 shim, for IE6-8 support of HTML elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Styles -->
  

 
</head>
<body>
    <form id="form1" runat="server">
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
                                   
                                  <li><a href="userpwd.aspx"><i class="icon-chevron-right"></i>登陆密码设置</a></li>
                                  <li><a href="userinfo.aspx"><i class="icon-chevron-right"></i>个人信息设置</a></li>
                                 <li class="active"><a href="userface.aspx"><i class="icon-chevron-right"></i>用户头像</a></li>
    </ul>
                      </div>
                  <div class="span9">
                                   <div class="left">
         <!--当前照片-->
         <div id="CurruntPicContainer"  >
            <div class="title"><b>当前照片</b></div>
            <div class="photocontainer">
                <asp:Image ID="imgphoto" cssclass="img-rounded" runat="server" ImageUrl="plugins/ZoomImage/image/man.GIF" />
            </div>
         </div>
         <!--Step 2-->
         <div id="Step2Container" runat="server">
           <div class="title"><b> 裁切头像照片</b></div>
           <div class="uploadtooltip">您可以拖动照片以裁剪满意的头像</div>                              
                   <div id="Canvas" class="uploaddiv">
                   
                            <div id="ImageDragContainer">                               
                               <asp:Image ID="ImageDrag" runat="server" ImageUrl="plugins/ZoomImage/image/blank.jpg" CssClass="imagePhoto" ToolTip=""/>                                                        
                            </div>
                            <div id="IconContainer">                               
                               <asp:Image ID="ImageIcon" runat="server" ImageUrl="plugins/ZoomImage/image/blank.jpg" CssClass="imagePhoto" ToolTip=""/>                                                        
                            </div>                          
                    </div>
                    <div class="uploaddiv">
                       <table>
                            <tr>
                                <td id="Min">
                                        <img alt="缩小" src="plugins/ZoomImage/image/_c.gif" onmouseover="this.src='plugin/ZoomImage/image/_c.gif';" onmouseout="this.src='plugin/ZoomImage/image/_h.gif';" id="moresmall" class="smallbig" />
                                </td>
                                <td>
                                    <div id="bar">
                                        <div class="child">
                                        </div>
                                    </div>
                                </td>
                                <td id="Max">
                                        <img alt="放大" src="plugins/ZoomImage/image/c.gif" onmouseover="this.src='plugin/ZoomImage/image/c.gif';" onmouseout="this.src='plugin/ZoomImage/image/h.gif';" id="morebig" class="smallbig" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="uploaddiv">
                        <asp:Button ID="btn_Image" runat="server" Text="保存头像" OnClick="btn_Image_Click" />
                    </div>           
                    <div style="display:none">
                    图片实际宽度： <asp:TextBox ID="txt_width" runat="server" Text="1" ></asp:TextBox><br />
                    图片实际高度： <asp:TextBox ID="txt_height" runat="server" Text="1" ></asp:TextBox><br />
                    距离顶部： <asp:TextBox ID="txt_top" runat="server"  Text="82"></asp:TextBox><br />
                    距离左边： <asp:TextBox ID="txt_left" runat="server" Text="73"></asp:TextBox><br />
                    截取框的宽： <asp:TextBox ID="txt_DropWidth" runat="server"  Text="120"></asp:TextBox><br />
                    截取框的高： <asp:TextBox ID="txt_DropHeight" runat="server" Text="120"></asp:TextBox><br />
                    放大倍数： <asp:TextBox ID="txt_Zoom" runat="server" ></asp:TextBox>
                   </div>
         </div>
     
     </div>
     <div class="right">
         <!--Step 1-->
         <div id="Step1Container">
            <div class="title"><b>更换照片</b></div>
            <div id="uploadcontainer">
                <div class="uploadtooltip">请选择新的照片文件，文件需小于2.5MB</div>
                <div class="uploaddiv"><asp:FileUpload ID="fuPhoto"  runat="server" ToolTip="选择照片"/></div>
                <div class="uploaddiv"><asp:Button ID="btnUpload" runat="server" Text="上 传" onclick="btnUpload_Click" /></div>
            </div>
         
         </div>
     </div>
                      </div>
    </div>
        <uc1:footer runat="server" ID="footer" />
            <script src="plugins/ZoomImage/js/jquery-ui-1.9.2.custom.js"></script>
     <script src="plugins/ZoomImage/js/CutPic.js"></script>
    </form>
 


         

</body>
</html>
