Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports DAL

Public Class GuestBookBLL

    Shared Function insert(GB As Model.GuestBook) As Model.GuestBook
        Return GuestBookDAL.insert(GB)
    End Function
    Shared Function Update(GB As Model.GuestBook) As Model.GuestBook
        Return GuestBookDAL.Update(GB)
    End Function
    Shared Function Reply(GB As Model.GuestBook) As Model.GuestBook
        Return GuestBookDAL.Reply(GB)
    End Function

    Shared Function del(ID As Integer) As Boolean
        Return GuestBookDAL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return GuestBookDAL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return GuestBookDAL.dt()
    End Function
    Shared Function rs(ID As Integer) As SqlDataReader
        Return GuestBookDAL.rs(ID)
    End Function
    Shared Function Entity(ID As Integer) As Model.GuestBook
        Return GuestBookDAL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return GuestBookDAL.PagerDt(pi)
    End Function

End Class
