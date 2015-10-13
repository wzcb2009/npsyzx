<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserPics.aspx.vb" Inherits="Web.UserPics" %>
  
<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

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

  
        <script src="plugins/Validform/Validform_v5.3.2.js"></script>
    <link href="plugins/Validform/Validform_style.css" rel="stylesheet" />
         <script src="plugins/uploadify/jquery.uploadify.js"></script>
    <link href="plugins/uploadify/uploadify.css" rel="stylesheet" />
    <script type="text/javascript"
        src="http://qzonestyle.gtimg.cn/qzone/openapi/qc_loader.js" data-appid="100411533" data-redirecturi="http://www.0577360.cn/qq_back.html" charset="utf-8"></script>

     
    
</head>
 
<body>
    <form id="form1" class="registerform" runat="server" action="infodo.aspx">
        <input id="action" type="hidden" name="action" value="modcmp" />
       
        <%--   <script src="js/Alabelop.js" type="text/javascript"></script>--%>
        <div class="container">
            <uc1:head runat="server" ID="head" />
            

                
                  <div class="row">
                      <div class="span12">
                           <ul class="breadcrumb">
    <li><a href="#">首页</a> <span class="divider">/</span></li>
    <li><a href="#">用户中心</a> <span class="divider">/</span></li>
    <li class="active">商户信息</li>
    </ul>
                      </div>
                      <div class="span3">
                              <ul class="nav nav-tabs nav-list nav-stacked bs-docs-sidenav">
                                  <li ><a href="#"><h4>用户中心</h4></a></li>
                                  <li  ><a href="usercmp.aspx"><i class="icon-chevron-right"></i>商户信息管理</a></li>
                                  <li class="active"><a href="userpics.aspx"><i class="icon-chevron-right"></i>商户相册</a></li>
                                  <li><a href="userinfolist.aspx"><i class="icon-chevron-right"></i>分类信息管理</a></li>
                                    
                                  <li><a href="userpwd.aspx"><i class="icon-chevron-right"></i>登陆密码设置</a></li>
                                  <li><a href="userinfo.aspx"><i class="icon-chevron-right"></i>个人信息设置</a></li>
                                 <li><a href="userface.aspx"><i class="icon-chevron-right"></i>用户头像</a></li>
    </ul>
                      </div>
                      
                      
                      <div class="span9">
                          <ul class="nav nav-tabs">
    <li>
    <a href="usercmp.aspx">基本信息</a>
    </li>
    <li class="active"><a href="userpics.aspx">商户图片相册</a></li>
    
    </ul>
                             <asp:hiddenfield id="hd_PicUrl1" runat="server"></asp:hiddenfield>
                    <asp:hiddenfield id="userFaceFileid1" runat="server"></asp:hiddenfield> 
                                                      <span id="file_upload_1"></span>
                          <ul class="thumbnails">
                          <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                              </ul>
                      </div>

                  </div>

                

             
            <uc1:footer runat="server" ID="footer" />
        </div>

    </form>
    <script src="plugins/bootstrap/js/bootstrap.js"></script>
    <script src="plugins/jquery.Xslider.js"></script>
    <script src="plugins/ms-Dropdown-master/js/msdropdown/jquery.dd.js"></script>
    <script src="plugins/jquery.scrollUp.min.js"></script>
    <script src="Index.js"></script>
 
     
     <script>
         function strToJson(str) {
             var json = eval('(' + str + ')');
             return json;
         }
         $(document).ready(function () {

             $("#file_upload_1").uploadify({
                 height: 30,
                 width: 120,
                 swf: '/Plugin/uploadify/uploadify.swf',
                 uploader: '/file/upload.aspx',

                 formData: { 'ASPSESSID': '<%= Session.SessionID %>', 'AUTHID': '<% 
                        Dim c As HttpCookie
                        c = Request.Cookies(FormsAuthentication.FormsCookieName)
                        If c Is Nothing Then
                            Response.Write("")
                        Else
                            Response.Write(Request.Cookies(FormsAuthentication.FormsCookieName).Value)
                        End If
    %>', 'pindex': '<%=Request.QueryString("pindex")%>', 'caseid': '535', 'parentid': '<%=unitInfo.Id%>' },

                onUploadSuccess: function (fileObj, data, response) {

                    var file = strToJson(data);


                    $("#userFace1").attr("src", file.filepath);
                    $("#userFaceFileid1").val(file.fileid);

                }
            });
            
        });
</script>
    <script src="File/FileHandle.js"></script>
    <link href="File/Style.css" rel="stylesheet" />

</body>
</html>
