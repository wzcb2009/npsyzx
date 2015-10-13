Imports Wzsckj.com.Common

Public Class ActiveCaseSetBLL
    Shared Function AddandSave(cs As Model.ActiveCaseSet) As Model.ActiveCaseSet
        If cs.Id > 0 Then
            Return DAL.ActiveCaseSetDAL.Update(cs)
        End If
        cs.Id = DAL.ActiveCaseSetDAL.GetId(cs)
        If cs.Id > 0 Then
            Return DAL.ActiveCaseSetDAL.Update(cs)
        Else
            Return DAL.ActiveCaseSetDAL.insert(cs)
        End If
    End Function
    'Shared Function insert(CS As Model.ActiveCaseSet) As Model.ActiveCaseSet
    '    Return DAL.ActiveCaseSetDAL.insert(CS)
    'End Function
    'Shared Function Update(CS As Model.ActiveCaseSet) As Model.ActiveCaseSet
    '    Return DAL.ActiveCaseSetDAL.Update(CS)
    'End Function
    Shared Function del(ID As Integer) As Boolean
        Return DAL.ActiveCaseSetDAL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return DAL.ActiveCaseSetDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return DAL.ActiveCaseSetDAL.dt()
    End Function

    Shared Function Entity(ID As Integer) As Model.ActiveCaseSet
        Return DAL.ActiveCaseSetDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.ActiveCaseSetDAL.PagerDt(pi)
    End Function
    Shared Function GetId(cs As Model.ActiveCaseSet) As Integer
        Return DAL.ActiveCaseSetDAL.GetId(cs)
    End Function
    Shared Function classdt(cs As Model.ActiveCaseSet) As DataTable
        Return DAL.ActiveCaseSetDAL.Classdt(cs)
    End Function
    Shared Function Gradedt(cs As Model.ActiveCaseSet) As DataTable
        Return DAL.ActiveCaseSetDAL.Gradedt(cs)
    End Function
    Shared Function Subjectdt(cs As Model.ActiveCaseSet) As DataTable
        Return DAL.ActiveCaseSetDAL.Subjectdt(cs)
    End Function
    Shared Function dt(cs As Model.ActiveCaseSet) As DataTable
        Return DAL.ActiveCaseSetDAL.dt(cs)
    End Function
    Shared Function TotalCent(cs As Model.ActiveCaseSet) As Single
        Return DAL.ActiveCaseSetDAL.TotalCent(cs)
    End Function
    Shared Function Cent(cs As Model.ActiveCaseSet) As Single
        Return DAL.ActiveCaseSetDAL.Cent(cs)
    End Function

End Class
