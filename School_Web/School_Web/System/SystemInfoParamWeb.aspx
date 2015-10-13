<%@ Page Language="vb" AutoEventWireup="false" enableEventValidation="false" enableViewStateMac="false"  CodeBehind="SystemInfoParamWeb.aspx.vb" Inherits="Web.SystemInfoParamWeb" %>
  <h2 class="contentTitle">系统信息</h2>


<div class="pageContent">
	
	<form id="Form1" runat ="server"  method="post" action="../system/systemdo.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
		<div class="pageFormContent nowrap" layoutH="97">
 
            
                &nbsp;
                    <dl>
                        <dt style="width: 100px">
                            网站名称</dt>
                        <dd style="width: 100px">
                            <asp:TextBox ID="txt_name" runat="server" Width="232px"></asp:TextBox>
                            
                        </dd>
                    </dl>
                    <dl>
                        <dt style="width: 100px">
                            联系地址</dt>
                        <dd style="width: 100px">
                            <asp:TextBox ID="txt_address" runat="server" Width="328px"></asp:TextBox>
                        </dd>
                    </dl>
                    <dl>
                        <dt style="width: 100px">
                            联系电话</dt>
                        <dd style="width: 100px">
                            <asp:TextBox ID="txt_tel" runat="server"></asp:TextBox>
                        </dd>
                    </dl>
                    <dl>
                        <dt style="width: 100px">
                            ICP备案号</dt>
                        <dd style="width: 100px">
                            <asp:TextBox ID="txt_icp" runat="server" Width="216px"></asp:TextBox>
                        </dd>
                    </dl>
                    <dl>
                        <dt style="width: 100px">
                            其他内容</dt>
                        <dd style="width: 100px">
                            <asp:TextBox ID="txt_content" runat="server" Height="88px" TextMode="MultiLine" 
                        Width="496px"></asp:TextBox>
                        </dd>
                    </dl>
                    <dl>
                        <dt style="width: 100px">
                            上传路径</dt>
                        <dd>
                            <asp:TextBox ID="txt_path" runat="server" Width="300px"></asp:TextBox>
                        </dd>
                    </dl>
                   
             </div>

       
<div class="formBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
	
</div>