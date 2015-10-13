<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UC_NewslistMore.ascx.vb" Inherits="Web.UC_NewslistMore" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
 
 
<asp:Literal ID="lt_list" runat="server"></asp:Literal>
 
 
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" UrlPaging="True" CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" ShowCustomInfoSection="Left" ShowPageIndexBox="Never" CssClass="pages" CurrentPageButtonClass="cpb" CustomInfoSectionWidth="" NumericButtonCount="8">
</webdiyer:AspNetPager>

 
 
