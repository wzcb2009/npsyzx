Imports Wzsckj.com.Common

Public Class FileAdd
    Inherits System.Web.UI.Page
    Public ap As New ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
 

        ap = ActionHelper.PageActionPara
        ap.Caseid = Request.QueryString("caseid")
        Dim title As String
  
        lt_title.Text = title
        Dim roleid As Integer
        Dim uscBll As New BLL.UserSystemCaseBLL
        roleid = uscBll.Caseid(67, ap.UserId) '获得用户角色
        If roleid = 75 Then
            lt_files.Text = files(ap.Pindex, ap.ID, ap.UserId)
        Else
            lt_files.Text = files(ap.Pindex, ap.ID, 0)

        End If
    End Sub
    Function files(caseid As Integer, parentid As Integer, userid As Integer) As String
        Dim bll As New BLL.FilelistBLL
        Dim dt As DataTable = bll.Dt(caseid, parentid, userid)
        Dim s As New StringBuilder

        For Each r As DataRow In dt.Rows
            Dim dostr As String
            dostr = "<a class='del' href=""javascript:delfile(" & r("fileid") & ")""     title=""确定要删除吗?""></a>"
            If r("ext") = "doc" Or r("ext") = "doc" Or r("ext") = "xls" Or r("ext") = "pdf" Then
                Dim ss() As String = r("path").Split(".")
                Dim swfpath As String = r("path").Replace(ss(ss.Length - 1), "swf")
                If IO.File.Exists(Server.MapPath(swfpath)) Then


                    dostr = dostr & "<a class='view'  href=""javascript:showfile(" & r("fileid") & ",'" & r("title") & "')""   title=""查看文件吗?"">预览</a>"
                Else
                    dostr = dostr & "<a class='view'  href=""" & r("Path") & """    >下载</a>"

                End If
            End If
            s.AppendLine("<li class=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title' targetType=""navTab"" target=""dwzExport"" href='../file/filedown.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a>" & dostr & "<div class='info'> 上传时间：" & r("pubdate") & "</div></div>")
            s.AppendLine("</li><li class='clearbox'></li>")
        Next
        Return s.ToString
    End Function
End Class