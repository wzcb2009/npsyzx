Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Public Class ActiveCaseSetDAL
    Shared Function insert(CS As Model.ActiveCaseSet) As Model.ActiveCaseSet
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "insert into ActiveCaseSet (Activeid,GradeId,ClassId,CaseId,Cent,PercentNum,TotalFlag) values (@Activeid,@GradeId,@ClassId,@CaseId,@Cent,@PercentNum,@TotalFlag);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@Activeid", SqlDbType.Int)
        sqlPara(0).Value = CS.Activeid
        sqlPara(1) = New SqlParameter("@GradeId", SqlDbType.Int)
        sqlPara(1).Value = CS.GradeId
        sqlPara(2) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(2).Value = CS.ClassId
        sqlPara(3) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(3).Value = CS.CaseId
        sqlPara(4) = New SqlParameter("@Cent", SqlDbType.Int)
        sqlPara(4).Value = CS.Cent
        sqlPara(5) = New SqlParameter("@PercentNum", SqlDbType.Int)
        sqlPara(5).Value = CS.PercentNum
        sqlPara(6) = New SqlParameter("@TotalFlag", SqlDbType.Bit)
        sqlPara(6).Value = CS.TotalFlag
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        CS.ID = i
        Return CS
    End Function
    Shared Function Update(CS As Model.ActiveCaseSet) As Model.ActiveCaseSet
        Dim sqlPara(7) As SqlParameter
        Dim sql As String
        sql = "update ActiveCaseSet  set Activeid=@Activeid,GradeId=@GradeId,ClassId=@ClassId,CaseId=@CaseId,Cent=@Cent,PercentNum=@PercentNum,TotalFlag=@TotalFlag  where  ID=@ID "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = CS.ID
        sqlPara(1) = New SqlParameter("@Activeid", SqlDbType.Int)
        sqlPara(1).Value = CS.Activeid
        sqlPara(2) = New SqlParameter("@GradeId", SqlDbType.Int)
        sqlPara(2).Value = CS.GradeId
        sqlPara(3) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(3).Value = CS.ClassId
        sqlPara(4) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(4).Value = CS.CaseId
        sqlPara(5) = New SqlParameter("@Cent", SqlDbType.Int)
        sqlPara(5).Value = CS.Cent
        sqlPara(6) = New SqlParameter("@PercentNum", SqlDbType.Int)
        sqlPara(6).Value = CS.PercentNum
        sqlPara(7) = New SqlParameter("@TotalFlag", SqlDbType.Bit)
        sqlPara(7).Value = CS.TotalFlag
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return CS
    End Function
    Shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveCaseSet where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveCaseSet where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ActiveCaseSet"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ActiveCaseSet where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(ID As Integer) As Model.ActiveCaseSet
        Return Fabricate.Fill(Of Model.ActiveCaseSet)(rs(ID))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ActiveCaseSet"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function GetId(cs As Model.ActiveCaseSet) As Integer
        Dim sql As New Text.StringBuilder
        sql.Append("select id from  ActiveCaseSet where 1=1")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If
        If cs.GradeId > 0 Then
            sql.Append(" and GradeId=" & cs.GradeId)
        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql.ToString))

    End Function
    Shared Function Cent(cs As Model.ActiveCaseSet) As Single
        Dim sql As New Text.StringBuilder
        sql.Append("select top 1 cent from  ActiveCaseSet where 1=1  ")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If
        If cs.GradeId > 0 Then
            sql.Append(" and GradeId=" & cs.GradeId)
        End If
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql.ToString))

    End Function
    Shared Function TotalCent(cs As Model.ActiveCaseSet) As Single
        Dim sql As New Text.StringBuilder
        sql.Append(" select top 1 ClassId,SUM(cent) from dbo.ActiveCaseSet where 1=1  ")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If
        If cs.GradeId > 0 Then
            sql.Append(" and GradeId=" & cs.GradeId)
        End If
        sql.Append("  group by ClassId")
        Current.Response.Write(sql.ToString)
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql.ToString))

    End Function

    Shared Function dt(cs As Model.ActiveCaseSet) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select  *  from  ActiveCaseSet where 1=1")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString)).Tables(0)

    End Function

    Shared Function Gradedt(cs As Model.ActiveCaseSet) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select caseid,casename from systemcase where caseid in (")
        sql.Append("select distinct gradeid from  ActiveCaseSet where 1=1")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If
        sql.Append(")")
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString)).Tables(0)

    End Function
    Shared Function Classdt(cs As Model.ActiveCaseSet) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select caseid,casename from systemcase where caseid in (")
        sql.Append("select distinct classid from  ActiveCaseSet where 1=1")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.CaseId > 0 Then
            sql.Append(" and CaseId=" & cs.CaseId)
        End If
        If cs.GradeId > 0 Then
            sql.Append(" and GradeId=" & cs.GradeId)
        End If
        sql.Append(")")
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString)).Tables(0)

    End Function

    Shared Function Subjectdt(cs As Model.ActiveCaseSet) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select caseid,casename from systemcase where caseid in (")
        sql.Append("select distinct caseid from  ActiveCaseSet where 1=1")
        If cs.Activeid > 0 Then
            sql.Append(" and activeid=" & cs.Activeid)
        End If
        If cs.ClassId > 0 Then
            sql.Append(" and ClassId=" & cs.ClassId)
        End If
        If cs.GradeId > 0 Then
            sql.Append(" and GradeId=" & cs.GradeId)
        End If
        sql.Append(")")
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString)).Tables(0)

    End Function

End Class
