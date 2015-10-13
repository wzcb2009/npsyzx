Imports Wzsckj.com.Common
Imports System.Data.OleDb
Imports StringHandling

Public Class UserBatchaddDo
    Inherits System.Web.UI.Page
    Dim cflag As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") = "" Then
            Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
            Response.End()
        End If
        cflag = IIf(Request.Form("c_baseinfo") = "1", True, False)


        Dim jpeg_image_upload As HttpPostedFile = Request.Files("Filedata")
        Dim fp As FileProperty
        fp = FileHelper.upload(jpeg_image_upload)
        If fp.Path <> "" Then
            fp.Path = Server.MapPath(fp.Path)
            th_DataAdd(fp.Path, "Sheet1$")

        End If

    End Sub
    Function scAdd(dt As DataTable, parentid As Integer)
         Dim i As Integer
        For Each rs As DataRow In dt.Rows
            i = i + 1
            Dim sc As New Model.SystemCase
            sc.CaseName = rs("部门")
            sc.ParentId = parentid
            sc.CaseId = BLL.SystemCaseBLL.Caseid(sc.ParentId, sc.CaseName)
            If sc.CaseId > 0 Then
                Continue For
            End If
            sc.CaseId = BLL.SystemCaseBLL.NewCaseId
            sc.PubDate = Now
            sc.Pindex = i
            sc.IsShowFlag = True
            sc.CaseDataTypeid = 0
            BLL.SystemCaseBLL.Add(sc)
        Next
    End Function
    Function uscAdd(userid As Integer, parentid As Integer, casename As String) As Boolean
        Dim usc As New Model.UserSystemCase
        usc.Parentid = parentid
        usc.CaseId = scbll.GetCaaseID(casename, usc.Parentid)
        usc.UserId = userid
        uscbll.AndandSave(usc)
    End Function
    Dim uscbll As New BLL.UserSystemCaseBLL
    Dim scbll As New BLL.SystemCaseBLL

    Function th_DataAdd(ByVal filename As String, ByVal tablenamestr As String) As String
 
        Dim dt As DataTable
        dt = ExcelHelper2.ImportDataTableFromExcel(filename, 0, 0)
     
        scAdd(dt, View.SystemCaseConst.DePartmentCaseId)
       
         Dim num As Integer
        Dim temperr As New StringBuilder
        Dim userBll As New BLL.UserlistBLL
        Dim user As Model.Userlist
        For Each rs As DataRow In dt.Rows

            Dim groupname, xl, xw, zc, zcdj, tel, mtel, js As String

            If IsDBNull(rs("用户名")) Then
                Exit For
            End If
            user = New Model.Userlist
            user.UserName = (Trim(rs("用户名")))
            user.Truename = Trim(rs("姓名"))
            groupname = Trim(SafeData.s_string(rs("部门")))
            js = Trim(SafeData.s_string(rs("角色")))
            If cflag Then
                user.Sex = Trim(rs("性别"))
                user.Qq = Trim(SafeData.s_string(rs("QQ")))
                user.Tel = Trim(SafeData.s_string(rs("手机全号"))) & "-" & Trim(SafeData.s_string(rs("手机短号")))
                user.Qqwx = Trim(SafeData.s_string(rs("QQWX")))
            Else
                user.Sex = "男"
            End If
            user.PubDate = Now
            user.Pwd = Security.Md5(user.UserName)
            user.State = True
            user.LoginTimes = 0
            user.LastLogin = Now
            Dim userid As Integer = userBll.Userid(user.UserName)
            user.UserId = userid
            user.RoleId = BLL.SystemCaseBLL.Caseid(View.SystemCaseConst.RoleCaseId, js)
            user = userBll.AddandSave(user)
            If groupname <> "" Then

                uscAdd(userid, View.SystemCaseConst.DePartmentCaseId, groupname)
            End If
            If js <> "" Then

                uscAdd(userid, View.SystemCaseConst.RoleCaseId, js)
            End If

            num = num + 1
         Next

     
        Dim dwz_ As New DWZJson.DWZ
        dwz_.statusCode = DWZJson.statusCode.OK
        dwz_.message = "添加用户数量" & num

        Response.Write(StringHandling.DWZJson.Alert(dwz_))
        Response.End()
    End Function

End Class