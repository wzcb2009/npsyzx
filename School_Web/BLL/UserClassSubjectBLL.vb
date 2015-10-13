Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports DAL

Public Class UserClassSubjectBLL
    Shared Function SaveAndUpdate(ucs As Model.UserClassSubject) As Model.UserClassSubject
        ucs.Id = UserClassSubjectDAL.GetId(ucs)
        If ucs.Id > 0 Then
            UserClassSubjectDAL.Update(ucs)
        Else
            UserClassSubjectDAL.insert(ucs)
        End If
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return UserClassSubjectDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return UserClassSubjectDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return UserClassSubjectDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return UserClassSubjectDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.UserClassSubject
        Return UserClassSubjectDAL.Entity(Id)
    End Function
    Shared Function Entity(ucs As Model.UserClassSubject) As Model.UserClassSubject
        Return UserClassSubjectDAL.Entity(ucs)
    End Function

    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return UserClassSubjectDAL.PagerDt(pi)
    End Function
    Shared Function GetId(ucs As Model.UserClassSubject) As Integer
        Return UserClassSubjectDAL.GetId(ucs)
    End Function
    Shared Function ClassDt(ucs As Model.UserClassSubject) As DataTable
        Return UserClassSubjectDAL.ClassDt(ucs)
    End Function

    Shared Function Dt(ucs As Model.UserClassSubject) As DataTable
        Return UserClassSubjectDAL.dt(ucs)
    End Function
    Shared Function GradeDt(ucs As Model.UserClassSubject) As DataTable
        Return UserClassSubjectDAL.GradeDt(ucs)
    End Function
    Shared Function GradeAdminDt(ucs As Model.UserClassSubject) As DataTable
        Return UserClassSubjectDAL.GradeAdminDt(ucs)
    End Function

    Shared Function SubjectDt(ucs As Model.UserClassSubject) As DataTable
        Return UserClassSubjectDAL.SubjectDt(ucs)
    End Function
    Shared Function UpdateAdmin(caseid As Integer, termid As Integer) As Boolean
        Return UserClassSubjectDAL.UpdateAdmin(caseid, termid)
    End Function

End Class
