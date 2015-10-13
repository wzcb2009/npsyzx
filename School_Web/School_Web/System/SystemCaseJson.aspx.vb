Imports StringHandling
Imports Wzsckj.com.Common

Public Class SystemCaseJson
    Inherits System.Web.UI.Page
    Dim parentid As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        parentid = Request.QueryString("parentid")
        Response.Clear()

        getjson()

    End Sub
    Function getjson()
        Dim keyword As String = SafeData.SafeString(Request.QueryString("q"))
        Dim bll As New BLL.SystemCaseBLL
        Dim dt As DataTable
        Dim pi As New PagerInfo
        pi.strwhere = keyword
        pi.PageIndex = 1
        pi.PageSize = 50
        pi.orderField = "casename"
        pi.fldName = "casename"
        pi.strwhere = "casename like '%" & keyword & "%' and parentid=" & parentid

        dt = bll.PagerDt(pi)
        Dim s As New StringBuilder

        For Each r As DataRow In dt.Rows
            s.AppendLine(r("CaseData") & "-" & r("casename"))
        Next
        If dt.Rows.Count = 0 Then
            s.AppendLine("")
        End If
        Response.Write(s.ToString)
        Response.End()
    End Function
End Class