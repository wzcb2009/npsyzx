Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class CourseUserDAL
    Shared Function insert(P As Model.EPortAward) As Model.EPortAward
        Dim sqlPara(13) As SqlParameter
        Dim sql As String
        sql = "insert into ePortAward (ActiveId,UserId,Truename,Title,YearNum,TermId,Caseid,ParentCaseid,Pubdate,UserChecked,Cent,Remark,AdminChecked) values (@ActiveId,@UserId,@Truename,@Title,@YearNum,@TermId,@Caseid,@ParentCaseid,@Pubdate,@UserChecked,@Cent,@Remark,@AdminChecked);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(0).Value = P.ActiveId
        sqlpara(1) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(1).Value = P.UserId
        sqlpara(2) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(2).Value = P.Truename
        sqlpara(3) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(3).Value = P.Title
        sqlpara(4) = New SqlParameter("@YearNum", SqlDbType.int)
        sqlpara(4).Value = P.YearNum
        sqlpara(5) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(5).Value = P.TermId
        sqlpara(6) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(6).Value = P.Caseid
        sqlpara(7) = New SqlParameter("@ParentCaseid", SqlDbType.int)
        sqlpara(7).Value = P.ParentCaseid
        sqlpara(8) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(8).Value = P.Pubdate
        sqlpara(9) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(9).Value = P.UserChecked
        sqlpara(10) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(10).Value = P.Cent
        sqlpara(11) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(11).Value = P.Remark
        sqlpara(12) = New SqlParameter("@AdminChecked", SqlDbType.bit)
        sqlpara(12).Value = P.AdminChecked
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        P.Id = i
        Return P
    End Function
    Shared Function Update(P As Model.EPortAward) As Model.EPortAward
        Dim sqlPara(13) As SqlParameter
        Dim sql As String
        sql = "update ePortAward  set ActiveId=@ActiveId,UserId=@UserId,Truename=@Truename,Title=@Title,YearNum=@YearNum,TermId=@TermId,Caseid=@Caseid,ParentCaseid=@ParentCaseid,Pubdate=@Pubdate,UserChecked=@UserChecked,Cent=@Cent,Remark=@Remark,AdminChecked=@AdminChecked  where  Id=@Id "
        sqlpara(0) = New SqlParameter("@Id", SqlDbType.int)
        sqlpara(0).Value = P.Id
        sqlpara(1) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(1).Value = P.ActiveId
        sqlpara(2) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(2).Value = P.UserId
        sqlpara(3) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(3).Value = P.Truename
        sqlpara(4) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(4).Value = P.Title
        sqlpara(5) = New SqlParameter("@YearNum", SqlDbType.int)
        sqlpara(5).Value = P.YearNum
        sqlpara(6) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(6).Value = P.TermId
        sqlpara(7) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(7).Value = P.Caseid
        sqlpara(8) = New SqlParameter("@ParentCaseid", SqlDbType.int)
        sqlpara(8).Value = P.ParentCaseid
        sqlpara(9) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(9).Value = P.Pubdate
        sqlpara(10) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(10).Value = P.UserChecked
        sqlpara(11) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(11).Value = P.Cent
        sqlpara(12) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(12).Value = P.Remark
        sqlpara(13) = New SqlParameter("@AdminChecked", SqlDbType.bit)
        sqlpara(13).Value = P.AdminChecked
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return P
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ePortAward"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ePortAward where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.EportAward
        Return Fabricate.Fill(Of Model.EportAward)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ePortAward"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function Count(P As Model.EportAward) As Integer
        Dim sql As String
        sql = "select count(*) from  ePortAward where activeId=" & P.ActiveId
        If P.UserId > 0 Then
            sql = sql & " and userid=" & P.UserId
        End If
        If P.Caseid > 0 Then
            sql = sql & " and Caseid=" & P.Caseid
        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function GetId(P As Model.EPortAward) As Integer
        Dim sql As String
        sql = "select id from  ePortAward where activeId=" & P.ActiveId & " and caseid=" & P.Caseid
        If P.UserId > 0 Then
            sql = sql & " and userid=" & P.UserId
        End If

        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

End Class
