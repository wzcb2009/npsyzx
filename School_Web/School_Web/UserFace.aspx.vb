Imports Wzsckj.com.Common.ZoomImageDemo

Public Class UserFace
    Inherits System.Web.UI.Page

    Dim user_ As New Model.Userlist
    Dim userbll As New BLL.UserlistBLL
    Dim userid As Integer

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Redirect("loginweb.aspx")
        End If

        userid = Session("userid")
        If Page.IsPostBack Then

            Return
        End If
        If Not Page.IsPostBack Then
            user_ = userbll.GetObj(userid)
            If user_ IsNot Nothing Then
                Me.imgphoto.ImageUrl = user_.FaceUrl

            End If
        End If
        If Not String.IsNullOrEmpty(Request.QueryString("Picurl")) Then
            ImageDrag.ImageUrl = Request.QueryString("Picurl")
            ImageIcon.ImageUrl = Request.QueryString("Picurl")
           
            Step2Container.Visible = True

            '  Page.ClientScript.RegisterStartupScript(GetType(UserFace), "step2", "<script type='text/javascript'>Step2();</script>")
        Else

            Step2Container.Visible = False
            '  Page.ClientScript.RegisterStartupScript(GetType(UserFace), "step1", "<script type='text/javascript'>Step1();</script>")
        End If
    End Sub
    Private Const savepath As String = "upfiles" & "/"

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs)
        If fuPhoto.PostedFile IsNot Nothing AndAlso fuPhoto.PostedFile.ContentLength > 0 Then

            Dim ext As String = System.IO.Path.GetExtension(fuPhoto.PostedFile.FileName).ToLower()
            If ext <> ".jpg" AndAlso ext <> ".jepg" AndAlso ext <> ".bmp" AndAlso ext <> ".gif" Then
                Return
            End If
            Dim filename As String = "xuanye_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ext
            Dim path As String = "upfiles/" & filename
            fuPhoto.PostedFile.SaveAs(Server.MapPath(path))
            Response.Redirect("~/userface.aspx?Picurl=" & Server.UrlEncode(path))
            'do some thing;
        Else
        End If
    End Sub

    Protected Sub btn_Image_Click(sender As Object, e As EventArgs)
        Dim imageWidth As Integer = Int32.Parse(txt_width.Text)
        Dim imageHeight As Integer = Int32.Parse(txt_height.Text)
        Dim cutTop As Integer = Int32.Parse(txt_top.Text)
        Dim cutLeft As Integer = Int32.Parse(txt_left.Text)
        Dim dropWidth As Integer = Int32.Parse(txt_DropWidth.Text)
        Dim dropHeight As Integer = Int32.Parse(txt_DropHeight.Text)

        Dim filename As String = CutPhotoHelp.SaveCutPic(Server.MapPath(ImageIcon.ImageUrl), Server.MapPath(savepath), 0, 0, dropWidth, dropHeight, _
            cutLeft, cutTop, imageWidth, imageHeight)

        Me.imgphoto.ImageUrl = savepath & filename
        Step2Container.Visible = False
        user_ = userbll.GetObj(userid)
        If user_ IsNot Nothing Then
            user_.FaceUrl = Me.imgphoto.ImageUrl
            userbll.AddandSave(user_)
        Else
            Response.Write(1)

        End If

        '  Page.ClientScript.RegisterStartupScript(GetType(UserFace), "step3", "<script type='text/javascript'>Step3();</script>")
    End Sub



End Class