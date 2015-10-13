Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class RoomInfoDAL
    Shared Function insert(RI As Model.RoomInfo) As Model.RoomInfo
        Dim sqlPara(6) As SqlParameter
        Dim sql As String
        sql = "insert into RoomInfo (CaseId,Pindex,RoomName,Address,LimitCount,Status) values (@CaseId,@Pindex,@RoomName,@Address,@LimitCount,@Status);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(0).Value = RI.CaseId
        sqlPara(1) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(1).Value = RI.Pindex
        sqlPara(2) = New SqlParameter("@RoomName", SqlDbType.NVarChar)
        sqlPara(2).Value = RI.RoomName
        sqlPara(3) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(3).Value = RI.Address
        sqlPara(4) = New SqlParameter("@LimitCount", SqlDbType.Int)
        sqlPara(4).Value = RI.LimitCount
        sqlPara(5) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(5).Value = RI.Status
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        RI.Id = i
        Return RI
    End Function
    Shared Function Update(RI As Model.RoomInfo) As Model.RoomInfo
        Dim sqlPara(6) As SqlParameter
        Dim sql As String
        sql = "update RoomInfo  set CaseId=@CaseId,Pindex=@Pindex,RoomName=@RoomName,Address=@Address,LimitCount=@LimitCount,Status=@Status  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = RI.Id
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = RI.CaseId
        sqlPara(2) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(2).Value = RI.Pindex
        sqlPara(3) = New SqlParameter("@RoomName", SqlDbType.NVarChar)
        sqlPara(3).Value = RI.RoomName
        sqlPara(4) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(4).Value = RI.Address
        sqlPara(5) = New SqlParameter("@LimitCount", SqlDbType.Int)
        sqlPara(5).Value = RI.LimitCount
        sqlPara(6) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(6).Value = RI.Status
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return RI
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from RoomInfo where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from RoomInfo where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  RoomInfo"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  RoomInfo where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function getRoomname(Id As Integer) As String
        Dim sql As String
        sql = "select roomname from  RoomInfo where Id=" & Id
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function

    Shared Function Entity(Id As Integer) As Model.RoomInfo
        Return Fabricate.Fill(Of Model.RoomInfo)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "RoomInfo"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
