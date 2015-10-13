Public Class ExamBLL
    Shared Function Dt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Return DAL.ViewTHClassSubjectExamDAL.Dt(activeid, caseid, classid, termid, userid)
    End Function
    Shared Function CaseDt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Return DAL.ViewTHClassSubjectExamDAL.ClassDt(activeid, caseid, classid, termid, userid)
    End Function
    Shared Function SubjectDt(activeid As Integer, caseid As Integer, classid As Integer, termid As Integer, userid As Integer) As DataTable
        Return DAL.ViewTHClassSubjectExamDAL.SubjectDt(activeid, caseid, classid, termid, userid)
    End Function

End Class
