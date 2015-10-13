Imports Wzsckj.com.Common

Public Class BlogInfoBLL
    Shared Function SaveAndUpdate(bi As Model.BlogInfo) As Model.BlogInfo
        If DAL.BlogInfoDAL.IsExit(bi.UserId) Then
            DAL.BlogInfoDAL.Update(bi)
        Else
            DAL.BlogInfoDAL.insert(bi)
        End If
    End Function
    Shared Function insert(BI As Model.BlogInfo) As Model.BlogInfo
        Return DAL.BlogInfoDAL.insert(BI)
    End Function
    Shared Function Update(BI As Model.BlogInfo) As Model.BlogInfo
        Return DAL.BlogInfoDAL.Update(BI)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DAL.BlogInfoDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.BlogInfoDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.BlogInfoDAL.dt()
    End Function
    Shared Function EntityByUserid(Id As Integer) As Model.BlogInfo
        Return DAL.BlogInfoDAL.EntityByUserid(Id)
    End Function

    Shared Function Entity(Id As Integer) As Model.BlogInfo
        Return DAL.BlogInfoDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.BlogInfoDAL.PagerDt(pi)
    End Function
    Shared Function IsExit(userid As Integer) As Boolean
        Return DAL.BlogInfoDAL.IsExit(userid)
    End Function
End Class
