Imports StringHandling
Imports Wzsckj.com.Common

Public Class HomeworkTjWeb
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Public pi As PagerInfo
    Dim ap As New ActionPara
    Dim scbll As New BLL.SystemCaseBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        If Not IsPostBack Then
            BindHelper.Bind(classid, scbll.Dt(5), "caseid", "casename")

        End If
        listL.Text = list(78, classid.SelectedValue)

    End Sub
    Function list(caseid As Integer, groupid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""138"" targetType=""dialog"" >")
        s.AppendLine("<thead>")
 
        s.AppendLine("<th width='80'>学号</th>")
        s.AppendLine("<th width='80'>姓名</th>")
        Dim hmdt As DataTable = bll.DtByUserGroup(caseid, groupid)
        For Each r As DataRow In hmdt.Rows
            s.AppendLine("<th width='120'>" & r("title") & "</th>")
        Next
        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        pi.fldName = "userid"
        pi.orderDirection = "desc"
        pi.strwhere = " userid in(select userid from user_systemcase where caseid=" & groupid & ")"
        Dim userbll As New BLL.UserlistBLL
        Dim dt As DataTable = userbll.PagerDt(pi)
        Dim dm As Model.DataMain
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("userid") & """>")
             s.AppendLine("<td>" & dr("username") & "</td>")
            s.AppendLine("<td>" & dr("truename") & "</td>")
            For Each r As DataRow In hmdt.Rows
                dm = New Model.DataMain
                dm.ParentId = r("id")
                dm.Userid = r("userid")

                dm = bll.Entity(dm)
                If dm IsNot Nothing Then
                    s.AppendLine("<td> " & dm.Cent & "</td>")
                Else
                    s.AppendLine("<td> </td>")

                End If
            Next
            s.AppendLine("</tr>")
        Next
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function
End Class