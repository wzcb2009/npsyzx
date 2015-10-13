Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports Passport.SSO.Passport.Class



Public Class _Default
    Inherits System.Web.UI.Page




    ''' <summary>
    ''' 用户登录
    ''' 接收Get参数：BackURL
    ''' </summary>


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '
        If Not IsPostBack Then
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        '摸拟用户登录验证(帐号、密码于web.config中)
        Dim username, pwd As String
        username = Me.TextBox1.Text
        pwd = Me.TextBox2.Text
        If pwd = "" Or username = "" Then
            lt_msg.Text = "用户名或者密码不能为空！"
            Return
        End If
        Dim userbll As New BLL.UserlistBLL
        pwd = StringHandling.Security.Md5(pwd)
        '真实环境此处应通过数据库进行验证
        If (userbll.login(username, pwd) = 1) Then
            '产生令牌
            Dim tokenValue As String = Me.getGuidString()


            Dim tokenCookie As New HttpCookie("Token")
            tokenCookie.Values.Add("Value", tokenValue)
            tokenCookie.Domain = "lwhczx.com"
            Response.AppendCookie(tokenCookie)


            ' 产生主站凭证()
            Dim info As Object = True
            '跳转回分站

            CacheManager.TokenInsert(tokenValue, username, info, DateTime.Now.AddMinutes(Double.Parse(30)))



            If Request.QueryString("BackURL") <> "" Then
                Response.Redirect(Server.UrlDecode(Request.QueryString("BackURL")) & "?Token=" & tokenValue & "&username=" & username)
                '  Response.Redirect(Server.UrlDecode(Request.QueryString("BackURL")))

            End If

        Else
            lt_msg.Text = ("抱歉，帐号或密码有误！")
        End If
    End Sub

    ''' <summary>
    ''' 产生绝对唯一字符串，用于令牌
    ''' </summary>
    ''' <returns></returns>
    Private Function getGuidString() As String
        Return GUID.NewGuid().ToString().ToUpper()
    End Function


  
End Class


