Imports DAL
Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class EventListBLL
    Shared Function SaveAndUpdate(el As Model.EventList) As Model.EventList
        If el.Id > 0 Then
            Return EventListDAL.Update(el)
        Else
            Return EventListDAL.insert(el)
        End If
    End Function
 
    Shared Function del(ID As Integer) As Boolean
        Return EventListDAL.del(ID)
    End Function
    Shared Function dt(Userid As Integer) As DataTable
        Return EventListDAL.dt(Userid)
    End Function

    Shared Function Multidel(IDs As String) As Boolean
        Return EventListDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return EventListDAL.dt()
    End Function

    Shared Function Entity(ID As Integer) As Model.EventList
        Return EventListDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return EventListDAL.PagerDt(pi)
    End Function

End Class
