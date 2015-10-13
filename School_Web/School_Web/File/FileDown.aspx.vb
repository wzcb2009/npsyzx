Imports Wzsckj.com.Common

Public Class FileDown
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Session("username") = "" Then
        '    Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
        '    Response.End()

        'End If

        Dim fileid As Integer = Request.QueryString("fileid")
        Dim bll As New BLL.FilelistBLL
        Dim f As Model.FileList = bll.Entity(fileid)
        If f Is Nothing Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
            Response.End()
        Else


            FileHelper.File_Download(f.Path, f.Title)
        End If
    End Sub
End Class