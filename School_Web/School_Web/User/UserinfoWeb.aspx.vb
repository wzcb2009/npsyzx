Imports Wzsckj.com.Common
Imports View

Public Class UserinfoWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara



        Select Case ap.Action
            Case ActionEnum.Modify
                Init_(ap.ID)
                hd_action.Value = "mod"
                lt_department.Text = caselistToCheckbox("chk_department", ap.ID, View.SystemCaseConst.DePartmentCaseId)
                rolelist.Text = caselistToCheckbox("chk_role", ap.ID, View.SystemCaseConst.RoleCaseId)

                hd_id.Value = ap.ID
            Case ActionEnum.Add
                rolelist.Text = caselistToCheckbox("chk_role", ap.ID, View.SystemCaseConst.RoleCaseId)
                lt_department.Text = caselistToCheckbox("chk_department", ap.ID, View.SystemCaseConst.DePartmentCaseId)
                hd_action.Value = "add"
        End Select
    End Sub
    Dim bll As New BLL.UserlistBLL
    Dim uscBll As New BLL.UserSystemCaseBLL
    Dim scBll As New BLL.SystemCaseBLL
    Sub Init_(UserId As Integer)
        Dim user As New Model.Userlist
        user = bll.GetObj(UserId)
        If Not (user Is Nothing) Then
            txt_username.Text = user.UserName
            txt_Truename.Text = user.Truename
            drp_State.SelectedValue = IIf(user.State, 1, 0)
            drp_sex.SelectedItem.Text = user.Sex


        End If

    End Sub
    Function caselistToCheckbox(fName As String, userid As Integer, parentid As Integer) As String
        Dim dt As DataTable = scBll.Dt(parentid)
        Dim uscdt As DataTable = uscBll.dt(parentid, userid)
        Dim s As New StringBuilder
        For Each r As DataRow In dt.Rows
            Dim r2() As DataRow = uscdt.Select("caseid=" & r("caseid"))
            Dim sel As String = ""
            If r2.Length > 0 Then
                sel = " checked=""checked"" "
            End If
            s.AppendLine("<label><input type=""checkbox"" " & sel & " value=""" & r("caseid") & """ name=""" & fName & """>" & r("casename") & "</label>")
        Next
        Return s.ToString
    End Function
End Class