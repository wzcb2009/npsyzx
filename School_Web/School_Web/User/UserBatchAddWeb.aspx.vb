Public Class UserBatchAddWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()
        End If

    End Sub

End Class