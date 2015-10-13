Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class RoomOrderBLL
    Shared Function insert(RO As Model.RoomOrder) As Model.RoomOrder
        Return DAL.RoomOrderDAL.insert(RO)
    End Function
    Shared Function Update(RO As Model.RoomOrder) As Model.RoomOrder
        Return DAL.RoomOrderDAL.Update(RO)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.RoomOrderDAL.del(Id)
    End Function
    Shared Function update(Id As Integer, flag As Integer) As Boolean
        Return DAL.RoomOrderDAL.Update(Id, flag)
    End Function

    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.RoomOrderDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.RoomOrderDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.RoomOrderDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.RoomOrder
        Return DAL.RoomOrderDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.RoomOrderDAL.PagerDt(pi)
    End Function
    Shared Function Entity(ro As Model.RoomOrder) As Model.RoomOrder
        Return DAL.RoomOrderDAL.Entity(ro)
    End Function

End Class
