﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="数据转移" />
    
        <asp:Button ID="Button2" runat="server" Text="Button" />
    
        <asp:Button ID="Button3" runat="server" Text="栏目类型设置" />
    
        <asp:Button ID="Button5" runat="server" Text="Button" />
    
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="61px"></asp:TextBox>
    
        <asp:Button ID="Button4" runat="server" Text="修改图片路径" />
    
    </div>
    </form>
</body>
</html>
