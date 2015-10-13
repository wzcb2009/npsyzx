Imports Wzsckj.com.Common

Public Class CommentListWeb
    Inherits System.Web.UI.Page

    Public pi As PagerInfo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim parentid As Integer = Request("parentid")
        hd_parentid.Value = parentid
        pi = PagerHelper.PagerPageInfo
        pi.orderDirection = "desc"
        pi.orderField = "id"
        pi.fldName = "id"
        listl.Text = list(0)
    End Sub
    Dim bll As New BLL.CommentBLL
    Function list(parentid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""118"" targetType=""dialog"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""ids"" /></th>")

        s.AppendLine("<th orderfield=""UserID"">评论人</th>")
        s.AppendLine("<th orderfield=""Content"">评语</th>")
        s.AppendLine("<th orderfield=""Pubdate"">发表时间</th>")
        s.AppendLine("<th orderfield=""Status"">状态</th>")
        s.AppendLine("<th orderfield=""Cent"">评分</th>")
        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        Dim userbll As New BLL.UserlistBLL

        Dim dt As DataTable = bll.PagerDt(pi, parentid)
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("id") & """>")
            s.AppendLine("<td><input type=""checkbox"" name=""orgId"" value=""" & dr("id") & """/></td>")

            s.AppendLine("<td>" & userbll.Truename(dr("UserID")) & "</td>")

            s.AppendLine("<td>" & dr("Content") & "</td>")
            s.AppendLine("<td>" & Convert.ToDateTime(dr("Pubdate")).ToString("yyyy-MM-dd") & "</td>")
            s.AppendLine("<td>" & IIf(dr("Status"), "是", "") & "</td>")
            s.AppendLine("<td>" & dr("Cent") & "</td>")
            s.AppendLine("</tr>")
        Next
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function

End Class