Imports Wzsckj.com.Common

Public Class WebShow
    Inherits System.Web.UI.Page

    Public flag As Boolean
    Dim scbll As New BLL.SystemCaseBLL
    Dim scView As New View.SystemCaseView
    Public Userinfo As New Model.Userlist
    Dim userid As Integer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim id As Integer
        id = Request.QueryString("id")

        userid = Session("userid")
        If userid > 0 Then
            Userinfo = userbll.GetObj(userid)
        Else
            Userinfo.FaceUrl = "images/user.gif"
        End If
        Dim bll As New BLL.DataMainBLL
        Dim dm As New Model.DataMain
        dm = bll.Entity(id)
        If dm IsNot Nothing Then

            lt_content.Text = Server.HtmlDecode(dm.Content)
            If dm.UserRight = True Then
                If isInternet() = False Then
                    lt_content.Text = "限制校内查看内容……"
                End If
            End If
            lt_info.Text = "发布人：" & dm.Author & " 发布时间：" & dm.PubDate.ToString("yyyy-MM-dd") & " 浏数:" & dm.BrowCount
            lt_title.Text = dm.Title
            bll.UpdateClicks(id)
            lt_files.Text = files(dm.Id)
            Dim dt As DataTable = scbll.Dt
            Dim caseid As Integer = dm.Caseid
            lt_sitenav.Text = scView.WebNavPositon(dt, caseid, caseid)
            Dim parentid As Integer
            parentid = scbll.Parentid(caseid)

            If parentid > 0 And parentid <> 16 Then
                lt_nav.Text = scView.WebNav(dt, parentid, "", caseid)
            Else
                lt_nav.Text = scView.WebNav(dt, caseid, "", caseid)
                If Not scbll.HaveSub(caseid) Then

                    Dim dmview As New View.DataMainView
                    '  lt_newslist.Text = dmview.infolist(caseid)
                End If
            End If
        End If


        ' lt_comment.Text = commentlist(id)
        'Dim vl As New View.DataMainView
        'lt_userlist.Text = vl.UserFacelistByParentid(id)

    End Sub
    Dim userbll As New BLL.UserlistBLL
    Function isInternet() As Boolean
        Dim ip As String = System.Web.HttpContext.Current.Request.UserHostAddress
        ' Response.Write(ip)
        If ip = "10.0.12.254" Then
            Return True
        End If

    End Function
    Function commentlist(id As Integer) As String
        Dim dt As DataTable
        Dim combll As New BLL.CommentBLL
        dt = combll.Dt(id)


        Dim s As New StringBuilder
        Dim user As New Model.Userlist
        For Each r As DataRow In dt.Rows
            user = userbll.GetObj(r("userid"))

            If user IsNot Nothing Then
                Dim width As String = r("cent") * 2 * 10
                s.AppendLine("  <div class=""media""><a class=""pull-left"" href=""#""><img class=""media-object img-rounded"" width=""64""  img-rounded  "" src=""" & user.FaceUrl & """></a><div class=""media-body""><h5 class=""media-heading"">" & user.Truename & " 发表时间:" & r("pubdate").ToString & "  <span class=""vote-star""><i style=""width:" & width & "%""></i></span><span class=""vote-number"">" & r("cent") & "分</span></h5>" & r("content") & "</div></div>")

            End If
        Next
        If s.Length = 0 Then
            s.Append("目前还没有评论，快来强沙发吧！")
        End If
        Return s.ToString
    End Function




    Function files(parentid As Integer) As String
        Dim bll As New BLL.FilelistBLL
        flag = bll.CountbyParentid(parentid)
        If flag = False Then
            Return ""
        End If
        Dim dt As DataTable = bll.dt2(parentid)
        Return FileHelper.files(dt, "")
    End Function


End Class