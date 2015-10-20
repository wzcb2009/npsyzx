<%@ Page Language="vb" AutoEventWireup="false" EnableViewState="false" CodeBehind="ContentWeb.aspx.vb"
    EnableViewStateMac="false" Inherits="Web.ContentWeb" %>

<h2 class="contentTitle">
    网站信息</h2>
<div class="pageContent ">
    <form id="Form1" runat="server" method="post" action="../web/contentdo.aspx" class="pageForm required-validate"
    onsubmit=" return validateCallback(this)">
    <asp:hiddenfield id="Hd_action" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id="hd_caseid" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id="hd_id" runat="server"></asp:hiddenfield>
    <div class="pageFormContent   pageFormContent2" layouth="97">
        <dl>
            <dt>审核</dt>
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
            <dt>浏览次数 </dt>
            <dd>
                <asp:textbox id="txt_BrowCount" runat="server" text="0" width="50px"></asp:textbox>
            </dd>
        </dl>
        <div style="clear: both">
        </div>
        <%--<textarea  class="editor" name="txt_content" rows="22" cols="100"
								upLinkUrl="../web/upload.aspx" upLinkExt="zip,rar,txt,doc,docx,ppt,pptx,xls,xlsx" 
								upImgUrl="../web/upload.aspx" upImgExt="jpg,jpeg,gif,png" 
								upFlashUrl="../web/upload.aspx" upFlashExt="swf"
								upMediaUrl="../web/upload.aspx" upMediaExt:"avi,wmv,mpg,rm,rmvb">--%>
        <textarea id="content" name="content" class="kindeditor" rows="22" cols="120">
		           
			<asp:literal id="lt_content" runat="server"></asp:literal>		</textarea>
    </div>
    <div class="formBar">
        <ul>
            <li>
                <div class="buttonActive">
                    <div class="buttonContent">
                        <button type="submit">
                            提交</button></div>
                </div>
            </li>
            <li>
                <div class="button">
                    <div class="buttonContent">
                        <button type="button" class="close">
                            取消</button></div>
                </div>
            </li>
        </ul>
    </div>
    </form>
</div>
