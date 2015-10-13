Imports System.IO
Partial Class Common_upload

    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '在这里可以写一些验证身份的代码 
        'Dim caseid As Integer
        'caseid = Request.Form("caseid")
        Dim type As Integer = Request.QueryString("type")

        'If Session("username") = "" Then
        'Response.Write("")
        ' Response.End()
        'End If
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

        jpeg_image_upload.SaveAs(Server.MapPath("../upfiles/" & SaveFileName))

        Dim filetitle As String = IO.Path.GetFileNameWithoutExtension(fileName)

        If type = 1 Then
            Response.Write("{""err"":"""",""msg"":""" & SaveFileName & """}")
        Else
            Response.Write(SaveFileName) '将缩略图地址返回
        End If

        Response.End()
    End Sub
 
End Class
