Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class TemplateDAL
    Shared Function insert(T As Model.Template) As Model.Template
        Dim sqlPara(6) As SqlParameter
        Dim sql As String
        sql = "insert into Template (Title,CaseId,Remark,Pubdate,State,UserId) values (@Title,@CaseId,@Remark,@Pubdate,@State,@UserId);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(0).Value = T.Title
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = T.CaseId
        sqlPara(2) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(2).Value = T.Remark
        sqlPara(3) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(3).Value = T.Pubdate
        sqlPara(4) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(4).Value = T.State
        sqlPara(5) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(5).Value = T.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        T.Id = i
        Return T
    End Function
    Shared Function Update(T As Model.Template) As Model.Template
        Dim sqlPara(6) As SqlParameter
        Dim sql As String
        sql = "update Template  set Title=@Title,CaseId=@CaseId,Remark=@Remark,Pubdate=@Pubdate,State=@State,UserId=@UserId  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = T.Id
        sqlPara(1) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(1).Value = T.Title
        sqlPara(2) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(2).Value = T.CaseId
        sqlPara(3) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(3).Value = T.Remark
        sqlPara(4) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(4).Value = T.Pubdate
        sqlPara(5) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(5).Value = T.State
        sqlPara(6) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(6).Value = T.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return T
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Template where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Template where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  Template"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  Template where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.Template
        Return Fabricate.Fill(Of Model.Template)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "Template"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
