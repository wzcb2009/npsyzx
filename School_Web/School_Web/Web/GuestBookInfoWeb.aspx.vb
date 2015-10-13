Public Class GuestBookInfoWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Hd_action.Value = "guestadd"
        hd_caseid.Value = Request.QueryString("caseid")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dm As New Model.DataMain
        dm.Caseid = hd_caseid.Value
        dm.BrowCount = 0
        dm.Pubdate = Now
        dm.Title = txt_title.Text
        dm.Content = txt_content.Text
        dm.Author = txt_author.Text & "-" & txt_tel.Text
        Dim bll As New BLL.DataMainBLL
        bll.AddandSave(dm)
        Response.Write("<script>alert('问题提交成功，感谢您的关心！');parent.$.fancybox.close();</script>")
        Response.End()


    End Sub
End Class