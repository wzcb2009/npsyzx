Imports Wzsckj.com.Common
Imports DAL
Public Class FilelistBLL

shared  Function  Entity(fileid As Integer) As Model.FileList
        Return FilelistDAL.Entity(fileid)

    End Function
    Shared Function EntityByparentid(caseid As Integer, Parentid As Integer, Optional projectid As Integer = 0) As Model.FileList
        Return FilelistDAL.EntityByparentid(caseid, Parentid, projectid)

    End Function
    Shared Function dt(f As Model.FileList, top As Integer, Optional orderStr As String = "pubdate asc") As DataTable
        Return FilelistDAL.dt(f, top, orderStr)

    End Function

    Shared Function Dt(Parentid As Integer) As DataTable
        Return FilelistDAL.dt(Parentid)

    End Function
    Shared Function Dt(pindex As Integer, Projectid As Integer) As DataTable
        Return FilelistDAL.dt(pindex, Projectid)

    End Function
    Shared Function Dt() As DataTable
        Return FilelistDAL.dt()

    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return FilelistDAL.PagerDt(pi)
    End Function

    Shared Function dt(f As Model.FileList) As DataTable
        Return FilelistDAL.dt(f)

    End Function

    Shared Function dt2(parentid As Integer, Optional unitid As Integer = 0, Optional caseid As Integer = 0) As DataTable
        Return FilelistDAL.dt2(parentid, unitid, caseid)

    End Function
    Shared Function Dt(caseid As Integer, Parentid As Integer, userid As Integer) As DataTable
        Return FilelistDAL.dt(caseid, Parentid, userid)

    End Function

    Shared Function Add(file As Model.FileList) As Model.FileList
        Return FilelistDAL.insert(file)

    End Function
    Shared Function Update2(parentid As Integer, fileids As String, userid As Integer) As Boolean
        Return FilelistDAL.Update2(parentid, fileids, userid)

    End Function

    Shared Function Update(projectid As Integer, fileids As String, Optional Parentid As Integer = 0) As Boolean
        Return FilelistDAL.Update(projectid, fileids, Parentid)

    End Function

    Shared Function Update(file As Model.FileList) As Model.FileList
        Return FilelistDAL.Update(file)

    End Function
    Shared Function UpdateUserid(Userid As Integer, fileids As String) As Boolean
        Return FilelistDAL.UpdateUserid(Userid, fileids)

    End Function

    Shared Function Del(file As Model.FileList) As Boolean
        Return FilelistDAL.del(file.FileId)
    End Function
    Shared Function Del(fileid As Integer) As Boolean
        Return FilelistDAL.del(fileid)
    End Function

    Shared Function MultDelByParentid(parentid As Integer) As Integer
        Return FilelistDAL.DelByParentid(parentid)
    End Function
    Shared Function MultDelByParentid(parentids As String) As Integer
        Return FilelistDAL.DelByParentid(parentids)
    End Function
    Shared Function Rs(fileid As Integer) As SqlClient.SqlDataReader
        Return FilelistDAL.rs(fileid)

    End Function
    Shared Function Count(f As Model.FileList, sd As String, ed As String) As Int16
        ' Return FilelistDAL.Count(f, sd, ed)

    End Function
    Shared Function Count(f As Model.FileList, StrWhere As String) As Int16
        Return FilelistDAL.Count(f, StrWhere)
    End Function

    Shared Function Count(f As Model.FileList) As Int16
        Return FilelistDAL.Count(f)

    End Function

    Shared Function Count(projectid As Integer, pindex As Integer) As Int16
        Return FilelistDAL.Count(projectid, pindex)

    End Function
    Shared Function fileid(projectid As Integer, parentid As Integer, caseid As Integer) As Int16
        Return FilelistDAL.fileid(projectid, parentid, caseid)
    End Function

    Shared Function fileid(file As Model.FileList) As Int16
        Return FilelistDAL.fileid(file)

    End Function

    Shared Function count(projectid As Integer) As Int16
        Return FilelistDAL.Count(projectid)

    End Function
    Shared Function CountbyParentid(parentid As Integer) As Int16
        Return FilelistDAL.CountbyParentid(parentid)

    End Function
    Shared Function UpdateGradeid(Gradeid As Integer, userid As Integer, typeid As Integer) As Boolean
        Return FilelistDAL.UpdateGradeid(Gradeid, userid, typeid)
    End Function
    Shared Function Updateclick(fileid As Integer) As Boolean
        Return FilelistDAL.Updateclick(fileid)
    End Function

End Class
