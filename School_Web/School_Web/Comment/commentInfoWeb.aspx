<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="commentInfoWeb.aspx.vb" Inherits="Web.commentInfoWeb" %>
<div class="pageContent">
    <form id="form1" runat="server" method="post" action="../comment/commentdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this,dialogAjaxDone)">
        <asp:hiddenfield runat="server" id="hd_action"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_id"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_parentid"></asp:hiddenfield>
        
        <div class="pageFormContent nowrap" layouth="56">
            <dl>
                <dt>内容：</dt>
                <dd>
                    <asp:textbox id="txt_Content" runat="server" Columns="50" Rows="5" TextMode="MultiLine"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>时间：</dt>
                <dd>
                    <asp:textbox id="txt_Pubdate" runat="server" cssclass="date required"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>状态：</dt>
                <dd>
                    <asp:dropdownlist id="txt_Status" runat="server">
                        <asp:ListItem Value="1">是</asp:ListItem>
                        <asp:ListItem Value="0">否</asp:ListItem>
                    </asp:dropdownlist>
                </dd>
            </dl>
            <dl>
                <dt>评分：</dt>
                <dd>
                    <asp:dropdownlist runat="server" id="txt_cent">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:dropdownlist>
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
