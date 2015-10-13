Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Public Class RoomOrderDAL
    Shared Function insert(RO As Model.RoomOrder) As Model.RoomOrder
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "insert into RoomOrder (RoomId,UserId,Author,Tel,Remark,SD,ED,UserCount,Pubdate,Status,FeedBack,FeedBackPudate) values (@RoomId,@UserId,@Author,@Tel,@Remark,@SD,@ED,@UserCount,@Pubdate,@Status,@FeedBack,@FeedBackPudate);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@RoomId", SqlDbType.Int)
        sqlPara(0).Value = RO.RoomId
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = RO.UserId
        sqlPara(2) = New SqlParameter("@Author", SqlDbType.NVarChar)
        sqlPara(2).Value = RO.Author
        sqlPara(3) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(3).Value = RO.Tel
        sqlPara(4) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(4).Value = RO.Remark
        sqlPara(5) = New SqlParameter("@SD", SqlDbType.DateTime)
        sqlPara(5).Value = RO.Sd
        sqlPara(6) = New SqlParameter("@ED", SqlDbType.DateTime)
        sqlPara(6).Value = RO.Ed
        sqlPara(7) = New SqlParameter("@UserCount", SqlDbType.Int)
        sqlPara(7).Value = RO.UserCount
        sqlPara(8) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(8).Value = RO.Pubdate
        sqlPara(9) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(9).Value = RO.Status
        sqlPara(10) = New SqlParameter("@FeedBack", SqlDbType.NVarChar)
        sqlPara(10).Value = RO.FeedBack
        sqlPara(11) = New SqlParameter("@FeedBackPudate", SqlDbType.DateTime)
        sqlPara(11).Value = RO.FeedBackPudate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        RO.Id = i
        Return RO
    End Function
    Shared Function Update(RO As Model.RoomOrder) As Model.RoomOrder
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "update RoomOrder  set RoomId=@RoomId,UserId=@UserId,Author=@Author,Tel=@Tel,Remark=@Remark,SD=@SD,ED=@ED,UserCount=@UserCount,Pubdate=@Pubdate,Status=@Status,FeedBack=@FeedBack,FeedBackPudate=@FeedBackPudate  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = RO.Id
        sqlPara(1) = New SqlParameter("@RoomId", SqlDbType.Int)
        sqlPara(1).Value = RO.RoomId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = RO.UserId
        sqlPara(3) = New SqlParameter("@Author", SqlDbType.NVarChar)
        sqlPara(3).Value = RO.Author
        sqlPara(4) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(4).Value = RO.Tel
        sqlPara(5) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(5).Value = RO.Remark
        sqlPara(6) = New SqlParameter("@SD", SqlDbType.DateTime)
        sqlPara(6).Value = RO.Sd
        sqlPara(7) = New SqlParameter("@ED", SqlDbType.DateTime)
        sqlPara(7).Value = RO.Ed
        sqlPara(8) = New SqlParameter("@UserCount", SqlDbType.Int)
        sqlPara(8).Value = RO.UserCount
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = RO.Pubdate
        sqlPara(10) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(10).Value = RO.Status
        sqlPara(11) = New SqlParameter("@FeedBack", SqlDbType.NVarChar)
        sqlPara(11).Value = RO.FeedBack
        sqlPara(12) = New SqlParameter("@FeedBackPudate", SqlDbType.DateTime)
        sqlPara(12).Value = RO.FeedBackPudate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return RO
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from RoomOrder where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function update(Id As Integer, flag As Integer) As Boolean
        Dim sql As String
        sql = "update RoomOrder set status=" & flag & " where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from RoomOrder where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  RoomOrder"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  RoomOrder where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function rs(ro As Model.RoomOrder) As SqlDataReader
        Dim sql As String
        sql = "select * from  RoomOrder where roomid=" & ro.RoomId
        Dim ds As String = StringHandling.String.DateBetweenStr(ro.Sd, ro.Ed)
        sql = sql & " and " & ds
        '  Current.Response.Write(sql)
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(ro As Model.RoomOrder) As Model.RoomOrder
        Return Fabricate.Fill(Of Model.RoomOrder)(rs(ro))
    End Function

    Shared Function Entity(Id As Integer) As Model.RoomOrder
        Return Fabricate.Fill(Of Model.RoomOrder)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "RoomOrder"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
