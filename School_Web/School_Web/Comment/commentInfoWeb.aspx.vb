Imports Wzsckj.com.Common

Public Class commentInfoWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Dim parentid As Integer = Request("parentid")
        Select Case ap.Action
            Case ActionEnum.Modify
                Init_(ap.ID)
                hd_action.Value = "mod"
                hd_id.Value = ap.ID
                hd_parentid.Value = parentid
            Case ActionEnum.Add
                txt_Pubdate.Text = Now.ToString("yyyy-MM-dd")
        End Select
    End Sub
    Dim bll As New BLL.CommentBLL
    Sub Init_(ID As Integer)
        Dim rs = bll.rs(ID)
        If rs.read Then
            txt_Content.text = rs("Content")
            txt_Pubdate.text = rs("Pubdate")
            txt_Status.SelectedValue = rs("Status")
            txt_Cent.text = rs("Cent")
        End If
        rs.close()
    End Sub

    Function GetPageEntity() As Model.Comment
        Dim C As New Model.Comment
        C.Id = Request.Form("txt_ID")
        C.Userid = Request.Form("txt_UserID")
        C.ParentId = Request.Form("txt_ParentId")
        C.Content = Request.Form("txt_Content")
        C.Pubdate = Request.Form("txt_Pubdate")
        C.Status = Request.Form("txt_Status")
        C.Cent = Request.Form("txt_Cent")
        Return C
    End Function

End Class