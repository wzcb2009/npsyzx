Imports System.Data
Imports System.Text
Imports StringHandling
Imports Wzsckj.com.Common

Public Enum CaseType
    Categories = 6
    News = 7
    Picture = 8
    Content = 9
    IndexPage = 12
    DownLoad = 10
    Links = 11
    Video = 76
    BBS = 84
End Enum
Public Enum SystemCaseConst
    RoleCaseId = 4
    Student = 13
    Teacher = 14
    DePartmentCaseId = 260
    WebTopCaseid = 16
End Enum
Public Class SystemCaseView
    Dim scbll As New BLL.SystemCaseBLL
 
    ''' <summary>
    ''' 菜单导航
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="parentid"></param>
    ''' <param name="mode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function WebMenu(dt As DataTable, ByVal parentid As Integer, ByVal mode As String) As String
        Dim rs() As DataRow = dt.Select(" parentid=" & parentid & " and isshowflag=1", "pindex asc")
         Dim s As New StringBuilder



        ' s.AppendLine("<li><a href='default.aspx'>网站首页</a></li>")
        Dim dh As StringHandling.DWZJson.DwzHref

        For Each r As DataRow In rs
            dh = New StringHandling.DWZJson.DwzHref
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            Dim typeid As Integer
            Dim cds As String = SafeData.s_string(r("casedata"))


            If (cds) <> "" Then
                If Not cds.Contains(",") Then
                    typeid = Convert.ToInt16(cds)

                End If

            End If
            If typeid = CaseType.IndexPage Then
                Dim dm As Model.DataMain
                Dim dmbll As New BLL.DataMainBLL
                dm = dmbll.EntityByCaseId(dh.CaseId)
                If dm IsNot Nothing Then
                    dh.Url = dm.Content

                End If
            End If
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)

            If HaveSubFlag Then
                s.AppendLine("<li class='dropdown'>")
                s.AppendLine("<a class='dropdown-toggle' data-toggle='dropdown' href='" & dh.Url & "'>" & dh.Text & "<b class='caret'></b></a>")
                s.AppendLine("<ul  class='dropdown-menu'>")
                Dim srs() As DataRow = scbll.Dt(dh.CaseId).Select("1=1", "pindex asc")
                For Each sr As DataRow In srs
                    dh = New StringHandling.DWZJson.DwzHref
                    dh.CaseId = sr("caseid")
                    dh.Text = sr("casename")
                    dh.Target = StringHandling.DWZJson.DwzTarget.null
                    dh.Url = "webcase.aspx?caseid=" & dh.CaseId
                    typeid = -1
                    Dim cd As String = SafeData.s_string(sr("casedata"))
                    If (cd) <> "" Then
                        If Not cd.Contains(",") Then
                            typeid = Convert.ToInt16(cd)

                        End If

                    End If


                    If typeid = CaseType.IndexPage Then
                    Dim dm As Model.DataMain
                    Dim dmbll As New BLL.DataMainBLL
                    dm = dmbll.EntityByCaseId(dh.CaseId)
                    If dm IsNot Nothing Then
                        dh.Url = dm.Content

                    End If
                    End If

                    s.AppendLine("<li><a href='" & dh.Url & "'>" & dh.Text & "</a></li>")
                Next
                s.AppendLine("</ul></li>")
            Else

                s.AppendLine("<li><a href='" & dh.Url & "'>" & dh.Text & "</a></li>")


            End If

        Next
      

        Return s.ToString
    End Function
    Function WebMenu2(dt As DataTable, ByVal parentid As Integer, ByVal mode As String) As String
        Dim rs() As DataRow = dt.Select(" parentid=" & parentid & " and isshowflag=1")
         Dim s As New StringBuilder


        s.AppendLine("<table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">  <tr>")
        ' s.AppendLine("<li><a href='default.aspx'>首页</a></li>")
        Dim dh As StringHandling.DWZJson.DwzHref
        Dim i As Integer = 1
        For Each r As DataRow In rs
            dh = New StringHandling.DWZJson.DwzHref
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            Dim typeid As Integer = SafeData.s_integer(r("casedata"))
            If typeid = CaseType.IndexPage Then
                Dim dm As Model.DataMain
                Dim dmbll As New BLL.DataMainBLL
                dm = dmbll.EntityByCaseId(dh.CaseId)
                If dm IsNot Nothing Then
                    dh.Url = dm.Content

                End If
            End If
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)

            If HaveSubFlag Then
                s.AppendLine("<td width=""8"" align=""center""></td>")
                s.AppendLine("<td width=""75"" align=""center"" class=""l1""><a href=""" & dh.Url & """ onMouseOver=""ypSlideOutMenu.showMenu('menu" & i & "');"" onmouseout=""ypSlideOutMenu.hideMenu('menu" & i & "')"">" & dh.Text & "</a></td>")
                s.AppendLine(" <td width=""8"" align=""center""></td>")
                i = i + 1
            Else
                s.AppendLine(" <td width=""8"" height=""32""></td>")
                s.AppendLine("<td width=""75"" align=""center"" class=""l1""><a href=""" & dh.Url & """>" & dh.Text & "</a></td>")
                s.AppendLine("<td width=""8"" align=""center""></td>")
            End If
        Next
        s.AppendLine("  </tr></table>")


        Return s.ToString
    End Function
    Function WebSubMenu(dt As DataTable, ByVal parentid As Integer, ByVal mode As String) As String
        Dim rs() As DataRow = dt.Select(" parentid=" & parentid & " and isshowflag=1")
        Dim n As Integer
        Dim s As New StringBuilder
        Dim dh As StringHandling.DWZJson.DwzHref
        Dim i As Integer = 1
        For Each r As DataRow In rs

            Dim HaveSubFlag As Boolean
            Dim caseid As Integer = r("caseid")
            HaveSubFlag = scbll.HaveSub(caseid)

            If HaveSubFlag Then
                s.AppendLine("<div id=""menu" & i & "Container"">")
                s.AppendLine("<div class=""menucontainer""></div>")
                s.AppendLine("<div class=""menu m_l_114"" id=""menu" & i & "Content"">")

                s.AppendLine("<ul>")

                Dim subdt As DataTable = scbll.Dt(caseid)
                Dim k As Integer = subdt.Rows.Count
                Dim j As Integer = 0
                For Each sr As DataRow In subdt.Rows
                    j = j + 1
                    Dim typeid As Integer
                    dh = New StringHandling.DWZJson.DwzHref
                    dh.CaseId = sr("caseid")
                    dh.Text = sr("casename")
                    dh.Target = StringHandling.DWZJson.DwzTarget.null
                    dh.Url = "webcase.aspx?caseid=" & dh.CaseId
                    typeid = -1
                    typeid = SafeData.s_integer(sr("casedata"))
                    If typeid = CaseType.IndexPage Then
                        Dim dm As Model.DataMain
                        Dim dmbll As New BLL.DataMainBLL
                        dm = dmbll.EntityByCaseId(dh.CaseId)
                        If dm IsNot Nothing Then
                            dh.Url = dm.Content

                        End If
                    End If
                    s.AppendLine("<li><a href=""" & dh.Url & """>" & dh.Text & "</a></li>")
                    If n <> j Then

                        s.AppendLine("<li class=""li_ban"">|</li>")
                    End If

                Next
                s.AppendLine(" </ul>")

                s.AppendLine(" </div>")
                s.AppendLine(" </div>")
                i = i + 1


            End If

        Next


        Return s.ToString
    End Function

    ''' <summary>
    ''' 左边页面导航
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="parentid"></param>
    ''' <param name="mode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function WebNav(dt As DataTable, ByVal parentid As Integer, ByVal mode As String, curCaseid As Integer, Optional unitid As Integer = 0) As String
        Dim sql As String = " parentid=" & parentid
        If unitid > 0 Then
            sql = sql & " and unitid=" & unitid
        End If
        Dim rs() As DataRow = dt.Select(sql, "pindex asc")

        Dim s As New StringBuilder

        ' s.AppendLine("<ul class='nav nav-list'>")
        s.AppendLine("<li class='nav-header'>" & scbll.CaseName(parentid) & "</li>")
        If rs.Length > 0 Then
            s.AppendLine("<li class='divider'></li>")

        End If

        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref


            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)
            Dim cs As String = ""
            If r("caseid") = curCaseid Then
                cs = "class='active'"
            Else
                cs = ""
            End If
            If HaveSubFlag Then
                s.AppendLine("<li " & cs & ">")
                s.AppendLine("<a  href='webcase.aspx?caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
                s.AppendLine("<ul class='nav nav-list'>")
                For Each sr As DataRow In scbll.Dt(dh.CaseId).Rows
                    If sr("caseid") = curCaseid Then
                        cs = "class='active'"
                    Else
                        cs = ""
                    End If
                    s.AppendLine("<li " & cs & ">")
                    s.AppendLine("<a href='webcase.aspx?caseid=" & sr("caseid") & "'>" & sr("casename") & "</a>")
                    s.AppendLine("</li>")

                Next
                s.AppendLine("</ul>")
            Else
                s.AppendLine("<li  " & cs & ">")
                s.AppendLine("<a href='webcase.aspx?caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
                s.AppendLine("</li>")

            End If
            s.AppendLine("</li>")
        Next
        ' s.AppendLine("</ul>")


        Return s.ToString
    End Function

    Function WebNavSingle(dt As DataTable, ByVal parentid As Integer, ByVal mode As String, curCaseid As Integer, Optional unitid As Integer = 0) As String
        Dim sql As String = " parentid=" & parentid
        If unitid > 0 Then
            sql = sql & " and unitid=" & unitid
        End If
        Dim rs() As DataRow = dt.Select(sql, "pindex asc")

        Dim s As New StringBuilder

        ' s.AppendLine("<ul class='nav nav-list'>")
        s.AppendLine("<li class='nav-header'>" & scbll.Casename(parentid) & "</li>")
        If rs.Length > 0 Then
            s.AppendLine("<li class='divider'></li>")

        End If

        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref


            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)
            Dim cs As String = ""
            If r("caseid") = curCaseid Then
                cs = "class='active'"
            Else
                cs = ""
            End If
           
                s.AppendLine("<li  " & cs & ">")
                s.AppendLine("<a href='webcase.aspx?caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
                s.AppendLine("</li>")



        Next
        ' s.AppendLine("</ul>")


        Return s.ToString
    End Function
    Function WebNav(ByVal parentid As Integer) As String
        Dim dt As DataTable = scbll.DtByParentid(parentid)

        Dim s As New StringBuilder
        Dim rs() As DataRow = dt.Select("isshowflag=1", "pindex asc")
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            s.AppendLine("<li><a href='webcase.aspx?caseid=" & dh.CaseId & "'>" & dh.Text & "</a></li>")
            s.AppendLine("</tr>")
        Next
        Return s.ToString
    End Function
    Function caselist(ByVal parentid As Integer, caseid As Integer, typeid As Integer) As String
        Dim dt As DataTable = scbll.DtByParentid(parentid)

        Dim s As New StringBuilder
        Dim rs() As DataRow = dt.Select("isshowflag=1", "pindex asc")
        If caseid = 0 Then
            s.AppendLine("<li><a class='current all' href='zylist.aspx?caseid=" & 0 & "&typeid=" & typeid & "'>全部科目</a></li>")
        Else
            s.AppendLine("<li><a  class='all'  href='zylist.aspx?caseid=" & 0 & "&typeid=" & typeid & "'>全部科目</a></li>")

        End If
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            Dim cur As String
            If caseid = r("caseid") Then
                cur = "current"
            Else
                cur = ""
            End If
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            s.AppendLine("<li><a class='" & cur & "' href='zylist.aspx?caseid=" & dh.CaseId & "&typeid=" & typeid & "'>" & dh.Text & "</a></li>")

        Next
        Return s.ToString
    End Function
    Function typelist(ByVal parentid As Integer, caseid As Integer, typeid As Integer) As String
        Dim dt As DataTable = scbll.DtByParentid(parentid)

        Dim s As New StringBuilder
        If typeid = 0 Then
            s.AppendLine("<li><a class='current all' href='zylist.aspx?caseid=" & caseid & "&typeid=" & 0 & "'>全部类型</a></li>")
        Else
            s.AppendLine("<li><a   class='all'  href='zylist.aspx?caseid=" & caseid & "&typeid=" & 0 & "'>全部类型</a></li>")

        End If

        Dim rs() As DataRow = dt.Select("isshowflag=1", "pindex asc")
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            Dim cur As String
            If typeid = r("caseid") Then
                cur = "current"
            Else
                cur = ""
            End If
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            s.AppendLine("<li><a class='" & cur & "' href='zylist.aspx?typeid=" & dh.CaseId & "&caseid=" & caseid & "'>" & dh.Text & "</a></li>")

        Next
        Return s.ToString
    End Function

    Function WebNav2(dt As DataTable, ByVal parentid As Integer, ByVal mode As String, curCaseid As Integer) As String

        Dim rs() As DataRow = dt.Select(" parentid=" & parentid)
         Dim s As New StringBuilder



        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref


            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "webcase.aspx?caseid=" & dh.CaseId
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)
            Dim cs As String = ""
            If r("caseid") = curCaseid Then
                cs = "class='active'"
            Else
                cs = ""
            End If
            s.AppendLine("<table class=m_t_10 cellSpacing=0 cellPadding=0 width=199 border=0>")
            s.AppendLine(" <tr>")
            s.AppendLine("<td class=left align=left height=28><a href='webcase.aspx?caseid=" & dh.CaseId & "'>" & dh.Text & "</a></td>")
            s.AppendLine("</tr>")
            s.AppendLine("</table>")



        Next



        Return s.ToString
    End Function

    ''' <summary>
    ''' 栏目位置导航
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="caseid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function WebNavPositon(dt As DataTable, ByVal caseid As Integer, curCaseid As Integer) As String
        Dim r() As DataRow = dt.Select("caseid=" & caseid)

        Dim s As String
        If r.Length > 0 Then
            If r(0)("parentid") > 0 Then
                If r(0)("caseid") <> 16 Then

                    If curCaseid = caseid Then
                        s = "<li class='active'>" & r(0)("casename") & "</li>"

                    Else

                        s = "<li><a href='webcase.aspx?caseid=" & caseid & "'>" & r(0)("casename") & "</a><span class='divider'>/</span></li>"
                    End If


                End If
                WebNavPositon = WebNavPositon(dt, r(0)("ParentID"), curCaseid) & s
            Else
                s = "<li><a href='default.aspx'>首页</a><span class='divider'>/</span></li>"
                WebNavPositon = WebNavPositon(dt, r(0)("ParentID"), curCaseid) & s
            End If
        End If
        dt.Dispose()
    End Function
    Function WebNavPositonSingle(ByVal caseid As Integer) As String


        Dim s As String

        s = "<li><a href='default.aspx'>首页</a><span class='divider'>/</span></li><li class='active'>" & scbll.Casename(caseid) & "</li>"
        Return s
    End Function

    Function WebNavPositon2(dt As DataTable, ByVal caseid As Integer, curCaseid As Integer) As String
        Dim r() As DataRow = dt.Select("caseid=" & caseid)

        Dim s As String
        If r.Length > 0 Then
            If r(0)("parentid") > 0 Then
                If r(0)("caseid") <> 16 Then

                    If curCaseid = caseid Then
                        s = r(0)("casename")

                    Else

                        s = "<a href='webcase.aspx?caseid=" & caseid & "'>" & r(0)("casename") & "</a>&nbsp;>>&nbsp;"
                    End If


                End If
                WebNavPositon2 = WebNavPositon2(dt, r(0)("ParentID"), curCaseid) & s
            Else
                s = "<a href='default.aspx'>首页</a>&nbsp;>>&nbsp;"
                WebNavPositon2 = WebNavPositon2(dt, r(0)("ParentID"), curCaseid) & s
            End If
        End If
        dt.Dispose()
    End Function
    Dim dmview As New View.DataMainView
    Function CourseClNav(courseid As Integer, parentid As Integer, curCaseid As Integer, zjStr As String) As String
        Dim s, t As New Text.StringBuilder
        Dim dt As DataTable
        dt = scbll.Dt(parentid)
        Dim i As Integer = 0
        For Each r As DataRow In dt.Rows
            Dim caseid As Integer = r("caseid")
            Dim c As String
            If caseid = curCaseid Then
                c = "active"
            Else
                c = "casehead"
            End If


            s.AppendLine("<li  class=""" & c & """ ><a href=""course.aspx?courseid=" & courseid & "&clCaseid=" & caseid & """  >" & r("casename") & "</a></li>")
            If caseid = 93 Then
                s.AppendLine(zjStr)
            End If
            i = i + 1
        Next

        Return s.ToString
    End Function
    Function zylist(caseid As Integer, courseid As Integer) As String
        Dim caseids As String = scbll.subCaseIds(caseid)
        If caseids = "" Then
            caseids = caseid
        End If
        Dim pi As New PagerInfo
        pi.fldName = "pubdate"
        pi.orderDirection = "desc"
        pi.orderField = "pubdate"

        pi.strwhere = "  zytypeid in(" & caseids & ")) and unitid=" & courseid
        pi.PageIndex = 1

        pi.PageSize = 20
        pi.Tablename = "data_main"
        Dim dmview As New View.DataMainView
        Return dmview.PicinfoList(pi)

    End Function


    'Function Tabs(userid As Integer, courseid As Integer, parentid As Integer, ByRef content As String) As String
    '    Dim s, t As New Text.StringBuilder
    '    Dim dt As DataTable
    '    dt = scbll.Dt(parentid)
    '    Dim i As Integer = 0
    '    For Each r As DataRow In dt.Rows
    '        Dim caseid As Integer = r("caseid")
    '        Dim c As String
    '        Dim files As String

    '        If caseid = 92 Then
    '            c = "active  "
    '            files = dmview.files(caseid, userid, courseid, 0)
    '        Else
    '            c = ""
    '            If caseid = 93 Then
    '                files = dmview.caselist8(caseid, caseid, userid, courseid)
    '            ElseIf caseid = 94 Then
    '                files = caselist10(caseid, courseid)
    '            ElseIf caseid = 95 Then
    '                files = dmview.infolist(88, 0)
    '            ElseIf caseid = 98 Then
    '                files = dmview.caselist9(caseid, caseid, userid, courseid)
    '            Else
    '                files = ""
    '            End If
    '            ' files = ""
    '        End If
    '        s.AppendLine("<li  class=""" & c & """ ><a href=""#tab" & caseid & """ data-toggle=""tab"">" & r("casename") & "</a></li>")
    '        t.AppendLine("<div class=""tab-pane fade in " & c & """ id=""tab" & caseid & """>" & files & "</div>")
    '        i = i + 1
    '    Next
    '    content = t.ToString
    '    Return s.ToString
    'End Function
    Function CourseNav(ByVal parentid As Integer, ByVal mode As String, curCaseid As Integer, subcaseid As Integer, Optional unitid As Integer = 0) As String
        Dim sc As New Model.SystemCase
        sc.Unitid = unitid
        sc.ParentId = parentid

        Dim dt As DataTable = scbll.Dt(sc)
         Dim s As New StringBuilder
        ' s.AppendLine("<ul class='nav nav-list'>")
        ' s.AppendLine("<li class='nav-header'>" & scbll.CaseName(parentid) & "</li>")
        'If dt.Rows.Count > 0 Then
        '    s.AppendLine("<li class='divider'></li>")

        'End If
        Dim firstCaseid As Integer = 0
        If curCaseid > 0 Then
            firstCaseid = curCaseid
        End If
        For Each r As DataRow In dt.Rows
            Dim dh As New StringHandling.DWZJson.DwzHref
            Dim courseid As Integer = r("unitid")
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "course.aspx?courseid=" & courseid & "&caseid=" & dh.CaseId
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)
            Dim cs As String = ""
            If firstCaseid = 0 Then
                curCaseid = dh.CaseId
            End If
            If r("caseid") = curCaseid Then
                cs = "class='active'"
            Else
                cs = ""
            End If
            If HaveSubFlag And cs <> "" Then
                s.AppendLine("<li " & cs & ">")
                s.AppendLine("<a  href='course.aspx?courseid=" & courseid & "&caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
                s.AppendLine("<ul class='nav nav-list'>")
                sc.ParentId = r("caseid")
                sc.Unitid = courseid
                Dim sdt As DataTable = scbll.Dt(sc)

                For Each sr As DataRow In sdt.Rows
                    Dim scourseid As Integer = sr("unitid")
                    If sr("caseid") = subcaseid Then
                        cs = "class='active'"
                    Else
                        cs = "class='casetitle'"
                    End If
                    s.AppendLine("<li " & cs & ">")
                    s.AppendLine("<a href='course.aspx?courseid=" & scourseid & "&caseid=" & r("caseid") & "&subcaseid=" & sr("caseid") & "'>" & sr("casename") & "</a>")
                    s.AppendLine("</li>")

                Next
                s.AppendLine("</ul>")
            Else
                s.AppendLine("<li  " & cs & ">")
                s.AppendLine("<a href='course.aspx?courseid=" & courseid & "&caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
                s.AppendLine("</li>")

            End If
            s.AppendLine("</li>")
        Next
        ' s.AppendLine("</ul>")


        Return s.ToString
    End Function
    Function CourseNav(ByVal parentid As Integer, ByVal mode As String, Optional unitid As Integer = 0) As String
        Dim sc As New Model.SystemCase
        sc.Unitid = unitid
        sc.ParentId = parentid

        Dim dt As DataTable = scbll.Dt(sc)
         Dim s As New StringBuilder
        ' s.AppendLine("<ul class='nav nav-list'>")
        's.AppendLine("<li class='nav-header'>" & scbll.CaseName(parentid) & "</li>")
        'If dt.Rows.Count > 0 Then
        '    s.AppendLine("<li class='divider'></li>")

        'End If

        For Each r As DataRow In dt.Rows
            Dim dh As New StringHandling.DWZJson.DwzHref
            Dim courseid As Integer = r("unitid")
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Target = StringHandling.DWZJson.DwzTarget.null
            dh.Url = "course.aspx?courseid=" & courseid & "&caseid=" & dh.CaseId
            Dim HaveSubFlag As Boolean
            HaveSubFlag = scbll.HaveSub(dh.CaseId)
            Dim cs As String = "class='casetitle'"

            s.AppendLine("<li  " & cs & ">")
            s.AppendLine("<a href='course.aspx?courseid=" & courseid & "&caseid=" & dh.CaseId & "'>" & dh.Text & "</a>")
            s.AppendLine("</li>")


            s.AppendLine("</li>")
        Next
        ' s.AppendLine("</ul>")


        Return s.ToString
    End Function
  
End Class
