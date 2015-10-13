Imports Wzsckj.com.Common

Public Class Rss
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim caseid As Integer = Request.QueryString("caseid")
        Dim dt As DataTable
        Dim dmbll As New BLL.DataMainBLL
        dt = dmbll.Dt(caseid)
        Dim rc As New Wzsckj.com.Common.RSS.Channel
        Dim sc As New Model.SystemCase
        Dim scbll As New BLL.SystemCaseBLL
        sc = scbll.Entity(caseid)
        If sc IsNot Nothing Then
            rc.title = sc.CaseName
            rc.pubDate = sc.PubDate
            rc.description = ""
            rc.lastBuildDate = Now.ToString

        End If
        FileHelper.RSS(dt, rc)
    End Sub

End Class