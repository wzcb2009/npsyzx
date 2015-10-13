Imports Wzsckj.com.Common

Public Class GuestbookWeb
    Inherits System.Web.UI.Page
    Public pi As PagerInfo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Function list(caseid As Integer)
        Dim s As New StringBuilder
        Dim dt As DataTable
        Dim bll As New BLL.GuestBookBLL
        pi = PagerHelper.PagerPageInfo
        pi.fldName = "pubdate"
        pi.orderDirection = "desc"
        pi.strwhere = " isshow=1 and  caseid=" & caseid

        dt = bll.PagerDt(pi)
        For Each r As DataRow In dt.Rows
            s.AppendLine("    <div class='media'>")
            s.AppendLine(" <a class='pull-left' href='#'>")
            s.AppendLine("<img class='media-object' src='images/user.png'>")
            s.AppendLine("</a>")
            s.AppendLine("<div class='media-body'>")
            s.AppendLine("<small>" & r("pubdate") & "</small>")
            s.AppendLine(r("content"))
        
            s.AppendLine("    <div class='media'>")
            s.AppendLine(" <a class='pull-left' href='#'>")
            s.AppendLine("<img class='media-object' src='images/admin.png'>")
            s.AppendLine("</a>")
            s.AppendLine("<div class='media-body'>")
            s.AppendLine("<small>" & r("pubdate") & "</small>")
            s.AppendLine(r("Reply"))
            s.AppendLine("</div>")
            s.AppendLine("</div>")
            s.AppendLine("</div>")
            s.AppendLine("</div>")

        Next
     End Function

   
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bll As New BLL.GuestBookBLL
        Dim gb As New Model.GuestBook
        gb.Title = ""
        gb.EMail = emailt.Text
        gb.CodeNum = codet.Text
        gb.Name = namet.Text
        gb.Postip = ""
        gb.Remark = contentt.Text
        gb.Tel = telt.Text
        gb.PostDate = Now
        bll.insert(gb)
        Response.Write("感谢您的留言，我们会尽快处理！")
    End Sub
End Class