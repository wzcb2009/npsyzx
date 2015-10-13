Public Class userHwdo
    Inherits System.Web.UI.Page
    Dim zid, userid As Integer
    Dim action_ As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Write("{""info"":""登陆超时！"",""status"":""n""}")
            Response.End()
        End If

        zid = Request.Form("hwid")
        action_ = Request.Form("hd_action")
        userid = Session("userid")
        If action_ = "add" Then
            add()
            Response.Clear()
            Response.Write("{""info"":""操作成功！"",""status"":""y""}")
            Response.End()
        ElseIf action_ = "mod" Then
            modify()

            Response.Write("{""info"":""操作成功！" & action_ & """,""status"":""y""}")
            Response.End()


        End If

    End Sub
    Dim bll As New BLL.DataMainBLL

    Sub add()
        Dim dm As New Model.DataMain
        dm = getPageEntity()
        dm.Userid = userid
        dm.UnitId = 0
        dm.Caseid = 78
        dm.PubDate = Now
        dm.Author = Session("truename")
        dm = bll.AddandSave(dm)
        Dim fileids As String = Request.Form("fileid")
        If fileids <> "" Then
            Dim fileBll As New BLL.FilelistBLL
            fileBll.Update(0, fileids, dm.Id)
        End If

    End Sub
    Function getPageEntity(dm As Model.DataMain) As Model.DataMain

        dm.Title = Request.Form("txt_title")

        dm.Content = Request.Form("txt_Content")


        Return dm
    End Function

    Function getPageEntity() As Model.DataMain
        Dim dm As New Model.DataMain
        dm.ParentId = IIf(Request.Form("hwid") = "", 0, Request.Form("hwid"))
        dm.Title = Request.Form("txt_title")
        dm.Author = Session("truename")
        dm.BrowCount = Request.Form("txt_BrowCount")
        dm.Cmd = False
        dm.Content = Request.Form("txt_Content")
        dm.Pindex = 1
        dm.Status = False
        dm.Cent = 0
        dm.EndDate = Now
        dm.Caseids = ""
        dm.Remark = ""

        Return dm
    End Function
    Sub modify()
        Dim dm As New Model.DataMain
        dm = bll.EntityByParentId(zid, userid)
        If dm Is Nothing Then
            Return

        End If


        dm = bll.Entity(dm.Id)
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

End Class