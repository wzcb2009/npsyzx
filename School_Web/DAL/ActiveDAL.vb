Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class ActiveDAL
   shared Function insert(ac As Model.Active) As Model.Active
        Dim sqlPara(15) As SqlParameter
        Dim sql As String
        sql = "insert into Active (OrderCode,CaseId,TypeId,ParentId,TermID,GroupId,Title,Remark,UserId,CaseIdlist,StartDate,EndDate,LessonPindex,Status,PicUrl) values (@OrderCode,@CaseId,@TypeId,@ParentId,@TermID,@GroupId,@Title,@Remark,@UserId,@CaseIdlist,@StartDate,@EndDate,@LessonPindex,@Status,@PicUrl);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@OrderCode", SqlDbType.NVarChar)
        sqlPara(0).Value = ac.OrderCode
        sqlPara(1) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(1).Value = ac.CaseId
        sqlPara(2) = New SqlParameter("@TypeId", SqlDbType.Int)
        sqlPara(2).Value = ac.TypeId
        sqlPara(3) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(3).Value = ac.ParentId
        sqlPara(4) = New SqlParameter("@TermID", SqlDbType.Int)
        sqlPara(4).Value = ac.TermID
        sqlPara(5) = New SqlParameter("@GroupId", SqlDbType.Int)
        sqlPara(5).Value = ac.GroupId
        sqlPara(6) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(6).Value = ac.Title
        sqlPara(7) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(7).Value = ac.Remark
        sqlPara(8) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(8).Value = ac.UserId
        sqlPara(9) = New SqlParameter("@CaseIdlist", SqlDbType.NVarChar)
        sqlPara(9).Value = ac.CaseIdlist
        sqlPara(10) = New SqlParameter("@StartDate", SqlDbType.DateTime)
        sqlPara(10).Value = ac.StartDate
        sqlPara(11) = New SqlParameter("@EndDate", SqlDbType.DateTime)
        sqlPara(11).Value = ac.EndDate
        sqlPara(12) = New SqlParameter("@LessonPindex", SqlDbType.Int)
        sqlPara(12).Value = ac.LessonPindex
        sqlPara(13) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(13).Value = ac.Status
        sqlPara(14) = New SqlParameter("@PicUrl", SqlDbType.NVarChar)
        sqlPara(14).Value = ac.PicUrl
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        ac.Id = i
        Return ac
    End Function
   shared Function Update(ac As Model.Active) As Model.Active
        Dim sqlPara(15) As SqlParameter
        Dim sql As String
        sql = "update Active  set OrderCode=@OrderCode,CaseId=@CaseId,TypeId=@TypeId,ParentId=@ParentId,TermID=@TermID,GroupId=@GroupId,Title=@Title,Remark=@Remark,UserId=@UserId,CaseIdlist=@CaseIdlist,StartDate=@StartDate,EndDate=@EndDate,LessonPindex=@LessonPindex,Status=@Status,PicUrl=@PicUrl  where id=@id  "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = ac.ID
        sqlPara(1) = New SqlParameter("@OrderCode", SqlDbType.NVarChar)
        sqlPara(1).Value = ac.OrderCode
        sqlPara(2) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(2).Value = ac.CaseId
        sqlPara(3) = New SqlParameter("@TypeId", SqlDbType.Int)
        sqlPara(3).Value = ac.TypeId
        sqlPara(4) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(4).Value = ac.ParentId
        sqlPara(5) = New SqlParameter("@TermID", SqlDbType.Int)
        sqlPara(5).Value = ac.TermID
        sqlPara(6) = New SqlParameter("@GroupId", SqlDbType.Int)
        sqlPara(6).Value = ac.GroupId
        sqlPara(7) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(7).Value = ac.Title
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = ac.Remark
        sqlPara(9) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(9).Value = ac.UserId
        sqlPara(10) = New SqlParameter("@CaseIdlist", SqlDbType.NVarChar)
        sqlPara(10).Value = ac.CaseIdlist
        sqlPara(11) = New SqlParameter("@StartDate", SqlDbType.DateTime)
        sqlPara(11).Value = ac.StartDate
        sqlPara(12) = New SqlParameter("@EndDate", SqlDbType.DateTime)
        sqlPara(12).Value = ac.EndDate
        sqlPara(13) = New SqlParameter("@LessonPindex", SqlDbType.Int)
        sqlPara(13).Value = ac.LessonPindex
        sqlPara(14) = New SqlParameter("@Status", SqlDbType.Bit)
        sqlPara(14).Value = ac.Status
        sqlPara(15) = New SqlParameter("@PicUrl", SqlDbType.NVarChar)
        sqlPara(15).Value = ac.PicUrl

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return ac
    End Function
    shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Active where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Active where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
 

   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  Active"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  Active where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Title(ID As Integer) As String
        Dim sql As String
        sql = "select Title from  Active where ID=" & ID
        Return StringHandling.SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function

   shared Function Entity(ID As Integer) As Model.Active
        Return Fabricate.Fill(Of Model.Active)(rs(ID))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "Active"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function CurrentId(caseid As Integer) As Integer
        Dim sql As String
        sql = "select id from active where status=1 and  caseid=" & caseid
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
End Class
