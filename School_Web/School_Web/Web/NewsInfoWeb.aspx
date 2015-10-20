<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewsInfoWeb.aspx.vb" Inherits="Web.NewsAddWeb" %>

<script src="../Admin/js/formsubmit.js"></script>
<script src="../File/FileHandle.js"></script>
<head>
    <link href="../File/Style.css" rel="stylesheet" />
    <script>
        function uploadifyComplete(event, queueId, fileObj, response, data) {
            var s, t;
            var file = DWZ.jsonEval(response);

            s = "<li id='file" + file.fileid + "'>";

            s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

            s = s + "<div class='main'><a class='title' href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile(" + file.fileid + ")'></a><a class='view' target='dialog' width='800' href='../file/fileinfoweb.aspx?action=mod&id=" + file.fileid + "'>修改</a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
            s = s + "</li><li class='clearbox'></li>";
            t = "<input name='fileid' value='" + file.fileid + "' type='hidden' />";
            $("#filesinput", navTab.getCurrentPanel()).append(t);
            $(".filelist", navTab.getCurrentPanel()).append(s);
            // $("#txt_title", navTab.getCurrentPanel()).val(fileObj.name);
            // DWZ.ajaxDone(DWZ.jsonEval(response));
        }

    </script>
    <link href="../kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../kindeditor/kindeditor-min.js"></script>
    <script src="../kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="../kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <%-- <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.create('#content', {
                //上传管理
                uploadJson: '../kindeditor/asp.net/upload_json.ashx',
                //文件管理
                fileManagerJson: '../kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                //设置编辑器创建后执行的回调函数
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                },
                //上传文件后执行的回调函数,获取上传图片的路径
                afterUpload: function (url) {
                    alert(url);
                },
                //编辑器高度
                width: '700px',
                //编辑器宽度
                height: '450px;',
                //配置编辑器的工具栏
                items: [
                'source', '|', 'undo', 'redo', '|', 'preview', 'print', 'template', 'code', 'cut', 'copy', 'paste',
                'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
                'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',
                'superscript', 'clearhtml', 'quickformat', 'selectall', '|', 'fullscreen', '/',
                'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
                'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image', 'multiimage',
                'flash', 'media', 'insertfile', 'table', 'hr', 'emoticons', 'baidumap', 'pagebreak',
                'anchor', 'link', 'unlink', '|', 'about'
                ]
            });
            prettyPrint();
        });
    </script>--%>
</head>
<h2 class="contentTitle">
    网站信息</h2>
<div class="pageContent" layouth="78">
    <form id="form1" runat="server" method="post" action="../web/newsdo.aspx" class="pageForm required-validate"
    onsubmit="return validateCallback(this, navTabAjaxDone)">
    <asp:hiddenfield id="Hd_action" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id="hd_caseid" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id="hd_id" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id="hd_objid" runat="server"></asp:hiddenfield>
    <div class=" pageFormContent2">
        <dl>
            <dt>标题：</dt>
            <dd>
                <asp:textbox id="txt_title" runat="server" size="30" cssclass="required"></asp:textbox>
            </dd>
        </dl>
        <dl>
            <dt>审核通过 </dt>
            <dd>
                <asp:checkbox id="chk_Status" checked="true" runat="server" text="" />
            </dd>
        </dl>
        <dl>
            <dt>加密</dt>
            <dd>
                <asp:checkbox id="chk_right" runat="server" text="" />
            </dd>
        </dl>
        <dl>
            <dt>推荐</dt>
            <dd>
                <asp:checkbox id="chk_cmd" runat="server" text="" />
            </dd>
        </dl>
        <dl>
            <dt>作者</dt>
            <dd>
                <asp:textbox id="txt_author" runat="server" width="50px"></asp:textbox>
            </dd>
        </dl>
        <dl>
            <dt>浏览次数</dt>
            <dd>
                <asp:textbox id="txt_BrowCount" runat="server" text="0" width="50px"></asp:textbox>
            </dd>
        </dl>
        <dl>
            <dt>排序</dt>
            <dd>
                <asp:textbox id="txt_pindex" runat="server" text="1000" width="50px"></asp:textbox>
            </dd>
        </dl>
        <dl>
            <dt>上传日期</dt>
            <dd>
                <asp:textbox id="txt_pubdate" runat="server" width="80px"></asp:textbox>
            </dd>
        </dl>
        <div style="clear: both">
        </div>
        <div>
            <dl>
                <dt>复制到</dt>
                <dd>
                    <asp:checkbox runat="server" id="xykx" value="107" text=""></asp:checkbox>
                    校园快讯
                </dd>
            </dl>
        </div>
        <div style="clear: both">
        </div>
        <div style="width: 100%">
            <%--<asp:TextBox id="content" name="txt_content" TextMode="MultiLine" runat="server"></asp:TextBox>--%>
            <%--<script id="editor" name="txt_content"    type="text/plain" style="width:1024px;height:500px;""><%=art_content%></script>--%>
            <textarea id="content" name="content" class="kindeditor" rows="22" cols="120">
                 <asp:literal id="lt_content" runat="server"></asp:literal>
            </textarea>
            <%--<textarea id="editor"   class="editor" name="txt_content" rows="22" cols="100"  type="text/plain">
               <asp:literal id="lt_content" runat="server"></asp:literal>
	           
					</textarea>--%>
            <%-- <textarea  class="editor" name="txt_content" rows="22" cols="100"
							   upLinkUrl="../web/upload.aspx" upLinkExt="zip,rar,txt,doc,docx,ppt,pptx,xls,xlsx" 
								upImgUrl="../web/upload.aspx" upImgExt="jpg,jpeg,gif,png" 
								upFlashUrl="../web/upload.aspx" upFlashExt="swf"
								upMediaUrl="../web/upload.aspx" upMediaExt="avi,wmv,mpg,rm,rmvb">

	            <asp:literal id="lt_content" runat="server"></asp:literal>
	           
					</textarea> --%>
        </div>
        <div id="filesinput">
            <asp:literal id="lt_fileinput" runat="server"></asp:literal>
        </div>
        <div style="margin: 10px">
        </div>
        <div class="divider">
        </div>
    </div>
    </form>

<div style="margin: 0 10px">
    <div style="float: left; width: 450px;">
        <div style="height: 10px;">
        </div>
        <input id="testFileInput<%=Now.ToFileTime%>" type="file" name="filedata" auto="true"
            uploader="uploadify/scripts/uploadify.swf" buttonimg="uploadify/Img/add.jpg"
            cancelimg="uploadify/cancel.png" script="../file/upload.aspx" scriptdata="{'ASPSESSID': '<%= Session.SessionID %>', 'AUTHID': '<% 
                Dim c As HttpCookie
                c = Request.Cookies(FormsAuthentication.FormsCookieName)
                If c Is Nothing Then
                    Response.Write("")
                Else
                    Response.Write(Request.Cookies(FormsAuthentication.FormsCookieName).Value)
                End If
    %>' ,'pindex':'0','projectid':'0','parentid':'<%=Request.QueryString("id")%>'}" filequeue="fileQueue"
            fileext="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip" filedesc="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip" />
        <div id="fileQueue" class="fileQueue">
        </div>
    </div>
    <div style="float: left; width: 470px;">
        <ul class="filelist">
            <asp:literal runat="server" id="lt_files"></asp:literal>
        </ul>
    </div>
</div>
</div>
<div class="formBar">
    <ul>
        <li><a class="buttonActive" href="javascript:tj(0);"><span>保存</span></a></li>
        <li><a class="buttonActive" href="javascript:tj(-1);"><span>取消</span></a></li>
    </ul>
</div>
