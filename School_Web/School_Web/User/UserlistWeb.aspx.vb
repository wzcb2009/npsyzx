Imports Wzsckj.com.Common

Public Class UserlistWeb
    Inherits System.Web.UI.Page

    Public pi As PagerInfo
    Dim ap As ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        pi.orderField = "userid"
        listL.Text = list()
        Dim uscBll As New BLL.UserSystemCaseBLL
        lt_toolbar.Text = uscBll.ToolBar(Session("UserSystemCase"), ap.Parentid, ap.Caseid).Replace("{typeid}", txt_roleid.SelectedValue)
        If Not IsPostBack Then
            bind(txt_roleid, View.SystemCaseConst.RoleCaseId)
            ' bind(txt_zcid, 230)
            '  bind(txt_collegeid, 187)

        End If
    End Sub
    Dim bll As New BLL.SystemCaseBLL
    Sub bind(obj As DropDownList, parentid As Integer)
        obj.DataSource = bll.Dt(parentid)
        obj.DataValueField = "caseid"
        obj.DataTextField = "casename"
        obj.DataBind()
        Dim item As New ListItem
        item.Value = "0"
        item.Text = ""
        obj.Items.Insert(0, item)

    End Sub
    Function list() As String
        Dim s As New System.Text.StringBuilder
        s.AppendLine("<table class=""table"" layoutH=""138"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""ids"" /></th>")

        s.AppendLine("<th orderfield=""username"">用户名</th>")
        s.AppendLine("<th  >姓名</th>")
        s.AppendLine("<th  >角色</th>")

        s.AppendLine("<th  >部门</th>")
        s.AppendLine("<th   >联系号码</th>")

        s.AppendLine("<th >最近登陆</th>")
        s.AppendLine("<th  >注册日期</th>")
        s.AppendLine("<th  >登陆IP</th>")
        s.AppendLine("<th  >登陆次数</th>")

        s.AppendLine("<th  >状态</th>")
        s.AppendLine("<th  >性别</th>")
        's.AppendLine("<th orderfield=""FaceUrl"">头像</th>")
        s.AppendLine(ActionHelper.ActionStr)
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
        If txt_roleid.SelectedIndex > -1 Then
            If txt_roleid.SelectedValue > 0 Then
                pi.strwhere = pi.strwhere & " and userid in(select userid from user_systemcase where caseid=" & txt_roleid.SelectedValue & ")"
            End If

        End If
        Dim dt As DataTable = bll.PagerDt(pi)
        Dim uscBll As New BLL.UserSystemCaseBLL
        Dim scBll As New BLL.SystemCaseBLL
        For Each dr As DataRow In dt.Rows
            s.AppendLine("<tr target=""sid_user"" rel=""" & dr("userid") & """>")

            s.AppendLine("<td><input type=""checkbox"" name=""ids"" value=""" & dr("userid") & """/></td>")

            s.AppendLine("<td>" & dr("username") & "</td>")
            s.AppendLine("<td>" & dr("truename") & "</td>")
            s.AppendLine("<td>" & scBll.CaseName(uscBll.Caseid(View.SystemCaseConst.RoleCaseId, dr("userid"))) & "</td>")

            s.AppendLine("<td>" & scBll.CaseName(uscBll.Caseid(View.SystemCaseConst.DePartmentCaseId, dr("userid"))) & "</td>")
            s.AppendLine("<td>" & dr("tel") & "</td>")

            s.AppendLine("<td>" & dr("lastlogin") & "</td>")
            s.AppendLine("<td>" & dr("pubdate") & "</td>")
            s.AppendLine("<td>" & dr("localip") & "</td>")
            s.AppendLine("<td>" & dr("logintimes") & "</td>")
            's.AppendLine("<td>" & dr("OtherGuID") & "</td>")
            s.AppendLine("<td>" & dr("State") & "</td>")
            s.AppendLine("<td>" & dr("Sex") & "</td>")
            's.AppendLine("<td>" & dr("FaceUrl") & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../user/"
            h.BaseUnit = "user"
            h.ID = dr("userid")
            s.AppendLine("<td>" & ActionHelper.ModandDelStr(h) & "</td>")
        Next
        s.AppendLine("</tr>")
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function

End Class