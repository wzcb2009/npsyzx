Imports Wzsckj.com.Common

Public Class PageAreaSetWeb
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
                Dim sc As New Model.SystemCase
                sc = bll.Entity(ap.ID)
                If sc IsNot Nothing Then
                    Dim fa As New FormArea
                    fa = ActionHelper.FormArea(sc.CaseData)
                    Casedata = fa.ReMark
                    lt_define.Text = caselists(109, sc.CaseData) '数据定义列表

                End If
            Case ActionEnum.Add
                hd_action.Value = "add"
                hd_id.Value = 0
                hd_parentid.Value = ap.Parentid
                Dim casename As String = bll.CaseName(ap.Parentid)
                lab_pCasename.Text = IIf(casename = "", "顶级", casename)
                hd_parentid.Value = ap.Parentid
                lt_define.Text = caselists(109, "") '数据定义列表



        End Select

    End Sub
    Dim bll As New BLL.SystemCaseBLL
    Public caseids, Casedata, casename As String
    Function caselists(parentid As Integer, casedata As String) As String
        Dim s As New StringBuilder
        Dim dt As DataTable = bll.Dt(parentid)
        If casedata <> "" Then
            If casedata.Contains(",") Then
                Dim cd() As String
                cd = casedata.Split(",")
                Dim i As Integer
                For Each r As DataRow In dt.Rows
                    If i < cd.Length Then
                        s.AppendLine(Caselist(r("caseid"), cd(i)))
                    End If
                Next

            End If
        Else
            For Each r As DataRow In dt.Rows

                s.AppendLine(Caselist(r("caseid"), ""))

            Next

        End If
        dt.Dispose()
        Return s.ToString
    End Function
    Function Caselist(Parentid As Integer, defaultValue As String) As String
        Dim s As New StringBuilder
        s.AppendLine("<dl><dt>" & bll.CaseName(Parentid) & "</dt><dd>")
        s.AppendLine("<select id=""sc.casename"" name=""sc.casename"" class=""valid"">")
        Dim dt As DataTable = bll.Dt(Parentid)
        For Each r As DataRow In dt.Rows
            Dim sel As String
            If r("casedata") = defaultValue Then
                sel = "selected"
            Else
                sel = ""
            End If
            s.AppendLine("<option " & sel & " value=""" & r("casedata") & """>" & r("casename") & "</option>")
        Next
        s.AppendLine("</select>")
        s.AppendLine(" </dd>  </dl>")
        dt.Dispose()
        Return s.ToString
    End Function
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