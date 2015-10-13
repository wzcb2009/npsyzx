Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling

Public Class CommentDAL
   shared Function insert(C As Model.Comment) As Model.Comment
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "insert into Comment (CaseId,ParentId,UserID,Cent,Status,ByUserId,Content,Pubdate) values (@CaseId,@ParentId,@UserID,@Cent,@Status,@ByUserId,@Content,@Pubdate);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(0).Value = C.CaseId
        sqlpara(1) = New SqlParameter("@ParentId", SqlDbType.int)
        sqlpara(1).Value = C.ParentId
        sqlpara(2) = New SqlParameter("@UserID", SqlDbType.int)
        sqlpara(2).Value = C.UserID
        sqlpara(3) = New SqlParameter("@Cent", SqlDbType.int)
        sqlpara(3).Value = C.Cent
        sqlpara(4) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(4).Value = C.Status
        sqlpara(5) = New SqlParameter("@ByUserId", SqlDbType.int)
        sqlpara(5).Value = C.ByUserId
        sqlpara(6) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(6).Value = C.Content
        sqlpara(7) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(7).Value = C.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        C.ID = i
        Return C
    End Function
   shared Function Update(C As Model.Comment) As Model.Comment
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "update Comment  set CaseId=@CaseId,ParentId=@ParentId,UserID=@UserID,Cent=@Cent,Status=@Status,ByUserId=@ByUserId,Content=@Content,Pubdate=@Pubdate  where   "
        sqlpara(0) = New SqlParameter("@ID", SqlDbType.int)
        sqlpara(0).Value = C.ID
        sqlpara(1) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(1).Value = C.CaseId
        sqlpara(2) = New SqlParameter("@ParentId", SqlDbType.int)
        sqlpara(2).Value = C.ParentId
        sqlpara(3) = New SqlParameter("@UserID", SqlDbType.int)
        sqlpara(3).Value = C.UserID
        sqlpara(4) = New SqlParameter("@Cent", SqlDbType.int)
        sqlpara(4).Value = C.Cent
        sqlpara(5) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(5).Value = C.Status
        sqlpara(6) = New SqlParameter("@ByUserId", SqlDbType.int)
        sqlpara(6).Value = C.ByUserId
        sqlpara(7) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(7).Value = C.Content
        sqlpara(8) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(8).Value = C.Pubdate

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return C
    End Function
   shared Function del(id As Integer) As Boolean
        Dim sql As String
        sql = "delete  from  comment where id= " & id
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, Sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
   shared Function MultiDel(ids As String) As Boolean
        Dim sql As String
        sql = "delete  from  comment where ids in(" & ids & ")"
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

   shared Function count(ByVal parentid As Integer) As Integer
        Dim sql As String
        sql = "select count(id) from  comment where parentid= " & parentid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function dt(parentid As Int16) As DataTable
        Dim sql As String
        sql = "select * from  comment where parentid= " & parentid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function AvgCent(parentid As Integer) As Single
        Dim sql As String
        sql = "select avg(cent) from  comment where parentid= " & parentid
        Return SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function



   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "comment"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function Rs(id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  comment where id= " & id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)

    End Function
End Class
