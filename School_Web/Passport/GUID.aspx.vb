Public Class GUID_
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s As New StringBuilder
        Dim gid As String = getGuidString()
        Dim c As New HttpCookie("guid")
        c.Value = gid
        c.Domain = "wz17.net"

        Response.AppendCookie(c)

        ' s.AppendLine("<script>")
        s.Append("document.getElementById('guid').value='" & gid & "';")
        '  s.AppendLine("</script>")
        Response.Clear()
        Response.Write(s.ToString)
        Response.End()

    End Sub
    Private Function getGuidString() As String
        Return System.Guid.NewGuid().ToString().ToUpper()
    End Function

End Class