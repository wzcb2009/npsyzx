Imports Wzsckj.com.Common

Public Class UserViewListBLL
    Shared Function insert(UVL As Model.UserViewList) As Model.UserViewList
        Return DAL.UserViewListDAL.insert(UVL)
    End Function
    Shared Function Update(UVL As Model.UserViewList) As Model.UserViewList
        Return DAL.UserViewListDAL.Update(UVL)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.UserViewListDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.UserViewListDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.UserViewListDAL.dt()
    End Function
    Shared Function dt(uvl As Model.UserViewList) As DataTable
        Return DAL.UserViewListDAL.dt(uvl)
    End Function

    Shared Function Entity(Id As Integer) As Model.UserViewList
        Return DAL.UserViewListDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.UserViewListDAL.PagerDt(pi)
    End Function
    Shared Function GetId(uvl As Model.UserViewList) As Integer
        Return DAL.UserViewListDAL.GetId(uvl)
    End Function
    Shared Function getClicks(id As Integer) As Integer
        Return DAL.UserViewListDAL.getClicks(id)
    End Function


End Class
