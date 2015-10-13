Imports Wzsckj.com.Common
Imports DAL
Public Class CourseUserBLL

shared  Function  insert(P As Model.EportAward) As Model.EportAward
        Return CourseUserDAL.insert(P)
    End Function
    Shared Function Update(P As Model.EportAward) As Model.EportAward
        Return CourseUserDAL.Update(P)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return CourseUserDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return CourseUserDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return CourseUserDAL.dt()
    End Function

    Shared Function Entity(Id As Integer) As Model.EportAward
        Return CourseUserDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return CourseUserDAL.PagerDt(pi)
    End Function
    Shared Function Count(P As Model.EportAward) As Integer
        Return CourseUserDAL.count(P)
    End Function
    Shared Function GetId(P As Model.EportAward) As Integer
        Return CourseUserDAL.GetId(P)
    End Function

End Class
