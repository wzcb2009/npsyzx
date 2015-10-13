Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class LabExperimentDAL
    Shared Function insert(LE As Model.LabExperiment) As Model.LabExperiment
        Dim sqlPara(9) As SqlParameter
        Dim sql As String
        sql = "insert into LabExperiment (CaseId,SubjectId,GradeId,Pubdate,Status,Pindex,Title,Remark,PicUrl) values (@CaseId,@SubjectId,@GradeId,@Pubdate,@Status,@Pindex,@Title,@Remark,@PicUrl);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(0).Value = LE.CaseId
        sqlPara(1) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(1).Value = LE.SubjectId
        sqlPara(2) = New SqlParameter("@GradeId", SqlDbType.Int)
        sqlPara(2).Value = LE.GradeId
        sqlPara(3) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(3).Value = LE.Pubdate
        sqlPara(4) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(4).Value = LE.Status
        sqlPara(5) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(5).Value = LE.Pindex
        sqlPara(6) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(6).Value = LE.Title
        sqlPara(7) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(7).Value = LE.Remark
        sqlPara(8) = New SqlParameter("@PicUrl", SqlDbType.NVarChar)
        sqlPara(8).Value = LE.PicUrl
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        LE.Id = i
        Return LE
    End Function
    Shared Function Update(LE As Model.LabExperiment) As Model.LabExperiment
        Dim sqlPara(9) As SqlParameter
        Dim sql As String
        sql = "update LabExperiment  set CaseId=@CaseId,SubjectId=@SubjectId,GradeId=@GradeId,Pubdate=@Pubdate,Status=@Status,Pindex=@Pindex,Title=@Title,Remark=@Remark,PicUrl=@PicUrl  where id=@id  "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = LE.Id
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = LE.CaseId
        sqlPara(2) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(2).Value = LE.SubjectId
        sqlPara(3) = New SqlParameter("@GradeId", SqlDbType.Int)
        sqlPara(3).Value = LE.GradeId
        sqlPara(4) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(4).Value = LE.Pubdate
        sqlPara(5) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(5).Value = LE.Status
        sqlPara(6) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(6).Value = LE.Pindex
        sqlPara(7) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(7).Value = LE.Title
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = LE.Remark
        sqlPara(9) = New SqlParameter("@PicUrl", SqlDbType.NVarChar)
        sqlPara(9).Value = LE.PicUrl

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return LE
    End Function
    Shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabExperiment where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabExperiment where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  LabExperiment"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  LabExperiment where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(ID As Integer) As Model.LabExperiment
        Return Fabricate.Fill(Of Model.LabExperiment)(rs(ID))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "LabExperiment"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function GetId(LE As Model.LabExperiment) As Integer
        Dim sql As String
        sql = "select id from LabExperiment where 1=1"
        If LE.CaseId > 0 Then
            sql = sql & " and caseid=" & LE.CaseId

        End If
        If LE.SubjectId > 0 Then
            sql = sql & " and SubjectId=" & LE.SubjectId

        End If
        If LE.GradeId > 0 Then
            sql = sql & " and GradeId=" & LE.GradeId

        End If
        If LE.Title <> "" Then
            sql = sql & " and Title='" & LE.Title & "'"

        End If
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

End Class
