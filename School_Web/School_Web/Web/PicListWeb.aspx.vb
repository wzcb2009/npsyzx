Imports Wzsckj.com.Common

Public Class PicListWeb
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Public pi As PagerInfo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pi = PagerHelper.PagerPageInfo
        Dim caseid As Integer = Request.QueryString("caseid")

        listL.Text = list(caseid)

    End Sub
    Function list(caseid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""138"" targetType=""dialog"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""orgId"" /></th>")

        s.AppendLine("<th orderfield=""pindex"">序号</th>")

        s.AppendLine("<th>新闻标题</th>")
        s.AppendLine("<th >用户</th>")
        s.AppendLine("<th orderfield=""unitid"">单位</th>")

        s.AppendLine("<th orderfield=""BrowCount"">浏览次数</th>")
        s.AppendLine("<th orderfield=""Status"">状态</th>")
        s.AppendLine("<th orderfield=""pubdate"">发布时间</th>")

        s.AppendLine("<th orderfield=""Author"">发布者</th>")
        s.AppendLine(ActionHelper.ActionStr)

        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        Dim dt As DataTable = bll.PagerDt(pi, caseid)
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("id") & """>")

            s.AppendLine("<td><input type=""checkbox"" name=""ids"" value=""" & dr("id") & """/></td>")
            s.AppendLine("<td>" & dr("pindex") & "</td>")

            s.AppendLine("<td>" & dr("Title") & "</td>")

            s.AppendLine("<td>" & dr("UserID") & "</td>")
            s.AppendLine("<td>" & dr("unitid") & "</td>")

            s.AppendLine("<td>" & dr("BrowCount") & "</td>")
            s.AppendLine("<td>" & dr("Status") & "</td>")
            s.AppendLine("<td>" & dr("pubdate") & "</td>")

            s.AppendLine("<td>" & dr("Author") & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../web/"
            h.BaseUnit = "pic"
            h.ID = dr("id")
            s.AppendLine(ActionHelper.ModandDelStr(h))
            s.AppendLine("</tr>")
        Next
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function




End Class