Public Class UserPics
    Inherits System.Web.UI.Page
    Dim userid As Integer
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        Dim action As String = Request.QueryString("action")
        If action = "del" Then
            delfile(Request.QueryString("id"))
        End If

        If Not IsPostBack Then


            userid = Session("userid")


            Dim UserBll As New BLL.UserlistBLL

            'unitInfo = unitBll.EntityByUserid(unitInfo.UserId)
            'If unitInfo Is Nothing Then
            '    unitInfo = New Model.UnitList
            'Else
            '    Dim dt As DataTable

            '    Dim filebll As New BLL.FilelistBLL
            '    dt = filebll.Dt(535, unitInfo.Id, unitInfo.UserId)

            '    Dim s As New StringBuilder
            '    For Each r As DataRow In dt.Rows
            '        s.AppendLine(" <li class=""span2""><div class=""thumbnail""><img  src=""" & r("path") & """ alt=""""><h5>" & r("title") & "</h5><p>" & r("content") & "</p>   <a href='userpics.aspx?action=del&id=" & r("fileid") & "'><i class='icon-remove'></i>删除</a> <a href='userpicmod.aspx?id=" & r("fileid") & "'><i class='icon-edit'></i>修改</a>  </div></li>")
            '    Next
            '    Literal1.Text = s.ToString

            'End If
        End If
    End Sub
    Function delfile(fileid As Integer) As Boolean
        Dim filebll As New BLL.FilelistBLL
        Dim file As New Model.FileList
        file.UserId = Session("userid")
        file.FileId = fileid
        filebll.Del(file)
    End Function
End Class