Imports Wzsckj.com.Common

Public Class FileRss
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = Request.QueryString("id")
        Dim dt As DataTable
        Dim dmbll As New BLL.DataMainBLL
        Dim dm As New Model.DataMain
        dm = dmbll.Entity(id)


        If dm IsNot Nothing Then
            Dim rc As New JwPlayer.Item
            Dim filebll As New BLL.FilelistBLL
            dt = filebll.dt2(dm.Id)
            rc.title = dm.Title
            rc.image = ""
            rc.description = ""

            FileHelper.JwPlayerRSS(dt, rc)

        End If
    End Sub

End Class