﻿Imports Wzsckj.com.Common

Public Class IndexLinkdo
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Dim ap As New ActionPara

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        add()
        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        Response.End()
    End Sub
    Dim scbll As New BLL.SystemCaseBLL
    Dim userbll As New BLL.UserlistBLL
    Sub add()
        Dim dm As New Model.DataMain
        dm = bll.EntityByCaseId(ap.Caseid)

        If dm Is Nothing Then
            dm = getPageEntity()
            dm.Title = scbll.CaseName(ap.Caseid)
            dm.Author = userbll.Truename(ap.UserId)
            dm.Caseid = ap.Caseid
            dm.ParentId = 0
            dm.Userid = ap.UserId
            dm.UnitId = 0
            dm.PubDate = Now
            dm.EndDate = Now
        Else
            dm = getPageEntity(dm)
            dm.Author = userbll.Truename(ap.UserId)
            dm.Caseid = ap.Caseid
            dm.PubDate = Now
            dm.EndDate = Now

        End If

        bll.AddandSave(dm)
    End Sub


    Function getPageEntity() As Model.DataMain
        Dim dm As New Model.DataMain

        dm.Caseid = ap.Caseid
        dm.Content = Request.Form("txt_Content")
        Return dm
    End Function
    Function getPageEntity(dm As Model.DataMain) As Model.DataMain
        dm.Caseid = Request.Form("Caseid")
        dm.Content = Request.Form("txt_Content")
        Return dm
    End Function


End Class