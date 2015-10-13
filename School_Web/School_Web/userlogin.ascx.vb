Public Class userlogin
    Inherits System.Web.UI.UserControl

    Dim userbll As New BLL.UserlistBLL

    Sub login(ByVal UserNameStr As String)
        Dim rs = userbll.Rs(UserNameStr)
        If rs.read Then

            Session("userid") = rs("userId")
            Session("UserName") = rs("UserName")
            Session("truename") = rs("truename")
            Dim uscbll As New BLL.UserSystemCaseBLL
            Dim usc As New Model.UserSystemCase
            usc.CaseId = 13
            usc.Parentid = 4
            usc.UserId = rs("userId")
            If uscbll.IsExit2(usc) Then
                Session("roleid") = 2
            Else
                Session("roleid") = 1


            End If


            If Session("roleid") = 2 Then
                Session("mag_flag") = True
                Session("IsAuthorized") = True
                Response.Redirect("admin/default.aspx")
            ElseIf Session("roleid") = 1 Then
                Response.Redirect("userindex.aspx")
            End If
        End If
    End Sub


    Sub show()
        If Session("username") <> "" Then

            Panel1.Visible = False
            Panel2.Visible = True

            Dim user As New Model.Userlist
            user = userbll.GetObj(Session("userid"))
            Label1.Text = "<div  class=userinfo><table> <tr><td>用户：</td><td>" & user.UserName & "</td></tr><tr><td>姓名：</td><td>" & user.Truename & "</td></tr></table></div>"
            If Session("roleid") = 2 Then
                HyperLink1.Visible = True
                HyperLink1.Text = "管理中心"
                HyperLink1.NavigateUrl = "admin/default.aspx"

            Else
                HyperLink1.Visible = False

                ' HyperLink1.Visible = False
            End If

        Else
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        flog_class.Debug("userlogin")
        show()
        flog_class.Debug("userlogin_end")
    End Sub


    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Session.Abandon()

        Response.End()
    End Sub

    'Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
    '    Dim UserNameStr As String = Trim(UserName.Text)
    '    Dim PwdStr As String = Trim(Pwd.Text)
    '    Dim flag As Integer
    '    flag = userbll.login(UserNameStr, PwdStr)
    '    If flag = 1 Then
    '        Call login(UserNameStr)
    '        show()
    '    ElseIf flag = -1 Then
    '        msg.Text = "密码错误！"
    '    ElseIf flag = -2 Then
    '        msg.Text = "用户名不存在！"
    '    End If
    'End Sub
End Class