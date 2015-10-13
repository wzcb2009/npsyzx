Imports Wzsckj.com.Common
Imports StringHandling

Public Class UserJson
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Response.Clear()
        Dim action As String = Request("action")
        If action = "" Then
            getjson()
        ElseIf action = "json" Then
            getjson2()
        ElseIf action = "checktruename" Then
            checktruename()
        ElseIf action = "checkusername" Then
            checkUsername()
        ElseIf action = "login" Then
            Login()

        ElseIf action = "reg" Then

            userAdd()
        ElseIf action = "modpwd" Then
            pwdMod()
        ElseIf action = "modinfo" Then
            InfoMod()
        End If
        Response.End()


    End Sub
    Function getjson2()
        Dim keyword As String = Request.QueryString("q")
        Dim bll As New BLL.UserlistBLL
        Dim dt As DataTable
        Dim pi As New PagerInfo
        pi.strwhere = "(username like '%" & keyword & "%') or ( truename like '%" & keyword & "%')"
        pi.PageIndex = 1
        pi.PageSize = 200
        pi.orderField = "username"
        pi.fldName = "username"
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.AppendLine("{""userid"":" & r("userid") & ",""truename"":""" & r("truename") & """,""username"":""" & r("username") & """}")
        Next
        If dt.Rows.Count = 0 Then
            s.AppendLine("")
        End If
        Response.Write(s.ToString)
        Response.End()
    End Function

    Function getjson()
        Dim keyword As String = Request.QueryString("q")
        Dim bll As New BLL.UserlistBLL
        Dim dt As DataTable
        Dim pi As New PagerInfo
        pi.strwhere = keyword
        pi.PageIndex = 1
        pi.PageSize = 200
        pi.orderField = "username"
        pi.fldName = "username"
        pi.strwhere = " username like '%" & keyword & "%' or truename like '%" & keyword & "%'"
        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.AppendLine(r("username") & "-" & r("truename"))
        Next
        If dt.Rows.Count = 0 Then
            s.AppendLine("")
        End If
        Response.Write(s.ToString)
        Response.End()
    End Function
    Function checktruename() As Boolean
        Dim urlname As String = Request.QueryString.GetKey(1).ToString()
        If urlname <> "" Then
            Dim userbll As New BLL.UserlistBLL
            Response.Write(userbll.Isexit(urlname))

        Else
            Response.Write(False)

        End If
    End Function
    Function checkUsername() As Boolean
        Dim urlname As String = Request("param")
        If urlname <> "" Then
            Dim userbll As New BLL.UserlistBLL
            If (userbll.UserId(urlname)) = 0 Then
                Response.Write(ActionHelper.ValidInfo("验证成功！", "y"))
            Else
                Response.Write(ActionHelper.ValidInfo("验证失败！", "n"))

            End If

        Else
            Response.Write(ActionHelper.ValidInfo("验证成功！", "y"))


        End If
    End Function

    Function GetPageEntityReg() As Model.Userlist
        Dim U As New Model.Userlist
        U.UserName = Request.Form("txt_UserName")
        U.Truename = Request.Form("txt_Truename")
        U.Pwd = (Request.Form("txt_Pwd"))
        If U.Pwd <> "" Then
            U.Pwd = StringHandling.Security.Md5(U.Pwd)

        End If
        U.Qq = Request.Form("txt_QQ")
        U.Qqwx = Request.Form("txt_QQWX")
        U.PubDate = Now

        Return U
    End Function
    Function GetPageEntityModInfo(ByRef U As Model.Userlist) As Model.Userlist


        U.Truename = Request.Form("txt_Truename")

        U.Qq = Request.Form("txt_QQ")
        U.Qqwx = Request.Form("txt_QQWX")


        Return U
    End Function
    Function InfoMod()
        Dim bll As New BLL.UserlistBLL
        Dim user As New Model.Userlist
        Dim userid As Integer = Session("userid")
        user = bll.GetObj(userid)
        If user IsNot Nothing Then
            GetPageEntityModInfo(user)
            bll.AddandSave(user)
            Response.Write(ActionHelper.ValidInfo("用户信息修改成功！", "y"))

            Response.End()

        End If

    End Function
    Function pwdMod()
        Dim bll As New BLL.UserlistBLL
        Dim user As New Model.Userlist
        Dim userid As Integer = Session("userid")
        Dim pwd, newpwd As String
        pwd = Trim(Request.Form("txt_pwdold"))
        newpwd = Trim(Request.Form("txt_pwd"))
        If pwd <> "" And newpwd <> "" Then
            user = bll.GetObj(userid)
            If user IsNot Nothing Then
                If user.Pwd = StringHandling.Security.Md5(pwd) Then
                    user.Pwd = StringHandling.Security.Md5(newpwd)
                    bll.AddandSave(user)
                    Response.Write(ActionHelper.ValidInfo("密码修改成功！", "y"))

                    Response.End()
                Else
                    Response.Write(ActionHelper.ValidInfo("旧密码不正确！", "n"))

                    Response.End()
                End If
            End If
        Else
            Response.Write(ActionHelper.ValidInfo("旧密码或者新密码为空", "n"))

            Response.End()
        End If


    End Function
    Function userAdd()
        Dim uscBll As New BLL.UserSystemCaseBLL
        Dim bll As New BLL.UserlistBLL

        Dim user As New Model.Userlist
        user = GetPageEntityReg()
        user.LastLogin = Now

        If bll.Isexit(user.UserName) Then

            Response.Write(ActionHelper.ValidInfo("用户名已经存在", "n"))

            Response.End()

        End If
        user.UserId = 0
        bll.AddandSave(user)
        Dim usc As New Model.UserSystemCase
        usc.CaseId = 28
        usc.UserId = 0
        usc.Parentid = 4

        uscBll.AndandSave(usc)
        If user.UserId > 0 Then
            Session("userid") = bll.UserId(user.UserName)
            Session("username") = user.UserName

            Response.Write(ActionHelper.ValidInfo("注册成功", "y"))

            Response.End()
        Else
            Response.Write(ActionHelper.ValidInfo("注册失败", "n"))


            Response.End()

        End If
    End Function
    Sub Login()
        Dim user As New Model.Userlist
        user.UserName = Request.Form("txt_username")
        user.Pwd = StringHandling.Security.Md5(Request.Form("txt_pwd"))
        Dim bll As New BLL.UserlistBLL
        Dim flag As Int16 = bll.login(user.UserName, user.Pwd)
        If flag = 1 Then
            Session("userid") = bll.UserId(user.UserName)
            Session("username") = user.UserName
            user = bll.GetObj(Session("userid"))
            user.LoginTimes = user.LoginTimes + 1
            user.LastLogin = Now

            bll.AddandSave(user)
            Response.Write(ActionHelper.ValidInfo("登陆成功", "y"))

            Response.End()


        Else
            Response.Write(ActionHelper.ValidInfo("用户名或者密码错误", "n"))

            Response.End()


        End If
    End Sub

End Class