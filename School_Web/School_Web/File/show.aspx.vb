Public Class show1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim fileid As Integer = Request.QueryString("fileid")
        Dim bll As New BLL.FilelistBLL
        Dim f As New Model.FileList
        f = bll.Entity(fileid)
        If f IsNot Nothing Then

            Dim fullpath As String = Server.MapPath(f.Path)
            If Not f.Path.Contains(".") Then
                Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
                Response.End()
            End If
            Dim s() As String = f.Path.Split(".")
            Dim swfpath As String = f.Path.Replace(s(s.Length - 1), "swf")

            Dim flag As Boolean = IO.File.Exists(Server.MapPath(swfpath))


            If flag Then
                Response.Redirect(swfpath)


            Else
                Response.Redirect("/file/filedown.aspx?fileid=" & fileid)

            End If


        End If
    End Sub

End Class