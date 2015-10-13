Imports Wzsckj.com.Common
Imports DAL

Public Class InvsetResultBLL

    Shared Function insert(IR As Model.InvsetResult) As Model.InvsetResult
        Return InvsetResultDAL.insert(IR)
    End Function
    Shared Function Update(IR As Model.InvsetResult) As Model.InvsetResult
        Return InvsetResultDAL.Update(IR)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return InvsetResultDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return InvsetResultDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return InvsetResultDAL.dt()
    End Function

    Shared Function Entity(Id As Integer) As Model.InvsetResult
        Return InvsetResultDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return InvsetResultDAL.PagerDt(pi)
    End Function

End Class
