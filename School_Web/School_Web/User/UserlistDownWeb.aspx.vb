Imports Wzsckj.com.Common

Public Class UserlistDownWeb
    Inherits System.Web.UI.Page
    Public pi As PagerInfo
    Public ap As ActionPara
    Dim useritemcount As Integer
    Dim roleid As Integer
    Dim userScdt As DataTable
    Dim scdt As DataTable
    Public keywords As String
    Dim searchitemid As Integer
    Dim subitemid As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        ap = ActionHelper.PageActionPara
        keywords = Request.Form("keywords")
       

        pi = PagerHelper.PagerPageInfo
        pi.orderField = "id"
        Dim uscBll As New BLL.UserSystemCaseBLL
       
        Dim uscdt As DataTable = Session("UserSystemCase")
        roleid = uscBll.Caseid(67, ap.UserId) '获得用户角色
        If roleid <> 77 Then
            Response.Write("无权限")
            Response.End()
        End If
        Dim typeid As Integer = IIf(Request("typeid") = "", 0, Request("typeid"))
        FileHelper.ToExcel("data", list(typeid))
    End Sub
 
    'class='border' 
 
    Dim uscbll As New BLL.UserSystemCaseBLL
    Dim scbll As New BLL.SystemCaseBLL
    Dim userBll As New BLL.UserlistBLL
    Dim fileBll As New BLL.FilelistBLL
    Function getCasename(caseid As Integer) As String
        Dim r() As DataRow
        r = scdt.Select("caseid=" & caseid)
        If r.Length > 0 Then
            Return r(0)("casename")
        End If
    End Function
    Function getCasedata(caseid As Integer) As String
        Dim r() As DataRow
        r = scdt.Select("caseid=" & caseid)
        If r.Length > 0 Then
            Return r(0)("casedata")
        End If
    End Function

    Function list(roleid As Integer) As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table   >")
        s.AppendLine("<thead>")
        s.AppendLine("<th  class='border'>序号</th>")

        s.AppendLine("<th class='border' >用户名</th>")
        s.AppendLine("<th class='border' >姓名</th>")
        s.AppendLine("<th class='border' >角色</th>")

        s.AppendLine("<th class='border' >部门</th>")
        s.AppendLine("<th class='border'   style='vnd.ms-excel.numberformat:@'>联系号码</th>")
        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        Dim bll As New BLL.UserlistBLL
        pi.fldName = "username"
        If (pi.strwhere) <> "" Then
            pi.strwhere = "(username like '%" & pi.strwhere & "%') or (truename like '%" & pi.strwhere & "%')"
        End If
        If pi.strwhere = "" Then
            pi.strwhere = "1=1 "
        End If

        If roleid > 0 Then
            pi.strwhere = pi.strwhere & " and userid in(select userid from user_systemcase where caseid=" & roleid & ")"
        End If
        Response.Write(pi.strwhere)


        Dim dt As DataTable = bll.PagerDt(pi)
        Dim uscBll As New BLL.UserSystemCaseBLL
        Dim scBll As New BLL.SystemCaseBLL
        Dim i As Integer
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr  >")

            i = i + 1
            s.AppendLine("<td class='border'>" & i & "</td>")

            s.AppendLine("<td class='border' style='vnd.ms-excel.numberformat:@'>" & dr("username") & "</td>")
            s.AppendLine("<td class='border'>" & dr("truename") & "</td>")
            s.AppendLine("<td class='border'>" & scBll.CaseName(uscBll.Caseid(View.SystemCaseConst.RoleCaseId, dr("userid"))) & "</td>")

            s.AppendLine("<td class='border'>" & scBll.CaseName(uscBll.Caseid(View.SystemCaseConst.DePartmentCaseId, dr("userid"))) & "</td>")
            s.AppendLine("<td class='border' style='vnd.ms-excel.numberformat:@'>" & dr("tel") & "</td>")


          

        
        Next
        s.AppendLine("</tr>")
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function

End Class