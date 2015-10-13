<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserinfoWeb.aspx.vb" Inherits="Web.UserinfoWeb" %>

<div class="pageContent">
    <form id="form1" runat="server" method="post" action="../user/userdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
        <asp:hiddenfield runat="server" id="hd_action"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_id"></asp:hiddenfield>


        <div class="pageFormContent" layouth="56">
            <dl>
                <dt>用户名：</dt>
                <dd>
                    <asp:textbox id="txt_username" runat="server"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>密码：</dt>
                <dd>
                    <asp:textbox id="txt_pwd" runat="server"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>确认密码：</dt>
                <dd>
                    <asp:textbox id="txt_pwd2" runat="server"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>姓名：</dt>
                <dd>
                    <asp:textbox id="txt_Truename" runat="server"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>性别：</dt>
                <dd>
                    <asp:dropdownlist id="drp_sex" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:dropdownlist>
                </dd>
            </dl>
            <dl  class="nowrap pageFormItemNormal">
                <dt>角色：</dt>
                <dd>
                     
                    <asp:literal id="rolelist" runat="server"></asp:literal>
                </dd>
            </dl>
              <dl  class="nowrap pageFormItemNormal">
                <dt>部门：</dt>
                <dd>
                     
                    <asp:literal id="lt_department" runat="server"></asp:literal>
                </dd>
            </dl>

            <dl>
<dt>状态：</dt>
<dd>
 <asp:dropdownlist id="drp_State" runat="server"  >
     <asp:ListItem Value="1">启用</asp:ListItem>
     <asp:ListItem Value="0">禁用</asp:ListItem>
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
