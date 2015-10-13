Imports Model
Imports System.Text
Imports DAL

Public Class UserSystemCaseBLL

    Shared Function dt(userid As Integer) As DataTable
        Return UserSystemCaseDAL.dt(userid)

    End Function
    Shared Function dt(usc As Model.UserSystemCase) As DataTable
        Return UserSystemCaseDAL.dt(usc)

    End Function
    Shared Function dt3(usc As Model.UserSystemCase) As DataTable
        Return UserSystemCaseDAL.dt3(usc)
    End Function

    Shared Function dt2(caseid As Integer) As DataTable
        Return UserSystemCaseDAL.dt2(caseid)

    End Function
    Shared Function dt(parentid As Integer, userid As Integer) As DataTable
        Return UserSystemCaseDAL.dt(parentid, userid)

    End Function
    Shared Function dtIsAdmin(usc As Model.UserSystemCase) As DataTable
        Return UserSystemCaseDAL.dtIsAdmin(usc)
    End Function
    Shared Function IsAdmin(usc As Model.UserSystemCase) As Boolean
        Return UserSystemCaseDAL.IsAdmin(usc)
    End Function
    Shared Function AdminCaseid(usc As Model.UserSystemCase) As Integer
        Return UserSystemCaseDAL.AdminCaseid(usc)
    End Function

    Shared Function BatchDel(userid As Integer, parentid As Integer) As Boolean
        Return UserSystemCaseDAL.BatchDel(userid, parentid)

    End Function

    Shared Function BatchDelOther(userid As Integer, caseids As String, parentid As Integer) As Boolean
        Return UserSystemCaseDAL.BatchDelOther(userid, caseids, parentid)
    End Function

    Shared Function DelOther(usc As Model.UserSystemCase) As Boolean
        Return UserSystemCaseDAL.del(usc)
    End Function
    Shared Function BatchDelOther(userid As Integer, caseids As String) As Boolean
        If caseids = "" Then
            Return False
        End If
        If UserSystemCaseDAL.BatchDelOther(userid, caseids) Then
            Return True
        End If
    End Function
    Shared Function GetId(usc As UserSystemCase) As Integer
        Return UserSystemCaseDAL.GetId(usc)
    End Function
    Shared Function Count(usc As UserSystemCase) As Integer
        Return UserSystemCaseDAL.Count(usc)
    End Function

    Shared Function IsExit2(usc As UserSystemCase) As Boolean
        Return UserSystemCaseDAL.IsExit2(usc)
    End Function

    Shared Function Insert(usc As UserSystemCase) As UserSystemCase
        Return UserSystemCaseDAL.Insert(usc)

    End Function
    Shared Function UpdateUnitid(USC As Model.UserSystemCase) As Model.UserSystemCase
        Return UserSystemCaseDAL.UpdateUnitid(USC)

    End Function
    Shared Function AdminUpdate(usc As Model.UserSystemCase, userids As String, Optional type As String = "") As Boolean
        Return UserSystemCaseDAL.AdminUpdate(usc, userids, type)
    End Function

    Shared Function update(usc As Model.UserSystemCase) As Model.UserSystemCase
        Return UserSystemCaseDAL.Update(usc)
    End Function
    Shared Function AdminUpdate(usc As Model.UserSystemCase) As Boolean
        Return UserSystemCaseDAL.AdminUpdate(usc)
    End Function

    Shared Function AndandSave(usc As Model.UserSystemCase) As Boolean
        If UserSystemCaseDAL.IsExit(usc) Then
            UserSystemCaseDAL.Update(usc)
            Return True
        End If
        UserSystemCaseDAL.Insert(usc)
        If usc.IsChanged Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function Del(usc As Model.UserSystemCase) As Boolean
        Return UserSystemCaseDAL.del(usc)
    End Function
    Shared Function MultiDel(usc() As Model.UserSystemCase) As Boolean
        Return UserSystemCaseDAL.MultiDel(usc)
    End Function
    Shared Function Caseid(usc As Model.UserSystemCase) As Integer
        Return UserSystemCaseDAL.Caseid(usc)
    End Function

    Shared Function Caseid(dt As DataTable, parentid As Integer, userid As Integer) As Integer
        Dim r() As DataRow = dt.Select("userid=" & userid & " and parentid=" & parentid)
        If r.Length > 0 Then
            Return r(0)("caseid")
        Else
            Return 0
        End If
    End Function


    Shared Function Caseid(parentid As Integer, userid As Integer) As Integer
        Return UserSystemCaseDAL.Caseid(parentid, userid)
    End Function

    Shared Function Parentid(dt As DataTable, caseid As Integer) As Integer
        Dim r() As DataRow = dt.Select("caseid=" & caseid)
        If r.Length > 0 Then
            Return r(0)("parentid")
        Else
            Return 0
        End If
    End Function
    Shared Function Haved(dt As DataTable, caseid As Integer) As Boolean
        If dt Is Nothing Then
            Return False
        End If
        Dim r() As DataRow = dt.Select("caseid=" & caseid)
        If r.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function CaseIds(userid As Integer) As String
        Dim s As New Text.StringBuilder
        Dim dt_ As DataTable = dt(userid)
        For Each r As DataRow In dt_.Rows
            s.Append("," & r("caseid"))
        Next
        If s.ToString.StartsWith(",") Then
            Return s.ToString.Remove(0, 1)
        Else
            Return s.ToString
        End If
    End Function
    Shared Function CaseIds(parentid As Integer, userid As Integer) As String
        Dim s As New Text.StringBuilder
        Dim dt_ As DataTable = dt(parentid, userid)
        For Each r As DataRow In dt_.Rows
            s.Append("," & r("caseid"))
        Next
        If s.ToString.StartsWith(",") Then
            Return s.ToString.Remove(0, 1)
        Else
            Return s.ToString
        End If
    End Function

    Shared Function ToolBar(uscdt As DataTable, parentid As Integer, caseid As Integer) As String

        Dim rs() As Data.DataRow
        rs = uscdt.Select("  parentid=" & parentid, "pindex asc")
        Dim s As New Text.StringBuilder
        For Each r As DataRow In rs
            Dim dh As New StringHandling.DWZJson.DwzHref
            If IsDBNull(r("casedata")) Then
                Continue For

            End If
            dh = StringHandling.DWZJson.CaseDataToDwzHref(r("casedata"))
            dh.CaseId = r("caseid")
            dh.Text = r("casename")
            dh.Parentid = caseid
            If dh.Url <> "" Then
                If dh.Url.Contains("?") Then
                    dh.Url = dh.Url & "&objid=" & parentid
                Else
                    dh.Url = dh.Url & "?objid=" & parentid

                End If
            End If

            ' s.AppendLine("<li>")
            s.AppendLine(StringHandling.DWZJson.ToolBarHref(dh))
            ' s.AppendLine("</li>")
        Next
        Return s.ToString
    End Function
End Class
