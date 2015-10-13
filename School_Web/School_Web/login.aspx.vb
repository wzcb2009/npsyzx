Public Class _Default
    Inherits System.Web.UI.Page
    Dim bll As New BLL.DataMainBLL
    Dim scbll As New BLL.SystemCaseBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim caseid As Integer = 183 'Request.QueryString("caseid")
        Dim newlen As Integer
        newlen = Request.QueryString("newlen")
        Dim titleLen As Integer = Request.QueryString("titleLength")
        Dim rowcount As Integer = Request.QueryString("rowCount")
        Dim s As New StringBuilder
        Dim dt As Data.DataTable
        dt = bll.Dt(caseid)
        'If scbll.HaveSub(caseid) Then
        '    Dim scdt As DataTable = scbll.Dt
        '    Dim CASEIDLIST As String = scbll.subCaseIds(scdt, caseid)
        '    If CASEIDLIST <> "" Then
        '        CASEIDLIST = "0" & CASEIDLIST
        '    End If
        '    dt = bll.Dt(CASEIDLIST)
        'Else
        'End If
        Dim n As Integer
        For Each rs As Data.DataRow In dt.Rows
            n = n + 1

            s.AppendLine("<li><a href='web/NewsInfoShow.aspx?id=" & rs("id") & "' class='fancybox fancybox-manual-b  fancybox.iframe'>" & rs("title") & "</a></li>")
            If n > 5 Then
                Exit For

            End If
        Next
        dt.Dispose()
        lt_news.Text = s.ToString



    End Sub
End Class