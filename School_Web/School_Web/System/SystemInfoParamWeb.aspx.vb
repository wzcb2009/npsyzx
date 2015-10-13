Public Class SystemInfoParamWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            init_()
        End If
    End Sub
    Sub init_()
        Dim bll As New BLL.SystemInfoParamBLL
        Dim rs = bll.Rs(1)
        If rs.Read Then
            txt_address.Text = rs("address")
            txt_content.Text = rs("content")
            txt_icp.Text = rs("icp")
            txt_name.Text = rs("schoolname")
            txt_path.Text = rs("uploadpath")
            txt_tel.Text = rs("Contact")
        End If
        rs.Close()

    End Sub
End Class