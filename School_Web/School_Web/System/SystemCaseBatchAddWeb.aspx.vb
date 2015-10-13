Imports Wzsckj.com.Common

Public Class SystemCaseBatchAddWeb
    Inherits System.Web.UI.Page

    Public ap As New ActionPara
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        Dim bll As New BLL.SystemCaseBLL
        lt_casename.Text = bll.CaseName(ap.ID)


    End Sub

End Class