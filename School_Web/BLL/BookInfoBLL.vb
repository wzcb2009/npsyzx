Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class BookInfoBLL
    Shared Function insert(RI As Model.RoomInfo) As Model.RoomInfo
        Return DAL.RoomInfoDAL.insert(RI)
    End Function
    Shared Function Update(RI As Model.RoomInfo) As Model.RoomInfo
        Return DAL.RoomInfoDAL.Update(RI)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.RoomInfoDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.RoomInfoDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.RoomInfoDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.RoomInfoDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.RoomInfo
        Return DAL.RoomInfoDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.RoomInfoDAL.PagerDt(pi)
    End Function

End Class
