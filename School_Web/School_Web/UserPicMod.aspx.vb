Public Class UserPicMod
    Inherits System.Web.UI.Page
    Public fileinfo As New Model.FileList
    Dim fileid As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        fileid = Request.QueryString("id")
        Dim filebll As New BLL.FilelistBLL
        fileinfo = filebll.Entity(fileid)
        If fileinfo Is Nothing Then
            fileinfo = New Model.FileList

        End If
    End Sub

End Class