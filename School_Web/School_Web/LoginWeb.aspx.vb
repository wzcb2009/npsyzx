Public Class LoginWeb
    Inherits System.Web.UI.Page

    Public urlstr As String
    Public otherPage As Boolean

   
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Url As Uri = HttpContext.Current.Request.UrlReferrer
        If Url Is Nothing Then
            Return

        End If
        urlstr = (Url.ToString)
        If urlstr = Me.Page.Request.Url.ToString Then
            otherPage = False
        Else
            otherPage = True

        End If
    End Sub
End Class