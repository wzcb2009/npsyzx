Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling
Public Class UserSystemCaseDAL
   shared Function Insert(usc As UserSystemCase) As UserSystemCase
        Dim sql As String
        sql = "INSERT INTO [User_SystemCase]([caseid],[userid],parentid,unitid)     VALUES (@caseid,@userid,@parentid,@unitid) "
        Dim sqlPara(3) As SqlParameter
        sqlPara(3) = New SqlParameter("@Unitid", SqlDbType.Int)
        sqlPara(3).Value = usc.Unitid
        sqlPara(0) = New SqlParameter("@caseid", SqlDbType.Int)
        sqlPara(0).Value = usc.CaseId
        sqlPara(1) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(1).Value = usc.UserId
        sqlPara(2) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(2).Value = usc.Parentid
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        Return usc

    End Function
   shared Function Update(USC As Model.UserSystemCase) As Model.UserSystemCase
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update User_SystemCase  set CaseId=@CaseId   where UserId=@UserId and parentid=@parentid  "
        sqlPara(4) = New SqlParameter("@Unitid", SqlDbType.Int)
        sqlPara(4).Value = USC.Unitid

        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = USC.CaseId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = USC.UserId
        sqlPara(0) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(0).Value = USC.Parentid
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return USC
    End Function
   shared Function UpdateUnitid(USC As Model.UserSystemCase) As Model.UserSystemCase
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update User_SystemCase  set unitid=@unitid where UserId=@UserId and parentid=@parentid  and CaseId=@CaseId  "
        sqlPara(4) = New SqlParameter("@Unitid", SqlDbType.Int)
        sqlPara(4).Value = USC.Unitid

        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = USC.CaseId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = USC.UserId
        sqlPara(0) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(0).Value = USC.Parentid
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return USC
    End Function
   shared Function BatchDel(userid As Integer, parentid As Integer) As Boolean
        Dim sql As String
        sql = "delete from User_SystemCase where userid=@userid  "
        If parentid > 0 Then
            sql = sql & " and parentid=" & parentid
        End If
        Dim sqlPara(0) As SqlParameter
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = userid
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then Return True
    End Function

   shared Function BatchDelOther(userid As Integer, caseids As String, Optional parentid As Integer = 0) As Boolean
        Dim sql As String
        sql = "delete from User_SystemCase where userid=@userid and caseid not in(" & caseids & ")"
        If parentid > 0 Then
            sql = sql & " and parentid=" & parentid
        End If
        Dim sqlPara(0) As SqlParameter
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = userid
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then Return True
    End Function
   shared Function del(usc As Model.UserSystemCase) As Boolean
        Dim sql As String
        sql = "delete from User_SystemCase where userid=@userid"
        Dim sqlPara(2) As SqlParameter
        If usc.Parentid > 0 Then
            sql = sql & "    and parentid=@parentid"
            sqlPara(2) = New SqlParameter("@parentid", SqlDbType.Int)
            sqlPara(2).Value = usc.Parentid
        End If
        If usc.CaseId > 0 Then
            sql = sql & "    and caseid=@caseid"
            sqlPara(1) = New SqlParameter("@caseid", SqlDbType.Int)
            sqlPara(1).Value = usc.CaseId
        End If
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = usc.UserId
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then Return True
    End Function
   shared Function MultiDel(usc() As Model.UserSystemCase) As Boolean
        For Each o As Model.UserSystemCase In usc
            del(o)
        Next
        Return True
    End Function
   shared Function IsExit(usc As UserSystemCase) As Boolean
        Dim sql As String
        sql = "select count(*) from User_SystemCase where userid= @userid and parentid=@parentid"
        Dim sqlPara(1) As SqlParameter

        sqlPara(1) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(1).Value = usc.Parentid
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = usc.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then Return True
    End Function
   shared Function IsExit2(usc As UserSystemCase) As Boolean
        Dim sql As String
        sql = "select count(*) from User_SystemCase where caseid=@caseid and  userid= @userid and parentid=@parentid"
        Dim sqlPara(2) As SqlParameter
        sqlPara(2) = New SqlParameter("@caseid", SqlDbType.Int)
        sqlPara(2).Value = usc.CaseId
        sqlPara(1) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(1).Value = usc.Parentid
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = usc.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then Return True
    End Function
   shared Function Count(usc As UserSystemCase) As Integer
        Dim sql As String
        sql = "select count(*) from User_SystemCase where caseid=@caseid   and parentid=@parentid"
        Dim sqlPara(2) As SqlParameter
        sqlPara(2) = New SqlParameter("@caseid", SqlDbType.Int)
        sqlPara(2).Value = usc.CaseId
        sqlPara(1) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(1).Value = usc.ParentId
        If usc.UserId > 0 Then
            sql = sql & " and userid=@userid"
            sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
            sqlPara(0).Value = usc.UserId

        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)

    End Function

   shared Function GetId(usc As UserSystemCase) As Integer
        Dim sql As String
        sql = "select id from User_SystemCase where caseid=@caseid and  userid= @userid and parentid=@parentid"
        Dim sqlPara(2) As SqlParameter
        sqlPara(2) = New SqlParameter("@caseid", SqlDbType.Int)
        sqlPara(2).Value = usc.CaseId
        sqlPara(1) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(1).Value = usc.Parentid
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = usc.UserId
        Dim i As Integer = StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara))
        Return i
    End Function


   shared Function dt(userid As Integer) As DataTable
        Dim sql As String
        sql = "select * from User_SystemCase where userid=" & userid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt3(usc As Model.UserSystemCase) As DataTable
        Dim sql As String
        sql = "select caseid from User_SystemCase where parentid=" & usc.Parentid & " and unitid=" & usc.UnitId
        If usc.CaseId > 0 Then
            sql = sql & " and caseid=" & usc.CaseId

        End If
        sql = "select * from systemcase where caseid in(" & sql & ")"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(usc As Model.UserSystemCase) As DataTable
        Dim sql As String
        sql = "select * from User_SystemCase where parentid=" & usc.Parentid & " and unitid=" & usc.Unitid
        If usc.CaseId > 0 Then
            sql = sql & " and caseid=" & usc.CaseId

        End If

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dtIsAdmin(usc As Model.UserSystemCase) As DataTable
        Dim sql As String
        sql = "select userid from User_SystemCase where isadmin=1 and  parentid=" & usc.Parentid & " and unitid=" & usc.UnitId
        If usc.CaseId > 0 Then
            sql = sql & " and caseid=" & usc.CaseId

        End If

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function IsAdmin(usc As Model.UserSystemCase) As Boolean
        Dim sql As String
        sql = "select count(*) from User_SystemCase where isadmin=1 and  parentid=" & usc.Parentid & " and userid=" & usc.UserId
        If usc.CaseId > 0 Then
            sql = sql & " and caseid=" & usc.CaseId

        End If

        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) > 0
    End Function
   shared Function AdminCaseid(usc As Model.UserSystemCase) As Integer
        Dim sql As String
        sql = "select caseid from User_SystemCase where isadmin=1 and  parentid=" & usc.Parentid & " and userid=" & usc.UserId


        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function


   shared Function dt2(caseid As Integer) As DataTable
        Dim sql As String
        sql = "select * from User_SystemCase where caseid=" & caseid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    
   shared Function Caseid(usc As Model.UserSystemCase) As Integer

        Dim sql As String
        sql = "select top 1 caseid from User_SystemCase where parentid=" & usc.Parentid & " and userid=" & usc.UserId
        If usc.Unitid > 0 Then
            sql = sql & " and unitid=" & usc.Unitid
        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function

   shared Function Caseid(parentid As Integer, userid As Integer) As Integer
        Dim sql As String
        sql = "select top 1 caseid from User_SystemCase where parentid=" & parentid & " and userid=" & userid & " order by caseid desc"
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
   shared Function dt(parentid As Integer, userid As Integer) As DataTable
        Dim sql As String
        sql = "select * from User_SystemCase where parentid=" & parentid & " and userid=" & userid
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables (0))
    End Function
   shared Function AdminUpdate(usc As Model.UserSystemCase) As Boolean
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update User_SystemCase  set isadmin=@isadmin where UserId=@UserId and parentid=@parentid  and CaseId=@CaseId  "
        sqlPara(4) = New SqlParameter("@isadmin", SqlDbType.Bit)
        sqlPara(4).Value = usc.IsAdmin
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = usc.CaseId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = usc.UserId
        sqlPara(0) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(0).Value = usc.Parentid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function
   shared Function AdminUpdate(usc As Model.UserSystemCase, userids As String, Optional type As String = "") As Boolean
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update User_SystemCase  set isadmin=@isadmin where UserId " & type & " in(" & userids & ") and parentid=@parentid  and CaseId=@CaseId  "
        sqlPara(4) = New SqlParameter("@isadmin", SqlDbType.Bit)
        sqlPara(4).Value = usc.IsAdmin
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = usc.CaseId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = usc.UserId
        sqlPara(0) = New SqlParameter("@parentid", SqlDbType.Int)
        sqlPara(0).Value = usc.Parentid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function


End Class
