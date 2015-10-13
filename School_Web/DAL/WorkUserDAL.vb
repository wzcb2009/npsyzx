Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext

Public Class WorkUserDAL
    Shared Function insert(WU As Model.WorkUser) As Model.WorkUser
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "insert into WorkUser (EventID,UserId,Pindex,EventCaseID,Pubdate,CheckCaseId,Remark) values (@EventID,@UserId,@Pindex,@EventCaseID,@Pubdate,@CheckCaseId,@Remark);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@EventID", SqlDbType.Int)
        sqlPara(0).Value = WU.EventID
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = WU.UserId
        sqlPara(2) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(2).Value = WU.Pindex
        sqlPara(3) = New SqlParameter("@EventCaseID", SqlDbType.Int)
        sqlPara(3).Value = WU.EventCaseID
        sqlPara(4) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(4).Value = WU.Pubdate
        sqlPara(5) = New SqlParameter("@CheckCaseId", SqlDbType.Int)
        sqlPara(5).Value = WU.CheckCaseId
        sqlPara(6) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(6).Value = WU.Remark
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        WU.Id = i
        Return WU
    End Function
    Shared Function Update(WU As Model.WorkUser) As Model.WorkUser
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "update WorkUser  set EventID=@EventID,UserId=@UserId,Pindex=@Pindex,EventCaseID=@EventCaseID,Pubdate=@Pubdate,CheckCaseId=@CheckCaseId,Remark=@Remark  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = WU.Id
        sqlPara(1) = New SqlParameter("@EventID", SqlDbType.Int)
        sqlPara(1).Value = WU.EventID
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = WU.UserId
        sqlPara(3) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(3).Value = WU.Pindex
        sqlPara(4) = New SqlParameter("@EventCaseID", SqlDbType.Int)
        sqlPara(4).Value = WU.EventCaseID
        sqlPara(5) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(5).Value = WU.Pubdate
        sqlPara(6) = New SqlParameter("@CheckCaseId", SqlDbType.Int)
        sqlPara(6).Value = WU.CheckCaseId
        sqlPara(7) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(7).Value = WU.Remark
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return WU
    End Function
    Shared Function UpdateCheck(WU As Model.WorkUser) As Model.WorkUser
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "update WorkUser  set Pubdate=@Pubdate,CheckCaseId=@CheckCaseId   where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = WU.Id

        sqlPara(5) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(5).Value = WU.Pubdate
        sqlPara(6) = New SqlParameter("@CheckCaseId", SqlDbType.Int)
        sqlPara(6).Value = WU.CheckCaseId
        sqlPara(7) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(7).Value = WU.Remark
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return WU
    End Function

    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from WorkUser where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from WorkUser where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  WorkUser"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  WorkUser where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.WorkUser
        Return Fabricate.Fill(Of Model.WorkUser)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "WorkUser"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function dt(eu As Model.WorkUser) As DataTable
        Dim sql As String
        sql = "select * from  WorkUser where eventid=" & eu.Eventid
        If eu.UserId > 0 Then
            sql = sql & " and userid=" & eu.UserId

        End If
        If eu.Pindex > 0 Then
            sql = sql & " and pindex=" & eu.Pindex
        End If
        If eu.EventCaseid > 0 Then
            sql = sql & " and eventcaseid=" & eu.EventCaseid

        End If
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(eu As Model.WorkUser) As SqlDataReader
        Dim sql As String
        sql = "select * from  WorkUser where eventid=" & eu.Eventid
        If eu.UserId > 0 Then
            sql = sql & " and userid=" & eu.UserId

        End If
        If eu.Pindex > 0 Then
            sql = sql & " and pindex=" & eu.Pindex
        End If
        If eu.EventCaseid > 0 Then
            sql = sql & " and eventcaseid=" & eu.EventCaseid

        End If

        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function GetId(eu As Model.WorkUser) As Integer
        Dim sql As String
        sql = "select Id from  WorkUser where eventid=" & eu.Eventid
        If eu.Pindex > 0 Then
            sql = sql & " and pindex=" & eu.Pindex
        End If
        If eu.UserId > 0 Then
            sql = sql & " and UserId=" & eu.UserId
        End If
        If eu.EventCaseid > 0 Then
            sql = sql & " and eventcaseid=" & eu.EventCaseid
        End If

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function

    Shared Function Entity(eu As Model.WorkUser) As Model.WorkUser
        Return Fabricate.Fill(Of Model.WorkUser)(rs(eu))
    End Function

End Class
