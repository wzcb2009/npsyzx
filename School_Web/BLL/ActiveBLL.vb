Imports Wzsckj.com.Common
Imports DAL

Public Class ActiveBLL
    Shared Function insert(ac As Model.Active) As Model.Active
        Return ActiveDAL.insert(ac)
    End Function
    Shared Function Update(ac As Model.Active) As Model.Active
        Return ActiveDAL.Update(ac)
    End Function
    Shared Function del(ID As Integer) As Boolean
        Return ActiveDAL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return ActiveDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return ActiveDAL.dt()
    End Function

    Shared Function Entity(ID As Integer) As Model.Active
        Return ActiveDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return ActiveDAL.PagerDt(pi)
    End Function
    Shared Function Title(ID As Integer) As String
        Return ActiveDAL.Title(ID)
    End Function
    Shared Function CurrentId(caseid As Integer) As Integer
        Return ActiveDAL.CurrentId(caseid)
    End Function

End Class
