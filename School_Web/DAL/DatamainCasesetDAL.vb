Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports Model
Public Class DatamainCasesetDAL
   shared Function insert(DMCS As Model.DataMainCaseSet) As Model.DataMainCaseSet
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "insert into DataMainCaseSet (Parentid,Caseid,CaseName,DataMainId) values (@Parentid,@Caseid,@CaseName,@DataMainId);SELECT @@IDENTITY"
        sqlPara(1) = New SqlParameter("@Parentid", SqlDbType.Int)
        sqlPara(1).Value = DMCS.Parentid
        sqlPara(2) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(2).Value = DMCS.Caseid
        sqlPara(3) = New SqlParameter("@CaseName", SqlDbType.NVarChar)
        sqlPara(3).Value = DMCS.CaseName
        sqlPara(4) = New SqlParameter("@DataMainId", SqlDbType.Int)
        sqlPara(4).Value = DMCS.DataMainId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        DMCS.Id = i
        Return DMCS
    End Function
   shared Function Update(DMCS As Model.DataMainCaseSet) As Model.DataMainCaseSet
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update DataMainCaseSet  set Parentid=@Parentid,Caseid=@Caseid,CaseName=@CaseName,DataMainId=@DataMainId  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = DMCS.Id

        sqlPara(1) = New SqlParameter("@Parentid", SqlDbType.Int)
        sqlPara(1).Value = DMCS.Parentid
        sqlPara(2) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(2).Value = DMCS.Caseid
        sqlPara(3) = New SqlParameter("@CaseName", SqlDbType.NVarChar)
        sqlPara(3).Value = DMCS.CaseName
        sqlPara(4) = New SqlParameter("@DataMainId", SqlDbType.Int)
        sqlPara(4).Value = DMCS.DataMainId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return DMCS
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from DataMainCaseSet where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from DataMainCaseSet where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  DataMainCaseSet"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(parentid As Integer, dmid As Integer) As DataTable
        Dim sql As String
        sql = "select * from  DataMainCaseSet where datamainid=" & dmid & " and parentid=" & parentid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  DataMainCaseSet where Id= " & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.DataMainCaseSet
        Return Fabricate.Fill(Of Model.DataMainCaseSet)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "DataMainCaseSet"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetId(dmcs As Model.DataMainCaseSet) As Integer
        Dim sql As String
        sql = "select id from datamaincaseset where caseid=" & dmcs.Caseid & " and parentid=" & dmcs.Parentid & " and datamainid=" & dmcs.DataMainId
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
   shared Function delCaseids(caseids As String, parentid As Integer, datamainid As Integer, Optional action As String = "") As Boolean
        Dim sql As String
        sql = "delete  from datamaincaseset where caseid not in(" & caseids & ")  and parentid=" & parentid & "   and datamainid=" & datamainid
        Return (SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)) > 0

    End Function
   shared Function count(caseid As Integer, parentid As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from datamaincaseset where 1=1 "
        If caseid > 0 Then
            sql = sql & " and caseid=" & caseid
        End If
        If parentid > 0 Then
            sql = sql & " and parentid=" & parentid
        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

   shared Function avg(parentid As Integer) As Integer
        Dim sql As String
        sql = "select avg(casenum) from View_DataMainCaseSetGroup where 1=1 "
        If parentid > 0 Then
            sql = sql & " and parentid=" & parentid
        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

End Class
