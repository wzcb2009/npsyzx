Imports Wzsckj.com.Common

Public Class UserInfoDo
    Inherits System.Web.UI.Page
    Dim bll As New BLL.UserlistBLL
    Dim uscBll As New BLL.UserSystemCaseBLL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ap As New ActionPara
        ap = ActionHelper.PageActionPara
        Select ap.Action
            Case ActionEnum.Add
                Dim user As New Model.Userlist
                user = GetPageEntity()
                user.UserId = 0
                user = bll.AddandSave(user)
                Dim roleids As String = Request.Form("chk_role")
                UserCaseSystemAdd(roleids, user.UserId, View.SystemCaseConst.RoleCaseId)
                Dim departmentids As String = Request.Form("chk_department")
                UserCaseSystemAdd(departmentids, user.UserId, View.SystemCaseConst.DePartmentCaseId)
 
                 
            Case ActionEnum.Modify
                Dim user As New Model.Userlist
                user = GetPageEntity(bll.GetObj(ap.ID))
                user.UserId = ap.ID
                bll.AddandSave(user)
                Dim roleids As String = Request.Form("chk_role")
                UserCaseSystemAdd(roleids, user.UserId, View.SystemCaseConst.RoleCaseId)
                UserCaseSystemDel(roleids, user.UserId, View.SystemCaseConst.RoleCaseId)
                Dim departmentids As String = Request.Form("chk_department")
                UserCaseSystemAdd(departmentids, user.UserId, View.SystemCaseConst.DePartmentCaseId)
                UserCaseSystemDel(departmentids, user.UserId, View.SystemCaseConst.DePartmentCaseId)

            Case ActionEnum.Delete
                Dim usc As New Model.UserSystemCase
                usc.UserId = ap.ID
                bll.Del(ap.ID)
            Case ActionEnum.MultiDelete
                bll.MultiDel(ap.Ids)

                For Each s As String In ap.Ids.Split(",")
                    Dim usc As New Model.UserSystemCase
                    usc.UserId = Convert.ToInt16(s)
                    usc.Parentid = 67
                    uscBll.Del(usc)
                Next
            Case ActionEnum.Login
                Dim username As String = Request.Form("username")
                Dim pwd As String = Request.Form("password")
                If pwd <> "" Then
                    pwd = StringHandling.Security.Md5(pwd)

                End If
                Dim bll As New BLL.UserlistBLL
                If bll.login(username, pwd) <> 1 Then
                    Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
                    Response.End()
                End If

            Case ActionEnum.ModPwd
                Dim old As String = Request.Form("oldPassword")
                Dim newpwd As String = Request.Form("newPassword")
                Dim bll As New BLL.UserlistBLL
                Dim u As New Model.Userlist
                u = bll.GetObj(ap.UserId)
                If u Is Nothing Then
                    Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Err))
                    Response.End()
                Else
                    If old = "" Or newpwd = "" Then
                        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
                        Response.End()
                    End If
                    If u.Pwd = StringHandling.Security.Md5(old) Then

                        u.Pwd = StringHandling.Security.Md5(newpwd)
                        bll.AddandSave(u)
                    Else
                        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.Info))
                        Response.End()


                    End If
                End If


        End Select

       

        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        Response.End()

    End Sub
    Function GetPageEntity() As Model.Userlist
        Dim user As New Model.Userlist
        user.Sex = Request.Form("drp_sex")
        user.UserName = Request.Form("txt_username")
        user.TrueName = Request.Form("txt_truename")
        user.State = Request.Form("drp_state")
        user.PubDate = Now
        user.Pwd = StringHandling.Security.Md5(Request.Form("txt_pwd"))
        user.PubDate = Now
        user.LastLogin = Now
        user.LoginTimes = 0
        Return user
    End Function
    Function GetPageEntity(ByRef user As Model.Userlist) As Model.Userlist
        user.Sex = Request.Form("drp_sex")
        user.UserName = Request.Form("txt_username")
        user.TrueName = Request.Form("txt_truename")
        user.State = Request.Form("drp_state")
        Dim pwd As String = Request.Form("txt_pwd")
        If pwd <> "" Then
            user.Pwd = StringHandling.Security.Md5(pwd)
        End If
        Return user
    End Function
    ''' <summary>
    ''' 批量设置用户对应Caseid
    ''' </summary>
    ''' <param name="roleids">caseids</param>
    ''' <param name="Userid"></param>
    ''' <param name="CaseParentid">caseids父Caseid</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UserCaseSystemDel(roleids As String, Userid As Integer, CaseParentid As Integer) As Boolean
        If roleids <> "" Then
            uscBll.BatchDelOther(Userid, roleids, CaseParentid)
        Else
            uscBll.BatchDel(Userid, CaseParentid)
        End If
    End Function
    Function UserCaseSystemAdd(roleids As String, Userid As Integer, CaseParentid As Integer) As Boolean
        If roleids = "" Then
            Return False
        End If
        Dim usc As Model.UserSystemCase
        If roleids.Contains(",") Then
            Dim ids() As String = roleids.Split(",")
            For Each id As String In ids
                usc = New Model.UserSystemCase
                usc.CaseId = Convert.ToInt16(id)
                usc.UserId = Userid
                usc.Parentid = CaseParentid
                If Not uscBll.IsExit2(usc) Then
                    uscBll.Insert(usc)
                End If
            Next
        Else
            usc = New Model.UserSystemCase
            usc.CaseId = Convert.ToInt16(roleids)
            usc.UserId = Userid
            usc.Parentid = CaseParentid
            If Not uscBll.IsExit2(usc) Then
                uscBll.Insert(usc)
            End If
        End If
    End Function

End Class