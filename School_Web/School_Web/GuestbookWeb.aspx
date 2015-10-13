<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GuestbookWeb.aspx.vb" Inherits="Web.GuestbookWeb" %>

<%@ Register Src="~/Header2.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="description" content="" />
    <meta name="author" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
     <link href="Plugins/ddouble-bsie/bootstrap/css/bootstrap.css" rel="stylesheet" />

    <!--[if lte IE 6]>
  <link rel="stylesheet" type="text/css" href="Plugins/bootstrap/css/bootstrap-ie6.css"/>
  <link rel="stylesheet" type="text/css" href="Plugins/bootstrap/css/ie.css"/>
  <![endif]-->
     <link href="Style.css" rel="stylesheet" />
    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="//cdnjs.bootcss.com/ajax/libs/html5shiv/3.6.2/html5shiv.js"></script>
    <![endif]-->


    <link href="File/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="registerform">
        <div class="container">
            <div>
                <uc1:Header ID="head1" runat="server" />
                <div class="row">
                    <div class="span20" style="background-color:#ffffff">
                        <ul class="breadcrumb">
                            <li><a href="default.aspx">首页</a> <span class="divider">/</span></li>
                            <li class="active">
                                <asp:Literal ID="lt_sitenav" runat="server"></asp:Literal></li>

                        </ul>

                        <div class="row">

                           <div class="span10">
        <div class="newscontent">
                               <asp:Literal ID="lt_list" runat="server"></asp:Literal>
                             </div>
                            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="pages" CurrentPageButtonClass="cpb" CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" CustomInfoSectionWidth="" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" NumericButtonCount="8" PrevPageText="上一页" ShowCustomInfoSection="Left" ShowPageIndexBox="Never" UrlPaging="True">
                            </webdiyer:AspNetPager>
                        </div>
                            <div class="span10">
                                <table   class="table"              >
                              <tr>
                                  <td  colspan="2"  
                    style="FONT-WEIGHT: bold; COLOR: #e50101">
                                      <span id="Label1">在线提交您的观点</span>：<asp:Label ID="msgl" 
                        runat="server"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td  >
                                      姓　　名：</td>
                                  <td  >
                                      <asp:TextBox ID="namet" runat="server" Width="207px" 
                              EnableViewState="False"></asp:TextBox>
                                      </td>
                              </tr>
                              <tr>
                                  <td  >
                                      联系电话：</td>
                                  <td >
                                     <asp:TextBox ID="telt" runat="server" 
                        Width="207px" EnableViewState="False"></asp:TextBox>
                                      </td>
                              </tr>
                              <tr>
                                  <td  >
                                      通讯地址：</td>
                                  <td >
                                    
                                      <asp:TextBox ID="addresst" runat="server" Width="207px" EnableViewState="False"></asp:TextBox>
                                      </td>
                              </tr>
                              <tr>
                                  <td  >
                                      邮政编码：</td>
                                  <td >
                                      <asp:TextBox ID="codet" runat="server" Width="207px" EnableViewState="False"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td  >
                                      E-mail：</td>
                                  <td >
                                   
                                      <asp:TextBox ID="emailt" runat="server" Width="207px" EnableViewState="False"></asp:TextBox>
                                      
                                      </td>
                              </tr>
                              <tr>
                                  <td  >
                                      联系QQ：</td>
                                  <td >
                                     
                                      <asp:TextBox ID="qqt" runat="server" Width="207px" EnableViewState="False"></asp:TextBox>
                                     
                                  </td>
                              </tr>
                              <tr>
                                  <td  colspan="2"  style="FONT-WEIGHT: bold">
                                      内容：</td>
                              </tr>
                              <tr>
                                  <td  colspan="2" >
                                      <asp:TextBox ID="contentt" runat="server" Height="136px" TextMode="MultiLine" 
                        Width="440px" EnableViewState="False"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                              ControlToValidate="contentt">*</asp:RequiredFieldValidator>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="middle" colspan="2"  >
                                      <asp:Button ID="Button1" runat="server" Text="提交" CssClass="btn btn-danger" />
                                  </td>
                              </tr>
                          </table>
                            </div>
                 
                        </div>
                    </div>

                </div>

                <uc1:Footer ID="footer1" runat="server" />
            </div>
        </div>

    </form>
    
 
   
</body>
</html>
