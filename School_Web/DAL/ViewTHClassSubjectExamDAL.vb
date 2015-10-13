Imports Wzsckj.com.Common

Public Class ViewTHClassSubjectExamDAL
    Shared Function Dt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select * from  View_THClassSubjectExam where 1=1")
        If Activeid > 0 Then
            sql.Append(" and activeid=" & Activeid)
        End If
        If CaseId > 0 Then
            sql.Append(" and CaseId=" & CaseId)
        End If
        If ClassId > 0 Then
            sql.Append(" and ClassId=" & ClassId)
        End If
        If Termid > 0 Then
            sql.Append(" and Termid=" & Termid)
        End If
        If UserId > 0 Then
            sql.Append(" and userid=" & UserId)
        End If
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0))


    End Function
    Shared Function ClassDt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select caseid ,casename from systemcase where caseid in (select classid from  View_THClassSubjectExam where 1=1")
        If activeid > 0 Then
            sql.Append(" and activeid=" & activeid)
        End If
        If caseid > 0 Then
            sql.Append(" and CaseId=" & caseid)
        End If
        If classid > 0 Then
            sql.Append(" and ClassId=" & classid)
        End If

        If termid > 0 Then
            sql.Append(" and Termid=" & termid)
        End If
        If userid > 0 Then
            sql.Append(" and userid=" & userid)
        End If
        sql.Append(")")
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0))


    End Function
    Shared Function SubjectDt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select caseid ,casename from systemcase where caseid in (select caseid from  View_THClassSubjectExam where 1=1")
        If activeid > 0 Then
            sql.Append(" and activeid=" & activeid)
        End If
        If caseid > 0 Then
            sql.Append(" and CaseId=" & caseid)
        End If
        If classid > 0 Then
            sql.Append(" and ClassId=" & classid)
        End If

        If termid > 0 Then
            sql.Append(" and Termid=" & termid)
        End If
        If userid > 0 Then
            sql.Append(" and userid=" & userid)
        End If
        sql.Append(")")
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0))


    End Function

End Class
