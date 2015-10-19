Public Class CourseView
    Dim bll As New BLL.CourseInfoBLL
    Dim userView As New View.UserView
    Function courselist(cols As Integer) As String
        Dim s As New Text.StringBuilder
        Dim dt As Data.DataTable = bll.dt
        s.AppendLine("    <ul class=""thumbnails"">")
        For Each r As DataRow In dt.Rows
            s.AppendLine(userView.userbaseinfoPic(r("userid"), r("id"), cols))
        Next
        s.AppendLine("</ul>")
        Return s.ToString
    End Function
    Function info(id As Integer) As String
        Dim s As New Text.StringBuilder
        Dim CI = BLL.entity(id)
        If CI IsNot Nothing Then
            s.AppendLine("<div class='row-fluid'>")
            s.AppendLine("<div class='span6'>专业大类：" & CI.SubjectParentName & "</div>")
            s.AppendLine("<div class='span6'>专业类型：" & CI.SubjectTypeName & "</div>")
            s.AppendLine("</div>")
            s.AppendLine("<div class='row-fluid'>")
            s.AppendLine("<div class='span6'>专业名称：" & CI.SubjectName & "</div>")
            s.AppendLine("<div class='span6'>课程类型：" & scbll.CaseName(CI.TypeId) & "</div>")
            s.AppendLine("</div>")
            s.AppendLine("<div class='row-fluid'>")
            s.AppendLine("<div class='span6'>课程属性：" & CI.PropertyIds & "</div>")
            s.AppendLine("<div class='span6'>课程学时：" & CI.LessonCount & "</div>")
            s.AppendLine("</div>")
            s.AppendLine("<div class='row-fluid'>")
            s.AppendLine("<div class='span12'>适用专业：" & CI.SubjectObjects & "</div>")
            s.AppendLine("</div>")
        End If
        Return s.ToString

    End Function
    Function remark(id As Integer) As String
        Dim s As New Text.StringBuilder
        Dim CI = bll.Entity(id)
        If CI IsNot Nothing Then
            Return CI.Remark
        End If
    End Function
    Dim scbll As New BLL.SystemCaseBLL
    Function Caselists(parentid As Integer, typeid As Integer, courseid As Integer, Optional subflag As Boolean = False) As String
        Dim s As New Text.StringBuilder
        Dim dt As Data.DataTable
        Dim allcount As Integer
        Dim dmcasebll As New BLL.DatamainCasesetBLL
        allcount = dmcasebll.avg(parentid)

        If subflag = False Then
            Dim sc As New Model.SystemCase
            sc.ParentId = parentid
            sc.Unitid = courseid
            sc.Typeid = typeid
            dt = scbll.Dt(sc)
            For Each r As DataRow In dt.Rows
                Dim count As Integer = dmcasebll.count(r("caseid"), parentid)
                Dim fontsize As Single = count / allcount
                s.AppendLine("<a href='coursezy.aspx?courseid=" & courseid & "&tabcaseid=" & r("caseid") & "' rel='" & fontsize & "'>" & r("casename") & "</a>")
            Next
        Else
            '获取章节下面子类id列表
            Dim subcaseid As String = scbll.MysubCaseids(scbll.Dt, typeid, courseid)

            dt = scbll.dtByTypeid(subcaseid, parentid, courseid)


            For Each r As DataRow In dt.Rows
                Dim count As Integer = dmcasebll.count(r("caseid"), parentid)
                Dim fontsize As Single = count / allcount

                s.AppendLine("<a href='coursezy.aspx?courseid=" & courseid & "&tabcaseid=" & r("caseid") & "' rel='" & fontsize & "'>" & r("casename") & "</a>")
            Next

        End If

        Return s.ToString
    End Function
End Class
