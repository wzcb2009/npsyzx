Imports StringHandling.DWZJson
Imports StringHandling
Imports Web.net.npsyzx
Imports Web.net.npsyzx.www
Imports Web.WebReference

Public Class UserLogindo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim action As String = Request("action")
        If action = "login" Then
            login()
        ElseIf action = "quit" Then
            logout(Context)
        ElseIf action = "ajaxlogin" Then
            ajaxlogin(Context)

        Else
            check(Context)
        End If
        Response.End()
    End Sub
    Sub check(ByVal context As HttpContext)
        If Session("username") = "" Then
            Response.Write("{result:""expired""}")
        Else
            Dim rolename As String
            If Session("roleid") = 1 Then
                rolename = "学生"
            ElseIf Session("roleid") = 2 Then
                rolename = "教师"
            End If
            Response.Write("{""result"":""session"",""username"":""" & Session("username") & """,""truename"":""" & Session("truename") & """,""rolename"":""" & rolename & """}")
        End If

    End Sub
    Sub logout(ByVal context As HttpContext)
        Session.Abandon()
        Response.Write("{""result"":""loginout""}")

    End Sub

    Sub login()

        Dim message As String
        Dim username As String
        Dim pwd As String
        username = Trim(Request.Form("username"))
        pwd = Trim(Request.Form("pwd"))
        Dim flag As Integer
        Dim bll As New BLL.UserlistBLL
        If pwd <> "" Then
            pwd = StringHandling.Security.Md5(pwd)

        End If

        flag = bll.login(username, pwd)
        Dim rolename As String
        If flag = 1 Then
            Dim rs = bll.Rs(username)
            If rs.Read Then
                Session("userid") = rs("userId")
                Session("UserName") = rs("UserName")

                Session("truename") = rs("truename")
                If Session("UserSystemCase") Is Nothing Then
                    Session("UserSystemCase") = userSysCaseDt(rs("userId"))
                    Session("token") = remotToken(username)
                End If
            End If
            message = ("ok")
        ElseIf flag = -1 Then
            message = ("密码错误！")
        ElseIf flag = -2 Then
            message = ("用户名错误！")
        Else
            message = (flag)
        End If
        Response.Write("{""result"":""" & message & """,""truename"":""" & Context.Session("truename") & """,""rolename"":""" & rolename & """}")

    End Sub
    Function userSysCaseDt(userid As Integer) As DataTable
        Dim scbll As New BLL.SystemCaseBLL
        Dim bll As New BLL.UserSystemCaseBLL
        Dim s As New StringBuilder
        Dim caseids As String = bll.CaseIds(View.SystemCaseConst.RoleCaseId, userid)
        Dim caseids2 As String = bll.CaseIds(View.SystemCaseConst.DePartmentCaseId, userid)
        s.Append(caseids)
        If caseids2 <> "" Then
            s.Append("," & caseids2)
        End If

        If s.Length > 0 Then
            Dim dt As DataTable = scbll.Dt(s.ToString) '用户角色ID
            Dim cd As String = "0"
            For Each r As DataRow In dt.Rows
                If r("casedata") <> "" Then
                    cd = cd & "," & r("casedata")
                End If
            Next



            Return scbll.Dt(cd)
        End If
    End Function
    Function remotToken(username As String) As String
        Dim tokenService As New TokenService
        tokenService.Url = "http://10.128.50.113/passport/TokenService.asmx"
        Return tokenService.TokenInsert(username)

    End Function
    Sub ajaxlogin(ByVal context As HttpContext)

        Dim message As String
        Dim username As String
        Dim pwd As String
        username = Trim(Request.Form("username"))
        pwd = Trim(Request.Form("pwd"))
        Dim flag As Integer
        Dim bll As New BLL.UserlistBLL

        If pwd <> "" Then
            pwd = StringHandling.Security.Md5(pwd)

        End If

        flag = bll.login(username, pwd)
        Dim dwz_ As New DWZ

        If flag = 1 Then
            Dim rs = bll.Rs(username)
            If rs.Read Then
                Session("userid") = rs("userId")
                Session("UserName") = rs("UserName")

                Session("truename") = rs("truename")
                If Session("UserSystemCase") Is Nothing Then
                    Session("UserSystemCase") = userSysCaseDt(rs("userId"))

                End If

            End If
            message = ("登陆成功！")
            dwz_.statusCode = statusCode.OK
        ElseIf flag = -1 Then
            message = ("密码错误！")
            dwz_.statusCode = statusCode.Info
        ElseIf flag = -2 Then
            dwz_.statusCode = statusCode.Info
            message = ("用户名错误！")
        Else
            message = (flag)
            dwz_.statusCode = statusCode.Info
        End If
        dwz_.message = message
        Dim s As New System.Text.StringBuilder
        dwz_.callbackType = "closeCurrent"
        Response.ContentType = "application/json"
        Response.Write(StringHandling.DWZJson.Alert(dwz_))
        Response.End()




    End Sub
End Class