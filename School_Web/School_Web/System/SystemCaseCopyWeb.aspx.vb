Imports Wzsckj.com.Common

Public Class SystemCaseCopyWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Dim bll As New BLL.SystemCaseBLL
        Select Case ap.Action
          
            Case ActionEnum.Copy
                hd_action.Value = "copy"
                hd_id.Value = 0
                hd_parentid.Value = ap.Parentid
                txt_pindex.Text = bll.pIndex(ap.Parentid)
                Dim casename As String = bll.CaseName(ap.Parentid)
                lab_pCasename.Text = IIf(casename = "", "顶级", casename)
                hd_parentid.Value = ap.Parentid



        End Select
        casedata_caseid.DataSource = bll.Dt(126)
        casedata_caseid.DataValueField = "caseid"
        casedata_caseid.DataTextField = "casename"
        casedata_caseid.DataBind()
        '  txt_casedata.Attributes.Add("name", "sc.txt_casedata")
    End Sub
    Dim bll As New BLL.SystemCaseBLL
    Public caseids, Casedata, casename As String


End Class