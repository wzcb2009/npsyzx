Imports DAL
Imports Wzsckj.com.Common

Public Class EventUserBLL
    Shared Function insert(EU As Model.EventUser) As Model.EventUser
        Return EventUserDAL.insert(EU)
    End Function
    Shared Function Update(EU As Model.EventUser) As Model.EventUser
        Return EventUserDAL.Update(EU)
    End Function
    Shared Function del(EventUserID As Integer) As Boolean
        Return EventUserDAL.del(EventUserID)
    End Function
    Shared Function Multidel(EventUserIDs As Integer) As Boolean
        Return EventUserDAL.Multidel(EventUserIDs)
    End Function
    Shared Function dt() As DataTable
        Return EventUserDAL.dt()
    End Function
    Shared Function Entity(EventUserID As Integer) As Model.EventUser
        Return EventUserDAL.Entity(EventUserID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return EventUserDAL.PagerDt(pi)
    End Function
    Shared Function Entity(eu As Model.EventUser) As Model.EventUser
        Return EventUserDAL.Entity(eu)
    End Function
    Shared Function GetId(eu As Model.EventUser) As Integer
        Return EventUserDAL.GetId(eu)
    End Function

End Class
