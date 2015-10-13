Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class PrinterBLL
    Shared Function insert(P As Model.Printer) As Model.Printer
        Return DAL.PrinterDAL.insert(P)
    End Function
    Shared Function Update(P As Model.Printer) As Model.Printer
        Return DAL.PrinterDAL.Update(P)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.PrinterDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.PrinterDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.PrinterDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.PrinterDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.Printer
        Return DAL.PrinterDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.PrinterDAL.PagerDt(pi)
    End Function

End Class
