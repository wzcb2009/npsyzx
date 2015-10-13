Imports Wzsckj.com.Common
Imports DAL
Public Class ActiveGroupBLL
 shared  Function  insert(G As Model.ActiveGroup) As Model.ActiveGroup
        Return ActiveGroupDAL.insert(G)
    End Function
    Shared Function Update(G As Model.ActiveGroup) As Model.ActiveGroup
        Return ActiveGroupDAL.Update(G)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return ActiveGroupDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return ActiveGroupDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return ActiveGroupDAL.dt()
    End Function
    Shared Function dt(activeId As Integer) As DataTable
        Return ActiveGroupDAL.dt(activeId)
    End Function

    Shared Function Entity(Id As Integer) As Model.ActiveGroup
        Return ActiveGroupDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return ActiveGroupDAL.PagerDt(pi)
    End Function
    Shared Function GetId(ag As Model.ActiveGroup) As Integer
        Return ActiveGroupDAL.GetId(ag)
    End Function
    Shared Function dt(ag As Model.ActiveGroup) As DataTable
        Return ActiveGroupDAL.dt(ag)
    End Function

    Shared Function casedt(ag As Model.ActiveGroup) As DataTable
        Return ActiveGroupDAL.Casedt(ag)
    End Function

End Class
