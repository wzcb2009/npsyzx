Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports DAL
Public Class EPortAwardBll

shared  Function  insert(P As Model.EPortAward) As Model.EPortAward
        Return ePortAwardDAL.insert(P)
    End Function
    Shared Function Update(P As Model.EportAward) As Model.EportAward
        Return ePortAwardDAL.Update(P)
    End Function
    Shared Function UpdateGroupid(groupid As Integer, Ids As String) As Boolean
        Return ePortAwardDAL.UpdateGroupid(groupid, Ids)
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return ePortAwardDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return ePortAwardDAL.Multidel(Ids)
    End Function
    Shared Function ClassDt(p As Model.EportAward, Optional orderStr As String = "pindex asc") As DataTable
        Return ePortAwardDAL.ClassDt(p, orderStr)
    End Function

    Shared Function dt() As DataTable
        Return ePortAwardDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return ePortAwardDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.EportAward
        Return ePortAwardDAL.Entity(Id)
    End Function
    Shared Function Entity(p As Model.EportAward) As Model.EportAward
        Return ePortAwardDAL.Entity(p)
    End Function

    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return ePortAwardDAL.PagerDt(pi)
    End Function
    Shared Function GetCount(p As Model.EportAward) As Integer
        Return ePortAwardDAL.GetCount(p)
    End Function
    Shared Function Dt(p As Model.EportAward, Optional orderStr As String = "pindex asc") As DataTable
        Return ePortAwardDAL.dt(p, orderStr)
    End Function
    Shared Function GetId(p As Model.EportAward) As Integer
        Return ePortAwardDAL.GetId(p)
    End Function
    Shared Function UpdateAreaId(ep As Model.EportAward, topnum As Integer) As Boolean
        Return ePortAwardDAL.UpdateAreaId(ep, topnum)
    End Function
    Shared Function UpdateAreaIdRest(ep As Model.EportAward) As Boolean
        Return ePortAwardDAL.UpdateAreaIdRest(ep)
    End Function
    Shared Function RankDT(ep As Model.EportAward) As DataTable
        Return ePortAwardDAL.RankDT(ep)
    End Function
    Shared Function SumDt(ep As Model.EportAward) As DataTable
        Return ePortAwardDAL.SumDt(ep)
    End Function
    Shared Function TjCount(ep As Model.EportAward, cent1 As Integer, cent2 As Integer) As Integer
        Return ePortAwardDAL.TjCount(ep, cent1, cent2)
    End Function
    Shared Function MinCent(ep As Model.EportAward, type As Integer) As Single
        Return ePortAwardDAL.MinCent(ep, type)
    End Function
    Shared Function UserCount(ep As Model.EportAward) As Integer
        Return ePortAwardDAL.UserCount(ep)
    End Function
    Shared Function UserCount(ep As Model.EportAward, typeid As Integer) As Integer
        Return ePortAwardDAL.UserCount(ep, typeid)
    End Function

    Shared Function TopPercentCent(ep As Model.EportAward, topPercent As Integer, type As Integer) As Single
        Return ePortAwardDAL.TopPercentCent(ep, topPercent, type)
    End Function
    Shared Function avgCent(ep As Model.EportAward) As Single
        Return ePortAwardDAL.avgCent(ep)
    End Function
    Shared Function StDevPCent(ep As Model.EportAward) As Single
        Return ePortAwardDAL.StDevPCent(ep)
    End Function
End Class
