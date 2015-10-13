Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class InvsetResultDAL
   shared Function insert(IR As Model.InvsetResult) As Model.InvsetResult
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "insert into InvsetResult (ActiveId,ClassId,SubjectId,UserId,ItemId,WeigthId,Cent,ByUserId) values (@ActiveId,@ClassId,@SubjectId,@UserId,@ItemId,@WeigthId,@Cent,@ByUserId);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(0).Value = IR.ActiveId
        sqlPara(1) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(1).Value = IR.ClassId
        sqlPara(2) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(2).Value = IR.SubjectId
        sqlPara(3) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(3).Value = IR.UserId
        sqlPara(4) = New SqlParameter("@ItemId", SqlDbType.Int)
        sqlPara(4).Value = IR.ItemId
        sqlPara(5) = New SqlParameter("@WeigthId", SqlDbType.Int)
        sqlPara(5).Value = IR.WeigthId
        sqlPara(6) = New SqlParameter("@Cent", SqlDbType.Float)
        sqlPara(6).Value = IR.Cent
        sqlPara(7) = New SqlParameter("@ByUserId", SqlDbType.Int)
        sqlPara(7).Value = IR.ByUserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        IR.Id = i
        Return IR
    End Function
   shared Function Update(IR As Model.InvsetResult) As Model.InvsetResult
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "update InvsetResult  set ActiveId=@ActiveId,ClassId=@ClassId,SubjectId=@SubjectId,UserId=@UserId,ItemId=@ItemId,WeigthId=@WeigthId,Cent=@Cent,ByUserId=@ByUserId  where   "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = IR.Id
        sqlPara(1) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(1).Value = IR.ActiveId
        sqlPara(2) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(2).Value = IR.ClassId
        sqlPara(3) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(3).Value = IR.SubjectId
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = IR.UserId
        sqlPara(5) = New SqlParameter("@ItemId", SqlDbType.Int)
        sqlPara(5).Value = IR.ItemId
        sqlPara(6) = New SqlParameter("@WeigthId", SqlDbType.Int)
        sqlPara(6).Value = IR.WeigthId
        sqlPara(7) = New SqlParameter("@Cent", SqlDbType.Float)
        sqlPara(7).Value = IR.Cent
        sqlPara(8) = New SqlParameter("@ByUserId", SqlDbType.Int)
        sqlPara(8).Value = IR.ByUserId

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return IR
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from InvsetResult where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from InvsetResult where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  InvsetResult"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  InvsetResult where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.InvsetResult
        Return Fabricate.Fill(Of Model.InvsetResult)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "InvsetResult"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
