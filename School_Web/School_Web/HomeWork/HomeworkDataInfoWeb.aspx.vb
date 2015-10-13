Imports Wzsckj.com.Common
Imports StringHandling


Public Class HomeworkDataInfoWeb
    Inherits System.Web.UI.Page

    Dim userid As Integer
    Dim bll As New BLL.DataMainBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Select Case ap.Action
            Case ActionEnum.Modify
                init_(ap.ID)
                lt_files.Text = files(ap.ID)

                Hd_action.Value = "mod"
                hd_id.Value = ap.ID
            Case ActionEnum.Add
                Hd_action.Value = "add"
                hd_caseid.Value = ap.Caseid
                txt_pubdate.Text = DateTime.Now.ToString("yyyy-MM-dd")
                '    txt_author.Text = Session("truename")
                txt_pindex.Text = bll.Pindex(ap.Caseid)
                hwid.Value = Request.QueryString("hwid")

        End Select



    End Sub
    Public caseids, Casedata, casename As String

    Sub init_(id As Integer)
        Dim dm As New Model.DataMain
        dm = bll.Entity(id)
        If dm Is Nothing Then
            Return

        End If
        hwid.Value = dm.ParentId
        hd_caseid.Value = dm.Caseid
        txt_title.Text = dm.Title
        txt_truename.Text = dm.Author
        txt_pubdate.Text = dm.PubDate.ToString("yyyy-MM-dd")
        txt_BrowCount.Text = dm.BrowCount
        txt_pindex.Text = dm.Pindex
        chk_cmd.Checked = dm.Cmd
        chk_Status.Checked = dm.Status
        hwid.Value = dm.ParentId
        txt_remark.Text = dm.Remark
        txt_cent.Text = dm.Cent
        lt_content.Text = dm.Content
        txt_cent.Text = dm.Cent
        Dim user As New Model.Userlist
        Dim userbll As New BLL.UserlistBLL
        user = userbll.GetObj(dm.Userid)
        If user IsNot Nothing Then
            txt_truename.Text = user.UserName & "-" & user.Truename

        End If
        'caseids = SafeData.s_string(dm.Caseids)
        'Dim scbll As New BLL.SystemCaseBLL
        'Casedata = scbll.CaseNames(caseids)
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