
Partial Class js_newslist
    Inherits System.Web.UI.Page
    Dim bll As New BLL.DataMainBLL
    Dim scbll As New BLL.SystemCaseBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim caseid As Integer = Request.QueryString("caseid")
        Dim newlen As Integer
        newlen = Request.QueryString("newlen")
        Dim titleLen As Integer = Request.QueryString("titleLength")
        Dim rowcount As Integer = Request.QueryString("rowCount")
        Dim s As New StringBuilder
        Dim dt As Data.DataTable
        If scbll.HaveSub(caseid) Then
            Dim scdt As DataTable = scbll.Dt
            Dim CASEIDLIST As String = scbll.MysubCaseids(scdt, caseid)
            If CASEIDLIST <> "" Then
                CASEIDLIST = "0" & CASEIDLIST
            End If
            dt = bll.Dt(CASEIDLIST)
        Else
            dt = bll.Dt(caseid)
        End If
        For Each rs As Data.DataRow In dt.Rows
            s.AppendLine("document.write(""<li><a href='web/showweb.aspx?id=" & rs("id") & "' class='fancybox fancybox-manual-b'>" & rs("title") & "</a></li>"");")
        Next
        Response.Write(s.ToString)
        s = Nothing
        GC.Collect()
    End Sub
End Class
