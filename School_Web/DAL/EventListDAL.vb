Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class EventListDAL
    Shared Function insert(EL As Model.EventList) As Model.EventList
        Dim sqlPara(13) As SqlParameter
        Dim sql As String
        sql = "insert into EventList (CodeNumber,UserId,CaseID,UnitId,LevelId,Number,Price,Title,TrueName,Tel,Pubdate,Address,Remak) values (@CodeNumber,@UserId,@CaseID,@UnitId,@LevelId,@Number,@Price,@Title,@TrueName,@Tel,@Pubdate,@Address,@Remak);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@CodeNumber", SqlDbType.NVarChar)
        sqlPara(0).Value = EL.CodeNumber
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = EL.UserId
        sqlPara(2) = New SqlParameter("@CaseID", SqlDbType.Int)
        sqlPara(2).Value = EL.Caseid
        sqlPara(3) = New SqlParameter("@UnitId", SqlDbType.Int)
        sqlPara(3).Value = EL.UnitId
        sqlPara(4) = New SqlParameter("@LevelId", SqlDbType.Int)
        sqlPara(4).Value = EL.LevelId
        sqlPara(5) = New SqlParameter("@Number", SqlDbType.Int)
        sqlPara(5).Value = EL.Number
        sqlPara(6) = New SqlParameter("@Price", SqlDbType.Float)
        sqlPara(6).Value = EL.Price
        sqlPara(7) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(7).Value = EL.Title
        sqlPara(8) = New SqlParameter("@TrueName", SqlDbType.NVarChar)
        sqlPara(8).Value = EL.TrueName
        sqlPara(9) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(9).Value = EL.Tel
        sqlPara(10) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(10).Value = EL.Pubdate
        sqlPara(11) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(11).Value = EL.Address
        sqlPara(12) = New SqlParameter("@Remak", SqlDbType.NVarChar)
        sqlPara(12).Value = EL.Remak
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        EL.Id = i
        Return EL
    End Function
    Shared Function Update(EL As Model.EventList) As Model.EventList
        Dim sqlPara(13) As SqlParameter
        Dim sql As String
        sql = "update EventList  set CodeNumber=@CodeNumber,UserId=@UserId,CaseID=@CaseID,UnitId=@UnitId,LevelId=@LevelId,Number=@Number,Price=@Price,Title=@Title,TrueName=@TrueName,Tel=@Tel,Pubdate=@Pubdate,Address=@Address,Remak=@Remak  where  ID=@ID "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = EL.Id
        sqlPara(1) = New SqlParameter("@CodeNumber", SqlDbType.NVarChar)
        sqlPara(1).Value = EL.CodeNumber
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = EL.UserId
        sqlPara(3) = New SqlParameter("@CaseID", SqlDbType.Int)
        sqlPara(3).Value = EL.Caseid
        sqlPara(4) = New SqlParameter("@UnitId", SqlDbType.Int)
        sqlPara(4).Value = EL.UnitId
        sqlPara(5) = New SqlParameter("@LevelId", SqlDbType.Int)
        sqlPara(5).Value = EL.LevelId
        sqlPara(6) = New SqlParameter("@Number", SqlDbType.Int)
        sqlPara(6).Value = EL.Number
        sqlPara(7) = New SqlParameter("@Price", SqlDbType.Float)
        sqlPara(7).Value = EL.Price
        sqlPara(8) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(8).Value = EL.Title
        sqlPara(9) = New SqlParameter("@TrueName", SqlDbType.NVarChar)
        sqlPara(9).Value = EL.TrueName
        sqlPara(10) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(10).Value = EL.Tel
        sqlPara(11) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(11).Value = EL.Pubdate
        sqlPara(12) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(12).Value = EL.Address
        sqlPara(13) = New SqlParameter("@Remak", SqlDbType.NVarChar)
        sqlPara(13).Value = EL.Remak
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return EL
    End Function
    Shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from EventList where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from EventList where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  EventList"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dt(Userid As Integer) As DataTable
        Dim sql As String
        sql = "select * from  EventList where userid=" & Userid

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  EventList where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(ID As Integer) As Model.EventList
        Return Fabricate.Fill(Of Model.EventList)(rs(ID))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "EventList"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
