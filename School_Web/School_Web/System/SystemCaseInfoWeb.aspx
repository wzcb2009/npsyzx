<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SystemCaseInfoWeb.aspx.vb" Inherits="Web.SystemCaseWeb" %>
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
                <label> 数据</label>
                
                  
                     <input name="sc.caseid" class="caseids"   target="sid_user" rel="" value="<%=caseids%>" type="hidden"/>
                     <input   name ="sc.casename" size="30" class="backinput"  type="text" value="<%=Casedata%>" />
                    <a class="btnLook"  href="../system/systemcasetree.aspx?action=multiselect&id=<%=Request.QueryString("id")%>&parentid=0" rel="newpage1" lookupGroup="sc">查找带回</a>	
            </p>
                 
               <p>
                <label>栏目数据类型</label>
                   <asp:dropdownlist id="drp_casedatatypeid" runat="server">
                    <asp:ListItem Value="0">备注</asp:ListItem>
                    <asp:ListItem Value="1">系统功能参数</asp:ListItem>
                    <asp:ListItem Value="2">相关栏目ID列表</asp:ListItem>
                    </asp:dropdownlist> 
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
