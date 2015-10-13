Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class TemplateBLL

    Shared Function insert(T As Model.Template) As Model.Template
        Return DAL.TemplateDAL.insert(T)
    End Function
    Shared Function Update(T As Model.Template) As Model.Template
        Return DAL.TemplateDAL.Update(T)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.TemplateDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.TemplateDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.TemplateDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return DAL.TemplateDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.Template
        Return DAL.TemplateDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.TemplateDAL.PagerDt(pi)
    End Function

End Class
