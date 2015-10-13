Imports Wzsckj.com.Common
Imports StringHandling.DWZJson

Partial Class Web_NewsDo
    Inherits System.Web.UI.Page
    Dim bll As New BLL.DataMainBLL
    Dim ap As New ActionPara

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara

        Response.ContentType = "application/json"
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
        dm.Userid = ap.UserId
        dm.UnitId = 0
        dm.Caseid = ap.Caseid



        dm = bll.AddandSave(dm)
        Dim fileids As String = Request.Form("fileid")
        If fileids <> "" Then
            Dim fileBll As New BLL.FilelistBLL
            fileBll.Update(0, fileids, dm.Id)
        End If
        Dim copycaseid As Integer = IIf(Request.Form("xykx") = "on", 107, 0)
        Dim xyCaseid As Integer = IIf(Request.Form("caselist2") = "", 0, Request.Form("caselist2"))
        If copycaseid > 0 Then
            dm.Caseid = copycaseid
            dm.Id = 0
            dm = bll.AddandSave(dm)
            If fileids <> "" Then
                Dim fileBll As New BLL.FilelistBLL
                fileBll.Update(0, fileids, dm.Id)
            End If

        End If
        If xyCaseid > 0 Then
            dm.Caseid = xyCaseid
            dm.Id = 0
            dm = bll.AddandSave(dm)
            If fileids <> "" Then
                Dim fileBll As New BLL.FilelistBLL
                fileBll.Update(0, fileids, dm.Id)
            End If

        End If

    End Sub
    Sub modify()
        Dim dm As New Model.DataMain
        dm = bll.Entity(ap.ID)
        dm = getPageEntity(dm)
        'dm.Caseid = ap.Caseid
        '  dm.PubDate = Now
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
        dm.PubDate = IIf(Request.Form("txt_PubDate") = "", Now, Request.Form("txt_PubDate"))
        dm.Caseids = IIf(Request.Form("sc.caseid") = "", Now, Request.Form("sc.caseid"))
        dm.Remark = Request.Form("txt_remark")
        Return dm
    End Function

    Function getPageEntity() As Model.DataMain
        Dim dm As New Model.DataMain
        dm.ParentId = IIf(Request.Form("hwid") = "", 0, Request.Form("hwid"))

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
        dm.PubDate = IIf(Request.Form("txt_PubDate") = "", Now, Request.Form("txt_PubDate"))

        dm.EndDate = IIf(Request.Form("txt_EndDate") = "", Now, Request.Form("txt_EndDate"))
        dm.Caseids = IIf(Request.Form("sc.caseid") = "", Now, Request.Form("sc.caseid"))
        dm.Remark = Request.Form("txt_remark")
        Dim truename As String = Request.Form("txt_truename")
        If truename <> "" Then
            If truename.Contains("-") Then
                Dim userbll As New BLL.UserlistBLL
                dm.Userid = userbll.UserId(truename.Split("-")(0))
                If dm.Userid = 0 Then
                    Dim dwz_ As New DWZ
                    dwz_.message = "用户不存在"
                    dwz_.statusCode = statusCode.Info

                    Response.Write(StringHandling.DWZJson.Alert(dwz_))
                    Response.End()
                Else
                    dm.Author = truename.Split("-")(1)
                End If
            End If
        End If
        Return dm
    End Function
End Class
