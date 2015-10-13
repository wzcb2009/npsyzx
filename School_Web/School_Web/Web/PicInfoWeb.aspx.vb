Imports Wzsckj.com.Common

Public Class PicInfoWeb
    Inherits System.Web.UI.Page

    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        userid = Session("userid")
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Select Case ap.Action
            Case ActionEnum.Modify
                init_(ap.ID)
                Hd_action.Value = "mod"
                hd_id.Value = ap.ID
                hd_caseid.Value = ap.Caseid
            Case ActionEnum.Add
                Hd_action.Value = "add"
                hd_caseid.Value = ap.Caseid
                txt_pubdate.Text = DateTime.Now.ToShortDateString()
                txt_author.Text = Session("username")
                txt_pindex.Text = bll.Pindex(ap.Caseid)

        End Select



    End Sub
    Sub init_(id As Integer)
        Dim dm As New Model.DataMain
        dm = bll.Entity(id)

        txt_title.Text = dm.Title
        txt_author.Text = dm.Author
        txt_pubdate.Text = dm.Pubdate
        txt_BrowCount.Text = dm.BrowCount
        txt_pindex.Text = dm.Pindex
        chk_cmd.Checked = dm.Cmd
        chk_Status.Checked = dm.Status
        chk_right.Checked = dm.UserRight

    End Sub


End Class