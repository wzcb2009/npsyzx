Public Class UserInfo
    Inherits System.Web.UI.Page

    Dim userbll As New BLL.UserlistBLL
    Public userinfo As New Model.Userlist
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        If Not IsPostBack Then
            Dim userid As Integer = Session("userid")
            If userid > 0 Then
                userinfo = userbll.GetObj(userid)


            End If
        End If
    End Sub


End Class