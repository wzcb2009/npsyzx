Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class EventUserDAL
    Shared Function insert(EU As Model.EventUser) As Model.EventUser
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "insert into EventUser (EventID,UserId,Pindex,EventCaseID,Pubdate,CheckCaseId,Remark) values (@EventID,@UserId,@Pindex,@EventCaseID,@Pubdate,@CheckCaseId,@Remark);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@EventID", SqlDbType.Int)
        sqlPara(0).Value = EU.Eventid
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = EU.UserId
        sqlPara(2) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(2).Value = EU.Pindex
        sqlPara(3) = New SqlParameter("@EventCaseID", SqlDbType.Int)
        sqlPara(3).Value = EU.EventCaseid
        sqlPara(4) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(4).Value = EU.Pubdate
        sqlPara(5) = New SqlParameter("@CheckCaseId", SqlDbType.Int)
        sqlPara(5).Value = EU.CheckCaseId
        sqlPara(6) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(6).Value = EU.Remark
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        EU.EventUserid = i
        Return EU
    End Function
    Shared Function Update(EU As Model.EventUser) As Model.EventUser
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "update EventUser  set EventID=@EventID,UserId=@UserId,Pindex=@Pindex,EventCaseID=@EventCaseID,Pubdate=@Pubdate,CheckCaseId=@CheckCaseId,Remark=@Remark  where  EventUserID=@EventUserID "
        sqlPara(0) = New SqlParameter("@EventUserID", SqlDbType.Int)
        sqlPara(0).Value = EU.EventUserid
        sqlPara(1) = New SqlParameter("@EventID", SqlDbType.Int)
        sqlPara(1).Value = EU.Eventid
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = EU.UserId
        sqlPara(3) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(3).Value = EU.Pindex
        sqlPara(4) = New SqlParameter("@EventCaseID", SqlDbType.Int)
        sqlPara(4).Value = EU.EventCaseid
        sqlPara(5) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(5).Value = EU.Pubdate
        sqlPara(6) = New SqlParameter("@CheckCaseId", SqlDbType.Int)
        sqlPara(6).Value = EU.CheckCaseId
        sqlPara(7) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(7).Value = EU.Remark
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return EU
    End Function
    Shared Function del(EventUserID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from EventUser where EventUserID=" & EventUserID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(EventUserIDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from EventUser where EventUserID in(" & EventUserIDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  EventUser"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(EventUserID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  EventUser where EventUserID=" & EventUserID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function rs(eu As Model.EventUser) As SqlDataReader
        Dim sql As String
        sql = "select * from  EventUser where eventid=" & eu.Eventid & " and eventcaseid=" & eu.EventCaseid
        If eu.UserId > 0 Then
            sql = sql & " and userid=" & eu.UserId

        End If
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function GetId(eu As Model.EventUser) As Integer
        Dim sql As String
        sql = "select EventUserID from  EventUser where eventid=" & eu.Eventid & " and eventcaseid=" & eu.EventCaseid

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function

    Shared Function Entity(eu As Model.EventUser) As Model.EventUser
        Return Fabricate.Fill(Of Model.EventUser)(rs(eu))
    End Function

    Shared Function Entity(EventUserID As Integer) As Model.EventUser
        Return Fabricate.Fill(Of Model.EventUser)(rs(EventUserID))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "EventUser"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
