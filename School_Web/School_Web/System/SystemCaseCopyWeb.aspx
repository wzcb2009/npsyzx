<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SystemCaseCopyWeb.aspx.vb" Inherits="Web.SystemCaseCopyWeb" %>
 <div class="pageContent">
	<form id="form1" runat="server"  method="post" action="../system/systemcasedo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this,dialogAjaxDone)">
        <asp:hiddenfield id="hd_action"  runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_id"  runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_parentid"  runat="server"></asp:hiddenfield>
        <div class="pageFormContent" layoutH="56">

            <p>
                <label>  归属：</label>
                 <asp:Label ID="lab_pCasename" runat="server"></asp:Label>
            </p>
            <p>
                <label> 栏目名称:</label>
                 <asp:TextBox ID="txt_casename" runat="server"  size="30"></asp:TextBox>
            </p>
            <p>
                <label>排序号</label>
                  <asp:TextBox ID="txt_pindex" runat="server" size="30">1</asp:TextBox>
            </p>
            <p>
                <label>显示</label>
                
                    <asp:dropdownlist id="drp_isShowFlag" runat="server">
                        <asp:ListItem Value="1">是</asp:ListItem>
                        <asp:ListItem Value="0">否</asp:ListItem>
                    </asp:dropdownlist>
                
                
            </p>
                    <p>
                <label> 关联项目</label>
                      <asp:dropdownlist runat="server" id="casedata_caseid"></asp:dropdownlist>
            </p>
                

          

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
