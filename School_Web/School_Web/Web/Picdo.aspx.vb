Imports Wzsckj.com.Common

Public Class Picdo
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
        dm.Userid = 0
        dm.UnitId = 0
        dm.Pubdate = Now
        bll.AddandSave(dm)
        Dim fp As FileProperty = upload()
        Dim f As New Model.FileList
        f.Path = fp.Path
        f.Ext = fp.Ext
        f.Filesize = fp.FileSize / 1024
        f.Pubdate = Now
        f.Parentid = dm.Id
        Dim fileBll As New BLL.FilelistBLL
        fileBll.Add(f)
    End Sub
    Sub modify()
        Dim dm As New Model.DataMain
        dm = bll.Entity(ap.ID)
        dm = getPageEntity()
        dm.Caseid = ap.Caseid
        dm.Pubdate = Now
        bll.AddandSave(dm)
    End Sub

    Function getPageEntity() As Model.DataMain
        Dim dm As New Model.DataMain
        dm.Title = Request.Form("txt_title")
        dm.Author = Request.Form("txt_Author")
        dm.BrowCount = Request.Form("txt_BrowCount")
        dm.Caseid = Request.Form("Caseid")
        dm.Cmd = IIf(Request.Form("chk_Cmd") = "on", True, False)
        dm.Content = Request.Form("txt_Content")
        dm.Pindex = Request.Form("txt_Pindex")
        dm.Status = IIf(Request.Form("txt_Status") = "on", True, False)
        Return dm
    End Function
    Function upload() As FileProperty
        Dim fp As New FileProperty
        Dim jpeg_image_upload As HttpPostedFile = Request.Files(0)
        If jpeg_image_upload.ContentLength = 0 Then
            Return Nothing
        End If
        Dim fileName As String = jpeg_image_upload.FileName
        Dim filesize As Integer = jpeg_image_upload.ContentLength
        Dim FileExt As String = fileName.Substring(fileName.LastIndexOf(".") + 1)
        Dim SaveFileName As String
        SaveFileName = Now
        Randomize()
        Dim RndNumber As Integer
        RndNumber = CInt(Int((99999 * Rnd()) + 10000))
        '保存下来的文件名，用日期和5位随机数
        Dim RndFileName As String
        RndFileName = Year(SaveFileName) & Month(SaveFileName) & Day(SaveFileName) & Hour(SaveFileName) & Minute(SaveFileName) & Second(SaveFileName) & CStr(RndNumber)
        SaveFileName = RndFileName & "." & FileExt
        fp.Ext = FileExt
        fp.Filename = fileName
        fp.NewFilename = SaveFileName
        fp.FileSize = jpeg_image_upload.ContentLength
        fp.Path = "../upfiles/" & SaveFileName
        jpeg_image_upload.SaveAs(Server.MapPath(fp.Path))
        Return fp
    End Function

End Class