Imports StringHandling
Imports Wzsckj.com.Common

Public Class UserInfolist
    Inherits System.Web.UI.Page
    Dim pi As New PagerInfo
    Dim scBll As New BLL.SystemCaseBLL
    Dim areaid, caseid As String
    Dim keywords, areaname As String
    Dim userid As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        userid = Session("userid")
        pi = PagerHelper.PagerPageInfo
        lt_infolist.Text = infolist()

    End Sub
    Function infolist() As String

        Dim dt As Data.DataTable

        Dim bll As New BLL.DataMainBLL
        Dim scbll As New BLL.SystemCaseBLL
        Dim a() As String
        pi.strwhere = "1=1 and userid= " & userid


        pi.Tablename = "data_main"
        pi.fldName = "id"
        pi.orderDirection = "desc"

        pi.PageSize = AspNetPager1.PageSize
        pi.PageIndex = AspNetPager1.CurrentPageIndex
        '  pi.strwhere = "1=1"
        caseid = 78
        pi.strwhere = "    caseid =" & caseid & " and parentid=0"
        dt = bll.PagerDt(pi)
        AspNetPager1.RecordCount = pi.TotalCount


        Dim s As New StringBuilder
        Dim i As Integer
        For Each rs As Data.DataRow In dt.Rows
            i = i + 1
            Dim pd As DateTime = rs("enddate")
            Dim t As String
            If DateDiff(DateInterval.Day, pd, Now) >= 0 Then
                If bll.Count(rs("id")) = 0 Then
                    t = "<a href='userhwshow.aspx?action=add&zid=480'>上交作业</a>"
                Else
                    t = "<a href='userhwshow.aspx?action=mod&zid=480'>修改作业</a>"

                End If
            Else
                t = ""
            End If
            s.AppendLine("<tr><td>" & i & "</td><td><a tagert='_blank' href='userhwshow.aspx?zid=" & rs("id") & "'><span>·</span>" & rs("title") & "</a></td><td>" & rs("cent") & "</td><td>" & Convert.ToDateTime(rs("enddate")).ToString("yyyy-MM-dd") & "</td><td>" & t & "</td></tr>")
        Next
        Return s.ToString
    End Function


    Protected Sub AspNetPager1_PageChanged(sender As Object, e As EventArgs) Handles AspNetPager1.PageChanged
        lt_infolist.Text = infolist()
    End Sub

End Class