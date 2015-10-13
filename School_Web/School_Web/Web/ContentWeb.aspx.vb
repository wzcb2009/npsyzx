Imports Wzsckj.com.Common

Public Class ContentWeb
    Inherits System.Web.UI.Page

    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Dim ap As New ActionPara
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ap = ActionHelper.PageActionPara
        init_(ap.Caseid)
               

    End Sub
    Dim dm As New Model.DataMain
    Sub init_(caseid As Integer)
        dm = bll.EntityByCaseId(caseid)
        If dm IsNot Nothing Then
            txt_BrowCount.Text = dm.BrowCount
            chk_Status.Checked = dm.Status
            chk_right.Checked = dm.UserRight
            lt_content.Text = dm.Content
            Hd_action.Value = "mod"
            hd_id.Value = dm.Id
            hd_caseid.Value = caseid
        Else
            Hd_action.Value = "add"
            hd_id.Value = 0
        End If
        hd_caseid.Value = ap.Caseid

    End Sub
   

End Class