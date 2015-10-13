Imports Wzsckj.com.Common

Public Class LinkInfoWeb
    Inherits System.Web.UI.Page

    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Dim ap As New ActionPara
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ap = ActionHelper.PageActionPara
        Select Case ap.Action
            Case ActionEnum.Modify
                init_(ap.ID)
                Hd_action.Value = ap.Action.ToString
                hd_id.Value = ap.ID
                hd_caseid.Value = ap.Caseid
                lt_file.Text = files()

            Case ActionEnum.Add
                Hd_action.Value = ap.Action.ToString
                hd_caseid.Value = ap.Caseid
                txt_pindex.Text = bll.Pindex(ap.Caseid)
        End Select
    End Sub
    Sub init_(id As Integer)
        Dim dm As New Model.DataMain
        dm = BLL.Entity(id)
        txt_title.Text = dm.Title
        txt_pindex.Text = dm.Pindex
        chk_Status.Checked = dm.Status
        txt_content.Text = dm.Content
    End Sub
    Function files() As String
        Dim bll As New BLL.FilelistBLL


        Dim dt As DataTable = bll.Dt(ap.ID)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.Append(" <a href='" & r("path") & "'>" & r("title") & "</a> ")
        Next
        Return s.ToString
    End Function
End Class