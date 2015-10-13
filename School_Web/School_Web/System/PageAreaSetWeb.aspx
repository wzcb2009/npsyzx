<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PageAreaSetWeb.aspx.vb" Inherits="Web.PageAreaSetWeb" %>
 <div class="pageContent">
	<form id="form1" runat="server"  method="post" action="../system/systemcasedo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this,dialogAjaxDone)">
        <asp:hiddenfield id="hd_action"  runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_id"  runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_parentid"  runat="server"></asp:hiddenfield>
        <div class="pageFormContent" layoutH="56">

            <dl>
                <dt>  归属：</dt>
                <dd> <asp:Label ID="lab_pCasename" runat="server"></asp:Label></dd>
            </dl>
            <dl>
                <dt> 字段名称:</dt>
                <dd> <asp:TextBox ID="txt_casename" runat="server" size="30"></asp:TextBox></dd>
            </dl>
            <dl>
                <dt>排序号</dt>
                <dd>  <asp:TextBox ID="txt_pindex" runat="server" size="30">1</asp:TextBox></dd>
            </dl>
            <dl>
                <dt>显示</dt>
                <dd>
                    <asp:dropdownlist id="drp_isShowFlag" runat="server">
                        <asp:ListItem Value="1">是</asp:ListItem>
                        <asp:ListItem Value="0">否</asp:ListItem>
                    </asp:dropdownlist>
                </dd>
            </dl>
            <asp:literal id="lt_define" runat="server"></asp:literal>
                  <dl>
                            <dt> 说明文字:</dt>
                <dd>
                    <input name="sc.casename" type="text" size="30" value="<%=Casedata%>" />  </dd>


               </dl>
                                     <dl>
                            <dt> 宽度:</dt>
                <dd>
                    <input name="sc.casename" type="text" size="30" value="80" />  </dd>
  </dl>

               <dl>

                <dt>栏目数据类型</dt>
                <dd>   <asp:dropdownlist id="drp_casedatatypeid" runat="server">
                    <asp:ListItem Value="0">备注</asp:ListItem>
                                       </asp:dropdownlist> </dd>
            </dl>

          

            	</div>
		<div class="formBar">
			<ul>
				<!--<li><a class="buttonActive" href="javascript:;"><span>保存</span></a></li>-->
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">保存</button></div></div></li>
				<li>
					<div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div>
				</li>
			</ul>
		</div>
	</form>
</div>
<p>
    </p>
