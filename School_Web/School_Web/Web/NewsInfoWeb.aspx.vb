Imports Wzsckj.com.Common

Public Class NewsAddWeb
    Inherits System.Web.UI.Page
    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Public ap As New ActionPara
    Public art_content As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        If Not IsPostBack Then
            Dim scbll As New BLL.SystemCaseBLL

            ' BindHelper.SystemCaseBind(caselist2, scbll.Dt(120), 0, "--评先评优--")
        End If
        Select Case ap.Action
            Case ActionEnum.Modify
                init_(ap.ID)
                lt_files.Text = files(ap.ID)

                Hd_action.Value = "mod"
                hd_id.Value = ap.ID
                hd_objid.Value = ap.Caseid
            Case ActionEnum.Add
                Hd_action.Value = "add"
                hd_caseid.Value = ap.Caseid
                txt_pubdate.Text = DateTime.Now.ToShortDateString()
                txt_author.Text = Session("truename")
                hd_objid.Value = ap.Caseid
                txt_pindex.Text = bll.Pindex(ap.Caseid)

        End Select



    End Sub
    Sub init_(id As Integer)
        Dim dm As New Model.DataMain
        dm = bll.Entity(id)
        hd_caseid.Value = dm.Caseid
        txt_title.Text = dm.Title
        txt_author.Text = dm.Author
        txt_pubdate.Text = dm.Pubdate
        txt_BrowCount.Text = dm.BrowCount
        txt_pindex.Text = dm.Pindex
        chk_cmd.Checked = dm.Cmd
        chk_Status.Checked = dm.Status
        chk_right.Checked = dm.UserRight
        'lt_content.Text = dm.Content
        art_content = dm.Content
    End Sub
    Function files(parentid As Integer) As String


        Dim bll As New BLL.FilelistBLL
        Dim flag As Boolean
        flag = bll.CountbyParentid(parentid)
        If flag = False Then
            Return ""
        End If
        Dim dt As DataTable = bll.Dt2(parentid)
        Dim s As New StringBuilder
        Dim fileinput As New StringBuilder
        For Each r As DataRow In dt.Rows
            s.AppendLine("<li id=""file" & r("fileid") & """>")
            s.AppendLine("<div class='ico'><img src='../file/images/" & r("ext") & ".jpg'/></div>")
            s.AppendLine("<div class='main'><a class='title'   href='../file/filedown.aspx?fileid=" & r("fileid") & "'>" & r("title") & "." & r("ext") & "</a><a class='del' onclick='delfile(" & r("fileid") & ")'></a><a class='view' target='dialog' href='../file/fileinfoweb.aspx?action=mod&id=" & r("fileid") & "'>修改</a><div class='info'> 上传时间：" & r("pubdate") & "</div></div>")
            s.AppendLine("</li>")
            fileinput.AppendLine("<input name='fileid' value='" & r("fileid") & "' type='hidden' />")
        Next
        lt_fileinput.Text = fileinput.ToString
        Return s.ToString
    End Function

End Class