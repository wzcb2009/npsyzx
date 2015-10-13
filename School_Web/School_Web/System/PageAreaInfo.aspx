<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PageAreaInfo.aspx.vb" Inherits="Web.PageAreaInfo" %>
<div class="pageContent">
    <form id="form1" runat="server" method="post" action="../project/projectdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
        <asp:hiddenfield runat="server" id="hd_action"></asp:hiddenfield>
        <asp:hiddenfield runat="server" id="hd_id"></asp:hiddenfield>

         
        <div class="pageFormContent" layouth="56">
            <asp:literal id="lt_formarea" runat="server"></asp:literal>
<dl>
<dt>类别：</dt>
<dd>
 <asp:literal id="txt_CaseName" runat="server"  ></asp:literal>
</dd>
</dl>
 
<dl>
<dt>所属学院：</dt>
<dd>
 <asp:textbox id="txt_CollegeName" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>课程名称(中文)：</dt>
<dd>
 <asp:textbox id="txt_CourseName0" runat="server"  ></asp:textbox>
</dd>
</dl>
  <dl>
<dt>课程名称(英文)：</dt>
<dd>
 <asp:textbox id="txt_CourseName1" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>外 语 语 种：</dt>
<dd>
 <asp:textbox id="txt_Language" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>课 程 类 别：</dt>
<dd>
    <asp:dropdownlist id="drp_CourseCaseId" runat="server"></asp:dropdownlist>
</dd>
</dl>
<dl>
<dt>所 属 专 业：</dt>
<dd>
 <asp:textbox id="txt_SubjecName" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>专 业 代 码：</dt>
<dd>
 <asp:textbox id="txt_SubjectCode" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>开 设 学 期：</dt>
<dd>
 <asp:textbox id="txt_TermName" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>课 程 负 责 人：</dt>
<dd>
 <asp:textbox id="txt_Truename" runat="server"  ></asp:textbox>
</dd>
</dl>
<dl>
<dt>申 报 日 期：</dt>
<dd>
 <asp:textbox id="txt_AppDate" runat="server"  cssclass="date required"></asp:textbox>
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
