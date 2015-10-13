Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Web.HttpContext

Public Class SystemCaseDAL
    Dim unitid_ As Integer
  

    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from SystemCase"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dt(parentid As Integer, Optional orderstr As String = "order by pindex asc", Optional isshowflag As Integer = -1) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where parentid=" & parentid
        If isshowflag > -1 And isshowflag <= 1 Then
            sql = sql & " and isshowflag=" & isshowflag
        End If
        sql = sql & " " & orderstr
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    'Shared Function dt(parentid As Integer) As DataTable
    '    Dim sql As String
    '    sql = "select * from SystemCase where parentid=" & parentid


    '    sql = sql & "  order by pindex asc"
    '    Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    'End Function
    Shared Function Subcasedt(parentid As Integer) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where  parentid in (select caseid  from systemcase where parentid=" & parentid & ")"
        sql = sql & "  order by casename asc"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function dtByCaseData() As DataTable
        Dim sql As String
        sql = "select * from SystemCase where casedata='7'"
        sql = sql & "  order by casename asc"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function dt(parentid As Integer, under_Caseid As Integer) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where parentid=" & parentid & " and caseid<=" & under_Caseid
      


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function


    Shared Function dt(caseids As String) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where caseid in(" & caseids & ")"
     



        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dtByunitid(caseids As String, UnitId As Integer) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where caseid in (" & caseids & ") "
        If UnitId > 0 Then
            sql = sql & " and unitid=" & UnitId
        End If



        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dtByTypeid(caseids As String, parentid As Integer, UnitId As Integer) As DataTable
        Dim sql As String
        sql = "select * from SystemCase where typeid in (" & caseids & ") "
        If UnitId > 0 Then
            sql = sql & " and unitid=" & UnitId
        End If
        If parentid > 0 Then
            sql = sql & " and parentid=" & parentid
        End If




        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function dt2(caseids As String, Optional fldlist As String = "*") As DataTable
        Dim sql As String
        sql = "select " & fldlist & " from SystemCase where caseid in(" & caseids & ")"
    


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function dtByparentids(parentids As String, Optional fldlist As String = "*") As DataTable
        Dim sql As String
        sql = "select " & fldlist & " from SystemCase where parentid  in(" & parentids & ")"
     


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function dt(sc As Model.SystemCase) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select * from SystemCase where 1=1 ")
        If sc.ParentId > 0 Then
            sql.Append(" and parentid=" & sc.ParentId)
        End If
        If sc.Typeid > 0 Then
            sql.Append(" and Typeid=" & sc.Typeid)
        End If
        If sc.Unitid > 0 Then
            sql.Append(" and unitid=" & sc.Unitid)

        End If
        If sc.CaseData <> "" Then
            sql.Append(" and CaseData='" & sc.CaseData & "'")

        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)
    End Function
    Shared Function GetCaaseID(casename As String, parentid As Integer) As Integer
        Dim sql As String
        sql = "select caseid from SystemCase where casename='" & casename & "' and parentid=" & parentid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
    Shared Function IsExit(sc As Model.SystemCase) As Boolean
        Dim sql As String
        sql = "select count(*) from SystemCase where  parentid=" & sc.ParentId
        If sc.CaseData <> "" Then
            sql = sql & "   and  casedata='" & sc.CaseData & "'  "
        End If
        If sc.UserId > 0 Then
            sql = sql & "   and  UserId=" & sc.UserId
        End If
        If sc.CaseName <> "" Then
            sql = sql & "   and  CaseName='" & sc.CaseName & "'  "
        End If

        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) > 0

    End Function

    Shared Function CaseName(caseid As Integer) As String
        Dim sql As String
        sql = "select casename from SystemCase where caseid=" & caseid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function CaseData(caseid As Integer) As String
        Dim sql As String
        sql = "select casedata from SystemCase where caseid=" & caseid
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function NewPindex(parentid As Integer) As Int16
        Dim sql As String
        sql = "select max(pindex) from SystemCase where parentid=" & parentid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) + 1
    End Function
    Shared Function NewCaseId() As Int16
        Dim sql As String
        sql = "select max(caseid) from SystemCase"
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) + 1
    End Function
    Shared Function subcount(parentid As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from SystemCase where parentid=" & parentid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function subcount(parentid As Integer, casedata As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from SystemCase where parentid=" & parentid & " and casedata='" & casedata & "'"
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function Casename(parentid As Integer, casedata As Integer) As String
        Dim sql As String
        sql = "select casename from SystemCase where parentid=" & parentid & " and casedata='" & casedata & "'"
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function

    Shared Function CaseidByName(casename As String) As Integer
        Dim sql As String
        sql = "select  caseid from SystemCase where   casename='" & casename & "'"
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function CaseidByName(parentid As Integer, casename As String) As Integer
        Dim sql As String
        sql = "select  caseid from SystemCase where   casename='" & casename & "' and parentid=" & parentid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function

    Shared Function Caseid(parentid As Integer, casename As String) As Integer
        Dim sql As String
        sql = "select  caseid from SystemCase where parentid=" & parentid & " and casename='" & casename & "'"
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function Caseid(parentid As Integer, Optional isShowFlag As Integer = -1, Optional orderby As String = " pindex asc") As Integer
        Dim sql As String
        sql = "select top 1 caseid from SystemCase where parentid=" & parentid

        If isShowFlag > -1 Then
            sql = sql & " and isshowflag=" & isShowFlag
        End If
        sql = sql & " order by " & orderby
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function


    Shared Function rs2(caseids As String) As SqlDataReader
        Dim sql As String
        sql = "select casename from SystemCase where caseid in(" & caseids & ")"
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function rs(caseid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from SystemCase where caseid=" & caseid
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)

    End Function
    Shared Function Entity(caseid As Integer) As Model.SystemCase
        Return Fabricate.Fill(Of Model.SystemCase)(rs(caseid))
    End Function
    Shared Function add(sc As SystemCase) As SystemCase
        Dim sqlPara(10) As SqlParameter
        sqlPara(10) = New SqlParameter("@Typeid", SqlDbType.Int)
        sqlPara(10).Value = sc.Typeid
        sqlPara(0) = New SqlParameter("@caseid", SqlDbType.SmallInt)
        sqlPara(0).Value = sc.CaseId
        sqlPara(8) = New SqlParameter("@parentid", SqlDbType.SmallInt)
        sqlPara(8).Value = sc.ParentId
        sqlPara(1) = New SqlParameter("@pindex", SqlDbType.SmallInt)
        sqlPara(1).Value = sc.Pindex
        sqlPara(2) = New SqlParameter("@userid", SqlDbType.SmallInt)
        sqlPara(2).Value = sc.UserId
        sqlPara(3) = New SqlParameter("@isshowflag", SqlDbType.Bit)
        sqlPara(3).Value = sc.IsShowFlag
        sqlPara(4) = New SqlParameter("@casedata", SqlDbType.NVarChar)
        sqlPara(4).Value = sc.CaseData
        sqlPara(5) = New SqlParameter("@casedatatypeid", SqlDbType.SmallInt)
        sqlPara(5).Value = sc.CaseDataTypeid
        sqlPara(6) = New SqlParameter("@pubdate", SqlDbType.DateTime)
        sqlPara(6).Value = sc.PubDate
        sqlPara(7) = New SqlParameter("@casename", SqlDbType.NVarChar)
        sqlPara(7).Value = sc.CaseName
        sqlPara(9) = New SqlParameter("@Unitid", SqlDbType.Int)
        sqlPara(9).Value = sc.Unitid
        Dim sql As String
        sql = "insert into SystemCase([pindex],   [parentid] ,typeid, [caseid]  ,[casename] ,[pubdate]  ,[Userid]  ,[isShowFlag]  ,[CaseData]  ,[CaseDataTypeID],unitid) values(@pindex,  @parentid , @typeid,@caseid  ,@casename ,@pubdate  ,@Userid ,@isShowFlag  ,@CaseData  ,@CaseDataTypeID,@unitid);SELECT @@IDENTITY"
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        sc.Id = i

        Return sc
    End Function
    Shared Function IsExit(caseid As Integer) As Boolean
        Dim sql As String
        sql = "select count(*) from SystemCase where caseid=" & caseid
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function IsExit(casename As String) As Boolean
        Dim sql As String
        sql = "select count(*) from SystemCase where casename='" & casename & "'"
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function IsExit(parentid As Integer, casename As String) As Boolean
        Dim sql As String
        sql = "select count(*) from SystemCase where parentid=" & parentid & " and casename=@casename  "
        Dim sqlPara(0) As SqlParameter
        sqlPara(0) = New SqlParameter("@casename", SqlDbType.NVarChar)
        sqlPara(0).Value = casename
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function update(sc As SystemCase) As SystemCase
        Dim sqlPara(10) As SqlParameter
        sqlPara(10) = New SqlParameter("@Typeid", SqlDbType.Int)
        sqlPara(10).Value = sc.Typeid
        sqlPara(0) = New SqlParameter("@caseid", SqlDbType.SmallInt)
        sqlPara(0).Value = sc.CaseId
        sqlPara(1) = New SqlParameter("@pindex", SqlDbType.SmallInt)
        sqlPara(1).Value = sc.Pindex
        sqlPara(2) = New SqlParameter("@userid", SqlDbType.SmallInt)
        sqlPara(2).Value = sc.UserId
        sqlPara(3) = New SqlParameter("@isshowflag", SqlDbType.Bit)
        sqlPara(3).Value = sc.IsShowFlag
        sqlPara(4) = New SqlParameter("@casedata", SqlDbType.NVarChar)
        sqlPara(4).Value = sc.CaseData
        sqlPara(5) = New SqlParameter("@casedatatypeid", SqlDbType.SmallInt)
        sqlPara(5).Value = sc.CaseDataTypeid
        sqlPara(6) = New SqlParameter("@pubdate", SqlDbType.DateTime)
        sqlPara(6).Value = sc.PubDate
        sqlPara(7) = New SqlParameter("@casename", SqlDbType.NVarChar)
        sqlPara(7).Value = sc.CaseName
        sqlPara(8) = New SqlParameter("@parentid", SqlDbType.SmallInt)
        sqlPara(8).Value = sc.ParentId
        sqlPara(9) = New SqlParameter("@Unitid", SqlDbType.Int)
        sqlPara(9).Value = sc.Unitid
        Dim sql As String
        sql = "update SystemCase set [pindex]=@pindex,  typeid=@typeid, [parentid]=@parentid ,[casename]=@casename ,[pubdate]= @pubdate ,[Userid]=@Userid ,[isShowFlag]=@isShowFlag  ,[CaseData]=@CaseData  ,[CaseDataTypeID]=@CaseDataTypeID,unitid=@unitid where  [caseid]=@caseid   "
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        If i > 0 Then
            sc.IsChanged = True
        End If
        Return sc
    End Function
    Shared Function Update(caseid As Integer, pindex As Integer, parentid As Integer)
        Dim sql As String
        sql = "update systemcase set pindex=" & pindex & ", parentid=" & parentid & " where caseid=" & caseid
        Dim i As Integer
        i = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function delete(caseid As Integer) As Boolean
        Dim sql As String
        sql = "delete from    systemcase  where caseid=   " & caseid
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function Multidelete(caseids As String) As Boolean
        Dim sql As String
        sql = "delete from    systemcase  where caseid in(  " & caseids & ")"
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "SystemCase"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function Parentid(caseid As Integer) As Integer
        Dim sql As String
        sql = "select  parentid from SystemCase where caseid=" & caseid
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
        Return i
    End Function
End Class
