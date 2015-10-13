Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports DAL

Public Class UserBaseInfoBLL
    Shared Function insert(UBI As Model.UserBaseInfo) As Model.UserBaseInfo
        Return UserBaseInfoDAL.insert(UBI)
    End Function
    Shared Function Update(UBI As Model.UserBaseInfo) As Model.UserBaseInfo
        Return UserBaseInfoDAL.Update(UBI)
    End Function
    Shared Function del(BaseInfoId As Integer) As Boolean
        Return UserBaseInfoDAL.del(BaseInfoId)
    End Function
    Shared Function Multidel(BaseInfoIds As String) As Boolean
        Return UserBaseInfoDAL.Multidel(BaseInfoIds)
    End Function
    Shared Function dt() As DataTable
        Return UserBaseInfoDAL.dt()
    End Function
    Shared Function EntityByUserid(userid As Integer) As Model.UserBaseInfo
        Return UserBaseInfoDAL.EntityByUserid(userid)

    End Function

    Shared Function Entity(userid As Integer) As Model.UserBaseInfo
        Return UserBaseInfoDAL.Entity(userid)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return UserBaseInfoDAL.PagerDt(pi)
    End Function
    Shared Function GetId(bi As Model.UserBaseInfo) As Integer
        Return UserBaseInfoDAL.GetId(bi)

    End Function
    Shared Function UpdatePic(userid As Integer, filepath As String) As Boolean
        Return UserBaseInfoDAL.UpdatePic(userid, filepath)
    End Function

End Class
