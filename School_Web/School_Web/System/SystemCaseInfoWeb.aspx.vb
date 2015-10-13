Imports Wzsckj.com.Common

Public Class SystemCaseWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Dim bll As New BLL.SystemCaseBLL
        Select Case ap.Action
            Case ActionEnum.Modify
                Init_(ap.ID)
                hd_action.Value = "mod"
                hd_id.Value = ap.ID
            Case ActionEnum.Add
                hd_action.Value = "add"
                hd_id.Value = 0
                hd_parentid.Value = ap.Parentid
                txt_pindex.Text = bll.pIndex(ap.ID)
                Dim casename As String = bll.CaseName(ap.Parentid)
                lab_pCasename.Text = IIf(casename = "", "顶级", casename)
                hd_parentid.Value = ap.Parentid



        End Select
        '  txt_casedata.Attributes.Add("name", "sc.txt_casedata")
    End Sub
    Dim bll As New BLL.SystemCaseBLL
    Public caseids, Casedata, casename As String

    Sub Init_(ID As Integer)
        Dim us As New Model.SystemCase
        us = bll.Entity(ID)
        txt_pindex.Text = us.Pindex
        lab_pCasename.Text = bll.CaseName(us.ParentId)
        txt_casename.Text = us.CaseName
        hd_parentid.Value = us.ParentId
        drp_isShowFlag.SelectedValue = IIf(us.IsShowFlag, 1, 0)
        caseids = us.CaseData
        drp_casedatatypeid.SelectedValue = StringHandling.SafeData.s_integer(us.CaseDataTypeid)
        If us.CaseDataTypeid = 2 Then
            Casedata = bll.CaseNames(caseids)
        Else
            Casedata = us.CaseData
        End If

         
    End Sub

End Class