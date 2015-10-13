Imports Wzsckj.com.Common

Public Class IndexlinkInfoWeb
    Inherits System.Web.UI.Page

    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Dim dm As New Model.DataMain
        dm = bll.EntityByCaseId(ap.Caseid)
        Hd_action.Value = "add"
        hd_caseid.Value = ap.Caseid
        If dm IsNot Nothing Then
            txt_content.Text = dm.Content

        End If
    End Sub

End Class