Imports Wzsckj.com.Common

Public Class UserGroupTree
    Inherits System.Web.UI.Page
    Dim uscBll As New BLL.UserSystemCaseBLL
    Dim bll As New BLL.SystemCaseBLL
    Dim ap As New ActionPara

     Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara


        ids.Value = ap.Ids
        pindex.Value = ap.Pindex
        EventCaseId.Value = ap.EventCaseId
        objid.Value = ap.ObjId
        ' Dim dt As DataTable = BLL.Dt()
        treel.Text = Userlist(ap.Parentid, "tree treeFolder treeCheck expand")
        txt_typeid.Text = caselistToCheckbox("txt_typeid", ap.ID, 4)
       

    End Sub
    Dim scbll As New BLL.SystemCaseBLL
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

    Dim userbll As New BLL.UserlistBLL
    Function Userlist(caseid As Integer, mode As String) As String
        Dim dt As DataTable = uscBll.dt2(caseid)
        Dim temp As New StringBuilder
        If dt.Rows.Count > 0 Then
            temp.AppendLine("<ul class=""" & mode & """>")
        End If
        '项目对应教室是否被选中
        'Dim puBll As New BLL.ProjectUserBLL
        Dim pudt As DataTable
        If Not ids.Value.Contains(",") Then
            'pudt = puBll.Dt2(ap.Pindex, ids.Value, ap.EventCaseId)
            'If pudt IsNot Nothing And pudt.Rows.Count > 0 Then
            '    If pudt.Rows(0)("typeid") > 1 Then

            '        ' txt_typeid.SelectedValue = pudt.Rows(0)("typeid")
            '    End If
            'End If

        End If
        Dim user As Model.Userlist
        For Each r As DataRow In dt.Rows
            Dim c As String = ""
            If pudt IsNot Nothing Then
                Dim usr() As Data.DataRow
                usr = pudt.Select("userid=" & r("userid"))
                If usr.Length > 0 Then
                    c = "checked"
                Else
                    c = ""
                End If
            End If
            user = userbll.GetObj(r("userid"))
            Dim truename As String = ""
            If user IsNot Nothing Then
                truename = user.Truename
            End If
            temp.AppendLine("<li><a href=""#"" " & c & " tname=""userid"" tvalue=""" & r("userid") & """ >" & truename & "</a><li>")
        Next
        If dt.Rows.Count > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
End Class