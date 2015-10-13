Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class ActiveAreaDAL
    Shared Function insert(aa As Model.ActiveArea) As Model.ActiveArea
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "insert into ActiveArea (ActiveId,GroupId,Pindex,Address,UserCount,UserId,UserChecked,Pubdate) values (@ActiveId,@GroupId,@Pindex,@Address,@UserCount,@UserId,@UserChecked,@Pubdate);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(0).Value = aa.ActiveId
        sqlPara(1) = New SqlParameter("@GroupId", SqlDbType.Int)
        sqlPara(1).Value = aa.GroupId
        sqlPara(2) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(2).Value = aa.Pindex
        sqlPara(3) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(3).Value = aa.Address
        sqlPara(4) = New SqlParameter("@UserCount", SqlDbType.Int)
        sqlPara(4).Value = aa.UserCount
        sqlPara(5) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(5).Value = aa.UserId
        sqlPara(6) = New SqlParameter("@UserChecked", SqlDbType.Bit)
        sqlPara(6).Value = aa.UserChecked
        sqlPara(7) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(7).Value = aa.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        aa.Id = i
        Return aa
    End Function
    Shared Function Update(aa As Model.ActiveArea) As Model.ActiveArea
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "update ActiveArea  set ActiveId=@ActiveId,GroupId=@GroupId,Pindex=@Pindex,Address=@Address,UserCount=@UserCount,UserId=@UserId,UserChecked=@UserChecked,Pubdate=@Pubdate  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = aa.Id
        sqlPara(1) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(1).Value = aa.ActiveId
        sqlPara(2) = New SqlParameter("@GroupId", SqlDbType.Int)
        sqlPara(2).Value = aa.GroupId
        sqlPara(3) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(3).Value = aa.Pindex
        sqlPara(4) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(4).Value = aa.Address
        sqlPara(5) = New SqlParameter("@UserCount", SqlDbType.Int)
        sqlPara(5).Value = aa.UserCount
        sqlPara(6) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(6).Value = aa.UserId
        sqlPara(7) = New SqlParameter("@UserChecked", SqlDbType.Bit)
        sqlPara(7).Value = aa.UserChecked
        sqlPara(8) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(8).Value = aa.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return aa
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveArea where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveArea where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ActiveArea"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dt(aa As Model.ActiveArea, Optional orderby As String = "id asc") As DataTable
        Dim sql As String
        sql = "select newid() as newid_, * from  ActiveArea where activeid=" & aa.ActiveId & " and groupid =" & aa.GroupId


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ActiveArea where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Address(Id As Integer) As String
        Dim sql As String
        sql = "select address from  ActiveArea where Id=" & Id
        Return StringHandling.SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
    Shared Function Entity(Id As Integer) As Model.ActiveArea
        Return Fabricate.Fill(Of Model.ActiveArea)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ActiveArea"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
