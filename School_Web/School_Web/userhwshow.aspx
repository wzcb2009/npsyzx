<%@ Page Language="vb" AutoEventWireup="false" EnableViewState="false"  CodeBehind="userhwshow.aspx.vb" Inherits="Web.userhwshow" %>

 
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
    <link href="Plugins/uploadify/uploadify.css" rel="stylesheet" />
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
    <link href="File/Style.css" rel="stylesheet" />


    <link href="plugins/Validform/Validform_style.css" rel="stylesheet" />
        <script src="Plugins/ueditor/editor_config.js"></script>
    <script src="Plugins/ueditor/editor_all.js"></script>
    <script src="File/FileHandle.js"></script>
    <link href="File/Style.css" rel="stylesheet" />
     
    
</head>
 
<body>
    <form id="form1" class="registerform" onsubmit="editor.sync();" runat="server" action="userhwdo.aspx">
     
        <asp:HiddenField ID="hd_action" runat="server" Value="add" />
        <input id="typeid" type="hidden" name="typeid" value="1" />
       
        <%--   <script src="js/Alabelop.js" type="text/javascript"></script>--%>
        <div class="container">
            <uc1:head runat="server" ID="head" />
            

                
                  <div class="row">
                      <div class="span12">
                           <ul class="breadcrumb">
    <li><a href="#">首页</a> <span class="divider">/</span></li>
    <li><a href="#">用户中心</a> <span class="divider">/</span></li>
                                   <li><a href="userinfolist.aspx">我的作业</a> <span class="divider">/</span></li>

    <li class="active">
        <asp:Literal ID="lt_hwtitle" runat="server"></asp:Literal></li>
    </ul>
                      </div>
                      <div class="span3">
                              <ul class="nav nav-tabs nav-list nav-stacked bs-docs-sidenav">
                                                                  <li ><a href="#"><h4>用户中心</h4></a></li>
                                  <li class="active"><a href="userinfolist.aspx"><i class="icon-chevron-right"></i>我的作业</a></li>
                                   
                                  <li><a href="userpwd.aspx"><i class="icon-chevron-right"></i>登陆密码设置</a></li>
                                  <li><a href="userinfo.aspx"><i class="icon-chevron-right"></i>个人信息设置</a></li>
                                 <li><a href="userface.aspx"><i class="icon-chevron-right"></i>用户头像</a></li>
   
    </ul>
                      </div>
                      
                      <div class="span9">
                          <asp:Literal ID="lt_hwinfo" runat="server"></asp:Literal>
                          <hr />
                           <asp:Literal ID="lt_userhwinfo" runat="server"></asp:Literal>
                          <hr />
                                <asp:hiddenfield id="hwid" runat="server"></asp:hiddenfield>

                <div class="form-horizontal">
                     <div class="control-group">
<label class="control-label" for="inputEmail">作业标题</label>
<div class="controls">
    <asp:TextBox ID="txt_title" runat="server"></asp:TextBox>
</div>
</div>
<div class="control-group">
<label class="control-label" for="inputPassword">作业内容</label>
<div class="controls">
     
     <script name="txt_content"   id="editor" type="text/plain"><asp:Literal runat="server" id="lt_content"></asp:Literal></script>
 
 <script type="text/javascript">
    var editor;

    editor = new UE.ui.Editor();
   editor.render("editor");
    //  editor.setHeight(100);
   //1.2.4以后可以使用一下代码实例化编辑器
    //UE.getEditor('myEditor')
</script> 

</div>
</div>
 
<div class="control-group">    <label class="control-label" for="inputPassword">附件上传</label>

<div class="controls">
  <div id="file_upload_11"></div>
      <div id="filesinput">
                <asp:literal id="lt_fileinput" runat="server"></asp:literal>

            </div>
       <ul id="filelist2" class="filelist">
                <asp:literal runat="server" id="lt_files"></asp:literal>
            </ul>
<button type="submit" class="btn">提交</button>
</div>
</div>
                </div>
             
                      </div>
                  </div>

                

             
            <uc1:footer runat="server" ID="footer" />
        </div>

    </form>
    <script src="plugins/bootstrap/js/bootstrap.js"></script>
         <script src="plugins/Validform/Validform_v5.3.2.js"></script>
    <script src="Plugins/uploadify/jquery.uploadify.js"></script>

         <script>
             function strToJson(str) {
                 var json = eval('(' + str + ')');
                 return json;
             }
             $(document).ready(function () {

                 $("#file_upload_11").uploadify({
                     height: 30,
                     width: 120,
                     swf: '/Plugins/uploadify/uploadify.swf',
                     uploader: '/file/upload.aspx',

                     formData: { 'ASPSESSID': '<%= Session.SessionID %>', 'AUTHID': '<% 
                        Dim c As HttpCookie
                        c = Request.Cookies(FormsAuthentication.FormsCookieName)
                        If c Is Nothing Then
                            Response.Write("")
                        Else
                            Response.Write(Request.Cookies(FormsAuthentication.FormsCookieName).Value)
                        End If
    %>', 'pindex': '<%=Request.QueryString("pindex")%>', 'caseid': '535', 'parentid': '<%=Request.QueryString("zid")%>' },

                  
                     onUploadSuccess: uploadifyComplete3
                 

                  
             });

         });
</script>
        <script type="text/javascript">
            $(function () {
                var demo = $(".registerform").Validform({
                    tiptype: 3,
                    label: ".label",
                    showAllError: true,
                    ajaxPost: true,
                    callback: function (data) {
                        if (data.status == "y") {
                            setTimeout(function () {
                                $.Hidemsg(); //公用方法关闭信息提示框;显示方法是$.Showmsg("message goes here.");
                            }, 2000);
                        }
                    }
                });
            });
    </script>

  

      
    
	 

</body>
</html>
