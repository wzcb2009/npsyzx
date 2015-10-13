Public Class systemdo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim bll As New BLL.SystemInfoParamBLL
        Dim sip As New Model.SystemInfoParam
        sip.Id = 1
        sip.Address = Request.Form("txt_address")
        sip.Contact = Request.Form("txt_tel")
        sip.Content = Request.Form("txt_content")
        sip.Icp = Request.Form("txt_icp")
        sip.Schoolname = Request.Form("txt_name")
        sip.Uploadpath = Request.Form("txt_path")
        sip.Pubdate = Now

        bll.AddAndSave(sip)
        If sip.IsChanged Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
            Response.End()
        End If
    End Sub

End Class