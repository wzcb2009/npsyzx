Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls


''' <summary>
''' 令牌验证
''' 以URL参数方式返回
''' </summary>
Partial Public Class GetToken
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("BackURL") IsNot Nothing Then
            Dim backURL As String = Server.UrlDecode(Request.QueryString("BackURL"))

            '获取Cookie

            Dim tokenCookie As HttpCookie = Request.Cookies("Token")
            If tokenCookie IsNot Nothing Then
                If tokenCookie.Values("Value") IsNot Nothing Then
                    backURL = backURL.Replace("$Token$", tokenCookie.Values("Value").ToString())
                End If

            End If

            ''Response.Write(backURL)

            Response.Redirect(backURL)
        End If
    End Sub

End Class
'end class

