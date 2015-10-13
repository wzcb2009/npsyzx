Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Public Class UserClassSubjectDAL
   shared Function insert(UCS As Model.UserClassSubject) As Model.UserClassSubject
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "insert into UserClassSubject (TermId,Classid,GradeId,SubjectId,UserId,Status,Pubdate,IsAdmin) values (@TermId,@Classid,@GradeId,@SubjectId,@UserId,@Status,@Pubdate,@IsAdmin);SELECT @@IDENTITY"
        sqlpara(1) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(1).Value = UCS.TermId
        sqlpara(2) = New SqlParameter("@Classid", SqlDbType.int)
        sqlpara(2).Value = UCS.Classid
        sqlpara(3) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(3).Value = UCS.GradeId
        sqlpara(4) = New SqlParameter("@SubjectId", SqlDbType.int)
        sqlpara(4).Value = UCS.SubjectId
        sqlpara(5) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(5).Value = UCS.UserId
        sqlpara(6) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(6).Value = UCS.Status
        sqlpara(7) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(7).Value = UCS.Pubdate
        sqlpara(8) = New SqlParameter("@IsAdmin", SqlDbType.bit)
        sqlpara(8).Value = UCS.IsAdmin
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        UCS.Id = i
        Return UCS
    End Function
   shared Function Update(UCS As Model.UserClassSubject) As Model.UserClassSubject
        Dim sqlPara(8) As SqlParameter
        Dim sql As String
        sql = "update UserClassSubject  set TermId=@TermId,Classid=@Classid,GradeId=@GradeId,SubjectId=@SubjectId,UserId=@UserId,Status=@Status,Pubdate=@Pubdate,IsAdmin=@IsAdmin  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@id", SqlDbType.Int)
        sqlPara(0).Value = UCS.Id
        sqlPara(1) = New SqlParameter("@TermId", SqlDbType.Int)
        sqlPara(1).Value = UCS.TermId
        sqlPara(2) = New SqlParameter("@Classid", SqlDbType.Int)
        sqlpara(2).Value = UCS.Classid
        sqlpara(3) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(3).Value = UCS.GradeId
        sqlpara(4) = New SqlParameter("@SubjectId", SqlDbType.int)
        sqlpara(4).Value = UCS.SubjectId
        sqlpara(5) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(5).Value = UCS.UserId
        sqlpara(6) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(6).Value = UCS.Status
        sqlpara(7) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(7).Value = UCS.Pubdate
        sqlpara(8) = New SqlParameter("@IsAdmin", SqlDbType.bit)
        sqlpara(8).Value = UCS.IsAdmin

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return UCS
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserClassSubject where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserClassSubject where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  UserClassSubject"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  UserClassSubject where Id=Id"
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.UserClassSubject
        Return Fabricate.Fill(Of Model.UserClassSubject)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "UserClassSubject"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetId(ucs As Model.UserClassSubject) As Integer
        Dim sql As String
        sql = "select id from userclasssubject where termid=" & ucs.TermId & " and subjectid=" & ucs.SubjectId & " and classid=" & ucs.Classid & " and userid=" & ucs.UserId
        Return StringHandling.SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function Entity(ucs As Model.UserClassSubject) As Model.UserClassSubject
        Dim sql As String
        sql = "select top 1 * from userclasssubject where termid=" & ucs.TermId & "  and userid=" & ucs.UserId
        If ucs.Classid > 0 Then
            sql = sql & " and  classid=" & ucs.Classid

        End If
        If ucs.SubjectId > 0 Then
            sql = sql & " and  SubjectId=" & ucs.SubjectId

        End If
        Return Fabricate.Fill(Of Model.UserClassSubject)(SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))


    End Function

   shared Function Dt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select * from userclasssubject where 1=1 ")
        If ucs.TermId > 0 Then
            sql.Append(" and termid = " & ucs.TermId)

        End If
        If ucs.SubjectId > 0 Then
            sql.Append(" And subjectid = " & ucs.SubjectId)
        End If
        If ucs.Classid > 0 Then
            sql.Append(" And classid = " & ucs.Classid)
        End If
        If ucs.UserId > 0 Then
            sql.Append("And userid = " & ucs.UserId)
        End If
        If ucs.GradeId > 0 Then
            sql.Append(" And GradeId = " & ucs.GradeId)
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function
    'Function GradeDt(ucs As Model.UserClassSubject) As DataTable
    '    Dim sql As New Text.StringBuilder

    '    sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.gradeid ")
    '    If ucs.TermId > 0 Then
    '        sql.Append(" and userclasssubject.termid = " & ucs.TermId)

    '    End If
    '    If ucs.SubjectId > 0 Then
    '        sql.Append(" And userclasssubject.subjectid = " & ucs.SubjectId)
    '    End If
    '    If ucs.Classid > 0 Then
    '        sql.Append(" And userclasssubject.classid = " & ucs.Classid)
    '    End If
    '    If ucs.UserId > 0 Then
    '        sql.Append("And userclasssubject.userid = " & ucs.UserId)
    '    End If


    '    Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    'End Function
   shared Function TermDt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.termid ")
        If ucs.GradeId > 0 Then
            sql.Append(" and userclasssubject.Gradeid = " & ucs.GradeId)

        End If
        If ucs.SubjectId > 0 Then
            sql.Append(" And userclasssubject.subjectid = " & ucs.SubjectId)
        End If
        If ucs.Classid > 0 Then
            sql.Append(" And userclasssubject.classid = " & ucs.Classid)
        End If
        If ucs.UserId > 0 Then
            sql.Append("And userclasssubject.userid = " & ucs.UserId)
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function
   shared Function GradeAdminDt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.gradeid ")
        If ucs.TermId > 0 Then
            sql.Append(" and userclasssubject.termid = " & ucs.TermId)

        End If
        If ucs.SubjectId > 0 Then
            sql.Append(" And userclasssubject.subjectid = " & ucs.SubjectId)
        End If

        sql.Append(" And  userclasssubject.isadmin =1")

        If ucs.UserId > 0 Then
            sql.Append("And userclasssubject.userid = " & ucs.UserId)
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function
   shared Function GradeDt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.gradeid ")
        If ucs.TermId > 0 Then
            sql.Append(" and userclasssubject.termid = " & ucs.TermId)

        End If
        If ucs.SubjectId > 0 Then
            sql.Append(" And userclasssubject.subjectid = " & ucs.SubjectId)
        End If



        If ucs.UserId > 0 Then
            sql.Append("And userclasssubject.userid = " & ucs.UserId)
        End If



        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function

   shared Function SubjectDt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.subjectid ")
        If ucs.GradeId > 0 Then
            sql.Append(" and userclasssubject.Gradeid = " & ucs.GradeId)
        End If
        If ucs.TermId > 0 Then
            sql.Append(" And userclasssubject.TermId = " & ucs.TermId)
        End If
        If ucs.Classid > 0 Then
            sql.Append(" And userclasssubject.classid = " & ucs.Classid)
        End If
        If ucs.UserId > 0 Then
            sql.Append("And userclasssubject.userid = " & ucs.UserId)
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function
   shared Function ClassDt(ucs As Model.UserClassSubject) As DataTable
        Dim sql As New Text.StringBuilder

        sql.Append("select distinct caseid,casename from SystemCase  inner  join userclasssubject on SystemCase.caseid=userclasssubject.classid ")
        If ucs.GradeId > 0 Then
            sql.Append(" and userclasssubject.Gradeid = " & ucs.GradeId)
        End If
        If ucs.TermId > 0 Then
            sql.Append(" And userclasssubject.TermId = " & ucs.TermId)
        End If
        If ucs.SubjectId > 0 Then
            sql.Append(" And userclasssubject.subjectid = " & ucs.SubjectId)
        End If
        If ucs.UserId > 0 Then
            sql.Append("And userclasssubject.userid = " & ucs.UserId)
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)

    End Function

   shared Function UpdateAdmin(caseid As Integer, termid As Integer) As Boolean
        Dim sql As String
        sql = "update userclasssubject set isadmin=1 where userid in (select userid from user_systemcase where caseid=" & caseid & ") and termid=" & termid
        SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        sql = "update userclasssubject set isadmin=0 where userid not in (select userid from user_systemcase where caseid=" & caseid & ") and termid=" & termid
        SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        Return True

    End Function
End Class
