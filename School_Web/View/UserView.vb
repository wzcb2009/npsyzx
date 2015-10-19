Imports System.Text

Public Class UserView
    Dim ubibll As New BLL.UserBaseInfoBLL
    Dim scbll As New BLL.SystemCaseBLL
    Dim uscbll As New BLL.UserSystemCaseBLL
    Function userbaseinfo(userid As Integer, courseid As Integer, Optional singleFlag As Boolean = True) As String
        Dim s As New StringBuilder

        Dim user As New Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(userid)
        If user IsNot Nothing Then

            Dim ubi As Model.UserBaseInfo
            ubi = ubibll.Entity(user.UserId)
            Dim usc As New Model.UserSystemCase
            usc.UserId = user.UserId
            usc.Parentid = 4
            usc.Unitid = courseid

            Dim casename As String = scbll.CaseName(uscbll.Caseid(usc))


            If ubi IsNot Nothing Then
                 s.AppendLine("    <div class=""media"">")
                s.AppendLine("    <div class=""pull-left"" >")
                ubi.PicUrl = Replace(ubi.PicUrl, "../", "")
                s.AppendLine(" <img class=""media-object img-polaroid"" width='120'  src='" & ubi.PicUrl & "'>")
                s.AppendLine(" </div>")
                s.AppendLine(" <div class=""media-body"">")
                s.AppendLine("<h5 class=""media-heading"">" & user.Truename & "[" & casename & "]" & "</h5>")
                s.AppendLine("<p>职称：" & ubi.Profession & "</p>")
                s.AppendLine("<p>专业：" & ubi.Specialty & "</p>")
                If singleFlag = False Then
                    s.AppendLine("<p>个人简介<span class='thjj' rel='thinfo" & ubi.UserId & "' data='0'>[展开]</span></p><p style='display:none' id='thinfo" & ubi.UserId & "'>" & "" & "</p>")

                End If

                s.AppendLine("</div>")
                s.AppendLine("</div>")



            End If


        End If

        Return s.ToString
    End Function
    Function userbaseinfoPic(userid As Integer, courseid As Integer, Optional cols As Integer = 4) As String
        Dim s As New StringBuilder

        Dim user As New Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(userid)
        If user IsNot Nothing Then

            Dim ubi As Model.UserBaseInfo
            ubi = ubibll.Entity(user.UserId)
            Dim usc As New Model.UserSystemCase
            usc.UserId = user.UserId
            usc.Parentid = 4
            usc.Unitid = courseid

            Dim casename As String = scbll.CaseName(uscbll.Caseid(usc))

            Dim coursename As String
            Dim coursebll As New BLL.CourseInfoBLL
            Dim ci As Model.CourseInfo
            ci = coursebll.Entity(courseid)
            If ci IsNot Nothing Then
                coursename = ci.Name
            End If
            If ubi IsNot Nothing Then
                 s.AppendLine("<li class=""span" & cols & """>")
                s.AppendLine("<div class=""thumbnail"">")
                s.AppendLine("    <a   href=""course.aspx?courseid=" & courseid & """>")
                ubi.PicUrl = ubi.PicUrl.Replace("../", "")
                s.AppendLine(" <img  src='" & ubi.PicUrl & "'>")
                s.AppendLine(" </a>")

                s.AppendLine("<p >" & user.Truename & "《" & coursename & "》</p>")
                's.AppendLine("<p>职称：" & ubi.Profession & "</p>")
                's.AppendLine("<p>专业：" & ubi.Specialty & "</p>")
                's.AppendLine("<p>个人简介：" & ubi.Remark & "</p>")

                s.AppendLine("</div>")
                s.AppendLine("</li>")



            End If


        End If

        Return s.ToString
    End Function
    Function userbaseinfoPicSingle(userid As Integer, courseid As Integer) As String
        Dim s As New StringBuilder

        Dim user As New Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(userid)
        If user IsNot Nothing Then

            Dim ubi As Model.UserBaseInfo
            ubi = ubibll.Entity(user.UserId)
            Dim usc As New Model.UserSystemCase
            usc.UserId = user.UserId
            usc.Parentid = 4
            usc.Unitid = courseid

            Dim casename As String = scbll.CaseName(uscbll.Caseid(usc))

            Dim coursename As String
            Dim coursebll As New BLL.CourseInfoBLL
            Dim ci As Model.CourseInfo
            ci = coursebll.Entity(courseid)
            If ci IsNot Nothing Then
                coursename = ci.Name
            End If
            If ubi IsNot Nothing Then
                 s.AppendLine("<li class=""span2"">")
                s.AppendLine("<div class=""thumbnail"">")
                s.AppendLine("    <a   href=""course.aspx?courseid=" & courseid & """>")
                ubi.PicUrl = ubi.PicUrl.Replace("../", "")
                s.AppendLine(" <img  src='" & ubi.PicUrl & "'>")
                s.AppendLine(" </a>")

                s.AppendLine("<p  >" & user.Truename & "</p>")
              

                s.AppendLine("</div>")
                s.AppendLine("</li>")



            End If


        End If

        Return s.ToString
    End Function

End Class
