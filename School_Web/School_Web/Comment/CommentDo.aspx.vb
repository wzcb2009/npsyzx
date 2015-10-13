Imports Wzsckj.com.Common

Public Class CommentDo
    Inherits System.Web.UI.Page
    Dim bll As New BLL.CommentBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Select Case ap.Action
            Case ActionEnum.Add
                Dim c As Model.Comment
                c = GetPageEntity()
                c.ParentId = ap.Parentid
                c.Id = 0
                bll.AddandMod(c)
            Case ActionEnum.Modify
                Dim c As Model.Comment
                c = GetPageEntity()
                c.ParentId = ap.Parentid
                c.Id = ap.ID
                bll.AddandMod(c)
            Case ActionEnum.Delete
                bll.Del(ap.ID)
            Case ActionEnum.MultiDelete
                bll.MultiDel(ap.Ids)


        End Select
        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        Response.End()
    End Sub

    Function GetPageEntity() As Model.Comment
        Dim C As New Model.Comment
        C.Content = Request.Form("txt_Content")
        C.Pubdate = Request.Form("txt_Pubdate")
        C.Status = Request.Form("txt_Status")
        C.Cent = Request.Form("txt_Cent")
        Return C
    End Function

End Class