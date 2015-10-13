Imports Wzsckj.com.Common

Public Class FileInfoWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Select Case ap.Action
            Case ActionEnum.Modify
                Init_(ap.ID)
                hd_action.Value = "mod"
                hd_id.Value = ap.ID


        End Select
    End Sub
    Dim bll As New BLL.FilelistBLL
    Sub Init_(FileId As Integer)
        Dim FL = bll.entity(FileId)
        If FL IsNot Nothing Then
            
            txt_Pindex.text = FL.Pindex
          
            txt_Title.text = FL.Title
          
            txt_content.Text = FL.Content
            lt_indexImage.Text = "<img src='" & StringHandling.SafeData.s_string(FL.IndexImagePath) & "' height='32'>"
           
        End If
    End Sub

End Class