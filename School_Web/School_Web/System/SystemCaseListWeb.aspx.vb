Imports Wzsckj.com.Common
Imports StringHandling

Public Class SystemCaseListWeb
    Inherits System.Web.UI.Page
    Dim bll As New BLL.SystemCaseBLL
    Dim ap As ActionPara
    Public pi As PagerInfo
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        Dim uscBll As New BLL.UserSystemCaseBLL
        If ap.Caseid = 19 Then
            ap.Caseid = 0

        End If
        'If Not (Cache("UserSystemCase") Is Nothing) Then
        Dim dt As DataTable = Session("UserSystemCase")
        Dim r() As DataRow
        r = dt.Select("parentid=" & ap.Parentid)
        'Response.Write(dt.Rows.Count)

        'Response.Write(r.Length)

        lt_toolbar.Text = uscBll.ToolBar(dt, ap.Parentid, ap.Caseid).Replace("{caseid}", ap.Caseid)

        ' End If
        listl.Text = toplist()

    End Sub
    Function toplist() As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""treetable list tablednd"" layoutH=""118""  width=""100%"">")
        s.AppendLine("<thead>")

        s.AppendLine("<th><input type=""checkbox"" class=""checkboxCtrl"" group=""ids"" />类型名称</th>")

        s.AppendLine("<th>序号</th>")

        s.AppendLine("<th>类型ID</th>")
        s.AppendLine("<th>发布日期</th>")
        's.AppendLine("<th>发布者</th>")
        s.AppendLine("<th>显示</th>")
        s.AppendLine("<th width='100'>数据</th>")
        s.AppendLine("<th>相关类型ID</th>")

        s.AppendLine(ActionHelper.ActionStr)
        s.AppendLine("<th>组长设置</th>")


        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")

        s.AppendLine(f(ap.Caseid, True))

        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString

    End Function
    Dim maxCount As Integer = 0
    Function f(parentid As Integer, top As Boolean) As String
        Dim s As New System.Text.StringBuilder
        Dim scdt As DataTable = bll.Dt

        Dim dt As DataTable
        If parentid = 0 Then
            dt = bll.Dt(parentid)
        Else
            dt = bll.Dt2(bll.MysubCaseids(scdt, parentid))
        End If
        'Dim dv As DataView = dt.DefaultView
        'dv.Sort = "pindex asc"
        'dt = dv.ToTable
        pi.TotalCount = dt.Rows.Count
        Dim dt2 As DataTable = dt.Copy
        dt2.Rows.Clear()
        ' If Cache("sortSystemCase" & parentid) Is Nothing Then
        sortDataTable(dt, parentid, dt2)
        'Cache("sortSystemCase" & parentid) = dt2
        ' End If

        dt = PagerHelper.GetPagedTable(dt2, pi.PageIndex, pi.PageSize)
        pi.PageCount = PagerHelper.PageCount(pi.TotalCount, pi.PageSize)
        Dim usc As Model.UserSystemCase
        For Each dr As DataRow In dt.Rows
            Dim classstr As String = "file"
            Dim flag As Boolean = False
            flag = bll.HaveSub(dr("caseid"))
            If flag Then
                classstr = "folder"
            End If
            Dim pstr As String
            If dr("parentid") = parentid Then
                pstr = ""

            Else
                Dim r() As DataRow = dt.Select("caseid=" & dr("parentid"))
                If r.Length > 0 Then
                    pstr = "data-tt-parent-id='" & dr("parentid") & "'"

                End If
            End If
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("caseid") & """ data-tt-id=""" & dr("caseid") & """ " & pstr & ">")

            s.AppendLine("<td><span class='" & classstr & "'><input type=""checkbox"" name=""ids"" value=""" & dr("Caseid") & """/>" & dr("casename") & "</span></td>")

            s.AppendLine("<td>" & dr("pindex") & "</td>")

            s.AppendLine("<td>" & dr("caseid") & "</td>")
            s.AppendLine("<td>" & dr("pubdate") & "</td>")
            's.AppendLine("<td>" & dr("Userid") & "</td>")
            s.AppendLine("<td>" & IIf(SafeData.s_Boolean(dr("isShowFlag")), "是", "否") & "</td>")
            s.AppendLine("<td  ><div  >" & CaseDataToHtml(dr("CaseDataTypeID"), dr("caseid"), dr("casename"), dr("CaseData")) & "</div></td>")
            s.AppendLine("<td>" & CaseDataTypeName(dr("CaseDataTypeID")) & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../system/"
            h.BaseUnit = "systemcase"
            h.UrlOptions = "&parentid=" & ap.Parentid & "&caseid=" & ap.Caseid
            h.ID = dr("caseid")
            s.AppendLine("<td>" & ActionHelper.ModandDelStr(h) & "</td>")
            usc = New Model.UserSystemCase
            usc.CaseId = dr("caseid")
            usc.Parentid = dr("parentid")
            Dim userlists As String = userlist(usc)
            If userlists = "" Then
                userlists = "设置"

            End If
            s.AppendLine("<td><div><a   href=""../user/usersystemcaseinfo.aspx?action=mod&caseid=" & dr("caseid") & "&parentid=" & dr("parentid") & "&objid=0"" target=""dialog"" title=""" & dr("casename") & "-小组管理员设置" & """ rel=""sc_" & dr("caseid") & "_dialog"">" & userlists & "</a></div></td>")
            s.AppendLine("</tr>")
            'If parentid > 0 Then
            '    s.AppendLine(f(dr("caseid"), False))

            'End If
        Next
        Return s.ToString
    End Function
    Function userlist(usc As Model.UserSystemCase) As String
        Dim dt As DataTable
        Dim bll As New BLL.UserSystemCaseBLL
        dt = bll.dtIsAdmin(usc)
        Dim s As New StringBuilder
        Dim userbll As New BLL.UserlistBLL
        For Each r As DataRow In dt.Rows
            s.AppendLine("," & userbll.Truename(r(0)))
        Next
        If s.Length > 0 Then
            s.Remove(0, 1)
        End If
        Return s.ToString
    End Function
    Function CaseDataToHtml(typeid As Object, caseid As Integer, casename As String, cd As Object) As String
        If IsDBNull(typeid) Then
            Return SafeData.s_string(cd)

        End If
        Dim dh As New StringHandling.DWZJson.DwzHref
        If IsDBNull(cd) Then
            Return ""
        ElseIf typeid = 1 Then
            dh = StringHandling.DWZJson.CaseDataToDwzHref(cd)
            dh.CaseId = caseid
            dh.Text = casename
            Return (StringHandling.DWZJson.ToolBarHref2(dh))
        ElseIf typeid = 0 Then

            Return cd.ToString
        ElseIf typeid = 2 Then
            If cd.ToString.Contains(",") Then
                Return "<a class=""btnLook""  href=""../system/systemcasetree.aspx?action=multiselect&id=" & caseid & "&parentid=66"" rel=""newpage1"" lookupGroup=""sc"">查看</a>	"
            End If

        Else
            Return bll.CaseName(Convert.ToInt16(cd))

        End If

    End Function
    Function CaseDataTypeName(typeid As Object) As String
        Select Case SafeData.s_integer(typeid)

            Case 0
                Return "备注"
            Case 1
                Return "系统功能"
            Case 2
                Return "栏目列表"
        End Select
    End Function

    Function sortDataTable(dt As DataTable, parentid As Integer, ByRef dt2 As DataTable) As Boolean

        Dim rs() As DataRow
        rs = dt.Select("parentid=" & parentid)
        For Each r As Data.DataRow In rs
            Dim sr() As DataRow
            sr = dt2.Select("caseid=" & r("caseid"))
            If sr.Length = 0 Then
                dt2.ImportRow(r)
                sortDataTable(dt, r("caseid"), dt2)

            End If

        Next

        Return True

    End Function

End Class