Imports System.Data

Imports System.Text
Imports StringHandling
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Imports BLL

Public Class DataMainView
    Dim bll As New BLL.DataMainBLL
    Dim scbll As New BLL.SystemCaseBLL
    Dim fileBll As New BLL.FilelistBLL
    Function NewsNav(id As Integer, caseid As Integer) As String
        Dim s As New StringBuilder
        Dim dm As Model.DataMain = DataMainBLL.EntityPrev(id, caseid)
        s.Append("<div class='lt'>")
        If dm IsNot Nothing Then
            s.Append("<a href='showweb.aspx?id=" & dm.Id & "'>上一篇：" & dm.Title & "</a>")
        Else
            s.Append("上一篇：没有了")
        End If
        s.Append("</div>")
        dm = DataMainBLL.EntityNext(id, caseid)
        s.Append("<div class='rt'>")
        If dm IsNot Nothing Then
            s.Append("<a href='showweb.aspx?id=" & dm.Id & "'>下一篇：" & dm.Title & "</a>")
        Else
            s.Append("下一篇：没有了")
        End If
        s.Append("</div>")
        Return s.ToString

    End Function
    Function KeywordinfoPagelist(ByRef pi As PagerInfo) As String
        pi.orderDirection = "desc"
        pi.orderField = "pubdate"
        pi.fldName = "pubdate"
        Dim dt As DataTable
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder

        Dim url As String
        Dim t As String
        For Each rs As Data.DataRow In dt.Rows
            Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(rs("caseid")))
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))

            If filecount = 1 And typeid = CaseType.DownLoad Then
                t = "<i class='icon-download-alt' ></i>"

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If
            Dim cmdstr As String = ""
            If rs("cmd") Then
                cmdstr = "<i class=""icon-thumbs-up icon-red""></i>"
            End If

            s.AppendLine("<li><span class='info'>" & d.ToString("yyyy-MM-dd") & "</span><a  title='" & rs("title") & "'   href='" & url & "'>·" & rs("title") & "</a>" & cmdstr & t & "</li>")


        Next
        dt.Dispose()
        Return s.ToString
    End Function
    Function infoPagelist2(caseids As String, ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
        pi.strwhere = "caseid in(" & caseids & ")"
        pi.orderDirection = "desc"
        pi.orderField = "pubdate"
        pi.fldName = "pubdate"
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder


        Dim url As String
        Dim t As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))


            url = "webshow.aspx?id=" & rs("id")



            Dim cmdstr As String = ""
            If rs("cmd") Then
                cmdstr = "<i class=""icon-thumbs-up icon-red""></i>"
            End If

            s.AppendLine("<li><span class='info'>" & d.ToString("yyyy-MM-dd") & "</span><a class='item' title='" & rs("title") & "'   href='" & url & "'>·" & rs("title") & "</a>" & cmdstr & t & "</li>")


        Next
        dt.Dispose()
        Return s.ToString
    End Function

    Function infoPagelist(caseid As Integer, ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            pi.strwhere = "caseid in(" & CASEIDLIST & ")"

        Else
            pi.strwhere = "caseid =" & caseid
        End If
        pi.strwhere = pi.strwhere & " and status=1"
        pi.orderDirection = "desc"
        pi.orderField = "pubdate"
        pi.fldName = "pubdate"
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder

        Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String
        Dim t As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))

            If filecount = 1 And typeid = CaseType.DownLoad Then
                t = "<i class='icon-download-alt' ></i>"
                f = New Model.FileList
                '  f.CaseId = rs("caseid")
                f.Parentid = rs("id")

                url = "file/filedown.aspx?fileid=" & fileBll.fileid(f)



            Else
                url = "webshow.aspx?id=" & rs("id")


            End If
            Dim cmdstr As String = ""
            If rs("cmd") Then
                cmdstr = "<i class=""icon-thumbs-up icon-red""></i>"
            End If

            s.AppendLine("<li><span class='info'>" & d.ToString("yyyy-MM-dd") & "</span><a class='item' title='" & rs("title") & "'   href='" & url & "'>·" & rs("title") & "</a>" & cmdstr & t & "</li>")


        Next
        dt.Dispose()
        Return s.ToString
    End Function
    Function DownPagelist(caseid As Integer, ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
       
            pi.strwhere = "caseid =" & caseid

        pi.orderDirection = "desc"
        pi.orderField = "pubdate"
        pi.fldName = "pubdate"
        dt = DataMainBLL.PagerDt(pi)
        Dim s As New StringBuilder

        Dim typeid As Integer = SafeData.s_integer(SystemCaseBLL.CaseData(caseid))
        Dim url As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim flag As Boolean = False
            Dim filecount As Integer = FilelistBLL.CountbyParentid(rs("id"))
            Dim fileid As Integer = 0
            If filecount = 1 And typeid = CaseType.DownLoad Then
                f = New Model.FileList
                '   f.CaseId = rs("caseid")
                f.Parentid = rs("id")

                url = "file/filedown.aspx?fileid=" & FilelistBLL.fileid(f)
                flag = True
            Else
                url = "webshow.aspx?id=" & rs("id")


            End If
            Dim cmdstr As String = ""
            If rs("cmd") Then
                cmdstr = "<i class=""icon-thumbs-up icon-red""></i>"
            End If
            s.AppendLine("<li><span class='info'>" & d.ToString("yyyy-MM-dd") & "</span><a class='item' title='" & rs("title") & "'   href='" & url & "'>·" & rs("title") & "</a>" & cmdstr & "</li>")

        Next
        dt.Dispose()
        Return s.ToString
    End Function

    Function PicturePagelist(caseid As Integer, ByRef pi As PagerInfo, Optional cols As Integer = 3) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)


            pi.strwhere = "caseid in(" & CASEIDLIST & ")"

        Else
            pi.strwhere = "caseid =" & caseid
        End If
        pi.orderDirection = "desc"
        pi.orderField = "pubdate"
        pi.fldName = "pubdate"
        dt = bll.PagerDt(pi)

        Dim s As New StringBuilder
        Dim file As New Model.FileList
        Dim i As Integer = 1
        Dim spanInt As Integer = 12 \ cols
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        s.AppendLine(" <div class=""row-fluid""><ul class='thumbnails'>")


        For Each rs As Data.DataRow In dt.Rows

            Dim d As DateTime
            d = rs("pubdate")
            '获取新闻内容图片作为封面
            Dim imageSrc As String = StringHandling.HTML.getImagePath(rs("content"))
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
                            imageSrc = "images/normal.png"
                        End If
                    Else
                        imageSrc = "images/normal.png"

                    End If
                End If
            End If
            imageSrc = imageSrc.Replace("../", "")
            s.AppendLine("<li class='span" & spanInt & "'><a class='thumbnail' title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""images/blank.gif""   data-original='" & imageSrc & "' alt='" & rs("title") & "'/><p class='text-center'>" & rs("title") & "</p></a></li>")
            If (i Mod 3 = 0) And i > 0 Then
                s.AppendLine("</ul></div>")
                '  If i < dt.Rows.Count Then
                s.AppendLine(" <div class=""row-fluid""><ul class='thumbnails'>")
                'End If
            End If
            i = i + 1

        Next
        s.AppendLine("</ul></div>")
        s.AppendLine("<div style='clear:both'></div>")
        dt.Dispose()
        Return s.ToString
    End Function
    Function Picturelist(caseid As Integer, Optional topRows As Integer = 10, Optional cols As Integer = 3) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim i As Integer = 1
        Dim spanInt As Integer = 12 \ cols
        Dim s As New StringBuilder
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        s.AppendLine(" <div class=""row-fluid""><ul class='thumbnails'>")
        Dim file As New Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            '获取新闻内容图片作为封面
            Dim imageSrc As String = StringHandling.HTML.getImagePath(rs("content"))
            If imageSrc = "" Then
                file = New Model.FileList
                file = fileBll.EntityByparentid(caseid, rs("id"))
                If file IsNot Nothing Then
                    imageSrc = file.IndexImagePath
                    If imageSrc = "" Then
                        imageSrc = file.Path

                    End If
                    imageSrc = LCase(imageSrc)
                    '判断是否为视频，取得视频首页图片路径
                    If imageSrc <> "" Then
                        If Not (imageSrc.Contains(".jpg") Or imageSrc.Contains(".png") Or imageSrc.Contains("gif")) Then
                            imageSrc = "images/normal.png"
                        End If
                    Else
                        imageSrc = "images/normal.png"

                    End If
                End If
            End If
            imageSrc = imageSrc.Replace("../", "")
            s.AppendLine("<li class='span" & spanInt & "'><a class='thumbnail' title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""images/blank.gif""   data-original='" & imageSrc & "' alt='" & rs("title") & "'/><p class='text-center'>" & rs("title") & "</p></a></li>")
            If (i Mod 3 = 0) Then
                s.AppendLine(" <li style='clear:both'></li>")
                s.AppendLine("</ul></div>")
                If i < dt.Rows.Count Then

                    s.AppendLine(" <div class=""row-fluid""><ul class='thumbnails'>")
                End If
            End If
            i = i + 1
        Next
        dt.Dispose()
        Return s.ToString
    End Function
    Function PicturelistSingle(caseid As Integer, topRows As Integer, width As Integer, heigth As Integer) As String
        Dim dt As Data.DataTable

        dt = bll.Dt(caseid, 200)

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


            imageSrc = imageSrc.Replace("../", "")

            If imageSrc <> "" Then
                Dim newsrc As String = imageSrc

                If Not newsrc.Contains("http://") Then

                    Dim ofile As String = Current.Server.MapPath(newsrc)
                    If IO.File.Exists(ofile) Then
                        Dim ext As String = IO.Path.GetExtension(newsrc)
                        Dim dfile As String = newsrc.Replace(ext, "_s" & ext)
                        Dim file2 As String = Current.Server.MapPath(dfile)



                        If Not IO.File.Exists(file2) Then

                            If ImageThumbnail.SmallPic(ofile, file2, 400) Then

                                imageSrc = dfile
                            End If


                        Else

                            imageSrc = dfile

                        End If


                    End If
                End If

            End If
            If imageSrc <> "" Then
                n = n + 1
                s.AppendLine("<li><a   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""" & imageSrc & """ width='" & width & "' height='" & heigth & "'    alt='" & rs("title") & "'/></a></li>")
                If n = 5 Then
                    Exit For
                End If
            End If


        Next
        dt.Dispose()
        Return s.ToString
    End Function

    Function PicturelistHotSingle(caseid As Integer, topRows As Integer, width As Integer, heigth As Integer) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            dt = bll.Dt(CASEIDLIST, 200)
        Else
            dt = bll.Dt(caseid, 200)
        End If
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


            imageSrc = imageSrc.Replace("../", "")

            If imageSrc <> "" Then
                Dim newsrc As String = imageSrc

                If Not newsrc.Contains("http://") Then

                    Dim ofile As String = Current.Server.MapPath(newsrc)
                    If IO.File.Exists(ofile) Then
                        Dim ext As String = IO.Path.GetExtension(newsrc)
                        Dim dfile As String = newsrc.Replace(ext, "_s" & ext)
                        Dim file2 As String = Current.Server.MapPath(dfile)



                        If Not IO.File.Exists(file2) Then

                            If ImageThumbnail.SmallPic(ofile, file2, 400) Then

                                imageSrc = dfile
                            End If


                        Else

                            imageSrc = dfile

                        End If


                    End If
                End If

            End If
            If imageSrc <> "" Then
                n = n + 1
                s.AppendLine("<a   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""" & imageSrc & """ width='" & width & "' height='" & heigth & "'    alt='" & rs("title") & "'/></a>")
                If n = 5 Then
                    Exit For
                End If
            End If


            'i = i + 1
            'If i > topRows Then
            '    Exit For
            'End If
        Next
        dt.Dispose()
        Return s.ToString
    End Function

    Function PicturelistHot(caseid As Integer, topRows As Integer, ByRef titles As String, width As Integer, heigth As Integer) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            dt = bll.Dt(CASEIDLIST, 200)
        Else
            dt = bll.Dt(caseid, 200)
        End If
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


            imageSrc = imageSrc.Replace("../", "")
            imageSrc = imageSrc.Replace("/Article/", "Article/")

            If imageSrc <> "" Then
                n = n + 1
                titles = titles & "<li>" & n & "</li> "
                s.AppendLine("<a   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""" & imageSrc & """ width='" & width & "' height='" & heigth & "'    alt='" & rs("title") & "'/></a>")
                If n = 5 Then
                    Exit For
                End If
            End If


            'i = i + 1
            'If i > topRows Then
            '    Exit For
            'End If
        Next
        titles = "<ul>" & titles & "</ul>"
        dt.Dispose()
        Return s.ToString
    End Function

    Function PicturelistHotFlash(caseid As Integer, topRows As Integer, ByRef titles As String, width As Integer, heigth As Integer) As String
        Dim pic As String
        Dim links As String
        Dim texts As String
        Dim dt As Data.DataTable
        dt = bll.Dt(caseid, 200)
         Dim i As Integer = 1
        Dim s As New StringBuilder
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        Dim file As New Model.FileList
        Dim n As Integer
         Dim tempPic As String = ""
        Dim Title1 As String = ""
        Dim Content1 As String = ""
        i = 0
        pic = ""
        links = ""
        texts = ""

        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Title1 = rs("title")
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


            imageSrc = imageSrc.Replace("../", "")
            imageSrc = imageSrc.Replace("/Article/", "Article/")

            If imageSrc <> "" Then
                tempPic = imageSrc
                n = n + 1
                If i = 0 Then
                    pic = tempPic
                    links = "shownews.aspx?zid=" & rs("id")
                    texts = Title1
                Else
                    pic = pic & "|" & tempPic
                    links = links & "|" & "webshow.aspx?id=" & rs("id")
                    texts = texts & "|" & Title1
                End If
                i = i + 1

                If n = 5 Then
                    Exit For
                End If
            End If


            'i = i + 1
            'If i > topRows Then
            '    Exit For
            'End If
        Next
        dt.Dispose()
        Return "<script> var pics='" & pic & "';" & vbCrLf & "	var links='" & links & "';" & vbCrLf & "	var texts='" & texts & "';</script>"

    End Function

    Function PicinfoList(caseid As Integer, courseid As Integer, Optional topnum As Integer = 0) As String
        Dim dt As Data.DataTable
        Dim CASEIDLIST As String
        If scbll.HaveSub(caseid) Then
            CASEIDLIST = scbll.MysubCaseids(scbll.Dt, caseid, courseid)


        Else
            CASEIDLIST = caseid
        End If

        Dim s As New StringBuilder

        '  Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        dt = bll.DtByCaseid(CASEIDLIST, courseid, 3)
        Dim file As Model.FileList


        Dim dmcasebll As New BLL.DatamainCasesetBLL
        s.AppendLine("<div class='row-fluid divderline'>")
        Dim i As Integer
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            file = fileBll.EntityByparentid(rs("caseid"), rs("id"))
            Dim imageSrc As String
            i = i + 1
            Dim urlstr As String
            If file IsNot Nothing Then
                imageSrc = SafeData.s_string(file.IndexImagePath) '.Replace("../", "")
                urlstr = "file/fileshow.aspx?fileid=" & file.FileId
            Else
                urlstr = "#"
            End If
            If imageSrc = "" Then
                imageSrc = "file/images/bank.jpg"
            End If
            s.AppendLine("<div class='span4'><div class=""media"">")
            s.AppendLine("<a class=""pull-left""   title='" & rs("title") & "'   href='" & urlstr & "'><img width='90' class=""media-object img-polaroid""  src='" & imageSrc & "' alt='" & rs("title") & "'/></a><div class=""media-body ""><h5 class=""media-heading"">" & scbll.Casename(rs("zytypeid")) & "</h5><small class=""clear"">" & scbll.Casename(rs("caseid")) & "</small><small class="""">" & rs("author") & "</small></div>")

            s.AppendLine("</div></div>")


        Next
        s.AppendLine("</div>")
        dt.Dispose()
        Return s.ToString

    End Function

    Function PicinfoList(ByRef pi As PagerInfo) As String
        Dim dt As Data.DataTable
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder

        '  Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))

        Dim file As Model.FileList


        Dim dmcasebll As New BLL.DatamainCasesetBLL
        s.AppendLine("<div class='row-fluid divderline'>")
        Dim i As Integer
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            file = fileBll.EntityByparentid(rs("caseid"), rs("id"))
            Dim imageSrc As String
            i = i + 1
            Dim urlstr As String
            If file IsNot Nothing Then
                imageSrc = SafeData.s_string(file.IndexImagePath) '.Replace("../", "")
                urlstr = "file/fileshow.aspx?fileid=" & file.FileId
            Else
                urlstr = "#"
            End If
            If imageSrc = "" Then
                imageSrc = "file/images/bank.jpg"
            End If
            s.AppendLine("<div class='span6'><div class=""media"">")
            s.AppendLine("<a class=""pull-left""   title='" & rs("title") & "'   href='" & urlstr & "'><img width='120' class=""media-object img-polaroid""  src='" & imageSrc & "' alt='" & rs("title") & "'/></a><div class=""media-body ""><h5 class=""media-heading"">" & rs("title") & "</h5><div class='row-fluid'><div class='span6'>作者:" & rs("author") & "</div><div class='text-info span6'>资源类型:" & scbll.Casename(rs("zytypeid")) & "</div></div><p class=""text-success clear"">知识点:" & dmcasebll.caselist(90, rs("id")) & "</p><p class=""text-success clear"">技能点:" & dmcasebll.caselist(91, rs("id")) & "</p></div>")

            s.AppendLine("</div></div>")
            If i Mod 2 = 0 Then
                s.AppendLine("</div>")
                s.AppendLine("<div class='row-fluid divderline'>")

            End If

        Next
        s.AppendLine("</div>")
        dt.Dispose()
        Return s.ToString

    End Function

    Function Picturelist(caseid As Integer, topRows As Integer, heigth As Integer, width As Integer, Optional showtitle As Boolean = True) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            dt = bll.Dt(CASEIDLIST, 100)
        Else
            dt = bll.Dt(caseid, 100)
        End If
        Dim i As Integer = 1

        Dim s As New StringBuilder
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        Dim file As New Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            '获取新闻内容图片作为封面
            Dim imageSrc As String = StringHandling.HTML.getImagePath(SafeData.s_string(rs("content")))
            If imageSrc = "" Then
                file = New Model.FileList
                file = fileBll.EntityByparentid(0, rs("id"))
                If file IsNot Nothing Then

                    imageSrc = Trim(file.IndexImagePath)
                    If imageSrc = "" Then
                        imageSrc = file.Path

                    End If
                    imageSrc = LCase(imageSrc)
                    '判断是否为视频, 取得视频首页图片路径
                    If imageSrc <> "" Then
                        If Not (imageSrc.Contains(".jpg") Or imageSrc.Contains(".png") Or imageSrc.Contains("gif")) Then
                            imageSrc = "images/normal.png"
                        End If
                    Else
                        imageSrc = "images/normal.png"

                    End If
                End If
            End If
            If imageSrc = "" Then
                Continue For

            End If




            'If imageSrc <> "images/normal.png" Then


            '    Dim newsrc As String = imageSrc
            '    If Not newsrc.Contains("http://") Then

            '        Dim ofile As String = Current.Server.MapPath(newsrc)
            '        If IO.File.Exists(ofile) Then
            '            Dim ext As String = IO.Path.GetExtension(newsrc)
            '            Dim dfile As String = newsrc.Replace(ext, "_s" & ext)
            '            Dim file2 As String = Current.Server.MapPath(dfile)
            '            If Not IO.File.Exists(file2) Then
            '                If ImageThumbnail.SmallPic(ofile, file2, 400) Then
            '                    imageSrc = dfile
            '                End If
            '            Else
            '                imageSrc = dfile
            '            End If
            '        End If
            '    End If



            'End If
            Dim whstr As String
            If width > 0 And heigth > 0 Then
                whstr = " width='" & width & "' height='" & heigth & "' "
            ElseIf width > 0 Then
                whstr = " width='" & width & "'   "
            ElseIf heigth > 0 Then
                whstr = "  height='" & heigth & "' "

            End If
            s.AppendLine("<li><a   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img src=""" & imageSrc & """  " & whstr & " data-original='" & imageSrc & "' alt='" & rs("title") & "'/></a>")
            If (showtitle) Then s.AppendLine("<p> <a   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'>" & rs("title") & "</a></p>")
            s.AppendLine(" </li>")

            i = i + 1
            If i > topRows Then
                Exit For
            End If
        Next

        dt.Dispose()
        Return s.ToString
    End Function
    Function PiclistWithBar(caseid As Integer, boxcss As String, topnum As Int16) As String
        Dim s As New StringBuilder


        Dim casename_ As String = scbll.Casename(caseid)


        s.AppendLine("<span class='" & boxcss & "'><h4  class=""divider""><a class='brand' href='webcase.aspx?caseid=" & caseid & "'>" & casename_ & "</a></h4>")
        's.AppendLine("<ul class='piclist'>")
        s.AppendLine(Picturelist(caseid, topnum))
        s.AppendLine("</span>")


        Return s.ToString
    End Function

    Function jccksm(parentid As Integer, srcTypeid As Integer, userid As Integer, courseid As Integer) As String
        Dim s As New StringBuilder

        '检测用户是否已经设置过该参数


        Dim dmbll As New BLL.DataMainBLL
        Dim dmv As New View.DataMainView
        Dim tdt As DataTable = scbll.Dt(srcTypeid)
        For Each sr As DataRow In tdt.Rows
            Dim typeid As Integer = sr("caseid")
            s.AppendLine("<fieldset><legend>" & scbll.Casename(typeid) & "</legend>")

            If typeid = 168 Or typeid = 169 Then
                Dim dmdt As DataTable = dmbll.DtByUserid(typeid, userid)
                For Each dmr As DataRow In dmdt.Rows
                    s.AppendLine(dmv.jcinfo(dmr("id"), userid, dmr("caseid"), dmr("unitid")))
                Next
            Else
                s.AppendLine(dmv.cksmINfo(typeid, userid, courseid))

            End If
            '  s.Append(ff(typeid))
            s.AppendLine("</fieldset>")
        Next
        Return s.ToString
    End Function
    Function infoSinglelist(caseid As Integer, Optional topRows As Integer = 10, Optional titleLength As Integer = 100, Optional casedata As String = "") As String
        Dim dt As Data.DataTable
        Dim CASEIDLIST As String
        If scbll.HaveSub(caseid) Then
            CASEIDLIST = scbll.MysubCaseids(scbll.Dt, caseid, 0, casedata)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim s As New StringBuilder


        Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String

        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))
            If filecount = 1 And typeid = CaseType.DownLoad Then

                url = "file/filedownload.aspx?fileid=" & fileBll.fileid(0, rs("caseid"), rs("id"))

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If

            Dim cid As Integer = rs("caseid")
            Dim cpid As Integer = scbll.Parentid(cid)

            s.AppendLine(" <a class='item' title='" & rs("title") & "'   href='" & url & "'> " & StringHandling.String.GetTopic(rs("title"), titleLength) & "</a> ")
        Next '& scbll.CaseName(cpid) & " " & scbll.CaseName(cid) <span class='info'></span>
        dt.Dispose()
        Return s.ToString
    End Function
    Function cmdinfolist(caseid As Integer, Optional topRows As Integer = 10, Optional titleLength As Integer = 100, Optional casedata As String = "") As String
        Dim dt As Data.DataTable

        dt = bll.cmd_Dt(caseid, topRows)

        Dim s As New StringBuilder


        Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String

        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))
            If filecount = 1 And typeid = CaseType.DownLoad Then

                url = "file/filedownload.aspx?fileid=" & fileBll.fileid(0, rs("caseid"), rs("id"))

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If

            Dim cid As Integer = rs("caseid")
            Dim cpid As Integer = scbll.Parentid(cid)
            Dim dd As String
            If IsDBNull(d.Date) Then
                dd = ""
            Else
                dd = d.Date.ToString("MM-dd")
            End If
            s.AppendLine("<li><a class='item' title='" & StringHandling.SafeData.s_string(rs("title")) & "'   href='" & url & "'>·" & "[" & dd & "] " & StringHandling.String.GetTopic(StringHandling.SafeData.s_string(rs("title")), titleLength) & "</a></li>")
        Next '& scbll.CaseName(cpid) & " " & scbll.CaseName(cid) <span class='info'></span>
        dt.Dispose()
        Return "<ul class=newslist>" & s.ToString & "</ul>"
    End Function
    Function infolist2(caseid As Integer, Optional topRows As Integer = 10, Optional titleLength As Integer = 100, Optional casedata As String = "") As String
        Dim dt As Data.DataTable
        Dim CASEIDLIST As String
        If scbll.HaveSub(caseid) Then
            CASEIDLIST = scbll.MysubCaseids(scbll.Dt, caseid, 0, casedata)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim s As New StringBuilder

        Dim typeid As Integer
        Dim cds As String = SafeData.s_string(scbll.CaseData(caseid))

        If (cds) <> "" Then
            If Not cds.Contains(",") Then
                typeid = Convert.ToInt16(cds)

            End If

        End If
        ' Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))
            If filecount = 1 And typeid = CaseType.DownLoad Then
                f = New Model.FileList
                '   f.CaseId = rs("caseid")
                f.Parentid = rs("id")

                url = "file/filedown.aspx?fileid=" & fileBll.fileid(f)

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If

            Dim cid As Integer = rs("caseid")
            Dim cpid As Integer = scbll.Parentid(cid)

            s.AppendLine("<li><a class='item' title='" & Trim(rs("title")) & "'   href='" & url & "'>·" & "[" & d.Date.ToString("MM-dd") & "][" & scbll.Casename(scbll.Parentid(rs("caseid"))) & "] " & StringHandling.String.GetTopic(Trim(rs("title")), titleLength) & "</a></li>")
        Next '& scbll.CaseName(cpid) & " " & scbll.CaseName(cid) <span class='info'></span>
        dt.Dispose()
        Return "<ul class=newslist>" & s.ToString & "</ul>"
    End Function
    Function infolist3(caseid As Integer, Optional topRows As Integer = 10, Optional titleLength As Integer = 100, Optional casedata As String = "") As String
        Dim dt As Data.DataTable
        Dim CASEIDLIST As String
        If scbll.HaveSub(caseid) Then
            CASEIDLIST = scbll.MysubCaseids(scbll.Dt, caseid, 0, casedata)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim s As New StringBuilder

        Dim typeid As Integer
        Dim cds As String = SafeData.s_string(scbll.CaseData(caseid))

        If (cds) <> "" Then
            If Not cds.Contains(",") Then
                typeid = Convert.ToInt16(cds)

            End If

        End If
        ' Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))
            If filecount = 1 And typeid = CaseType.DownLoad Then
                f = New Model.FileList
                '   f.CaseId = rs("caseid")
                f.Parentid = rs("id")

                url = "file/filedown.aspx?fileid=" & fileBll.fileid(f)

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If

            Dim cid As Integer = rs("caseid")
            Dim cpid As Integer = scbll.Parentid(cid)
            Dim title As String = StringHandling.SafeData.s_string(rs("title"))
            s.AppendLine("<li><a class='item' title='" & title & "'   href='" & url & "'>·" & StringHandling.String.GetTopic(title, titleLength) & "</a></li>")
        Next '& scbll.CaseName(cpid) & " " & scbll.CaseName(cid) <span class='info'></span>
        dt.Dispose()
        Return "<ul class=newslist>" & s.ToString & "</ul>"
    End Function

    Function infolist(caseid As Integer, Optional topRows As Integer = 10, Optional titleLength As Integer = 100, Optional casedata As String = "") As String
        Dim dt As Data.DataTable
        Dim CASEIDLIST As String
        If scbll.HaveSub(caseid) Then
            CASEIDLIST = scbll.MysubCaseids(scbll.Dt, caseid, 0, casedata)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim s As New StringBuilder

        Dim typeid As Integer
        Dim cds As String = SafeData.s_string(scbll.CaseData(caseid))

        If (cds) <> "" Then
            If Not cds.Contains(",") Then
                typeid = Convert.ToInt16(cds)

            End If

        End If
        ' Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))
        Dim url As String
        Dim f As Model.FileList
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim filecount As Integer = fileBll.CountbyParentid(rs("id"))
            If filecount = 1 And typeid = CaseType.DownLoad Then
                f = New Model.FileList
                '   f.CaseId = rs("caseid")
                f.Parentid = rs("id")

                url = "file/filedown.aspx?fileid=" & fileBll.fileid(f)

            Else
                url = "webshow.aspx?id=" & rs("id")


            End If

            Dim cid As Integer = rs("caseid")
            Dim cpid As Integer = scbll.Parentid(cid)
            Dim title As String = StringHandling.SafeData.s_string(rs("title"))
            s.AppendLine("<li><a class='item' title='" & title & "'   href='" & url & "'>·" & "[" & d.Date.ToString("MM-dd") & "] " & StringHandling.String.GetTopic(title, titleLength) & "</a></li>")
        Next '& scbll.CaseName(cpid) & " " & scbll.CaseName(cid) <span class='info'></span>
        dt.Dispose()
        Return "<ul class=newslist>" & s.ToString & "</ul>"
    End Function
    Function infolistWithBar(caseid As Integer, boxcss As String, topnum As Integer) As String
        Dim s As New StringBuilder


        Dim casename_ As String = scbll.Casename(caseid)


        s.AppendLine("<span class='" & boxcss & "'><h4   class=""divider newsbar""><a class='brand' href='webcase.aspx?caseid=" & caseid & "'>" & casename_ & "</a></h4>")
        's.AppendLine("<ul class='newslist'>")
        s.AppendLine(infolist(caseid, topnum))
        s.AppendLine("</span>")


        Return s.ToString
    End Function
    Function infolists(caseid As Integer) As String
        Dim s As New StringBuilder
        Dim dt As DataTable
        dt = scbll.Dt(caseid)

        For Each r As Data.DataRow In dt.Rows
            Dim caseid_ As Integer = r("caseid")
            Dim casename_ As String = r("casename")

            s.AppendLine("<a class='brand' href='#'>" & casename_ & "</a>")
            s.AppendLine("<ul>")
            s.AppendLine(infolist(caseid_))
            s.AppendLine("</ul>")
        Next
        Return s.ToString
    End Function
    Function InfoContent(caseid As Integer) As String
        Dim dm As New Model.DataMain
        dm = bll.EntityByCaseId(caseid)
        If dm IsNot Nothing Then
            Return dm.Content
        Else
            Return ""

        End If
    End Function
    Function InfoTopOne(caseid As Integer) As String
        Dim dm As New Model.DataMain
        dm = bll.EntityByCaseId(caseid)
        If dm IsNot Nothing Then
            Return "<div class='dateinfo'><span class='d'>" & dm.PubDate.Day & "</span><span class='ym'>" & dm.PubDate.Year & "." & dm.PubDate.Month & "</span></div><div class='title'><a href='webshow.aspx?id=" & dm.Id & "'>" & dm.Title & "</a></div>"
        Else
            Return ""

        End If
    End Function

    Function VideoImagesList(caseid As Integer, Optional topRows As Integer = 10) As String
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            dt = bll.Dt(CASEIDLIST, topRows)
        Else
            dt = bll.Dt(caseid, topRows)
        End If
        Dim s As New StringBuilder

        Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(caseid))

        Dim file As Model.FileList


        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            Dim imageSrc As String = StringHandling.HTML.getImagePath(rs("content"))
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
                            imageSrc = "images/normal.png"
                        End If
                    Else
                        imageSrc = "images/normal.png"

                    End If
                End If
            End If
            imageSrc = imageSrc.Replace("../", "")


            s.AppendLine("<div class=""media"">")


            s.AppendLine("<a class=""pull-left""   title='" & rs("title") & "'   href='webshow.aspx?id=" & rs("id") & "'><img width='120' class=""media-object img-rounded""  src='" & imageSrc & "' alt='" & rs("title") & "'/></a><div class=""media-body""><h5 class=""media-heading"">" & rs("title") & "</h5><p><samll>作者:" & rs("author") & "," & Convert.ToDateTime(rs("pubdate")).ToShortDateString & "</small></p></div>")

            s.AppendLine("</div>")

        Next
        dt.Dispose()
        Return s.ToString

    End Function
    Function UserFacelist(caseid As Integer, Optional topnum As Integer = 10) As String

        Dim caseids As String
        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(scbll.Dt, caseid)

            caseids = CASEIDLIST

        Else
            caseids = caseid
        End If


        If caseids.StartsWith(",") Then
            caseids = caseids.Remove(0, 1)

        End If

        Dim dt As DataTable = bll.UserDt(caseids, topnum)

        Dim s As New StringBuilder
        Dim userinfo As Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        For Each rs As DataRow In dt.Rows
            userinfo = userbll.GetObj(rs("userid"))

            Dim imagesrc As String
            imagesrc = userinfo.FaceUrl
            If imagesrc = "" Then
                imagesrc = "images/user.gif"
            End If
            s.AppendLine("<li class='span1'><div class='' ><img class=""img-rounded"" src='" & imagesrc & "' alt='" & userinfo.Truename & "'/><p class='text-center'>" & userinfo.Truename & "</p></div></li>")

        Next
        Return s.ToString
    End Function
    Function UserFacelistByParentid(parentid As Integer) As String


        Dim dt As DataTable = bll.DtByParentid(parentid, 50)
        Dim s As New StringBuilder
        Dim userinfo As Model.Userlist
        Dim userbll As New BLL.UserlistBLL

        For Each rs As DataRow In dt.Rows
            userinfo = userbll.GetObj(rs("userid"))

            Dim imagesrc As String
            imagesrc = userinfo.FaceUrl
            If imagesrc = "" Then
                imagesrc = "images/user.gif"
            End If
            s.AppendLine("<li class='span1'><a class='thumbnail' href='webshow.aspx?id=" & rs("id") & "'><img class=""img-rounded"" src='" & imagesrc & "' alt='" & userinfo.Truename & "'/><p class='text-center'>" & userinfo.Truename & "</p></a></li>")

        Next
        Return s.ToString
    End Function

    Dim userbll As New BLL.UserlistBLL
    Function files(caseid As Integer, userid As Integer, courseid As Integer, parentid As Integer) As String

        Dim s As New StringBuilder

        Dim bll As New BLL.FilelistBLL
        Dim flag As Boolean
        Dim f As New Model.FileList
        f.ProjectId = courseid
        f.CaseId = caseid
        'f.UserId = userid
        f.Parentid = parentid
        flag = bll.Count(f)
        If flag = False Then
            Return caseid & parentid & courseid
        End If
        Dim dt As DataTable = bll.Dt(f)


        For Each r As DataRow In dt.Rows
            s.AppendLine("<div class='media'>")
            s.AppendLine("<a href='file/show.aspx?fileid=" & r("fileid") & "' class='pull-left span3'><img class=""img-polaroid"" src='file/images/" & caseid & ".jpg'/></a>")
            s.AppendLine("<div class='media-body'><h4 class='media-heading'>" & r("title") & "</h4><p>  上传人：" & userbll.Truename(r("userid")) & "</p><p> 上传时间：" & r("pubdate") & "</p></div>")
            s.AppendLine("</div>")

        Next
        Return s.ToString

    End Function
    Function files_Single(caseid As Integer, userid As Integer, courseid As Integer, parentid As Integer) As String

        Dim s As New StringBuilder

        Dim bll As New BLL.FilelistBLL
        Dim flag As Boolean
        Dim f As New Model.FileList
        f.ProjectId = courseid
        f.CaseId = caseid
        'f.UserId = userid
        f.Parentid = parentid
        flag = bll.Count(f)
        If flag = False Then
            Return caseid & parentid & courseid
        End If
        Dim dt As DataTable = bll.Dt(f)


        For Each r As DataRow In dt.Rows
            s.AppendLine("<li class='span3'>")
            s.AppendLine("<a class='thumbnail' href='file/show.aspx?fileid=" & r("fileid") & "'><img src='file/images/" & caseid & ".jpg'/></a>")
            s.AppendLine("<h5>" & r("title") & "</h5>")
            s.AppendLine("</li>")

        Next
        Return s.ToString

    End Function

    Function DatamainFilelist(parentid As Integer, srcTypeid As Integer, userid As Integer, courseid As Integer) As String


        Dim s As New StringBuilder

        '检测用户是否已经设置过该参数


        Dim dmbll As New BLL.DataMainBLL

        Dim tdt As DataTable = scbll.Dt(srcTypeid)
        For Each sr As DataRow In tdt.Rows
            Dim typeid As Integer = sr("caseid")

            s.Append(files_Single(typeid, userid, courseid, 0))

        Next


        Return "<ul class=""thumbnails"">" & s.ToString & "</div>"
    End Function
    Function jcinfo(id As Integer, userid As Integer, caseid As Integer, courseid As Integer) As String
        Dim s As New StringBuilder

        Dim dm As New Model.DataMain
        Dim dmbll As New BLL.DataMainBLL
        dm = dmbll.Entity(id)
        If dm IsNot Nothing Then


            Dim casename As String = scbll.Casename(caseid)



            Dim f As New Model.FileList
            Dim filebll As New BLL.FilelistBLL
            Dim fileid As Integer = filebll.fileid(courseid, dm.Id, dm.Caseid)
            f = filebll.Entity(fileid)
            Dim picpath As String
            If f IsNot Nothing Then
                picpath = f.Path
            End If
            s.AppendLine("<fieldset><legend>" & casename & ":" & dm.Title & "</legend>")
            s.AppendLine("<div style='width:150px; float:left'><img  width=120 src='" & picpath & "'></div>")
            s.AppendLine("<dl><dt>教材名称：</dt><dd>" & dm.Title & "</dd></dl>")
            s.AppendLine("<dl><dt>ISBN：</dt><dd>" & dm.Remark & "</dd></dl>")
            s.AppendLine("<dl><dt>主编：</dt><dd>" & dm.Author & "</dd></dl>")

            s.AppendLine("<dl><dt>出版社：</dt><dd>" & dm.Content & "</dd></dl>")

            s.AppendLine("<div style='clear:both'><a  class='btnEdit' href=""../course/jcinfoweb.aspx?action=mod&id=" & dm.Id & "&objid=0"" target=""navTab"" title="""" rel=""sc_2_navTab"">编辑</a>")
            s.AppendLine("<a class=""btnDel"" href=""../web/newsdo.aspx?action=del&amp;id=" & dm.Id & "&amp;objid=0"" target=""ajaxTodo"" title="""">删除</a></div>")
            s.AppendLine("</fieldset>")
        End If

        Return s.ToString
    End Function
    Function cksmINfo(caseid As Integer, userid As Integer, courseid As Integer)
        Dim dmbll As New BLL.DataMainBLL
        Dim dm As Model.DataMain
        dm = dmbll.EntityByCaseId(caseid, courseid)
        If dm IsNot Nothing Then
            Return dm.Content
        End If
    End Function
    Function jcinfo2(id As Integer, userid As Integer, caseid As Integer, courseid As Integer) As String
        Dim s As New StringBuilder

        Dim dm As New Model.DataMain
        Dim dmbll As New BLL.DataMainBLL
        dm = dmbll.Entity(id)
        If dm IsNot Nothing Then


            Dim casename As String = scbll.Casename(caseid)



            Dim f As New Model.FileList
            Dim filebll As New BLL.FilelistBLL
            Dim fileid As Integer = filebll.fileid(courseid, dm.Id, dm.Caseid)
            f = filebll.Entity(fileid)
            Dim picpath As String
            If f IsNot Nothing Then
                picpath = f.Path
            End If
            's.AppendLine("<h4>" & casename & ":" & dm.Title & "</h4>")
            s.AppendLine("<div class='media'>")
            s.AppendLine("<div class='pull-left'><img class='img-polaroid' width=120 src='" & picpath & "'></div>")
            s.AppendLine("<div class='media-body'><h5 class=""media-heading"">" & dm.Title & "</h5>")
            s.AppendLine("<p>ISBN：" & dm.Remark & "</p>")
            s.AppendLine("<p>主编：" & dm.Author & "</p>")

            s.AppendLine("<p>出版社：" & dm.Content & "</p>")
            s.AppendLine("</div></div>")


        End If

        Return s.ToString
    End Function
    Function cksmINfo2(caseid As Integer, userid As Integer, courseid As Integer)
        Dim dmbll As New BLL.DataMainBLL
        Dim dm As Model.DataMain
        dm = dmbll.EntityByCaseId(caseid, courseid)
        If dm IsNot Nothing Then
            Return "<h4 class='divider'>" & scbll.Casename(caseid) & "</h4><p>" & dm.Content & "</p>"
        End If
    End Function
    Function BookInfolist(parentid As Integer, srcTypeid As Integer, userid As Integer, courseid As Integer) As String
        Dim s As New StringBuilder

        '检测用户是否已经设置过该参数


        Dim dmbll As New BLL.DataMainBLL
        Dim dmv As New View.DataMainView
        Dim tdt As DataTable = scbll.Dt(srcTypeid)
        For Each sr As DataRow In tdt.Rows
            Dim typeid As Integer = sr("caseid")


            If typeid = 168 Or typeid = 169 Then
                s.AppendLine("<h4 class='divider'>" & scbll.Casename(typeid) & "</h4>")
                s.AppendLine("<div class=""row-fluid"">")
                Dim dmdt As DataTable = dmbll.DtByUserid(typeid, userid)
                For Each dmr As DataRow In dmdt.Rows
                    s.AppendLine("<div class='span6'>")
                    s.AppendLine(dmv.jcinfo2(dmr("id"), userid, dmr("caseid"), dmr("unitid")))
                    s.AppendLine("</div>")

                Next
                s.AppendLine("</div>")

            Else


                s.AppendLine(dmv.cksmINfo2(typeid, userid, courseid))

            End If
            '  s.Append(ff(typeid))

        Next
        Return s.ToString
    End Function

End Class
