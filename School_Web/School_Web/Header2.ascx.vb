Imports View

Public Class Header2
    Inherits System.Web.UI.UserControl

    Dim scView As New SystemCaseView
    Dim scbll As New BLL.SystemCaseBLL
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lt_menu.Text = scView.WebMenu(scbll.Dt, 16, "")
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
    End Sub

End Class