Imports System.IO

Public Class FileInfoMod
    Inherits System.Web.UI.Page

    Protected Sub Page_Load2(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '在这里可以写一些验证身份的代码 


        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))

            Response.End()
        End If
        Dim SaveFileName As String = ""
        Dim jpeg_image_upload As HttpPostedFile = Request.Files("Filedata")
        If jpeg_image_upload IsNot Nothing Then

            Dim fileName As String = jpeg_image_upload.FileName
            Dim filesize As Integer = jpeg_image_upload.ContentLength
            If filesize > 0 Then

                ' 图片格式
                '   Dim fe As FileExtension() = {FileExtension.GIF, FileExtension.JPG, FileExtension.PNG, FileExtension.ZIP, FileExtension.SWF, FileExtension.RAR, FileExtension.WMV, FileExtension.OFFICE, FileExtension.PDF}
                Dim FileExt As String = fileName.Substring(fileName.LastIndexOf(".") + 1)
                ' If FileValidation.IsAllowedExtension(jpeg_image_upload, fe) = False Then
                '    Response.Write("")
                'Response.End()
                '   End If
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
            End If
        End If
        Dim f As New Model.FileList
        f.FileId = Request.Form("hd_id")
        Dim bll As New BLL.FilelistBLL
        f = bll.Entity(f.FileId)
        GetPageEntity(f)
        If SaveFileName <> "" Then

            f.IndexImagePath = "../upfiles/" & SaveFileName
        End If
        f = bll.Update(f)

        If f.FileId > 0 Then
            Dim dwz_ As New StringHandling.DWZJson.DWZ
            dwz_.statusCode = StringHandling.DWZJson.statusCode.OK
            dwz_.message = "操作成功！"
            Response.Write(StringHandling.DWZJson.Alert(dwz_))

            Response.End()
        Else
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()
        End If
        Response.End()
    End Sub
    Function GetPageEntity(ByRef fl As Model.FileList) As Model.FileList

        FL.Pindex = Request.Form("txt_Pindex")

        FL.Title = Request.Form("txt_Title")

        FL.Content = Request.Form("txt_Content")


        Return FL
    End Function


End Class