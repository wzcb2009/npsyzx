Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class PayDAL
    Shared Function insert(P As Model.EportAward) As Model.EportAward
        Dim sqlPara(10) As SqlParameter
        Dim sql As String
        sql = "insert into ePortAward (ActiveId,UserId,Truename,Title,TermId,Caseid,Pubdate,UserChecked,Remark,MoneyNum) values (@ActiveId,@UserId,@Truename,@Title,@TermId,@Caseid,@Pubdate,@UserChecked,@Remark,@MoneyNum);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(0).Value = P.ActiveId
        sqlpara(1) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(1).Value = P.UserId
        sqlpara(2) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(2).Value = P.Truename
        sqlpara(3) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(3).Value = P.Title
        sqlpara(4) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(4).Value = P.TermId
        sqlpara(5) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(5).Value = P.Caseid
        sqlpara(6) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(6).Value = P.Pubdate
        sqlpara(7) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(7).Value = P.UserChecked
        sqlpara(8) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(8).Value = P.Remark
        sqlpara(9) = New SqlParameter("@MoneyNum", SqlDbType.Decimal)
        sqlpara(9).Value = P.MoneyNum
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        P.Id = i
        Return P
    End Function
    Shared Function Update(P As Model.EportAward) As Model.EportAward
        Dim sqlPara(10) As SqlParameter
        Dim sql As String
        sql = "update ePortAward  set ActiveId=@ActiveId,UserId=@UserId,Truename=@Truename,Title=@Title,TermId=@TermId,Caseid=@Caseid,Pubdate=@Pubdate,UserChecked=@UserChecked,Remark=@Remark,MoneyNum=@MoneyNum  where id=@id  "
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
        sqlpara(5) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(5).Value = P.TermId
        sqlpara(6) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(6).Value = P.Caseid
        sqlpara(7) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(7).Value = P.Pubdate
        sqlpara(8) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(8).Value = P.UserChecked
        sqlpara(9) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(9).Value = P.Remark
        sqlpara(10) = New SqlParameter("@MoneyNum", SqlDbType.Decimal)
        sqlpara(10).Value = P.MoneyNum

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return P
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ePortAward"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ePortAward where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.EportAward
        Return Fabricate.Fill(Of Model.ePortAward)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ePortAward"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function UserCount(activeid As Integer) As Integer
        Dim sql As String
        sql = "select count(userid) from ePortAward where activeid=" & activeid
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function UserCount(activeid As Integer, groupid As Integer) As Integer
        Dim sql As String
        sql = "select count(userid) from ePortAward where activeid=" & activeid & " and userid in (select userid from user_systemcase where caseid=" & groupid & ")"
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function


    Shared Function MoneyNumSum(activeid As Integer) As Single
        Dim sql As String
        sql = "select sum(moneynum) from ePortAward where activeid=" & activeid
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function MoneyNumSum(activeid As Integer, groupid As Integer) As Single
        Dim sql As String
        sql = "select sum(moneynum) from ePortAward where activeid=" & activeid & " and userid in (select userid from user_systemcase where caseid=" & groupid & ")"
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function MoneyNumSum(userid As Integer, strWhere As String) As Single
        Dim sql As String
        sql = "select sum(moneynum) from ePortAward where userid=" & userid & " and activeid in(select id from active where caseid=583  " & strWhere & ") "

        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function Usersdt(strWhere As String) As DataTable
        Dim sql As String
        sql = "select * from  ePortAward where 1=1 " & strWhere

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function GetId(P As Model.EportAward) As Integer
        Dim sql As String
        sql = "select Id from ePortAward where activeid=" & P.ActiveId & " and userid=" & P.UserId

        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
End Class
