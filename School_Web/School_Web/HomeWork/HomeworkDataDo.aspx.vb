Imports Wzsckj.com.Common

Public Class HomeworkDataDo
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Dim ap As New ActionPara

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara


        Select Case ap.Action
            Case ActionEnum.Add
                add()

            Case ActionEnum.Modify
                modify()
            Case ActionEnum.Delete
                bll.Del(ap.ID)
            Case ActionEnum.MultiDelete
                bll.MultiDel(ap.Ids)
        End Select
        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        Response.End()
    End Sub
    Sub add()
        Dim dm As New Model.DataMain
        dm = getPageEntity()
        dm.ParentId = 0
        dm.Userid = ap.UserId
        dm.UnitId = 0
        dm.Caseid = ap.Caseid
        dm.PubDate = Now

        dm = bll.AddandSave(dm)
        Dim fileids As String = Request.Form("fileid")
        If fileids <> "" Then
            Dim fileBll As New BLL.FilelistBLL
            fileBll.Update(0, fileids, dm.Id)
        End If
    End Sub
    Sub modify()
        Dim dm As New Model.DataMain
        dm = bll.Entity(ap.ID)
        dm = getPageEntity(dm)
        'dm.Caseid = ap.Caseid
        dm.PubDate = Now
        dm = bll.AddandSave(dm)
        Dim fileids As String = Request.Form("fileid")
        If fileids <> "" Then
            Dim fileBll As New BLL.FilelistBLL
            fileBll.Update(0, fileids, dm.Id)
        End If

    End Sub
    Function getPageEntity(dm As Model.DataMain) As Model.DataMain

        dm.Title = Request.Form("txt_title")
        dm.Author = Request.Form("txt_Author")
        dm.BrowCount = Request.Form("txt_BrowCount")
        dm.Cmd = IIf(Request.Form("chk_Cmd") = "on", True, False)
        dm.UserRight = IIf(Request.Form("chk_right") = "on", True, False)
        dm.Content = Request.Form("txt_Content")
        dm.Pindex = Request.Form("txt_Pindex")
        dm.Status = IIf(Request.Form("chk_Status") = "on", True, False)
        dm.Cent = IIf(Request.Form("txt_cent") = "", 0, Request.Form("txt_cent"))
        dm.EndDate = IIf(Request.Form("txt_EndDate") = "", Now, Request.Form("txt_EndDate"))
        dm.Caseids = IIf(Request.Form("sc.caseid") = "", Now, Request.Form("sc.caseid"))

        Return dm
    End Function

    Function getPageEntity() As Model.DataMain
        Dim dm As New Model.DataMain

        dm.Title = Request.Form("txt_title")
        dm.Author = Request.Form("txt_Author")
        dm.BrowCount = Request.Form("txt_BrowCount")
        dm.Caseid = Request.Form("Caseid")
        dm.Cmd = IIf(Request.Form("chk_Cmd") = "on", True, False)
        dm.UserRight = IIf(Request.Form("chk_right") = "on", True, False)
        dm.Content = Request.Form("txt_Content")
        dm.Pindex = Request.Form("txt_Pindex")
        dm.Status = IIf(Request.Form("chk_Status") = "on", True, False)
        dm.Cent = IIf(Request.Form("txt_cent") = "", 0, Request.Form("txt_cent"))
        dm.EndDate = IIf(Request.Form("txt_EndDate") = "", Now, Request.Form("txt_EndDate"))
        dm.Caseids = IIf(Request.Form("sc.caseid") = "", Now, Request.Form("sc.caseid"))
        Return dm
    End Function


End Class