<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FileShow.aspx.vb" Inherits="Web.FileShow" %>
 <form id="form1" runat="server">
 <h2 class="contentTitle">
    <asp:literal id="lt_title" runat="server"></asp:literal>
    <a    href='../file/filedown.aspx?fileid=<%=Request.QueryString("fileid")%>'   > 材料下载 </a></h2>
<div class="pageContent"   layoutH="50">
    
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    
</div>
</form>
