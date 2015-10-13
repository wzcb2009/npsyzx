Imports Wzsckj.com.Common
Imports DAL

Public Class DatamainCasesetBLL

    Shared Function insert(DMCS As Model.DataMainCaseSet) As Model.DataMainCaseSet
        Return DatamainCasesetDAL.insert(DMCS)
    End Function
    Shared Function Update(DMCS As Model.DataMainCaseSet) As Model.DataMainCaseSet
        Return DatamainCasesetDAL.Update(DMCS)
    End Function
    Shared Function del(Id As Integer) As Boolean
        Return DatamainCasesetDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DatamainCasesetDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DatamainCasesetDAL.dt()
    End Function
    Shared Function dt(parentid As Integer, dmid As Integer) As DataTable
        Return DatamainCasesetDAL.dt(parentid, dmid)

    End Function

    Shared Function Entity(Id As Integer) As Model.DataMainCaseSet
        Return DatamainCasesetDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DatamainCasesetDAL.PagerDt(pi)
    End Function
    Shared Function GetId(dmcs As Model.DataMainCaseSet) As Integer
        Return DatamainCasesetDAL.GetId(dmcs)

    End Function
    Shared Function delCaseids(caseids As String, parentid As Integer, datamainid As Integer, Optional action As String = "") As Boolean
        Return DatamainCasesetDAL.delCaseids(caseids, parentid, datamainid, action)

    End Function
    Shared Function count(caseid As Integer, parentid As Integer) As Integer
        Return DatamainCasesetDAL.count(caseid, parentid)
    End Function
    Shared Function avg(parentid As Integer) As Integer
        Return DatamainCasesetDAL.avg(parentid)
    End Function
    Sub caselist(parentid As Integer, dmid As Integer, ByRef caseids As String, ByRef casedata As String)
        Dim dt As DataTable
        Dim dmcasebll As New BLL.DatamainCasesetBLL
        dt = dmcasebll.dt(parentid, dmid)
        Dim s, t As New Text.StringBuilder
        For Each r As DataRow In dt.Rows
            s.Append("," & r("casename"))
            t.Append("," & r("caseid"))
        Next
        If s.Length > 0 Then
            s.Remove(0, 1)
            t.Remove(0, 1)

        End If
        casedata = s.ToString
        caseids = t.ToString

    End Sub
    Shared Function caselist(parentid As Integer, dmid As Integer)
        Dim dt As DataTable
        Dim dmcasebll As New BLL.DatamainCasesetBLL
        dt = dmcasebll.dt(parentid, dmid)
        Dim s As New Text.StringBuilder
        For Each r As DataRow In dt.Rows
            s.Append("," & r("casename"))

        Next
        If s.Length > 0 Then
            s.Remove(0, 1)


        End If
        Return s.ToString

    End Function

End Class
