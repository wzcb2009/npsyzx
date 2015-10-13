<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FileInfoWeb.aspx.vb" Inherits="Web.FileInfoWeb" %>

<div class="pageContent">
    <form id="form1" runat="server" method="post" action="../file/fileinfomod.aspx" enctype="multipart/form-data" class="pageForm required-validate" onsubmit="return iframeCallback(this,dialogAjaxDone)">
        <asp:hiddenfield runat="server" id="hd_action"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_id"></asp:hiddenfield>


        <div class="pageFormContent nowrap" layouth="56">
             <h2 class="contentTitle">
    <asp:literal id="lt_title" runat="server"></asp:literal>
    <a    href='../file/filedown.aspx?fileid=<%=Request.QueryString("id")%>'   > 材料下载 </a></h2>

            <dl>
                <dt>文件标题：</dt>
                <dd>
                    <asp:textbox id="txt_title" size="30"   runat="server"></asp:textbox>
                </dd>
            </dl>
            <dl  >
                <dt>文件说明：</dt>
                <dd>
                    <asp:textbox id="txt_content" runat="server" Columns="60" Rows="5" TextMode="MultiLine"></asp:textbox>
                </dd>
            </dl>
            <div class="clear"></div>
            <dl>
                <dt>图标文件：</dt>
                <dd>
                    <input id="Filedata" name="Filedata" type="file" />
                    <asp:literal id="lt_indexImage" runat="server"></asp:literal>
                </dd>
            </dl>
            <dl>
                <dt>序号：</dt>
                <dd>
                    <asp:textbox id="txt_Pindex" size="5" runat="server"></asp:textbox>
                </dd>
            </dl>
            
          






        </div>
        <div class="formBar">
            <ul>
                <!--<li><a class="buttonActive" href="javascript:;"><span>保存</span></a></li>-->
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
