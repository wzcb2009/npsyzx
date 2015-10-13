Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports Passport.SSO.Passport.Class
Imports System.Web.HttpContext
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class TokenService
    Inherits System.Web.Services.WebService

    ''' <summary>
    ''' 根据令牌获取用户凭证
    ''' </summary>
    ''' <param name="tokenValue">令牌</param>
    ''' <returns></returns>
    <WebMethod()> _
    Public Function TokenGetCredence(ByVal tokenValue As String) As Object
        Dim o As Object = Nothing

        Dim dt As DataTable = CacheManager.GetCacheTable()
        If dt IsNot Nothing Then
            Dim dr As DataRow() = dt.Select("token = '" & tokenValue & "'")
            If dr.Length > 0 Then
                o = dr(0)("info")
            End If
        End If

        Return o
    End Function
    <WebMethod()> _
    Public Function TokenInsert(username As String) As Object
        '产生令牌
        Dim tokenValue As String = Guid.NewGuid().ToString().ToUpper()

        Dim tokenCookie As New HttpCookie("Token")
        tokenCookie.Values.Add("Value", tokenValue)
        tokenCookie.Domain = "lwhczx.com"
        Current.Response.AppendCookie(tokenCookie)
        ' 产生主站凭证()
        Dim info As Object = True
        '跳转回分站
        CacheManager.TokenInsert(tokenValue, username, info, DateTime.Now.AddMinutes(Double.Parse(30)))
        Return tokenValue
    End Function

    <WebMethod()> _
    Public Function TokenGetUserName(ByVal tokenValue As String) As Object
        Dim o As Object = Nothing

        Dim dt As DataTable = CacheManager.GetCacheTable()
        If dt IsNot Nothing Then
            Dim dr As DataRow() = dt.Select("token = '" & tokenValue & "'")
            If dr.Length > 0 Then
                o = dr(0)("username")
            End If
        End If

        Return o
    End Function

    ''' <summary>
    ''' 清除令牌
    ''' </summary>
    ''' <param name="tokenValue">令牌</param>
    <WebMethod()> _
    Public Sub ClearToken(ByVal tokenValue As String)
        Dim dt As DataTable = CacheManager.GetCacheTable()
        If dt IsNot Nothing Then
            Dim dr As DataRow() = dt.Select("token = '" & tokenValue & "'")
            If dr.Length > 0 Then
                dt.Rows.Remove(dr(0))
            End If
        End If
    End Sub

End Class