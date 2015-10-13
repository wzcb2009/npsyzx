Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class WorkApplyDAL
    Shared Function insert(W As Model.WorkApply) As Model.WorkApply
        Dim sqlPara(21) As SqlParameter
        Dim sql As String
        sql = "insert into WorkApply (TypeId,CaseId,UserId,Author,Tel,ZW,SD,ED,LessonCount,EventInfo,Remark,Pubdate,Status,CheckUserId,CheckInfo,UserChecked,CheckedPubdate,CheckUserId2,CheckInfo2,UserChecked2,CheckedPubdate2) values (@TypeId,@CaseId,@UserId,@Author,@Tel,@ZW,@SD,@ED,@LessonCount,@EventInfo,@Remark,@Pubdate,@Status,@CheckUserId,@CheckInfo,@UserChecked,@CheckedPubdate,@CheckUserId2,@CheckInfo2,@UserChecked2,@CheckedPubdate2);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@TypeId", SqlDbType.int)
        sqlpara(0).Value = W.TypeId
        sqlpara(1) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(1).Value = W.CaseId
        sqlpara(2) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(2).Value = W.UserId
        sqlpara(3) = New SqlParameter("@Author", SqlDbType.nvarchar)
        sqlpara(3).Value = W.Author
        sqlpara(4) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(4).Value = W.Tel
        sqlpara(5) = New SqlParameter("@ZW", SqlDbType.nvarchar)
        sqlpara(5).Value = W.ZW
        sqlpara(6) = New SqlParameter("@SD", SqlDbType.datetime)
        sqlpara(6).Value = W.SD
        sqlpara(7) = New SqlParameter("@ED", SqlDbType.datetime)
        sqlpara(7).Value = W.ED
        sqlpara(8) = New SqlParameter("@LessonCount", SqlDbType.int)
        sqlpara(8).Value = W.LessonCount
        sqlpara(9) = New SqlParameter("@EventInfo", SqlDbType.nvarchar)
        sqlpara(9).Value = W.EventInfo
        sqlpara(10) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(10).Value = W.Remark
        sqlpara(11) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(11).Value = W.Pubdate
        sqlpara(12) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(12).Value = W.Status
        sqlpara(13) = New SqlParameter("@CheckUserId", SqlDbType.int)
        sqlpara(13).Value = W.CheckUserId
        sqlpara(14) = New SqlParameter("@CheckInfo", SqlDbType.nvarchar)
        sqlpara(14).Value = W.CheckInfo
        sqlpara(15) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(15).Value = W.UserChecked
        sqlpara(16) = New SqlParameter("@CheckedPubdate", SqlDbType.datetime)
        sqlpara(16).Value = W.CheckedPubdate
        sqlpara(17) = New SqlParameter("@CheckUserId2", SqlDbType.int)
        sqlpara(17).Value = W.CheckUserId2
        sqlpara(18) = New SqlParameter("@CheckInfo2", SqlDbType.nvarchar)
        sqlpara(18).Value = W.CheckInfo2
        sqlpara(19) = New SqlParameter("@UserChecked2", SqlDbType.bit)
        sqlpara(19).Value = W.UserChecked2
        sqlpara(20) = New SqlParameter("@CheckedPubdate2", SqlDbType.datetime)
        sqlpara(20).Value = W.CheckedPubdate2
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        W.Id = i
        Return W
    End Function
    Shared Function Update(W As Model.WorkApply) As Model.WorkApply
        Dim sqlPara(21) As SqlParameter
        Dim sql As String
        sql = "update WorkApply  set TypeId=@TypeId,CaseId=@CaseId,UserId=@UserId,Author=@Author,Tel=@Tel,ZW=@ZW,SD=@SD,ED=@ED,LessonCount=@LessonCount,EventInfo=@EventInfo,Remark=@Remark,Pubdate=@Pubdate,Status=@Status,CheckUserId=@CheckUserId,CheckInfo=@CheckInfo,UserChecked=@UserChecked,CheckedPubdate=@CheckedPubdate,CheckUserId2=@CheckUserId2,CheckInfo2=@CheckInfo2,UserChecked2=@UserChecked2,CheckedPubdate2=@CheckedPubdate2  where  Id=@Id "
        sqlpara(0) = New SqlParameter("@Id", SqlDbType.int)
        sqlpara(0).Value = W.Id
        sqlpara(1) = New SqlParameter("@TypeId", SqlDbType.int)
        sqlpara(1).Value = W.TypeId
        sqlpara(2) = New SqlParameter("@CaseId", SqlDbType.int)
        sqlpara(2).Value = W.CaseId
        sqlpara(3) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(3).Value = W.UserId
        sqlpara(4) = New SqlParameter("@Author", SqlDbType.nvarchar)
        sqlpara(4).Value = W.Author
        sqlpara(5) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(5).Value = W.Tel
        sqlpara(6) = New SqlParameter("@ZW", SqlDbType.nvarchar)
        sqlpara(6).Value = W.ZW
        sqlpara(7) = New SqlParameter("@SD", SqlDbType.datetime)
        sqlpara(7).Value = W.SD
        sqlpara(8) = New SqlParameter("@ED", SqlDbType.datetime)
        sqlpara(8).Value = W.ED
        sqlpara(9) = New SqlParameter("@LessonCount", SqlDbType.int)
        sqlpara(9).Value = W.LessonCount
        sqlpara(10) = New SqlParameter("@EventInfo", SqlDbType.nvarchar)
        sqlpara(10).Value = W.EventInfo
        sqlpara(11) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(11).Value = W.Remark
        sqlpara(12) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(12).Value = W.Pubdate
        sqlpara(13) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(13).Value = W.Status
        sqlpara(14) = New SqlParameter("@CheckUserId", SqlDbType.int)
        sqlpara(14).Value = W.CheckUserId
        sqlpara(15) = New SqlParameter("@CheckInfo", SqlDbType.nvarchar)
        sqlpara(15).Value = W.CheckInfo
        sqlpara(16) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(16).Value = W.UserChecked
        sqlpara(17) = New SqlParameter("@CheckedPubdate", SqlDbType.datetime)
        sqlpara(17).Value = W.CheckedPubdate
        sqlpara(18) = New SqlParameter("@CheckUserId2", SqlDbType.int)
        sqlpara(18).Value = W.CheckUserId2
        sqlpara(19) = New SqlParameter("@CheckInfo2", SqlDbType.nvarchar)
        sqlpara(19).Value = W.CheckInfo2
        sqlpara(20) = New SqlParameter("@UserChecked2", SqlDbType.bit)
        sqlpara(20).Value = W.UserChecked2
        sqlpara(21) = New SqlParameter("@CheckedPubdate2", SqlDbType.datetime)
        sqlpara(21).Value = W.CheckedPubdate2
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return W
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from WorkApply where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from WorkApply where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  WorkApply"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  WorkApply where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.WorkApply
        Return Fabricate.Fill(Of Model.WorkApply)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "WorkApply"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function rs(ro As Model.WorkApply) As SqlDataReader
        Dim sql As String
        sql = "select * from  WorkApply where userid=" & ro.UserId
        Dim ds As String = StringHandling.String.DateBetweenStr(ro.Sd, ro.Ed)
        sql = sql & " and " & ds
        '  Current.Response.Write(sql)
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(w As Model.WorkApply) As Model.WorkApply
        Return Fabricate.Fill(Of Model.WorkApply)(rs(w))
    End Function
    Shared Function update(Id As Integer, flag As Integer) As Boolean
        Dim sql As String
        sql = "update WorkApply set status=" & flag & " where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function


End Class
