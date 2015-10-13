Imports StringHandling
Imports Wzsckj.com.Common

Public Class HomeWorkDatalist
    Inherits System.Web.UI.Page

    Dim bll As New BLL.DataMainBLL
    Public pi As PagerInfo
    Dim ap As New ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        Dim hwid As Integer = Request.QueryString("hwid")
        listL.Text = list(hwid)

    End Sub
    Function list(parentid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""138"" targetType=""dialog"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""orgId"" /></th>")
        s.AppendLine("<th  >序号</th>")
        s.AppendLine("<th>作业标题</th>")
        s.AppendLine("<th>得分</th>")
        s.AppendLine("<th>评语</th>")
        s.AppendLine("<th >发布者</th>")
        s.AppendLine("<th  >浏览次数</th>")
        s.AppendLine("<th  >状态</th>")
        s.AppendLine("<th  >置顶</th>")
        s.AppendLine("<th  >上交时间</th>")
        s.AppendLine("<th  >编辑</th>")
        s.AppendLine(ActionHelper.ActionStr)

        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        pi.fldName = "pindex"
        pi.orderDirection = "desc"
        pi.strwhere = "parentid=" & parentid & " and caseid=" & ap.Caseid
        Dim dt As DataTable = bll.PagerDt(pi)
        Dim userBll As New BLL.UserlistBLL
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("id") & """>")

            s.AppendLine("<td><input type=""checkbox"" name=""ids"" value=""" & dr("id") & """/></td>")
            s.AppendLine("<td>" & dr("pindex") & "</td>")

            s.AppendLine("<td>" & dr("Title") & "</td>")

            s.AppendLine("<td>" & dr("Cent") & "</td>")
            s.AppendLine("<td>" & dr("remark") & "</td>")


             s.AppendLine("<td>" & userBll.Truename(dr("UserID")) & "</td>")


            s.AppendLine("<td>" & dr("BrowCount") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("Status")), "已审核", "未审核") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("cmd")), "已置顶", "") & "</td>")

            s.AppendLine("<td>" & dr("pubdate") & "</td>")

            s.AppendLine("<td>" & dr("Author") & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../homework/"
            h.BaseUnit = "homeworkdata"
            h.DelUrl = "../web/newsdo.aspx"
            h.EditUrl = "../homework/homeworkdatainfoweb.aspx"
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