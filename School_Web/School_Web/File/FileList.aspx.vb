Public Class FileList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim projectid, pindex As Integer
        projectid = Request("projectid")
        pindex = Request("pindex")
        Response.Write(files(pindex, projectid))
    End Sub
    Function files(caseid As Integer, parentid As Integer) As String
        Dim bll As New BLL.FilelistBLL
        Dim dt As DataTable = bll.Dt(caseid, parentid)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.AppendLine("<li id=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title' title='下载文件' targetType=""navTab"" target=""dwzExport"" href='../file/show.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a></div>")
            s.AppendLine("</li><li class='clearbox'></li>")
        Next
        Return "<ul class=""filelist"">" & s.ToString & "</ul>"
    End Function
End Class