Imports Wzsckj.com.Common
Imports DAL

Public Class DataMainBLL

    Shared Function Rs(id As Integer) As SqlClient.SqlDataReader
        Return DataMainDAL.Rs(id)

    End Function
    Shared Function Entity(id As Integer) As Model.DataMain
        Return DataMainDAL.Entity(id)

    End Function
    Shared Function EntityPrev(id As Integer, caseid As Integer) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(DataMainDAL.RsPrev(id, caseid))

    End Function
    Shared Function EntityNext(id As Integer, caseid As Integer) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(DataMainDAL.RsNext(id, caseid))

    End Function
    Shared Function Entity(id As Integer, Userid As Integer) As Model.DataMain
        Return DataMainDAL.Entity(id, Userid)

    End Function
    Shared Function Pindex(caseid As Integer) As Integer
        Return DataMainDAL.Pindex(caseid) + 1

    End Function
    Shared Function EntityByCaseId(caseid As Integer, Optional unitid As Integer = 0, Optional typeid As Integer = 0) As Model.DataMain
        Return DataMainDAL.EntityByCaseId(caseid, unitid, typeid)

    End Function
    Shared Function EntityByParentId(parentid As Integer, userid As Integer) As Model.DataMain
        Return DataMainDAL.EntityByParentId(parentid, userid)

    End Function

    Shared Function Entity(dm As Model.DataMain) As Model.DataMain
        Return DataMainDAL.Entity(dm)

    End Function

    Shared Function DtByUserGroup(caseid As Integer, groupid As Integer) As DataTable
        Return DataMainDAL.DtbyUserGroup(caseid, groupid)

    End Function
    Shared Function UserDt(caseids As String, Optional topnum As Integer = 0) As DataTable
        Return DataMainDAL.UserDt(caseids, topnum)

    End Function
    Shared Function DtByUserid(caseid As Integer, userid As Integer) As DataTable
        Return DataMainDAL.DtByUserid(caseid, userid)

    End Function
    Shared Function DtByModuleid(Moduleid As Integer, Optional topRows As Integer = 10, Optional orderby As String = "pubdate desc") As DataTable
        Return DataMainDAL.DtByModuleid(Moduleid, topRows, orderby)
    End Function
    Shared Function DtDistinctUserId(sd As String, ed As String) As DataTable
        Return DAL.DataMainDAL.DtDistinctUserId(sd, ed)
    End Function

    Shared Function Dt() As DataTable
        Return DataMainDAL.Dt

    End Function
    Shared Function cmd_Dt(caseid As Integer, Optional topRows As Integer = 10) As DataTable
        Return DataMainDAL.cmd_Dt(caseid, topRows)
    End Function

    Shared Function Dt(caseid As Integer, Optional toprows As Integer = 10) As Data.DataTable
        Return DataMainDAL.Dt(caseid, toprows)

    End Function
    Shared Function DtByParentid(parentid As Integer, Optional topRows As Integer = 10) As DataTable
        Return DataMainDAL.Dt(parentid, topRows)

    End Function
    Shared Function DtByCaseid(caseids As String, courseid As Integer, Optional topRows As Integer = 10) As DataTable
        Return DataMainDAL.DtByCaseid(caseids, courseid, topRows)

    End Function

    Shared Function DtByTypeid(caseids As String, courseid As Integer, Optional topRows As Integer = 10) As DataTable
        Return DataMainDAL.DtByTypeid(caseids, courseid, topRows)

    End Function
    Shared Function Dt(dm As Model.DataMain, Optional topRows As Integer = 10) As DataTable
        Return DataMainDAL.Dt(dm, topRows)
    End Function
 

    Shared Function Dt(caseids As String, Optional toprows As Integer = 10) As Data.DataTable
        Return DataMainDAL.Dt(caseids, toprows)

    End Function
    Shared Function UpdateClicks(id As Integer) As Boolean
        Return DataMainDAL.UpdateClicks(id)

    End Function
    Shared Function del(id As Integer, userid As Integer) As Boolean
        Return DataMainDAL.del(id, userid)
    End Function

    Shared Function Del(id As Integer) As Boolean
        Return DataMainDAL.del(id)
    End Function
    Shared Function MultiDel(ids As String) As Boolean
        Return DataMainDAL.Multidel(ids)

    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo, caseid As Integer) As DataTable
        pi.strwhere = " caseid=" & caseid
        If pi.keywords <> "" Then
            pi.strwhere = pi.strwhere & " and title like '%" & pi.keywords & "%'"
        End If
        Return DataMainDAL.PagerDt(pi)
    End Function


    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable

        Return DataMainDAL.PagerDt(pi)
    End Function
    Shared Function GetPrevId(id) As Integer
        Return DataMainDAL.GetPrevId(id)
    End Function
    Shared Function GetNextId(id) As Integer
        Return DataMainDAL.GetNextId(id)
    End Function

    Shared Function GetId(dm As Model.DataMain) As Integer
        Return DataMainDAL.GetId(dm)

    End Function

    Shared Function AddandSave(ByRef dm As Model.DataMain) As Model.DataMain
        If dm.Id > 0 Then
            Return DataMainDAL.Update(dm)
        Else
            Return DataMainDAL.insert(dm)

        End If


    End Function
    Shared Function Count(parentid As Integer) As Integer
        Return DataMainDAL.Count(parentid)

    End Function

End Class
