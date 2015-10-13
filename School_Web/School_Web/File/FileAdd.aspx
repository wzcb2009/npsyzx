<%@ Page Language="vb" AutoEventWireup="false" EnableViewStateMac="false" CodeBehind="FileAdd.aspx.vb" Inherits="Web.FileAdd" %>
<style type="text/css" media="screen">
.my-uploadify-button {
	background:none;
	border: none;
	text-shadow: none;
	border-radius:0;
}

.uploadify:hover .my-uploadify-button {
	background:none;
	border: none;
}

.fileQueue {
	width: 400px;
	height: 150px;
	overflow: auto;
	border: 1px solid #E5E5E5;
	margin-bottom: 10px;
}
    ul.filelist li:hover {
        background-color:#E5E5E5;
    }
    ul.filelist li {
        height:46px;
        width:400px;
        border:solid 1px #E5E5E5;
        margin:3px;

           
    }
        ul.filelist li .ico {
            float:left;
            height:40px;
            width:40px;
            margin:3px;

        }
        ul.filelist li .main a.title {
            display:block;
            font-size:14px;
             line-height:22px;
             vertical-align:middle;
             height:22px;
             width:300px;
            

        
        }
                ul.filelist li .main a.del {
            display:block;
            background-image:url(../file/images/del.png);
            background-repeat:no-repeat;
            float:right;
            
             line-height:22px;
             vertical-align:middle;
             height:22px;
             width:20px;
            

        
        }

        ul.filelist li .info {
         height:22px; line-height:22px;  font-size:12px;
        }
    ul.filelist li.clearbox {
        clear:both;
        height:0px;
        border:none;
    
    }
</style>
<script>
    function uploadifyAllComplete(event, data) {
       // $.pdialog.reload("../file/fileadd.aspx?pindex=<%=Request.QueryString("pindex")%>&id=<%=Request.QueryString("id")%>");
       // navTab.reload("../project/projectlistweb.aspx?parentid=<%=ap.Caseid%>&caseid=<%=ap.ObjId%>&pindex=<%= ap.Pindex%>", {}, "sc<%=ap.ObjId%>");


    }


    function uploadifyComplete(event, queueId, fileObj, response, data) {
        var s, t;
        var file = DWZ.jsonEval(response);

        s = "<li class='file" + file.fileid + "'>";

        s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

        s = s + "<div class='main'><a class='title' targetType='navTab' target='dwzExport' href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile(" + file.fileid + ")'></a><a class='view'  href=\"javascript:showfile(" + file.fileid + ",'" + fileObj.name + "')\"   title=\"查看文件吗?\">预览</a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
        s = s + "</li><li class='clearbox'></li>";
       
        

        $(".filelist" ).append(s);


        DWZ.ajaxDone(DWZ.jsonEval(response));
    }
    function delfile(fileid) {
        $(function () {
            alertMsg.confirm("您确认要删除该文件吗？", {

                okCall: function () {

                    $.post("../file/filedel.aspx", { "fileid": fileid }, DWZ.ajaxDone, "json");
                    $(".file" + fileid).slideUp(500, function () {
                        $(this).remove();
                    });
                   

                }

            });


        });
    }
    function showfile(fileid, title) {
        var options;
        options = {
            width: 820,
            height: 550,
            max: true,
            mask: true,
            mixable: true,
            minable: true,
            resizable: true,
            drawable: true,
            fresh: true
        }
        $.pdialog.open("../file/fileshow.aspx?fileid=" + fileid, "filedialog", title, options);

    }

</script>
<h2 class="contentTitle">
    <asp:literal id="lt_title" runat="server"></asp:literal>
    材料上传</h2>
<div class="pageContent"   layoutH="50">
 
 <div style="float:left ; width:400px; padding:10px">
	<input id="testFileInput" type="file" name="filedata" 
        auto =true    
		uploader="uploadify/scripts/uploadify.swf"
		cancelImg="uploadify/cancel.png" 
		script="../file/upload.aspx" 
		scriptData="{'ASPSESSID': '<%= Session.SessionID %>', 'AUTHID': '<% 
	    Dim c As HttpCookie
	    c = Request.Cookies(FormsAuthentication.FormsCookieName)
	    If c Is Nothing Then
	        Response.Write("")
	    Else
	        Response.Write(Request.Cookies(FormsAuthentication.FormsCookieName).Value)
	    End If
    %>' ,'pindex':'<%=ap.Pindex%>','projectid':'<%= ap.ID %>','parentid':'<%=0%>'}"
		fileQueue="fileQueue"
		     
		fileExt="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip;*.xls;*.xlsx"
		fileDesc="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip;*.xls;*.xlsx"/>
       <div style="height:10px;"></div>
 	<div id="fileQueue" class="fileQueue"></div>
</div>
			<div style="float:left ; width:400px;  padding:10px">
                <h3>附件列表：</h3>
                <ul class="filelist">
                <asp:literal runat="server" id="lt_files"></asp:literal>

                </ul>
			</div>
			</div>  
	
 