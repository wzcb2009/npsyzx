Imports View

Public Class Header
    Inherits System.Web.UI.UserControl
    Dim scView As New SystemCaseView
    Dim scbll As New BLL.SystemCaseBLL
    Public userinfo As New Model.Userlist

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        flog_class.Debug("scView.WebMenu(scbll.Dt, 16, "")")
        lt_menu.Text = scView.WebMenu(scbll.Dt, 16, "")
        Dim dmview As New View.DataMainView
        flog_class.Debug(" dmview.InfoTopOne(113)")
        lt_xsl.Text = dmview.InfoTopOne(113)
        'If Not IsPostBack Then
        '    Dim userid As Integer = Session("userid")
        '    If userid > 0 Then
        '        Dim userbll As New BLL.UserlistBLL

        '        userinfo = userbll.GetObj(userid)
        '        If userinfo IsNot Nothing Then
        '            If userinfo.FaceUrl = "" Then
        '                userinfo.FaceUrl = "plugins/ZoomImage/image/man.GIF"
        '            End If
        '            Me.imgphoto.ImageUrl = userinfo.FaceUrl
        '        Else
        '            userinfo = New Model.Userlist
        '            userinfo.FaceUrl = "plugins/ZoomImage/image/man.GIF"
        '            Me.imgphoto.ImageUrl = userinfo.FaceUrl

        '        End If

        '    End If
        'End If
        flog_class.Debug("结束")
    End Sub

End Class