Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Public Class ActiveGroupDAL
   shared Function insert(G As Model.ActiveGroup) As Model.ActiveGroup
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "insert into ActiveGroup (ActiveId,CaseId,GradeId,Pindex,Title,UserCount,AdminUserId,CheckUserId,Status,SexFlag,Sex) values (@ActiveId,@CaseId,@GradeId,@Pindex,@Title,@UserCount,@AdminUserId,@CheckUserId,@Status,@SexFlag,@Sex);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(0).Value = G.ActiveId
        sqlpara(1) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(1).Value = G.CaseId
        sqlpara(2) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(2).Value = G.GradeId
        sqlpara(3) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(3).Value = G.Pindex
        sqlpara(4) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(4).Value = G.Title
        sqlpara(5) = New SqlParameter("@UserCount", SqlDbType.int)
        sqlpara(5).Value = G.UserCount
        sqlpara(6) = New SqlParameter("@AdminUserId", SqlDbType.int)
        sqlpara(6).Value = G.AdminUserId
        sqlpara(7) = New SqlParameter("@CheckUserId", SqlDbType.int)
        sqlpara(7).Value = G.CheckUserId
        sqlpara(8) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(8).Value = G.Status
        sqlpara(9) = New SqlParameter("@SexFlag", SqlDbType.bit)
        sqlpara(9).Value = G.SexFlag
        sqlpara(10) = New SqlParameter("@Sex", SqlDbType.int)
        sqlpara(10).Value = G.Sex
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        G.Id = i
        Return G
    End Function
   shared Function Update(G As Model.ActiveGroup) As Model.ActiveGroup
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "update ActiveGroup  set ActiveId=@ActiveId,CaseId=@CaseId,GradeId=@GradeId,Pindex=@Pindex,Title=@Title,UserCount=@UserCount,AdminUserId=@AdminUserId,CheckUserId=@CheckUserId,Status=@Status,SexFlag=@SexFlag,Sex=@Sex  where id=@id  "
        sqlpara(0) = New SqlParameter("@Id", SqlDbType.int)
        sqlpara(0).Value = G.Id
        sqlpara(1) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(1).Value = G.ActiveId
        sqlpara(2) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(2).Value = G.CaseId
        sqlpara(3) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(3).Value = G.GradeId
        sqlpara(4) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(4).Value = G.Pindex
        sqlpara(5) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(5).Value = G.Title
        sqlpara(6) = New SqlParameter("@UserCount", SqlDbType.int)
        sqlpara(6).Value = G.UserCount
        sqlpara(7) = New SqlParameter("@AdminUserId", SqlDbType.int)
        sqlpara(7).Value = G.AdminUserId
        sqlpara(8) = New SqlParameter("@CheckUserId", SqlDbType.int)
        sqlpara(8).Value = G.CheckUserId
        sqlpara(9) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(9).Value = G.Status
        sqlpara(10) = New SqlParameter("@SexFlag", SqlDbType.bit)
        sqlpara(10).Value = G.SexFlag
        sqlpara(11) = New SqlParameter("@Sex", SqlDbType.int)
        sqlpara(11).Value = G.Sex

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return G
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveGroup where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveGroup where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ActiveGroup"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(activeId As Integer) As DataTable
        Dim sql As String
        sql = "select * from  ActiveGroup where ActiveId=" & activeId

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ActiveGroup where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.ActiveGroup
        Return Fabricate.Fill(Of Model.ActiveGroup)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ActiveGroup"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetId(Ag As Model.ActiveGroup) As Integer
        Dim sql As String
        sql = "select id from  ActiveGroup where ActiveId=" & Ag.ActiveId & " and Caseid=" & Ag.CaseId & " and GradeId=" & Ag.GradeId
      
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Casedt(ag As Model.ActiveGroup) As DataTable
        Dim sql As String
        sql = "select * from systemcase where caseid in (select caseid from  ActiveGroup where ActiveId=" & ag.ActiveId & ")"

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function
   shared Function dt(ag As Model.ActiveGroup) As DataTable
        Dim sql As String
        sql = " select * from  ActiveGroup where ActiveId=" & ag.ActiveId
        If ag.CaseId > 0 Then
            sql = sql & " and caseid=" & ag.CaseId

        End If

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function
End Class
