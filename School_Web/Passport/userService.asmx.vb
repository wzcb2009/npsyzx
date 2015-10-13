Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports Wzsckj.com.Common

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class userService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function User_login(ByVal username As String, ByVal pwd As String) As Int16
        Dim userbll As New BLL.UserlistBLL
        If pwd = "" Then
            Return -1

        End If
        pwd = StringHandling.Security.Md5(pwd)

        Return userbll.login(username, pwd)

    End Function
    <WebMethod()> _
    Public Function Pwd_mod(ByVal username As String, oldpwd As String, ByVal newPwd As String) As Integer
        Dim userbll As New BLL.UserlistBLL


        Dim flag As Integer = userbll.login(username, oldpwd)
        If flag = 1 Then
            If userbll.PwdUpdate(username, newPwd) Then
                Return 1
            Else
                Return -3
            End If
        Else
            Return flag
        End If

    End Function
End Class