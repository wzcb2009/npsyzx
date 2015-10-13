Public Class ShowWeb
    Inherits System.Web.UI.Page
    Public flag As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim id As Integer
        id = Request.QueryString("id")
        Dim bll As New BLL.DataMainBLL
        Dim dm As New Model.DataMain
        dm = bll.Entity(id)
        If dm IsNot Nothing Then

            lt_content.Text = dm.Content
            lt_info.Text = "发布人：" & dm.Author & " 发布时间：" & dm.Pubdate.ToString("yyyy-MM-dd") & " 浏览次数:" & dm.BrowCount
            lt_title.Text = dm.Title
            bll.UpdateClicks(id)

            lt_files.Text = files(dm.Id)
        End If

    End Sub
    Function files(parentid As Integer) As String
        Dim bll As New BLL.FilelistBLL
        flag = bll.CountbyParentid(parentid)
        If flag = False Then
            Return ""
        End If
        Dim dt As DataTable = bll.Dt2(parentid)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            Dim v As String
            If r("ext") = "doc" Or r("ext") = "ppt" Then
                v = "<a class='view'  href=""javascript:showfile(" & r("fileid") & ",'" & r("title") & "')""   title=""查看文件吗?"">预览</a>"

            End If
            s.AppendLine("<li id=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title'   href='../file/filedown.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a>" & v & "<div class='info'> 上传时间：" & r("pubdate") & "</div></div>")
            s.AppendLine("</li>")
        Next
        Return "<ul class=""filelist"">" & s.ToString & "<li class='clearbox'></li></ul>"
    End Function

End Class