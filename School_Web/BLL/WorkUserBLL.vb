Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class WorkUserBLL
    Shared Function SaveAndUpdate(WU As Model.WorkUser) As Model.WorkUser
        If WU.Id > 0 Then
            Return DAL.WorkUserDAL.Update(WU)

        Else
            Return DAL.WorkUserDAL.insert(WU)

        End If
    End Function

    Shared Function UpdateCheck(WU As Model.WorkUser) As Model.WorkUser
        Return DAL.WorkUserDAL.UpdateCheck(WU)
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return DAL.WorkUserDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.WorkUserDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.WorkUserDAL.dt()
    End Function
    Shared Function dt(eu As Model.WorkUser) As DataTable
        Return DAL.WorkUserDAL.dt(eu)
    End Function

    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.WorkUserDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.WorkUser
        Return DAL.WorkUserDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.WorkUserDAL.PagerDt(pi)
    End Function
    Shared Function GetId(eu As Model.WorkUser) As Integer
        Return DAL.WorkUserDAL.GetId(eu)
    End Function
    Shared Function Entity(eu As Model.WorkUser) As Model.WorkUser
        Return DAL.WorkUserDAL.Entity(eu)
    End Function

End Class
