Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace SSO.Passport.Class
    ''' <summary>
    ''' 缓存管理
    ''' 将用户凭证、令牌的关系数据存放于Cache中
    ''' </summary>
    Public Class CacheManager
        ''' <summary>
        ''' 获取缓存中的DataTable
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetCacheTable() As DataTable
            Dim dt As DataTable = Nothing
            If HttpContext.Current.Cache("CERT") IsNot Nothing Then
                dt = DirectCast(HttpContext.Current.Cache("CERT"), DataTable)
            End If
            Return dt
        End Function

        ''' <summary>
        ''' 初始化数据结构
        ''' </summary>
        ''' <remarks>
        ''' ----------------------------------------------------
        ''' | token(令牌) | info(用户凭证) | timeout(过期时间) |
        ''' |--------------------------------------------------|
        ''' </remarks>
        Private Shared Sub cacheInit()
            If HttpContext.Current.Cache("CERT") Is Nothing Then
                Dim dt As New DataTable()

                dt.Columns.Add("token", Type.[GetType]("System.String"))
                dt.Columns("token").Unique = True
                dt.Columns.Add("username", Type.[GetType]("System.String"))
                dt.Columns("username").DefaultValue = Nothing
                dt.Columns.Add("info", Type.[GetType]("System.Object"))
                dt.Columns("info").DefaultValue = Nothing

                dt.Columns.Add("timeout", Type.[GetType]("System.DateTime"))
                dt.Columns("timeout").DefaultValue = DateTime.Now.AddMinutes(Double.Parse(30))

                Dim keys As DataColumn() = New DataColumn(0) {}
                keys(0) = dt.Columns("token")
                dt.PrimaryKey = keys

                'Cache的过期时间为 令牌过期时间*2
                HttpContext.Current.Cache.Insert("CERT", dt, Nothing, DateTime.MaxValue, TimeSpan.FromMinutes(Double.Parse(10) * 2))
            End If
        End Sub

        ''' <summary>
        ''' 判断令牌是否存在
        ''' </summary>
        ''' <param name="token">令牌</param>
        ''' <returns></returns>
        Public Shared Function TokenIsExist(ByVal token As String) As Boolean
            cacheInit()

            Dim dt As DataTable = DirectCast(HttpContext.Current.Cache("CERT"), DataTable)
            If dt.[Select]("token = '" & token & "'").Length = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 更新令牌过期时间
        ''' </summary>
        ''' <param name="token">令牌</param>
        ''' <param name="time">过期时间</param>
        Public Shared Sub TokenTimeUpdate(ByVal token As String, ByVal time As DateTime)
            cacheInit()

            Dim dt As DataTable = DirectCast(HttpContext.Current.Cache("CERT"), DataTable)
            Dim dr As DataRow() = dt.[Select]("token = '" & token & "'")
            If dr.Length > 0 Then
                dr(0)("timeout") = time
            End If
        End Sub

        ''' <summary>
        ''' 添加令牌
        ''' </summary>
        ''' <param name="token">令牌</param>
        ''' <param name="info">凭证</param>
        ''' <param name="timeout">过期时间</param>
        Public Shared Sub TokenInsert(ByVal token As String, ByVal username As String, ByVal info As Object, ByVal timeout As DateTime)
            cacheInit()

            If Not TokenIsExist(token) Then
                Dim dt As DataTable = DirectCast(HttpContext.Current.Cache("CERT"), DataTable)
                Dim dr As DataRow = dt.NewRow()
                dr("token") = token
                dr("username") = username
                dr("info") = info
                dr("timeout") = timeout
                dt.Rows.Add(dr)
                HttpContext.Current.Cache("CERT") = dt
            Else
                TokenTimeUpdate(token, timeout)
            End If
        End Sub

    End Class
    'end class
End Namespace
