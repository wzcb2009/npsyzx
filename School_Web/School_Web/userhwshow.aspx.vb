Imports StringHandling
Imports Wzsckj.com.Common

Public Class userhwshow
    Inherits System.Web.UI.Page
    Dim zid, userid As Integer
    Dim action_ As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        zid = Request.QueryString("zid")

        action_ = Request.QueryString("action")



        userid = Session("userid")
        lt_hwinfo.Text = hwinfo(zid, 0)
        lt_userhwinfo.Text = hwinfo(zid, userid)

        hwid.Value = zid

        If action_ = "mod" Then
            Dim dm As New Model.DataMain
            dm = bll.EntityByParentId(zid, userid)

            If dm Is Nothing Then
                Return
            End If
            hwid.Value = dm.ParentId
            lt_content.Text = dm.Content
            txt_title.Text = dm.Title
            lt_files.Text = files2(dm.Id)
            hd_action.Value = "mod"
        End If
    End Sub
    Dim bll As New BLL.DataMainBLL

    Function hwinfo(zid As String, userid As Integer)
        Dim s As New StringBuilder

        Dim dm As Model.DataMain
        Dim bll As New BLL.DataMainBLL
        If userid = 0 Then
            dm = bll.Entity(zid)

        Else
            dm = bll.EntityByParentId(zid, userid)

        End If
        If dm Is Nothing Then
            Return ""

        End If
        If userid = 0 Then
            lt_hwtitle.Text = dm.Title

        End If
        Dim file As Model.FileList
        Dim filebll As New BLL.FilelistBLL
        file = filebll.EntityByparentid(dm.Caseid, dm.Id)


        '   If file IsNot Nothing Then
        s.AppendLine("<div class=""media"">")
        Dim user As Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(dm.Userid)
        Dim imageSrc As String '= SafeData.s_string(file.IndexImagePath).Replace("../", "")
        If user IsNot Nothing Then

            imageSrc = user.FaceUrl


        End If
        If imageSrc = "" Then
            imageSrc = "images/user.gif"
        End If
        s.AppendLine("<a class=""pull-left""   title='" & dm.Title & "'   href='webshow.aspx?id=" & dm.Id & "'><img width='60' class=""media-object img-rounded""  src='" & imageSrc & "' alt='" & dm.Title & "'/></a><div class=""media-body""><h4 class=""media-heading"">" & dm.Title & "</h4><p><samll>作者:" & dm.Author & ",发布日期：" & Convert.ToDateTime(dm.PubDate).ToShortDateString & ",截至日期：" & dm.EndDate.ToString("yyyy-MM-dd") & "</small></p>" & dm.Content & files(dm.Id) & "</div>")
        s.AppendLine("</div>")
        '  End If
        Return s.ToString
    End Function
    Function files(parentid As Integer) As String


        Dim bll As New BLL.FilelistBLL
        Dim flag As Boolean
        flag = bll.CountbyParentid(parentid)
        If flag = False Then
            Return ""
        End If
        Dim dt As DataTable = bll.dt2(parentid)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows

            Dim filesize As String = FileHelper.file_size(r("filesize"))

            s.AppendLine("<li id=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title'   href='../file/filedown.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a>大小：" & filesize & " </div>")
            s.AppendLine("</li>")

        Next

        Return "  <ul class=""filelist"">" & s.ToString & "</ul>"
    End Function
    Function files2(parentid As Integer) As String


        Dim bll As New BLL.FilelistBLL
        Dim flag As Boolean
        flag = bll.CountbyParentid(parentid)
        If flag = False Then
            Return ""
        End If
        Dim dt As DataTable = bll.dt2(parentid)
        Dim s As New StringBuilder
        Dim fileinput As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.AppendLine("<li id=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title'   href='../file/filedown.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a><a class='del' onclick='delfile2(" & r("fileid") & ")'></a><div class='info'> 上传时间：" & r("pubdate") & "</div></div>")
            s.AppendLine("</li>")
            fileinput.AppendLine("<input name='fileid' value='" & r("fileid") & "' type='hidden' />")
        Next
        lt_fileinput.Text = fileinput.ToString
        Return s.ToString
    End Function

End Class