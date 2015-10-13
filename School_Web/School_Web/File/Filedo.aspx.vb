Imports System.IO
Imports Wzsckj.com.Common

Public Class Filedo

    Inherits System.Web.UI.Page
    '
    ' * upload demo for c# .net 2.0
    ' * 
    ' * @requires xhEditor
    ' * @author Jediwolf<jediwolf@gmail.com>
    ' * @licence LGPL(http://www.opensource.org/licenses/lgpl-license.php)
    ' * 
    ' * @Version: 0.1.3 (build 100504)
    ' * 
    ' * 注1：本程序仅为演示用，请您务必根据自己需求进行相应修改，或者重开发
    ' * 注2：本程序将HTML5上传与普通POST上传转换为byte类型统一处理
    ' * 
    ' 


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Response.Charset = "UTF-8"
        ' If Session("username") = "" Then
        'Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))

        '  Response.End()
        ' End If
        ' 初始化一大堆变量
        Dim inputname As String = "filedata"
        '表单文件域name
        Dim attachdir As String = "../upfiles"
        ' 上传文件保存路径，结尾不要带/
        Dim dirtype As Integer = 1
        ' 1:按天存入目录 2:按月存入目录 3:按扩展名存目录  建议使用按天存
        Dim maxattachsize As Integer = 2097152
        ' 最大上传大小，默认是2M
        Dim upext As String = "txt,rar,zip,jpg,jpeg,gif,png,swf,wmv,avi,wma,mp3,mid"
        ' 上传扩展名
        Dim msgtype As Integer = 2
        '返回上传参数的格式：1，只返回url，2，返回参数数组
        Dim immediate As String = Request.QueryString("immediate")
        '立即上传模式，仅为演示用
        Dim file As Byte()
        ' 统一转换为byte数组处理
        Dim localname As String = ""
        Dim disposition As String = Request.ServerVariables("HTTP_CONTENT_DISPOSITION")

        Dim err As String = ""
        Dim msg As String = "''"

        If disposition IsNot Nothing Then
            ' HTML5上传
            file = Request.BinaryRead(Request.TotalBytes)
            ' 读取原始文件名
            localname = Regex.Match(disposition, "filename=""(.+?)""").Groups(1).Value
        Else
            Dim filecollection As HttpFileCollection = Request.Files
            Dim postedfile As HttpPostedFile = filecollection.[Get](inputname)

            ' 读取原始文件名
            localname = postedfile.FileName
            ' 初始化byte长度.
            file = New [Byte](postedfile.ContentLength - 1) {}

            ' 转换为byte类型
            Dim stream As System.IO.Stream = postedfile.InputStream
            stream.Read(file, 0, postedfile.ContentLength)
            stream.Close()

            filecollection = Nothing
        End If

        If file.Length = 0 Then
            err = "无数据提交"
        Else
            If file.Length > maxattachsize Then
                err = "文件大小超过" & maxattachsize & "字节"
            Else
                Dim attach_dir As String, attach_subdir As String, filename As String, extension As String, target As String

                ' 取上载文件后缀名
                extension = GetFileExt(localname)
                Dim fe As FileExtension() = {FileExtension.GIF, FileExtension.JPG, FileExtension.PNG}
                If FileValidation.IsAllowedExtension(file, fe) = False Then
                    err = "上传文件扩展名必需为：" & upext
                Else
                    'if (("," + upext + ",").IndexOf("," + extension + ",") < 0)err = "上传文件扩展名必需为：" + upext;
                    Select Case dirtype
                        Case 2
                            attach_subdir = "month_" & DateTime.Now.ToString("yyMM")
                            Exit Select
                        Case 3
                            attach_subdir = "ext_" & extension
                            Exit Select
                        Case Else
                            attach_subdir = "day_" & DateTime.Now.ToString("yyMMdd")
                            Exit Select
                    End Select
                    attach_dir = attachdir & "/" & attach_subdir & "/"

                    ' 生成随机文件名
                    Dim random As New Random(DateTime.Now.Millisecond)
                    filename = DateTime.Now.ToString("yyyyMMddhhmmss") + random.[Next](10000) + "." & extension

                    target = attach_dir & filename
                    Try
                        CreateFolder(Server.MapPath(attach_dir))

                        Dim fs As New System.IO.FileStream(Server.MapPath(target), System.IO.FileMode.Create, System.IO.FileAccess.Write)
                        fs.Write(file, 0, file.Length)
                        fs.Flush()
                        fs.Close()
                    Catch ex As Exception
                        err = ex.Message.ToString()
                    End Try

                    ' 立即模式判断
                    If immediate = "1" Then
                        target = "!" & target
                    End If
                    target = jsonString(target)
                    If msgtype = 1 Then
                        msg = "'" & target & "'"
                    Else
                        msg = "{'url':'" & target & "','localname':'" & jsonString(localname) & "','id':'1'}"
                    End If
                End If
            End If
        End If

        file = Nothing
        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        ' Response.Write("{'err':'" & jsonString(err) & "','msg':" & msg & "}")
    End Sub


    Private Function jsonString(str As String) As String
        str = str.Replace("\", "\\")
        str = str.Replace("/", "\/")
        str = str.Replace("'", "\'")
        Return str
    End Function


    Private Function GetFileExt(FullPath As String) As String
        If FullPath <> "" Then
            Return FullPath.Substring(FullPath.LastIndexOf("."c) + 1).ToLower()
        Else
            Return ""
        End If
    End Function

    Private Sub CreateFolder(FolderPath As String)
        If Not System.IO.Directory.Exists(FolderPath) Then
            System.IO.Directory.CreateDirectory(FolderPath)
        End If
    End Sub
    Public Enum FileExtension
        JPG = 255216
        GIF = 7173
        PNG = 13780
        SWF = 6787
        RAR = 8297
        ZIP = 8075
        _7Z = 55122

        ' 255216 jpg;

        ' 7173 gif;

        ' 6677 bmp,

        ' 13780 png;

        ' 6787 swf

        ' 7790 exe dll,

        ' 8297 rar

        ' 8075 zip

        ' 55122 7z

        ' 6063 xml

        ' 6033 html

        ' 239187 aspx

        ' 117115 cs

        ' 119105 js

        ' 102100 txt

        ' 255254 sql 

    End Enum

    Public Class FileValidation
        Public Shared Function IsAllowedExtension(imgArray As Byte(), fileEx As FileExtension()) As Boolean
            Dim ms As New MemoryStream(imgArray)
            Dim br As New System.IO.BinaryReader(ms)
            Dim fileclass As String = ""
            Dim buffer As Byte
            Try
                buffer = br.ReadByte()
                fileclass = buffer.ToString()
                buffer = br.ReadByte()
                fileclass += buffer.ToString()
            Catch
            End Try
            br.Close()
            ms.Close()
            For Each fe As FileExtension In fileEx
                If Int32.Parse(fileclass) = CInt(fe) Then
                    Return True
                End If
            Next
            Return False
        End Function
    End Class
End Class
