<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HomeworkDataInfoWeb.aspx.vb" Inherits="Web.HomeworkDataInfoWeb" %>
<script src="../File/FileHandle.js"></script>
<link href="../File/Style.css" rel="stylesheet" />
 <div class="pageContent">

    <form id="Form1" runat="server" method="post" action="../web/newsdo.aspx" class="pageForm required-validate" onsubmit=" return validateCallback(this)">
        <asp:hiddenfield id="Hd_action" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_caseid" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_id" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hwid" runat="server"></asp:hiddenfield>

        <div class="pageFormContent pageFormContent2 " layouth="56">
             <dl>
                <dt>作业标题：</dt>
                <dd><asp:textbox id="txt_title" runat="server" size="40" cssclass="required"></asp:textbox>
                    </dd>
            </dl>

              <dl>
                <dt>学生姓名：</dt>
                <dd>
                    <asp:hiddenfield id="txt_userid" runat="server"></asp:hiddenfield>
                    <asp:textbox id="txt_truename" runat="server" size="30" cssclass="required autocomplete" AsuggestFields="username,truename" pk="txt_userid" autourl="../user/userjson.aspx"></asp:textbox>
                    </dd>
            </dl>
         

                <div  style="clear:both">
            </div>
            <dl>
                <dt>审核通过</dt>
                <dd><asp:checkbox id="chk_Status" checked="true" runat="server"  /></dd>
                
            </dl>
   
       
            <dl>
                <dt>置顶</dt>
                <dd><asp:checkbox id="chk_cmd" runat="server"   /></dd>
                
            </dl>
            <dl>
                <dt>浏览次数</dt><dd>
                <asp:textbox id="txt_BrowCount" runat="server" text="0" width="50px"></asp:textbox>
                    </dd>
            </dl>
            <dl>
                <dt>排序</dt><dd>
                <asp:textbox id="txt_pindex" runat="server" text="1" width="50px"></asp:textbox>
                    </dd> 
            </dl>
            <dl>
                <dt>上传日期</dt>
                <dd>
                    <asp:textbox id="txt_pubdate" cssclass="date" runat="server" width="80px"></asp:textbox>
                    </dd>
            </dl>

            <div style="clear: both"></div>
            <%--<textarea  class="editor" name="txt_content" rows="12" cols="100"
								upLinkUrl="../web/upload.aspx" upLinkExt="zip,rar,txt" 
								upImgUrl="../web/upload.aspx" upImgExt="jpg,jpeg,gif,png" 
								upFlashUrl="../web/upload.aspx" upFlashExt="swf"
								upMediaUrl="../web/upload.aspx" upMediaExt:"avi">--%>
<textarea id="content" name="content" class="kindeditor" rows="22" cols="120">
		           
			<asp:literal id="lt_content" runat="server"></asp:literal>		</textarea> 
      
           
       
            <div id="filesinput">
                <asp:literal id="lt_fileinput" runat="server"></asp:literal>

            </div>

            <div style="margin: 10px">
            </div>
    <div class="divider"></div>
    <div class="fileupload">
        <div class="left">
            <h2 class="contentTitle">
                <asp:literal id="lt_title" runat="server"></asp:literal>
                材料上传

            </h2>
        </div>
        <div class="line"></div>
        <div class="right">
            <h2 class="contentTitle">附件列表：</h2>
        </div>
        <div class="clearbox">
        </div>

    </div>
    <div class="clearbox"></div>
    <div style="margin: 0 10px">
        <div style="float: left; width: 450px;">
            <div style="height: 10px;"></div>
            <input id="testFileInput" type="file" name="filedata"
                auto="true"
                uploader="uploadify/scripts/uploadify.swf"
                cancelimg="uploadify/cancel.png"
                script="../file/upload.aspx"
                scriptdata="{'ASPSESSID': '<%= Session.SessionID %>', 'AUTHID': '<% 
                Dim c As HttpCookie
                c = Request.Cookies(FormsAuthentication.FormsCookieName)
                If c Is Nothing Then
                    Response.Write("")
                Else
                    Response.Write(Request.Cookies(FormsAuthentication.FormsCookieName).Value)
                End If
    %>' ,'pindex':'0','projectid':'0','parentid':'<%=Request.QueryString("id")%>'}"
                filequeue="fileQueue"
                fileext="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip"
                filedesc="*.jpg;*.jpeg;*.gif;*.png;*.doc;*.docx;*.pdf;*.rar;*.zip" />
            <div id="fileQueue" class="fileQueue2"></div>
        </div>
        <div style="float: left; width: 470px;">

            <ul class="filelist">
                <asp:literal runat="server" id="lt_files"></asp:literal>
            </ul>
        </div>
    </div>

    <div class="clearbox"></div>
                        <h2 class="contentTitle">教师评语：</h2>
                        <dl>
                <dt>得分：</dt>
                <dd><asp:textbox id="txt_cent" runat="server" text="100" size="5" cssclass="required"></asp:textbox>
                    </dd>
            </dl>
                        <div style="clear: both"></div>
            <asp:textbox runat="server" id="txt_remark" Columns="100" Rows="4" TextMode="MultiLine"></asp:textbox>
      


        </div>
         <div class="formBar">
            <ul>
                 <li>
                    <div class="buttonActive">
                        <div class="buttonContent">
                            <button type="submit">保存</button></div>
                    </div>
                </li>
                <li>
                    <div class="button">
                        <div class="buttonContent">
                            <button type="button" class="close">取消</button></div>
                    </div>
                </li>
            </ul>
        </div>
   </form>

</div>

