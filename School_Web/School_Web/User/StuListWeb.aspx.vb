Imports Wzsckj.com.Common

Public Class StuListWeb
    Inherits System.Web.UI.Page


    Public pi As PagerInfo
    Dim ap As ActionPara

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        pi = PagerHelper.PagerPageInfo
        pi.orderField = "username"
        listL.Text = list()
        Dim uscBll As New BLL.UserSystemCaseBLL
        lt_toolbar.Text = uscBll.ToolBar(Session("UserSystemCase"), ap.Parentid, ap.Caseid)
        If Not IsPostBack Then
            '  bind(txt_gradeid, SystemConfig.Teaching.GradeCaseId)
            'bind(txt_zcid, 230)
      

            If txt_gradeid.SelectedIndex > 0 Then

                bind(txt_classid, txt_gradeid.SelectedValue)
            End If

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
        s.AppendLine("<table class=""table"" layoutH=""113"" width=""100%"">")
        s.AppendLine("<thead>")
        s.AppendLine("<th width=""30""><input type=""checkbox"" class=""checkboxCtrl"" group=""ids"" /></th>")

        s.AppendLine("<th orderfield=""username"">用户名</th>")
        s.AppendLine("<th  >姓名</th>")
 
         s.AppendLine("<th  >班级</th>")


        s.AppendLine("<th   >联系号码</th>")
        s.AppendLine("<th >最近登陆</th>")

        s.AppendLine("<th  >登陆次数</th>")


        s.AppendLine("<th  >性别</th>")
        s.AppendLine("<th  >状态</th>")
        's.AppendLine("<th orderfield=""FaceUrl"">头像</th>")
        s.AppendLine(ActionHelper.ActionStr)
        s.AppendLine("</tr></thead>")
        s.AppendLine("<tbody>")
        Dim bll As New BLL.UserlistBLL
        pi.fldName = "username"
        pi.orderDirection = "asc"
        pi.orderField = "username"
        If (pi.strwhere) <> "" Then
            pi.strwhere = "(username like '%" & pi.strwhere & "%') or (truename like '%" & pi.strwhere & "%')"
        End If
        Dim roleid As Integer = 14
        If pi.strwhere = "" Then
            pi.strwhere = "1=1 "
        End If

        pi.strwhere = pi.strwhere & " and roleid=" & roleid
        If txt_gradeid.SelectedIndex > 0 Then
            pi.strwhere = pi.strwhere & " and gradeid=" & txt_gradeid.SelectedValue

        End If
        If txt_classid.SelectedIndex > 0 Then
            pi.strwhere = pi.strwhere & " and classid=" & txt_classid.SelectedValue

        End If
    


        Dim dt As DataTable = bll.PagerDt(pi)
        Dim uscBll As New BLL.UserSystemCaseBLL
        Dim scBll As New BLL.SystemCaseBLL
        Dim userinfo As Model.Userlist
        For Each dr As DataRow In dt.Rows
            userinfo = Mapper.ToEntity(dr, GetType(Model.Userlist))
            s.AppendLine("<tr target=""sid_user"" rel=""" & userinfo.UserId & """>")

            s.AppendLine("<td><input type=""checkbox"" name=""ids"" value=""" & userinfo.UserId & """/></td>")

            s.AppendLine("<td>" & userinfo.UserName & "</td>")
            s.AppendLine("<td>" & userinfo.Truename & "</td>")

             s.AppendLine("<td>" & scBll.CaseName(userinfo.Classid) & "</td>")
            s.AppendLine("<td>" & userinfo.Tel & "</td>")

            s.AppendLine("<td>" & userinfo.LastLogin & "</td>")


            s.AppendLine("<td>" & userinfo.LoginTimes & "</td>")
            's.AppendLine("<td>" & dr("OtherGuID") & "</td>")

            s.AppendLine("<td>" & userinfo.Sex & "</td>")
            s.AppendLine("<td>" & IIf(userinfo.State = False, "休学", "") & "</td>")
            's.AppendLine("<td>" & dr("FaceUrl") & "</td>")
            Dim h As New HrefInfo
            h.BasePath = "../user/"
            h.BaseUnit = "user"
            h.Width = 800
            h.Height = 450
            h.ID = userinfo.UserId
            s.AppendLine("<td>" & ActionHelper.ModandDelStr(h) & "</td>")
        Next
        s.AppendLine("</tr>")
        s.AppendLine("</tbody>")
        s.AppendLine("</table>")
        Return s.ToString
    End Function

    Protected Sub txt_gradeid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_gradeid.SelectedIndexChanged
        If txt_gradeid.SelectedIndex > 0 Then

            bind(txt_classid, txt_gradeid.SelectedValue)
        End If
    End Sub

 

 
End Class