<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PageIndexWeb.aspx.vb" Inherits="Web.PageIndexWeb" %>

<div class="pageContent">
    <form id="form1" runat="server" method="post" action="../user/userdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
        <asp:hiddenfield runat="server" id="hd_action"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_id"></asp:hiddenfield>


        <div class="pageFormContent" layouth="56">
            <dl>
                <dt>网址：</dt>
                <dd>
                    <asp:textbox id="txt_username" runat="server"></asp:textbox>
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
