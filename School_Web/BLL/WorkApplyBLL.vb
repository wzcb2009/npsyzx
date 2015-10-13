Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class WorkApplyBLL
    Shared Function insert(W As Model.WorkApply) As Model.WorkApply
        Return DAL.WorkApplyDAL.insert(W)
    End Function
    Shared Function Update(W As Model.WorkApply) As Model.WorkApply
        Return DAL.WorkApplyDAL.Update(W)
    End Function
    Shared Function update(Id As Integer, flag As Integer) As Boolean
        Return DAL.WorkApplyDAL.Update(Id, flag)
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return DAL.WorkApplyDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.WorkApplyDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.WorkApplyDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.WorkApplyDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.WorkApply
        Return DAL.WorkApplyDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.WorkApplyDAL.PagerDt(pi)
    End Function
    Shared Function Entity(w As Model.WorkApply) As Model.WorkApply
        Return DAL.WorkApplyDAL.Entity(w)
    End Function

End Class
