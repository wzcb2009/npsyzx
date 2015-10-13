Imports Wzsckj.com.Common

Public Class UserClassSubjectDataBLL
    Shared Function insert(UCSD As Model.UserClassSubjectData) As Model.UserClassSubjectData
        Return DAL.UserClassSubjectDataDAL.insert(UCSD)
    End Function
    Shared Function Update(UCSD As Model.UserClassSubjectData) As Model.UserClassSubjectData
        Return DAL.UserClassSubjectDataDAL.Update(UCSD)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.UserClassSubjectDataDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.UserClassSubjectDataDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.UserClassSubjectDataDAL.dt()
    End Function

    Shared Function Entity(Id As Integer) As Model.UserClassSubjectData
        Return DAL.UserClassSubjectDataDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.UserClassSubjectDataDAL.PagerDt(pi)
    End Function

End Class
