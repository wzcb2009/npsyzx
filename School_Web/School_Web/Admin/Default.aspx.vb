Imports StringHandling

Public Class _Default1
    Inherits System.Web.UI.Page
    Dim userid As Integer
    Dim scbll As New BLL.SystemCaseBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("username") = "teacher"

        userid = Session("userid")
        If userid = 0 Then
            Response.Redirect("../login.aspx")
        End If
        ' If Cache("UserSystemCase") Is Nothing Then
        ' Dim dt As Data.DataTable = bll.dt(userid)
        Dim scdt As DataTable = scbll.Dt ' scbll.Dt(67)
        ''用户权限列表缓存
        '  If SC.CaseData <> "" Then

        'End If
        ' End If 
        ' Session("UserSystemCase") = scbll.Dt


        Dim uscdt As DataTable = Session("UserSystemCase")


        Dim s As New StringBuilder
        s.AppendLine(web(16))

        s.AppendLine(sys(2))

        uscdt.Dispose()
        lit_menu.Text = s.ToString
        'Dim dt As DataTable = scbll.Dt(16)
        'Dim newsStr As New StringBuilder
        'For Each sr As DataRow In dt.Rows
        '    If sr("isShowFlag") = False Then
        '        Continue For
        '    End If
        '    newsStr.AppendLine("<div class='newsbox'><h2 class='contentTitle'>" & sr("casename") & "</h2>")
        '    newsStr.AppendLine("<div  class='main'>")
        '    newsStr.AppendLine("<ul class='newslist'> ")
        '    newsStr.AppendLine(infolist(sr("caseid")))
        '    newsStr.AppendLine("</ul>")
        '    newsStr.AppendLine("</div>")
        '    newsStr.AppendLine("</div>")

        'Next
        'dt.Dispose()
        '   lt_newsbox.Text = newsStr.ToString

        lt_userinfo.Text = userinfo(userid)
        Dim sysl As New BLL.SystemInfoParamBLL

        Dim rs As Data.SqlClient.SqlDataReader = sysl.Rs(1)

        If rs.Read Then

            lt_schoolname.Text = rs("schoolname")
          
        End If
        rs.Close()
        rs = Nothing

    End Sub
    Function sys(parentid As Integer) As String
        Dim s As New StringBuilder
        Dim uscdt As DataTable = Session("UserSystemCase")
        Dim rs() As Data.DataRow
        rs = uscdt.Select("isshowflag=1 and parentid=" & parentid, "pindex asc")
        For Each r As DataRow In rs
            s.AppendLine(" <div class=""accordionHeader"">")
            s.AppendLine("<h2><span>Folder</span>" & r("casename") & "</h2>")
            s.AppendLine("</div>")
            s.AppendLine("<div class=""accordionContent"">")
            s.AppendLine(system_lmList_nav(uscdt, r("caseid"), "tree treeFolder"))
            s.AppendLine("</div>")
        Next
        Return s.ToString
    End Function
    Function web(parentid As Integer) As String
        Dim s As New StringBuilder
        Dim uscdt As DataTable = Session("UserSystemCase")
        Dim r() As DataRow
        r = uscdt.Select("parentid=" & parentid)
        If r.Length = 0 Then
            Return ""
        End If
        Dim bll As New BLL.SystemCaseBLL
        s.AppendLine(" <div class=""accordionHeader"">")
        s.AppendLine("<h2><span>Folder</span>" & bll.CaseName(parentid) & "</h2>")
        s.AppendLine("</div>")
        s.AppendLine("<div class=""accordionContent"">")
        s.AppendLine(web_lmList_nav(uscdt, parentid, "tree treeFolder"))
        s.AppendLine("</div>")

        Return s.ToString
    End Function
    Function system_lmList_nav(dt As DataTable, ByVal parentid As Integer, ByVal mode As String) As String
        Dim rs() As DataRow = dt.Select("isshowflag=1 and parentid=" & parentid)
         Dim s As New StringBuilder
        If rs.Length > 0 Then
            If mode <> "" Then
                s.AppendLine("<ul class='" & mode & "'>")
            Else
                s.AppendLine("<ul  >")
            End If


        End If
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            dh = StringHandling.DWZJson.CaseDataToDwzHref(r("casedata"))
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            ' Response.Write(r("casedata") & "<br>")
            s.AppendLine("<li>")
           
            s.AppendLine(StringHandling.DWZJson.MenuHref(dh))
            If r("caseid") = 19 Then
                Dim dt2 As Data.DataTable = scbll.Dt(0)
                s.AppendLine("<ul  >")
                For Each r2 As DataRow In dt2.Rows
                    Dim dh2 As New StringHandling.DWZJson.DwzHref
                    dh.CaseId = r2("caseid")
                    dh.Text = r2("casename")
                    dh.Url = "../system/systemcaselistweb.aspx?caseid=" & r2("caseid") & "&parentid=" & r("caseid")
                    ' Response.Write(r("casedata") & "<br>")
                    s.AppendLine("<li>")

                    s.AppendLine(StringHandling.DWZJson.MenuHref(dh))
                Next
                s.AppendLine("</ul>")
            Else
                s.AppendLine(system_lmList_nav(dt, dh.CaseId, ""))

            End If
            s.AppendLine("</li>")

        Next
        If rs.Length > 0 Then
            s.AppendLine("</ul>")
        End If
        Return s.ToString
    End Function
    Function web_lmList_nav(dt As DataTable, ByVal parentid As Integer, ByVal mode As String) As String
        Dim rs() As DataRow = dt.Select(" parentid=" & parentid)
         Dim s As New StringBuilder
        If rs.Length > 0 Then
            If mode <> "" Then
                s.AppendLine("<ul class='" & mode & "'>")
            Else
                s.AppendLine("<ul  >")
            End If


        End If
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            Dim casetypeid As Integer


            If SafeData.s_string(r("casedata")) <> "" Then
                If Not r("casedata").ToString.Contains(",") Then
                    If IsNumeric(r("casedata")) Then
                        casetypeid = Convert.ToInt16(r("casedata"))
                        Dim sc As New Model.SystemCase
                        sc = scbll.Entity(casetypeid)


                        If sc.CaseData <> "" Then
                            dh = StringHandling.DWZJson.CaseDataToDwzHref(sc.CaseData)

                        End If
                    End If
                End If



            End If

            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Rel = "1"



            'dh.Url = "../web/newslistweb.aspx?caseid=" & dh.CaseId

            ' Response.Write(r("casedata") & "<br>")
            s.AppendLine("<li>")
            s.AppendLine(StringHandling.DWZJson.MenuHref(dh))
            s.AppendLine(web_lmList_nav(dt, dh.CaseId, ""))
            s.AppendLine("</li>")

        Next
        If rs.Length > 0 Then
            s.AppendLine("</ul>")
        End If
        Return s.ToString
    End Function
    Function infolist(caseid As Integer) As String
        Dim dt As Data.DataTable

        Dim bll As New BLL.DataMainBLL
        Dim scbll As New BLL.SystemCaseBLL
        Dim uscdt As DataTable = Session("UserSystemCase")

        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(uscdt, caseid)
            If CASEIDLIST <> "" Then
                CASEIDLIST = "0" & CASEIDLIST
            End If
            dt = bll.Dt(CASEIDLIST)



        Else
            dt = bll.Dt(caseid)


        End If


        Dim s As New StringBuilder
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            s.AppendLine("<li><span>·</span><a target='dialog' rel='webd1' width='800' height='480'  href='../web/showweb.aspx?id=" & rs("id") & "'>" & rs("title") & "" & d.Date & "</a></li>")
        Next
        Return s.ToString
    End Function
    Function userinfo(userid As Integer) As String
        Dim user As New Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(userid)
        Dim s As New StringBuilder

        If user IsNot Nothing Then
            s.AppendLine(" <div class='userinfo'>")

            s.AppendLine("<div class='left'>")
            s.AppendLine("  <img src='../user/images/pic.jpg' />")
            s.AppendLine("</div>")
            s.AppendLine("<div class='right'>")
            Dim uscBll As New BLL.UserSystemCaseBLL
            Dim collegeid As Integer = uscBll.Caseid(187, userid)
            Dim collegename As String
            Dim scBll As New BLL.SystemCaseBLL
            If collegeid > 0 Then
                collegename = scBll.CaseName(collegeid)
            End If
            Dim roleid As Integer = uscBll.Caseid(67, userid)
            Dim rolename As String = scBll.CaseName(roleid)


            s.AppendLine("<div class='title'><h2>" & collegename & " " & Session("truename") & " " & rolename & "</h2></div>")
            s.AppendLine(" <div class='info'>登陆" & user.LoginTimes & "次 上次登陆：" & user.LastLogin & "</div>")
            s.AppendLine("</div>")
            s.AppendLine("</div>   ")
        End If
        Return s.ToString
    End Function
End Class