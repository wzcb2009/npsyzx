Imports StringHandling.DWZJson

Public Class FileDel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()

        End If

        Dim fileid As Integer = Request("fileid")
        Dim bll As New BLL.FilelistBLL
        Dim f As New Model.FileList
        f = bll.Entity(fileid)
        Dim dwz_ As New DWZ
        If f IsNot Nothing Then
            Dim fullpath As String = Server.MapPath(f.Path)
            Dim flag As Boolean
            flag = bll.Del(f.FileId)

            If IO.File.Exists(fullpath) And flag Then
                dwz_.message = "删除成功"
                dwz_.statusCode = statusCode.OK
                dwz_.rel = "file" & fileid
                IO.File.Delete(fullpath)
                Response.Write(StringHandling.DWZJson.Alert(dwz_))
                Response.End()
            Else
                dwz_.message = "删除失败：文件不存在！"
                dwz_.statusCode = statusCode.Info
                Response.Write(StringHandling.DWZJson.Alert(dwz_))
                Response.End()
            End If
        Else
            dwz_.message = "删除失败：记录不存在！"
            dwz_.statusCode = statusCode.Info
            Response.Write(StringHandling.DWZJson.Alert(dwz_))
            Response.End()

        End If


    End Sub

End Class