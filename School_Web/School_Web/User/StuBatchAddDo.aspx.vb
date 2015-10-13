Imports Wzsckj.com.Common
Imports System.Data.OleDb
Imports StringHandling

Public Class StuBatchaddDo
    Inherits System.Web.UI.Page
     Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()
        End If



        Dim jpeg_image_upload As HttpPostedFile = Request.Files("Filedata")
        Dim fileName As String = jpeg_image_upload.FileName
        Dim filesize As Integer = jpeg_image_upload.ContentLength
        If filesize = 0 Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
            Response.End()

        End If

        ' 图片格式

        Dim FileExt As String = fileName.Substring(fileName.LastIndexOf(".") + 1)


        Dim SaveFileName As String
        SaveFileName = Now
        Randomize()
        Dim RndNumber As Integer
        RndNumber = CInt(Int((99999 * Rnd()) + 10000))
        '保存下来的文件名，用日期和5位随机数
        Dim RndFileName As String
        RndFileName = Year(SaveFileName) & Month(SaveFileName) & Day(SaveFileName) & Hour(SaveFileName) & Minute(SaveFileName) & Second(SaveFileName) & CStr(RndNumber)
        SaveFileName = RndFileName & "." & FileExt
        Dim dirpath As String = "../upfiles/"
        Dim fullpath As String = Server.MapPath(dirpath & SaveFileName)
        jpeg_image_upload.SaveAs(fullpath)
        Dim typeid As Integer = Request.Form("typeid")
        '  th_DataAdd(fullpath, "Sheet1$")

 
    End Sub
 
    Dim uscbll As New BLL.UserSystemCaseBLL
    Dim scbll As New BLL.SystemCaseBLL

    'Function th_DataAdd(ByVal filename As String, ByVal tablenamestr As String) As String
    '     Dim connstr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
    '    "Data Source=" & filename & ";Extended Properties=""Excel 8.0;"""

    '    Dim sc, zysc, bjsc As Model.SystemCase
    '    Dim scbll As New BLL.SystemCaseBLL
    '    Dim xydt As DataTable
    '    Dim sql As String
    '    sql = "SELECT distinct  年级     FROM  [" & tablenamestr & "]"
    '    xydt = OleDbHelper.ExecuteDataTable(connstr, CommandType.Text, sql)
    '    For Each r As DataRow In xydt.Rows
    '        sc = New Model.SystemCase
    '        sc.ParentId = SystemConfig.Teaching.GradeCaseId
    '        sc.CaseName = Trim(r(0))
    '        sc.CaseId = scbll.GetCaaseID(sc.CaseName, sc.ParentId)
    '        sc.PubDate = Now

    '        If sc.CaseId = 0 Then
    '            sc.CaseId = scbll.NewCaseId
    '            sc = scbll.Add(sc)

    '        End If
    '        sql = "SELECT distinct 班级       FROM  [" & tablenamestr & "] where 年级='" & Trim(r(0)) & "'"
    '        Dim zydt As DataTable
    '        zydt = OleDbHelper.ExecuteDataTable(connstr, CommandType.Text, sql)
    '        For Each zyr As DataRow In zydt.Rows
    '            zysc = New Model.SystemCase
    '            zysc.ParentId = sc.CaseId
    '            zysc.CaseName = zyr(0)
    '            zysc.CaseId = scbll.GetCaaseID(zysc.CaseName, zysc.ParentId)
    '            zysc.PubDate = Now
    '            If zysc.CaseId = 0 Then
    '                zysc.CaseId = scbll.NewCaseId
    '                zysc = scbll.Add(zysc)

    '            End If

    '        Next

    '    Next


    '    Dim dt As DataTable
    '    sql = "SELECT * FROM  [" & tablenamestr & "]"
    '    dt = OleDbHelper.ExecuteDataTable(connstr, CommandType.Text, sql)


    '    Dim num As Integer
    '    Dim temperr As New StringBuilder
    '    Dim userBll As New BLL.UserlistBLL

    '    For Each rs As DataRow In dt.Rows


    '        Dim UserNamestr, TrueNamestr, sex, bj, js As String

    '        If IsDBNull(rs("学号")) Or IsDBNull(rs("姓名")) Or IsDBNull(rs("班级")) Or IsDBNull(rs("年级")) Then
    '            Exit For
    '        End If


    '        UserNamestr = (Trim(rs("学号")))
    '        TrueNamestr = Trim(rs("姓名"))

    '        bj = Trim(SafeData.s_string(rs("班级")))

    '        Dim nj As String
    '        nj = Trim(SafeData.s_string(rs("年级")))
    '        js = "学生"
    '        sex = Trim(rs("性别"))

    '        Dim user As New Model.Userlist
    '        user.RoleId = 14 '学生
    '        Dim py As String = CNPY.Convert(TrueNamestr)
    '        user.TruenameEn = py

    '        user.Gradeid = scbll.Caseid(SystemConfig.Teaching.GradeCaseId, nj)
    '        user.ClassId = scbll.Caseid(user.GradeId, bj)
    '        user.UserName = UserNamestr
    '        user.Truename = TrueNamestr
    '        user.PubDate = Now
    '        user.Pwd = Security.Md5(UserNamestr)
    '        user.Sex = sex
    '        user.State = True
    '        user.LoginTimes = 0
    '        user.LastLogin = Now

    '         Dim userid As Integer = userBll.Userid(UserNamestr)
    '        user.UserId = userid
    '        user = userBll.AddandSave(user)

    '        num = num + 1
    '    Next
    '    Dim dwz_ As New DWZJson.DWZ
    '    dwz_.statusCode = DWZJson.statusCode.OK
    '    dwz_.message = "添加用户数量" & num

    '    Response.Write(StringHandling.DWZJson.Alert(dwz_))
    '    Response.End()
    'End Function
 
End Class