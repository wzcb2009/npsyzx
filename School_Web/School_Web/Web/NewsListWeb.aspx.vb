Imports Wzsckj.com.Common
Imports StringHandling

Public Class NewsListWeb
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Public pi As PagerInfo
    Dim ap As New ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        listL.Text = list(ap.Caseid)

    End Sub
    Function list(caseid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""138"" targetType=""navTab"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""orgId"" /></th>")
        s.AppendLine("<th  >序号</th>")
        s.AppendLine("<th>新闻标题</th>")
        s.AppendLine("<th >操作人</th>")
        s.AppendLine("<th  >浏览次数</th>")
        s.AppendLine("<th  >状态</th>")
        s.AppendLine("<th  >置顶</th>")
        s.AppendLine("<th  >加密</th>")
        s.AppendLine("<th  >发布时间</th>")
        s.AppendLine("<th  >编辑</th>")
        s.AppendLine(ActionHelper.ActionStr)

        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        pi.fldName = "pubdate"
        pi.orderDirection = "desc"
        Dim dt As DataTable = bll.PagerDt(pi, caseid)
        Dim userBll As New BLL.UserlistBLL
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("id") & """>")

            s.AppendLine("<td><input type=""checkbox"" name=""ids"" value=""" & dr("id") & """/></td>")
            s.AppendLine("<td>" & dr("pindex") & "</td>")

            s.AppendLine("<td>" & dr("Title") & "</td>")

            s.AppendLine("<td>" & userBll.Truename(dr("UserID")) & "</td>")


            s.AppendLine("<td>" & dr("BrowCount") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("Status")), "已审核", "未审核") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("cmd")), "已置顶", "") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("UserRight")), "已加密", "") & "</td>")
            s.AppendLine("<td>" & dr("pubdate") & "</td>")

            s.AppendLine("<td>" & dr("Author") & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../web/"
            h.BaseUnit = "news"
            h.ModTarget = "navTab"
            h.ID = dr("id")
            s.AppendLine("<td>" & ActionHelper.ModandDelStr(h) & "</td>")



            s.AppendLine("</tr>")
        Next
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function


End Class