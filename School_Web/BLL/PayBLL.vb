Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports DAL

Public Class PayBLL
    Shared Function insert(P As Model.EportAward) As Model.EportAward
        Return PayDAL.insert(P)
    End Function
    Shared Function Update(P As Model.EportAward) As Model.EportAward
        Return PayDAL.Update(P)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return PayDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return PayDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return PayDAL.dt()
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Return PayDAL.rs(Id)
    End Function
    Shared Function Entity(Id As Integer) As Model.EportAward
        Return PayDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return PayDAL.PagerDt(pi)
    End Function
    Shared Function MoneyNumSum(activeid As Integer) As Single
        Return PayDAL.MoneyNumSum(activeid)
    End Function
    Shared Function MoneyNumSum(activeid As Integer, groupid As Integer) As Single
        Return PayDAL.MoneyNumSum(activeid, groupid)
    End Function


    Shared Function MoneyNumSum(userid As Integer, sd As String, ed As String) As Single
        Dim sql As String = ""
        If sd <> "" And ed <> "" Then
            sql = " and (datediff(day,enddate,'" & sd & "')<=0 and datediff(day,enddate,'" & ed & "')>=0) "
        ElseIf sd <> "" Then
            sql = " and datediff(day,enddate,'" & sd & "')<=0   "
        ElseIf ed <> "" Then

            sql = " and   datediff(day,enddate,'" & ed & "')>=0  "
        End If
        Return PayDAL.MoneyNumSum(userid, sql)
    End Function
    Shared Function Usersdt(strWhere As String) As DataTable
        Return PayDAL.Usersdt(strWhere)
    End Function
    Shared Function GetId(P As Model.EportAward) As Integer
        Return PayDAL.GetId(P)
    End Function
    Shared Function UserCount(activeid As Integer) As Integer
        Return PayDAL.UserCount(activeid)
    End Function
    Shared Function UserCount(activeid As Integer, groupid As Integer) As Integer
        Return PayDAL.UserCount(activeid, groupid)
    End Function

End Class
