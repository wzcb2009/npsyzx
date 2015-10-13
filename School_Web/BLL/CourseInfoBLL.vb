Imports Wzsckj.com.Common
Imports System.Data.SqlClient
Imports DAL

Public Class CourseInfoBLL

    Shared Function insert(CI As Model.CourseInfo) As Model.CourseInfo
        Return CourseInfoDaL.insert(CI)
    End Function
    Shared Function Update(CI As Model.CourseInfo) As Model.CourseInfo
        Return CourseInfoDaL.Update(CI)
    End Function
    Shared Function del(ID As Integer) As Boolean
        Return CourseInfoDaL.del(ID)
    End Function
    Shared Function Multidel(IDs As Integer) As Boolean
        Return CourseInfoDaL.Multidel(IDs)
    End Function
    Shared Function dt() As DataTable
        Return CourseInfoDaL.dt()
    End Function
    Shared Function rs(ID As Integer) As SqlDataReader
        Return CourseInfoDaL.rs(ID)
    End Function
    Shared Function Entity(ID As Integer) As Model.CourseInfo
        Return CourseInfoDaL.Entity(ID)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return CourseInfoDaL.PagerDt(pi)
    End Function
    Shared Function GetId(userid As Integer) As Integer
        Return CourseInfoDaL.GetId(userid)

    End Function

End Class
