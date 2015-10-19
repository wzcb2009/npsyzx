Imports Wzsckj.com.Common
Imports System.Text
Imports StringHandling

Public Class BlogView
    '$Title
    '$Nickname
    '$Template
    '$Remark
    '$Userinfo
    '$Caseitem
    '$Visitusers
    '$Pager
    '$Copyright
    Shared Function Userinfo(userid As Integer, Nickname As String) As String
        Dim s As New Text.StringBuilder
        Dim ui As Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        ui = userbll.GetObj(userid)
        If ui IsNot Nothing Then
            ui.FaceUrl = Replace(ui.FaceUrl, "../", "")
            If ui.FaceUrl = "" Then
                ui.FaceUrl = "images/user.gif"
            End If
            s.AppendLine("<img src=""/eport/" & ui.FaceUrl & """ class=""photo"">")
            s.AppendLine("<p class=""fn"">姓名：" & ui.Truename & "</p>")
            s.AppendLine("<p class=""nickname"">网名：" & Nickname & "</p>")
            's.AppendLine("")

        End If
        Return s.ToString
    End Function
    Shared Function CaseItem(username As String) As String
        Dim s As New Text.StringBuilder
        s.AppendLine("<li><a href=""userindex.aspx?blog=" & username & """>所有</a></li>")
        s.AppendLine("<li><a href=""userindex.aspx?blog=" & username & "&caseid=595"">心得体会</a></li>")
        Return s.ToString
    End Function
    Shared Function infoPagelist(ByRef pi As PagerInfo, username As String) As String
        Dim dt As Data.DataTable
        Dim dmbll As New BLL.DataMainBLL
        dt = dmbll.PagerDt(pi)
        Dim s As New StringBuilder
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            s.AppendLine(" <h3 class=""title""><a href=""show.aspx?id=" & rs("id") & """>" & rs("title") & "</a></h3>")
            s.AppendLine(" <ul class=""text"">")
            If Not IsDBNull(rs("content")) Then
                ' s.AppendLine(StringHandling.String.GetTopic(rs("content"), 200))

                s.AppendLine(rs("content"))

            End If
            s.AppendLine("  </ul>")
            s.AppendLine(" <div class=""textfoot""> <a href=""show.aspx?blog=" & username & "&id=" & rs("id") & """>阅读全文</a></div>")

        Next
        dt.Dispose()
        Return s.ToString
    End Function
    Shared Function IndexinfoPagelist(ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
        Dim dmbll As New BLL.DataMainBLL
        dt = dmbll.PagerDt(pi)
        Dim s As New StringBuilder
        Dim userbll As New BLL.UserlistBLL
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            s.AppendLine(" <h3 class=""title""><a href=""show.aspx?id=" & rs("id") & """>" & rs("title") & "</a></h3>")
            s.AppendLine(" <ul class=""text"">")
            '获取新闻内容图片作为封面
            Dim imageSrc As String = StringHandling.HTML.getImagePath(SafeData.s_string(rs("content")))



            imageSrc = imageSrc.Replace("../", "")
            imageSrc = imageSrc.Replace("/Article/", "Article/")

            If imageSrc <> "" Then
                Dim username As String = userbll.username(rs("userid"))
                s.AppendLine("<figure><img src=""" & imageSrc & """      alt='" & rs("title") & "'/></figure>")
                s.AppendLine("<ul>")
                s.AppendLine("<p>" & StringHandling.String.gettitle(StringHandling.HTML.NoHTML(rs("content")), 200) & "</p>")
                s.AppendLine("<a title=""" & rs("title") & """ href='webshow.aspx?id=" & rs("id") & "' target=""_blank"" class=""readmore"">阅读全文>></a> ")
                s.AppendLine("</ul>")
                s.AppendLine("  <p class=""dateview""><span>" & Convert.ToDateTime(rs("pubdate")).ToString("yyyy-MM-dd") & "</span><span>作者：" & rs("author") & "</span><span>个人博客：[<a href=""userindex.aspx?blog=" & username & """>程序人生</a>]</span></p>")
            End If

        Next
        dt.Dispose()
        Return s.ToString
    End Function
    Shared Function IndexinfoPagelist2(ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
        Dim dmbll As New BLL.DataMainBLL
        dt = dmbll.PagerDt(pi)
        Dim s As New StringBuilder
        Dim userbll As New BLL.UserlistBLL
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            Dim username As String = userbll.UserName(rs("userid"))
            d = rs("pubdate")
            Dim flag As Boolean = False
            s.AppendLine(" <h2 >" & rs("title") & "</h2>")
            s.AppendLine("  <p class=""dateview""><span>" & Convert.ToDateTime(rs("pubdate")).ToString("yyyy-MM-dd") & "</span><span>作者：" & rs("author") & "</span><span>个人博客：[<a href=""userindex.aspx?blog=" & username & """>程序人生</a>]</span></p>")
            '获取新闻内容图片作为封面
 


             s.AppendLine(" <ul class=""nlist"">")




            s.AppendLine("<p>" & StringHandling.String.gettitle(StringHandling.HTML.NoHTML(rs("content")), 200) & "</p>")
            s.AppendLine("<a title=""" & rs("title") & """ href='webshow.aspx?id=" & rs("id") & "' target=""_blank"" class=""readmore"">阅读全文>></a> ")

            s.AppendLine("</ul>")

        Next
        dt.Dispose()
        Return s.ToString
    End Function

    Shared Function IndexinfoToplist(orderby As String) As String
        Dim dt As Data.DataTable
        Dim dmbll As New BLL.DataMainBLL
        dt = dmbll.DtByModuleid(2, 10, orderby)
        Dim s As New StringBuilder

        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            s.AppendLine(" <li><a href=""show.aspx?id=" & rs("id") & """>" & rs("title") & "</a></li>")
        Next
        dt.Dispose()
        Return s.ToString
    End Function


    Shared Function info(id As Integer) As String
        Dim dm As Model.DataMain
        Dim dmbll As New BLL.DataMainBLL
        dm = dmbll.Entity(id)
        Dim s As New StringBuilder
        If dm IsNot Nothing Then
            s.AppendLine(" <h3 class=""title""> " & dm.Content & " </h3>")
            s.AppendLine(" <ul class=""text"">")
            s.AppendLine(dm.Content)
            s.AppendLine("  </ul>")
            s.AppendLine(" <div class=""textfoot""> 阅读(" & dm.BrowCount & ") | 发布日期(" & dm.PubDate.ToShortDateString & ") </div>")

        End If

        Return s.ToString
    End Function
    Shared Function Userfaces(userid As Integer, parentid As Integer) As String
        Dim s As New Text.StringBuilder
        Dim dt As DataTable
        Dim uvl As New Model.UserViewList
        uvl.ModuleId = 2
        uvl.ObjUserid = userid
        uvl.Parentid = parentid
        dt = BLL.UserViewListBLL.dt(uvl)
        Dim ui As Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        For Each rs As DataRow In dt.Rows
            Dim byuserid As Integer = rs("userid")
            ui = userbll.GetObj(byuserid)
            If ui IsNot Nothing Then
                ui.FaceUrl = Replace(ui.FaceUrl, "../", "")
                If ui.FaceUrl = "" Then
                    ui.FaceUrl = "images/user.gif"
                End If
                s.AppendLine("<li><a href=""userindex.aspx?blog=" & ui.UserName & "/""><img src=""/eport/" & ui.FaceUrl & """></a>")
                s.AppendLine("<p class=""fn"">姓名：" & ui.Truename & "</p></li>")
               

            End If
        Next
        Return s.ToString
    End Function
    Shared Function PicturelistHotSingle(caseid As Integer, topRows As Integer, width As Integer, heigth As Integer) As String
        Dim dt As Data.DataTable
        Dim bll As New BLL.DataMainBLL
        Dim filebll As New BLL.FilelistBLL

        dt = bll.Dt(caseid, 20)

        Dim i As Integer = 1

        Dim s As New StringBuilder
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        Dim file As New Model.FileList
        Dim n As Integer
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            '获取新闻内容图片作为封面
            Dim imageSrc As String = StringHandling.HTML.getImagePath(SafeData.s_string(rs("content")))
            If imageSrc = "" Then
                file = New Model.FileList
                file = fileBll.EntityByparentid(caseid, rs("id"))
                If file IsNot Nothing Then
                    imageSrc = file.IndexImagePath
                    If imageSrc = "" Then
                        imageSrc = file.Path

                    End If
                    '判断是否为视频，取得视频首页图片路径
                    If imageSrc <> "" Then
                        If Not (imageSrc.Contains(".jpg") Or imageSrc.Contains(".png") Or imageSrc.Contains("gif")) Then
                            imageSrc = ""
                        End If
                    Else
                        imageSrc = ""

                    End If
                End If
            End If



            imageSrc = imageSrc.Replace("/Article/", "Article/")

            If imageSrc <> "" Then
                n = n + 1
                s.AppendLine("<li><a   title='" & rs("title") & "'   href='../webshow.aspx?id=" & rs("id") & "'><img src=""" & imageSrc & """ width='" & width & "' height='" & heigth & "'    alt='" & rs("title") & "'/></a><span>" & rs("title") & "</span></li>")
                If n = 6 Then
                    Exit For
                End If
            End If


          
        Next
        dt.Dispose()
        Return s.ToString
    End Function

End Class
