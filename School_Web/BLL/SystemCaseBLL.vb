Imports Wzsckj.com.Common
Imports DAL

Public Class SystemCaseBLL
    Shared Function Casenamelists(caseid As Integer, TopCaseid As Integer) As String
        Dim rs = DAL.SystemCaseDAL.rs(caseid)
        If rs.Read Then
            If rs("parentid") = TopCaseid Then
                Return CaseName(TopCaseid)
            Else
                Casenamelists = Casenamelists(rs("parentid"), TopCaseid) & "/" & rs("casename")

            End If
        End If
    End Function

    Shared Function Add(ByRef sc As Model.SystemCase) As Model.SystemCase
        If SystemCaseDAL.IsExit(sc) Then
            Return sc
        End If
        Return SystemCaseDAL.add(sc)

    End Function
    Shared Function Modify(sc As Model.SystemCase) As Boolean
        SystemCaseDAL.update(sc)
        Return True
        'If Not SystemCaseDAL.IsExit(sc.ParentId, sc.CaseName) Then

        'Else
        '    Return False
        'End If
    End Function
    Shared Function Del(caseid As Integer) As Boolean
        Return SystemCaseDAL.delete(caseid)

    End Function
    Shared Function MultiDel(caseids As String) As Boolean
        Return SystemCaseDAL.Multidelete(caseids)
    End Function
    Shared Function Dt() As DataTable
        Return SystemCaseDAL.dt
    End Function
    Shared Function dtByTypeid(caseids As String, parentid As Integer, UnitId As Integer) As DataTable
        Return SystemCaseDAL.dtByTypeid(caseids, parentid, UnitId)

    End Function
    Shared Function dt(caseids As String) As DataTable
        Return SystemCaseDAL.dtByunitid(caseids, 0)
    End Function

    Shared Function dtByunitid(caseids As String, UnitId As Integer) As DataTable
        Return SystemCaseDAL.dtByunitid(caseids, UnitId)
    End Function
    Shared Function Dt2(caseids As String, Optional fldlist As String = "*") As DataTable
        Return SystemCaseDAL.dt2(caseids, fldlist)
    End Function
    Shared Function dt(parentid As Integer, orderstr As String, isshowflag As Integer) As DataTable
        Return SystemCaseDAL.dt(parentid, orderstr, isshowflag)
    End Function
    Shared Function dt(parentid As Integer, courseid As Integer) As DataTable
        Return SystemCaseDAL.dt(parentid, courseid)

    End Function
    Shared Function dtByCaseData() As DataTable
        Return SystemCaseDAL.dtByCaseData()

    End Function

    Shared Function Dt(parentid As Integer) As DataTable
        Return SystemCaseDAL.dt(parentid)
    End Function
    Shared Function DtByParentid(parentid As Integer) As DataTable
        Return SystemCaseDAL.dt(parentid, , 1)
    End Function
    Shared Function DtDepartment() As DataTable
        Return SystemCaseDAL.dt(SystemConfig.Sys.Department, 581)
    End Function
    Shared Function DtGrade() As DataTable
        Return SystemCaseDAL.dt(SystemConfig.Teaching.GradeCaseId)
    End Function
    Shared Function Dtsubject() As DataTable
        Return SystemCaseDAL.dt(SystemConfig.Teaching.SubjectCaseId)
    End Function

    Shared Function dt(sc As Model.SystemCase) As DataTable
        Return SystemCaseDAL.dt(sc)

    End Function
    Shared Function Classdt() As DataTable
 
      
        Return SystemCaseDAL.Subcasedt(277)

    End Function

    Shared Function Parentid(caseid As Integer) As Integer
        Return SystemCaseDAL.Parentid(caseid)

    End Function

    Shared Function Rs(caseid As Integer) As SqlClient.SqlDataReader
        Return SystemCaseDAL.rs(caseid)
    End Function


    Shared Function Entity(caseid As Integer) As Model.SystemCase
        Return SystemCaseDAL.Entity(caseid)

    End Function
    Shared Function Nav(caseid As Integer) As String
        Dim rs = SystemCaseDAL.rs(caseid)
        If rs.Read Then
            If rs(0) <> 0 Then
                Nav = Nav & Nav(rs(0)) & " > <a href='?caseid=" & caseid & "'>" & rs(1) & "</a>"
            Else
                Nav = "<a href='?caseid=0'>顶级</a>"
            End If
        End If
    End Function


    Shared Function MysubCaseids(dt As DataTable, parentid As Integer, Optional Unitid As Integer = 0, Optional casedata As String = "") As String
        Dim s As String = subCaseIds(dt, parentid, Unitid, casedata)
        If s.StartsWith(",") Then
            Return s.Remove(0, 1)
        End If
    End Function
    Private Shared Function subCaseIds(dt As DataTable, parentid As Integer, Optional Unitid As Integer = 0, Optional casedata As String = "") As String
        Dim sql As String
        sql = "parentid=" & parentid
        If Unitid > 0 Then
            sql = sql & " and unitid=" & Unitid
        End If
        If casedata <> "" Then
            sql = sql & " and ( casedata='6' or casedata='" & casedata & "')"

        End If
        Dim rs() As DataRow = dt.Select(sql)
        Dim s As New Text.StringBuilder
        For Each r As DataRow In rs
            s.Append(subCaseIds(dt, r("caseid"), Unitid) & "," & r("caseid"))
        Next
        '  If subCaseIds <> "" Then
        'subCaseIds = subCaseIds.Remove(0, 1)
        'If s.ToString.StartsWith(",") Then
        '    s.Remove(0, 1)
        'End If
        Return s.ToString
        '  End If
    End Function

    Shared Function subCaseIds2(parentids As String) As String
        Dim dt As DataTable = SystemCaseDAL.dtByparentids(parentids)

        For Each r As DataRow In dt.Rows
            subCaseIds2 = subCaseIds2 & "," & r("caseid")
        Next
        If subCaseIds2 <> "" Then
            subCaseIds2 = subCaseIds2.Remove(0, 1)

        End If
    End Function

    Shared Function subCaseIds(parentid As Integer) As String
        Dim dt As DataTable = SystemCaseDAL.dt(parentid)
        Dim rs() As DataRow = dt.Select("parentid=" & parentid)
        For Each r As DataRow In rs
            subCaseIds = subCaseIds & "," & r("caseid")
        Next
        If subCaseIds <> "" Then
            subCaseIds = subCaseIds.Remove(0, 1)

        End If
    End Function
    Shared Function CaseNames(caseids As String) As String
        If caseids = "" Then
            Return ""
        End If
        Dim dt As DataTable = SystemCaseDAL.dt(caseids)
        Dim s As New Text.StringBuilder
        For Each r As DataRow In dt.Rows
            s.Append("," & r("casename"))
        Next
        If s.Length > 0 Then
            s.Remove(0, 1)
        End If
        Return s.ToString
    End Function

    Shared Function pIndex(caseid As Integer) As Integer
        Return SystemCaseDAL.NewPindex(caseid)

    End Function
    Shared Function Move(caseid As Integer, pindex As Integer, parentid As Integer) As Boolean
        Return SystemCaseDAL.update(caseid, pindex, parentid)

    End Function
    Shared Function HaveSub(caseid As Integer) As Boolean
        If SystemCaseDAL.subcount(caseid) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function subcount(parentid As Integer, casedata As Integer) As Integer
        Return SystemCaseDAL.subcount(parentid, casedata)

    End Function

    Shared Function GetCaaseID(casename As String, parentid As Integer) As Integer
        Return SystemCaseDAL.GetCaaseID(casename, parentid)
    End Function
    Shared Function IsExit(sc As Model.SystemCase) As Boolean
        Return SystemCaseDAL.IsExit(sc)
    End Function

    Shared Function CaseData(caseid As Integer) As String
        Return SystemCaseDAL.CaseData(caseid)
    End Function
    Shared Function Casename(parentid As Integer, casedata As Integer) As String
        Return SystemCaseDAL.CaseName(parentid, casedata)
    End Function

    Shared Function CaseName(caseid As Integer) As String
        Return SystemCaseDAL.CaseName(caseid)
    End Function
    Shared Function NewCaseId() As Integer
        Return SystemCaseDAL.NewCaseId
    End Function
    Shared Function getSuperBottomCaseids(dt As DataTable) As String

        For Each r As DataRow In dt.Rows
            Dim rs() As DataRow = dt.Select("parentid=" & r("caseid"))
            If rs.Length = 0 Then
                getSuperBottomCaseids = getSuperBottomCaseids & "," & r("caseid")

            End If

        Next


    End Function
    Shared Function CaseidByName(casename As String) As Integer
        Return SystemCaseDAL.CaseidByName(casename)
    End Function
    Shared Function CaseidByName(parentid As Integer, casename As String) As Integer
        Return SystemCaseDAL.CaseidByName(parentid, casename)
    End Function

    Shared Function Caseid(parentid As Integer, casename As String) As Integer
        Return SystemCaseDAL.Caseid(parentid, casename)
    End Function
    ''' <summary>
    ''' 返回第一caseid
    ''' </summary>
    ''' <param name="parentid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function Caseid(parentid As Integer, Optional isShowFlag As Integer = -1, Optional orderby As String = " pindex asc") As Integer
        Return SystemCaseDAL.Caseid(parentid, isShowFlag, orderby)

    End Function

    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "systemcase"
        Return SystemCaseDAL.PagerDt(pi)
    End Function

End Class
