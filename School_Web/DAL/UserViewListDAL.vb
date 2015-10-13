Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class UserViewListDAL
    Shared Function insert(UVL As Model.UserViewList) As Model.UserViewList
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "insert into UserViewList (ModuleId,ObjUserid,Parentid,UserId,Pubdate,LastDate,Ip,Clicks) values (@ModuleId,@ObjUserid,@Parentid,@UserId,@Pubdate,@LastDate,@Ip,@Clicks);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@ModuleId", SqlDbType.Int)
        sqlPara(0).Value = UVL.ModuleId
        sqlPara(1) = New SqlParameter("@ObjUserid", SqlDbType.Int)
        sqlPara(1).Value = UVL.ObjUserid
        sqlPara(2) = New SqlParameter("@Parentid", SqlDbType.Int)
        sqlPara(2).Value = UVL.Parentid
        sqlPara(3) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(3).Value = UVL.UserId
        sqlPara(4) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(4).Value = UVL.Pubdate
        sqlPara(5) = New SqlParameter("@LastDate", SqlDbType.DateTime)
        sqlPara(5).Value = UVL.LastDate
        sqlPara(6) = New SqlParameter("@Ip", SqlDbType.NVarChar)
        sqlPara(6).Value = UVL.Ip
        sqlPara(7) = New SqlParameter("@Clicks", SqlDbType.Int)
        sqlPara(7).Value = UVL.Clicks
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        UVL.Id = i
        Return UVL
    End Function
    Shared Function Update(UVL As Model.UserViewList) As Model.UserViewList
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "update UserViewList  set ModuleId=@ModuleId,ObjUserid=@ObjUserid,Parentid=@Parentid,UserId=@UserId, LastDate=@LastDate,Ip=@Ip,Clicks=@Clicks  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = UVL.Id
        sqlPara(1) = New SqlParameter("@ModuleId", SqlDbType.Int)
        sqlPara(1).Value = UVL.ModuleId
        sqlPara(2) = New SqlParameter("@ObjUserid", SqlDbType.Int)
        sqlPara(2).Value = UVL.ObjUserid
        sqlPara(3) = New SqlParameter("@Parentid", SqlDbType.Int)
        sqlPara(3).Value = UVL.Parentid
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = UVL.UserId
         sqlPara(6) = New SqlParameter("@LastDate", SqlDbType.DateTime)
        sqlPara(6).Value = UVL.LastDate
        sqlPara(7) = New SqlParameter("@Ip", SqlDbType.NVarChar)
        sqlPara(7).Value = UVL.Ip
        sqlPara(8) = New SqlParameter("@Clicks", SqlDbType.Int)
        sqlPara(8).Value = UVL.Clicks
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return UVL
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserViewList where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserViewList where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function GetId(uvl As Model.UserViewList) As Integer
         Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "select id from UserViewList where ModuleId=@ModuleId and ObjUserid=@ObjUserid and Parentid=@Parentid and UserId=@UserId "
        sqlpara(0) = New SqlParameter("@ModuleId", SqlDbType.int)
        sqlpara(0).Value = UVL.ModuleId
        sqlpara(1) = New SqlParameter("@ObjUserid", SqlDbType.int)
        sqlpara(1).Value = UVL.ObjUserid
        sqlpara(2) = New SqlParameter("@Parentid", SqlDbType.int)
        sqlpara(2).Value = UVL.Parentid
        sqlpara(3) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(3).Value = UVL.UserId
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara))


    End Function
    Shared Function getClicks(id As Integer) As Integer

        Dim sql As String
        sql = "select clicks from UserViewList where  id=" & id
  
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  UserViewList"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dt(uvl As Model.UserViewList) As DataTable
        Dim sql As String
        sql = "select top 10 * from  UserViewList where 1=1"
        If uvl.ObjUserid > 0 Then
            sql = sql & " and objuserid=" & uvl.ObjUserid

        End If
        If uvl.Parentid > 0 Then
            sql = sql & " and parentid=" & uvl.Parentid

        End If
        sql = sql & " order by lastdate desc"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  UserViewList where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.UserViewList
        Return Fabricate.Fill(Of Model.UserViewList)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "UserViewList"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
