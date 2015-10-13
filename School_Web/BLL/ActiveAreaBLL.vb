Imports Wzsckj.com.Common

Public Class ActiveAreaBLL
    Shared Function insert(aa As Model.ActiveArea) As Model.ActiveArea
        Return DAL.ActiveAreaDAL.insert(aa)
    End Function
    Shared Function Update(aa As Model.ActiveArea) As Model.ActiveArea
        Return DAL.ActiveAreaDAL.Update(aa)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.ActiveAreaDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.ActiveAreaDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.ActiveAreaDAL.dt()
    End Function
    Shared Function dt(aa As Model.ActiveArea) As DataTable
        Return DAL.ActiveAreaDAL.dt(aa)
    End Function

    Shared Function Entity(Id As Integer) As Model.ActiveArea
        Return DAL.ActiveAreaDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.ActiveAreaDAL.PagerDt(pi)
    End Function
    Shared Function Address(Id As Integer) As String
        Return DAL.ActiveAreaDAL.Address(Id)
    End Function

End Class
