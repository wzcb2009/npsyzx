Imports Wzsckj.com.Common
Imports DAL

Public Class ActiveePortAwardTotalBLL
    Shared Function SaveAndUpdate(PT As Model.ActiveePortAwardTotal) As Model.ActiveePortAwardTotal
        PT.Id = ActiveePortAwardTotalDAL.GetId(PT)
        If PT.Id > 0 Then
            Return ActiveePortAwardTotalDAL.Update(PT)
        Else

            Return ActiveePortAwardTotalDAL.insert(PT)
        End If
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return ActiveePortAwardTotalDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return ActiveePortAwardTotalDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return ActiveePortAwardTotalDAL.dt()
    End Function
    Shared Function dt(ept As Model.ActiveePortAwardTotal) As DataTable
        Return ActiveePortAwardTotalDAL.dt(ept)
    End Function
    Shared Function dt(ept As Model.ActiveePortAwardTotal, classid As Integer) As DataTable
        Return ActiveePortAwardTotalDAL.dt(ept, classid)
    End Function

    Shared Function Rankdt(ep As Model.EportAward) As DataTable
        Return ActiveePortAwardTotalDAL.Rankdt(ep)
    End Function


    Shared Function Entity(Id As Integer) As Model.ActiveePortAwardTotal
        Return ActiveePortAwardTotalDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return ActiveePortAwardTotalDAL.PagerDt(pi)
    End Function
    Shared Function Entity(ept As Model.ActiveePortAwardTotal) As Model.ActiveePortAwardTotal
        Return ActiveePortAwardTotalDAL.Entity(ept)
    End Function
    Shared Function GetId(ept As Model.ActiveePortAwardTotal) As Integer
        Return ActiveePortAwardTotalDAL.GetId(ept)
    End Function
    Shared Function TjCount(ep As Model.EportAward, cent1 As Integer, cent2 As Integer) As Integer
        Return ActiveePortAwardTotalDAL.TjCount(ep, cent1, cent2)
    End Function
    Shared Function MinCent(ep As Model.EportAward) As Single
        Return ActiveePortAwardTotalDAL.MinCent(ep)
    End Function
    Shared Function MaxCent(ep As Model.EportAward) As Single
        Return ActiveePortAwardTotalDAL.MaxCent(ep)
    End Function
    Shared Function userCount(ep As Model.EportAward) As Integer
        Return ActiveePortAwardTotalDAL.userCount(ep)
    End Function
    Shared Function TopPercentCent(ep As Model.EportAward, TopPercent As Integer, typeid As Integer) As Integer
        Return ActiveePortAwardTotalDAL.TopPercentCent(ep, TopPercent, typeid)
    End Function
    Shared Function avgCent(ep As Model.EportAward) As Single
        Return ActiveePortAwardTotalDAL.avgCent(ep)
    End Function
    Shared Function StDevPCent(ep As Model.EportAward) As Single
        Return ActiveePortAwardTotalDAL.StDevPCent(ep)
    End Function
    Shared Function userCount(ep As Model.EportAward, typeid As Integer) As Integer
        Return ActiveePortAwardTotalDAL.userCount(ep, typeid)
    End Function

End Class
