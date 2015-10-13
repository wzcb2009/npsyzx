Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class UserClassSubjectDataDAL
    Shared Function insert(UCSD As Model.UserClassSubjectData) As Model.UserClassSubjectData
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "insert into UserClassSubjectData (UserId,ClassId,SubjectId,Pindex,WeekNum,TermId,ParentId,EventCaseId,Remark,Pubdate,UserChecked) values (@UserId,@ClassId,@SubjectId,@Pindex,@WeekNum,@TermId,@ParentId,@EventCaseId,@Remark,@Pubdate,@UserChecked);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(0).Value = UCSD.UserId
        sqlPara(1) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(1).Value = UCSD.ClassId
        sqlPara(2) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(2).Value = UCSD.SubjectId
        sqlPara(3) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(3).Value = UCSD.Pindex
        sqlPara(4) = New SqlParameter("@WeekNum", SqlDbType.Int)
        sqlPara(4).Value = UCSD.WeekNum
        sqlPara(5) = New SqlParameter("@TermId", SqlDbType.Int)
        sqlPara(5).Value = UCSD.TermId
        sqlPara(6) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(6).Value = UCSD.ParentId
        sqlPara(7) = New SqlParameter("@EventCaseId", SqlDbType.Int)
        sqlPara(7).Value = UCSD.EventCaseId
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = UCSD.Remark
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = UCSD.Pubdate
        sqlPara(10) = New SqlParameter("@UserChecked", SqlDbType.Bit)
        sqlPara(10).Value = UCSD.UserChecked
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        UCSD.Id = i
        Return UCSD
    End Function
    Shared Function Update(UCSD As Model.UserClassSubjectData) As Model.UserClassSubjectData
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "update UserClassSubjectData  set UserId=@UserId,ClassId=@ClassId,SubjectId=@SubjectId,Pindex=@Pindex,WeekNum=@WeekNum,TermId=@TermId,ParentId=@ParentId,EventCaseId=@EventCaseId,Remark=@Remark,Pubdate=@Pubdate,UserChecked=@UserChecked  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = UCSD.Id
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = UCSD.UserId
        sqlPara(2) = New SqlParameter("@ClassId", SqlDbType.Int)
        sqlPara(2).Value = UCSD.ClassId
        sqlPara(3) = New SqlParameter("@SubjectId", SqlDbType.Int)
        sqlPara(3).Value = UCSD.SubjectId
        sqlPara(4) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(4).Value = UCSD.Pindex
        sqlPara(5) = New SqlParameter("@WeekNum", SqlDbType.Int)
        sqlPara(5).Value = UCSD.WeekNum
        sqlPara(6) = New SqlParameter("@TermId", SqlDbType.Int)
        sqlPara(6).Value = UCSD.TermId
        sqlPara(7) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(7).Value = UCSD.ParentId
        sqlPara(8) = New SqlParameter("@EventCaseId", SqlDbType.Int)
        sqlPara(8).Value = UCSD.EventCaseId
        sqlPara(9) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(9).Value = UCSD.Remark
        sqlPara(10) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(10).Value = UCSD.Pubdate
        sqlPara(11) = New SqlParameter("@UserChecked", SqlDbType.Bit)
        sqlPara(11).Value = UCSD.UserChecked
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return UCSD
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserClassSubjectData where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserClassSubjectData where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  UserClassSubjectData"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  UserClassSubjectData where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.UserClassSubjectData
        Return Fabricate.Fill(Of Model.UserClassSubjectData)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "UserClassSubjectData"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
