Imports System.IO
Imports Wzsckj.com.Common

Partial Class Common_upload

    Inherits System.Web.UI.Page
    Protected Sub Page_Load2(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '在这里可以写一些验证身份的代码 


        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))

            Response.End()
        End If

        Dim parentid, projectid, pindex As Integer
        parentid = Request.Form("parentid")
        projectid = Request.Form("projectid")
        pindex = Request.Form("pindex")

        Dim jpeg_image_upload As HttpPostedFile = Request.Files("Filedata")
        Dim fileName As String = jpeg_image_upload.FileName
        Dim filesize As Integer = jpeg_image_upload.ContentLength


        ' 图片格式




        '   Dim fe As FileExtension() = {FileExtension.GIF, FileExtension.JPG, FileExtension.PNG, FileExtension.ZIP, FileExtension.SWF, FileExtension.RAR, FileExtension.WMV, FileExtension.OFFICE, FileExtension.PDF}



        Dim FileExt As String = fileName.Substring(fileName.LastIndexOf(".") + 1)

        ' If FileValidation.IsAllowedExtension(jpeg_image_upload, fe) = False Then

        '    Response.Write("")
        'Response.End()
        '   End If

        Dim SaveFileName As String
        SaveFileName = Now
        Randomize()
        Dim RndNumber As Integer
        RndNumber = CInt(Int((99999 * Rnd()) + 10000))
        '保存下来的文件名，用日期和5位随机数
        Dim RndFileName As String
        RndFileName = Year(SaveFileName) & Month(SaveFileName) & Day(SaveFileName) & Hour(SaveFileName) & Minute(SaveFileName) & Second(SaveFileName) & CStr(RndNumber)
        SaveFileName = RndFileName & "." & FileExt
        Dim dirpath As String = "../upfiles/"
        jpeg_image_upload.SaveAs(Server.MapPath(dirpath & SaveFileName))
        Dim filetitle As String = IO.Path.GetFileNameWithoutExtension(fileName)
        Dim f As New Model.FileList
        f.Title = Path.GetFileNameWithoutExtension(fileName)
        f.Filesize = filesize
        f.Path = dirpath & SaveFileName
        f.UserId = Session("userid")
        f.Pubdate = Now
        f.PIndex = pindex
        f.ProjectId = projectid
        f.Parentid = parentid
        f.Ext = FileExt
        f.Content = ""
        Dim bll As New BLL.FilelistBLL
        bll.Add(f)

        If f.FileId > 0 Then
            Dim dwz_ As New StringHandling.DWZJson.DWZ
            dwz_.statusCode = StringHandling.DWZJson.statusCode.OK
            dwz_.message = "成功上传文件：" & fileName
            dwz_.Other = """fileid"":" & f.FileId & ",""ext"":""" & f.Ext & """,""pubdate"":""" & Now & """"
            Response.Write(StringHandling.DWZJson.Alert(dwz_))

            Response.End()
        Else
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()
        End If
        Response.End()
    End Sub

End Class
