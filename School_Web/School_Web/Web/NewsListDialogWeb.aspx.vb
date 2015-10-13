Imports Wzsckj.com.Common

Public Class NewsListDialogWeb
    Inherits System.Web.UI.Page
    Public ap As ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara

        lt_newsbox.Text = infolist(ap.Caseid)
    End Sub
    Function infolist(caseid As Integer) As String
        Dim dt As Data.DataTable

        Dim bll As New BLL.DataMainBLL
        Dim scbll As New BLL.SystemCaseBLL
        Dim uscdt As DataTable = Session("UserSystemCase")

        If scbll.HaveSub(caseid) Then
            Dim CASEIDLIST As String = scbll.MysubCaseids(uscdt, caseid)
            If CASEIDLIST <> "" Then
                CASEIDLIST = "0" & CASEIDLIST
            End If
            dt = bll.Dt(CASEIDLIST)



        Else
            dt = bll.Dt(caseid)


        End If


        Dim s As New StringBuilder
        For Each rs As Data.DataRow In dt.Rows
            Dim d As DateTime
            d = rs("pubdate")
            s.AppendLine("<li><span>·</span><a target='dialog' rel='webd1' width='800' height='480'  href='../web/showweb.aspx?id=" & rs("id") & "'>" & rs("title") & "" & d.Date & "</a></li>")
        Next
        Return s.ToString
    End Function

End Class