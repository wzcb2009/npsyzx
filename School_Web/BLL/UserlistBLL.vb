Imports System.Data.SqlClient
Imports DAL
Imports Wzsckj.com.Common
Imports Model

Public Class UserlistBLL
    ''' <summary>
    ''' 登陆验证
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="pwd"></param>
    ''' <returns>1表示成功，-1表示密码错误，-2表示用户名错误</returns>
    ''' <remarks></remarks>
    Public Shared Function login(ByVal username As String, ByVal pwd As String) As Int16

        Dim rs As SqlDataReader = UserListDAL.rsByUsername(username)
        If rs.Read Then
            If (pwd) = rs("pwd") Then
                UserListDAL.UpdateLoginTimes(username)
                Return 1
            Else
                Return -1
            End If
        Else
            Return -2
        End If
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable

        Return UserListDAL.PagerDt(pi)
    End Function
    Shared Function dt() As DataTable
        Return UserListDAL.Dt
    End Function
    Shared Function DtPinNull() As DataTable
        Return UserListDAL.DtPinNull
    End Function

    Shared Function dt(truename As String, top As Integer, Optional roleid As Integer = 13) As DataTable
        Return UserListDAL.Dt(truename, top, roleid)

    End Function

    Shared Function Dt(userinfo As Model.Userlist, Optional orderby As String = "username asc") As DataTable
        Return UserListDAL.Dt(userinfo, orderby)

    End Function


    Shared Function Rs(userid As Integer) As SqlDataReader
        Return UserListDAL.RsByUserid(userid)
    End Function
    Shared Function Rs(username As String) As SqlDataReader
        Return UserListDAL.rsByUsername(username)
    End Function
    Shared Function Isexit(Truename As String) As Boolean
        Return UserListDAL.Isexit(Truename)

    End Function
    Shared Function Count(roleid As Integer) As Integer
        Return UserListDAL.Count(roleid)
    End Function
    Shared Function Userid(UserNameStr As String, roleid As Integer) As Int16
        Return UserListDAL.Userid(UserNameStr, roleid)
    End Function

    Shared Function UserId(username As String) As Int16
        Return UserListDAL.Userid(username)

    End Function
    Shared Function Userid2(Truename As String, Optional roleid As Integer = 13) As Int16
        Return UserListDAL.Userid2(Truename, roleid)

    End Function
    Shared Function GetEntity(username As String) As Userlist
        Return UserListDAL.GetEntity(username)
    End Function

    Shared Function GetObj(userid As Integer) As Model.Userlist
        Return UserListDAL.GetEntity(userid)
    End Function

    Shared Function AddandSave(user As Model.Userlist) As Model.Userlist
        If UserListDAL.Userid(user.UserName) = 0 And user.UserId = 0 Then
            Return UserListDAL.insert(user)

        Else
            Dim userid As Integer = UserListDAL.Userid(user.UserName)
            If userid > 0 Then
                user.UserId = userid
            End If
            If user.UserId > 0 Then
                Return UserListDAL.Update(user)
            End If

        End If
    End Function
    Shared Function Del(userid As Integer) As Boolean
        Return UserListDAL.Del(userid)

    End Function
    Shared Function MultiDel(userids As Integer) As Boolean
        Return UserListDAL.MultiDel(userids)

    End Function
    Shared Function Truename(userid As Integer) As String
        Return UserListDAL.Truename(userid)
    End Function
    Shared Function UserName(userid As Integer) As String
        Return UserListDAL.UserName(userid)
    End Function

    Shared Function PwdUpdate(UserNameStr As String, pwdstr As String) As Boolean
        Return UserListDAL.PwdUpdate(UserNameStr, pwdstr)

    End Function
    Shared Function TruenameEnUpdate(userid As Integer, TruenameEn As String) As Boolean
        Return UserListDAL.TruenameEnUpdate(userid, TruenameEn)
    End Function
    Shared Function GradeidUpdate(userid As Integer, gradeid As Integer) As Boolean
        Return UserListDAL.GradeidUpdate(userid, gradeid)
    End Function
    Shared Function userCount(userinfo As Model.Userlist) As Integer
        Return UserListDAL.userCount(userinfo)
    End Function

End Class
