Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class LabApplyDAL
    Shared Function insert(L As Model.LabApply) As Model.LabApply
        Dim sqlPara(14) As SqlParameter
        Dim sql As String
        sql = "insert into LabApply (LabId,Title,UserId,UserChecked,Type,Pubdate,LabDoDate,Pindex,Remark,Cent,StudentCount,GroupId) values (@LabId,@Title,@UserId,@UserChecked,@Type,@Pubdate,@LabDoDate,@Pindex,@Remark,@Cent, @StudentCount,@GroupId);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@LabId", SqlDbType.int)
        sqlpara(0).Value = L.LabId
        sqlpara(1) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(1).Value = L.Title
        sqlpara(2) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(2).Value = L.UserId
        sqlpara(3) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(3).Value = L.UserChecked
        sqlpara(4) = New SqlParameter("@Type", SqlDbType.nvarchar)
        sqlpara(4).Value = L.Type
        sqlpara(5) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(5).Value = L.Pubdate
        sqlpara(6) = New SqlParameter("@LabDoDate", SqlDbType.datetime)
        sqlpara(6).Value = L.LabDoDate
        sqlpara(7) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(7).Value = L.Pindex
        sqlpara(8) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(8).Value = L.Remark
        sqlpara(9) = New SqlParameter("@Cent", SqlDbType.int)
        sqlpara(9).Value = L.Cent
         sqlpara(12) = New SqlParameter("@StudentCount", SqlDbType.int)
        sqlpara(12).Value = L.StudentCount
        sqlpara(13) = New SqlParameter("@GroupId", SqlDbType.int)
        sqlpara(13).Value = L.GroupId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        L.Id = i
        Return L
    End Function
    Shared Function Update(L As Model.LabApply) As Model.LabApply
        Dim sqlPara(14) As SqlParameter
        Dim sql As String
        sql = "update LabApply  set LabId=@LabId,Title=@Title,UserId=@UserId,UserChecked=@UserChecked,Type=@Type,Pubdate=@Pubdate,LabDoDate=@LabDoDate,Pindex=@Pindex,Remark=@Remark,Cent=@Cent ,StudentCount=@StudentCount,GroupId=@GroupId  where  Id=@Id "
        sqlpara(0) = New SqlParameter("@Id", SqlDbType.int)
        sqlpara(0).Value = L.Id
        sqlpara(1) = New SqlParameter("@LabId", SqlDbType.int)
        sqlpara(1).Value = L.LabId
        sqlpara(2) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(2).Value = L.Title
        sqlpara(3) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(3).Value = L.UserId
        sqlpara(4) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(4).Value = L.UserChecked
        sqlpara(5) = New SqlParameter("@Type", SqlDbType.nvarchar)
        sqlpara(5).Value = L.Type
        sqlpara(6) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(6).Value = L.Pubdate
        sqlpara(7) = New SqlParameter("@LabDoDate", SqlDbType.datetime)
        sqlpara(7).Value = L.LabDoDate
        sqlpara(8) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(8).Value = L.Pindex
        sqlpara(9) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(9).Value = L.Remark
        sqlpara(10) = New SqlParameter("@Cent", SqlDbType.int)
        sqlpara(10).Value = L.Cent
 
        sqlpara(13) = New SqlParameter("@StudentCount", SqlDbType.int)
        sqlpara(13).Value = L.StudentCount
        sqlpara(14) = New SqlParameter("@GroupId", SqlDbType.int)
        sqlpara(14).Value = L.GroupId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return L
    End Function
    Shared Function UpdateAssetsChecked(id As Integer, AssetsChecked As Object, AssetsCheckedDate As DateTime) As Boolean
        Dim sqlPara(2) As SqlParameter
        Dim sql As String
        sql = "update LabApply  set AssetsChecked=@AssetsChecked,AssetsCheckedDate=@AssetsCheckedDate  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = id
        sqlPara(1) = New SqlParameter("@AssetsChecked", SqlDbType.Bit)
        sqlPara(1).Value = AssetsChecked
        sqlPara(2) = New SqlParameter("@AssetsCheckedDate", SqlDbType.DateTime)
        sqlPara(2).Value = AssetsCheckedDate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return i > 0
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabApply where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabApply where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  LabApply"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  LabApply where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.LabApply
        Return Fabricate.Fill(Of Model.LabApply)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "LabApply"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function isExit(L As Model.LabApply) As Boolean
        Dim sql As String
        sql = "select count(*) from LabApply where   datediff(day,LabDoDate,'" & L.LabDoDate & "')=0 and   labid=" & L.LabId
        If L.UserId > 0 Then
            sql = sql & " and UserId=" & L.UserId
        End If
        If L.Pindex > 0 Then
            sql = sql & " and Pindex=" & L.Pindex

        End If

        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) > 0

    End Function
    Shared Function GetId(L As Model.LabApply) As Boolean
        Dim sql As String
        sql = "select id from LabApply where   datediff(day,LabDoDate,'" & L.LabDoDate & "')=0 and   labid=" & L.LabId
        If L.UserId > 0 Then
            sql = sql & " and UserId=" & L.UserId

        End If
        If L.Pindex > 0 Then
            sql = sql & " and Pindex=" & L.Pindex

        End If

        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) > 0

    End Function

End Class
