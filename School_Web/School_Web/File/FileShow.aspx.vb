Public Class FileShow
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Session("username") = "" Then
        '    Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
        '    Response.End()

        'End If

        Dim fileid As Integer = Request.QueryString("fileid")
        Dim bll As New BLL.FilelistBLL
        Dim f As New Model.FileList
        f = bll.Entity(fileid)
        If f IsNot Nothing Then

            Dim fullpath As String = Server.MapPath(f.Path)
            If Not f.Path.Contains(".") Then
                Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
                Response.End()
            End If
            Dim s() As String = f.Path.Split(".")
            Dim swfpath As String = f.Path.Replace(s(s.Length - 1), "swf")

            Dim flag As Boolean = IO.File.Exists(Server.MapPath(swfpath))


            If flag Then
                Literal1.Text = " <div   id=""swf1"">......</div><script>swfobject.embedSWF(""" & swfpath & """, ""swf1"", ""100%"", ""98%"", ""9.0.0"", ""expressInstall.swf"");</script>"

                'Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))

            Else
                If IO.File.Exists(fullpath) Then


                    fullpath = LCase(fullpath)
                    change("C:\\wwwroot\\Web\FlashPaper2.2\\FlashPrinter.exe", fullpath, Server.MapPath(swfpath))

                    Literal1.Text = " <div   id=""swf1"">......</div><script>swfobject.embedSWF(""" & swfpath & """, ""swf1"", ""100%"", ""100%"", ""9.0.0"", ""expressInstall.swf"");</script>"

                    'Response.Write("<script>swfobject.embedSWF(""" & swfpath & """, ""swf1"", ""100%"", ""100%"", ""9.0.0"", ""expressInstall.swf"");</script>")
                    'Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))

                Else
                    Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
                    Response.End()
                End If
            End If

        End If
    End Sub
    Function change(ExePath As String, infileName As String, outfilename As String)
        If infileName.Contains(".doc") Or infileName.Contains(".docx") Or infileName.Contains(".pdf") Then
            '  Try
            Dim p As New Process()
            p.StartInfo.FileName = "cmd"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardInput = True
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.RedirectStandardError = True
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            p.Start()
            Dim strOutput As String = Nothing
            Dim s As String = ExePath & " " & (infileName) & " -o " & (outfilename)
            p.StandardInput.WriteLine(s)
            p.StandardInput.WriteLine("exit")
            strOutput = p.StandardOutput.ReadToEnd()
            Console.WriteLine(strOutput)
            p.WaitForExit()
            p.Close()
            ' Catch ex As Exception

            'End Try
        End If

    End Function
End Class