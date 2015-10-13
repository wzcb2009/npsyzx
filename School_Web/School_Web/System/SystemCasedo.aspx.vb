Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Data.OleDb

Public Class SystemCasedo
    Inherits System.Web.UI.Page

    Dim ap As New ActionPara
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
       

        Select Case ap.Action
            Case ActionEnum.Add
                add()
            Case ActionEnum.BatchAdd
                bacthAdd()
            Case ActionEnum.Move
                move()
            Case ActionEnum.RightSet
                RightSet()
            Case ActionEnum.Modify
                SC = bll.Entity(ap.ID)
                modify()
            Case ActionEnum.Delete
                bll.Del(ap.ID)
            Case ActionEnum.MultiDelete
                bll.MultiDel(ap.Ids)
            Case ActionEnum.Copy
                copy()
        End Select
        Response.Write(StringHandling.DWZJson.Alert(StringHandling.DWZJson.statusCode.OK))
        Response.End()

    End Sub
    Sub RightSet()
        Dim bll As New BLL.UserSystemCaseBLL
        Dim caseids_ As String = ap.Ids
        Dim udt As DataTable = bll.dt(ap.UserId)
        If caseids_ <> "" Then
            bll.BatchDelOther(ap.UserId, caseids_)
            Dim caseids() As String
            If caseids_.Contains(",") Then
                caseids = Split(caseids_, ",")
                For Each caseid As Integer In caseids
                    Dim usc As New Model.UserSystemCase
                    usc.CaseId = caseid
                    ' usc.Parentid = bll.Parentid(udt, caseid)
                    usc.UserId = ap.UserId
                    bll.AndandSave(usc)
                Next
            Else
                Dim usc As New Model.UserSystemCase
                usc.CaseId = caseids_
                ' usc.Parentid = bll.Parentid(udt, caseids_)
                usc.UserId = ap.UserId
                bll.AndandSave(usc)
            End If


        End If


    End Sub
    Sub move()

        If ap.Caseid = 0 Then
            ap.Caseid = ap.ID
        End If
        If ap.Parentid <> ap.Caseid Then
            Dim pindex As Integer = bll.pIndex(ap.Parentid)
            bll.Move(ap.Caseid, pindex, ap.Parentid)
        End If

    End Sub
    Function GetPageEntity2() As Model.SystemCase
        SC.Pindex = Request.Form("txt_Pindex")
        SC.CaseName = Request.Form("txt_CaseName")
        SC.IsShowFlag = Request.Form("drp_isShowFlag")
        SC.CaseDataTypeid = 1
        Dim baseurl As String = "|../project/ProjectListWeb.aspx?ParentId={parentid}|navTab"
        SC.CaseData = baseurl.Replace("{parentid}", Request.Form("casedata_caseid"))
        Return SC
    End Function
    Dim bll As New BLL.SystemCaseBLL
    Dim SC As New Model.SystemCase
    Function GetPageEntity() As Model.SystemCase
        SC.Pindex = Request.Form("txt_Pindex")
        SC.CaseName = Request.Form("txt_CaseName")
        SC.IsShowFlag = Request.Form("drp_isShowFlag")
        SC.CaseDataTypeid = Request.Form("drp_casedatatypeid")
        If SC.CaseDataTypeid = 2 Then
            SC.CaseData = Request.Form("sc.caseid")
        Else
            SC.CaseData = Request.Form("sc.casename")

        End If
        Return SC
    End Function
    Sub copy()
        Dim sc As New Model.SystemCase
        sc = GetPageEntity2()
        sc.ParentId = ap.Parentid
        sc.CaseId = bll.NewCaseId
        sc.PubDate = Now
        sc = bll.Add(sc)
        Dim parentid As Integer = 160 '教学改革研究项目
        Dim dt As DataTable = bll.Dt(parentid)
        For Each r As DataRow In dt.Rows
            Dim sctemp As New Model.SystemCase
            sctemp.CaseId = bll.NewCaseId
            sctemp.CaseName = r("casename")
            sctemp.ParentId = sc.CaseId
            sctemp.IsShowFlag = SafeData.s_Boolean(r("IsShowFlag"))
            sctemp.Pindex = r("pindex")
            sctemp.CaseData = r("casedata")
            sctemp.CaseDataTypeid = r("CaseDataTypeid")
            sctemp.PubDate = r("pubdate")
            bll.Add(sctemp)
        Next
        dt.Dispose()
    End Sub
    Sub add()
        Dim sc As New Model.SystemCase
        sc = GetPageEntity()
        If sc.CaseName.Contains(" ") Then
            Dim ss() As String = Trim(sc.CaseName).Split(" ")
            For Each s As String In ss
                sc.CaseName = s
                sc.ParentId = ap.Parentid
                sc.CaseId = bll.NewCaseId
                sc.PubDate = Now
                bll.Add(sc)

            Next
        Else

            sc.ParentId = ap.Parentid
            sc.CaseId = bll.NewCaseId
            sc.PubDate = Now
            bll.Add(sc)
        End If

    End Sub
    Sub modify()
        Dim sc As New Model.SystemCase
        sc = GetPageEntity()
        sc.ParentId = ap.Parentid
        sc.CaseId = ap.ID
        sc.PubDate = Now

        bll.Modify(sc)
    End Sub
    Sub bacthAdd()
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
        th_DataAdd(fullpath, "Sheet1$", ap.Parentid)
    End Sub
    Function scAdd(rs As OleDbDataReader, parentid As Integer)
        Dim bll As New BLL.SystemCaseBLL
        Dim i As Integer
        Dim num As Integer
        While rs.Read
            i = i + 1
            Dim sc As New Model.SystemCase
            sc.CaseId = bll.NewCaseId
            sc.CaseName = rs("栏目名称")
            sc.PubDate = Now
            sc.Pindex = i
            sc.IsShowFlag = True
            sc.CaseDataTypeid = 0
            sc.CaseData = rs("备注")
            sc.ParentId = parentid
            If bll.GetCaaseID(sc.CaseName, sc.ParentId) = 0 Then
                num = num + 1
                bll.Add(sc)
            End If
        End While
        rs.Close()
        Return num
    End Function
    Function th_DataAdd(ByVal filename As String, ByVal tablenamestr As String, parentid As Integer) As String
        Dim conMyData As OleDbConnection
        Dim cmdselect As OleDbCommand
        Dim rs As OleDbDataReader
        conMyData = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & filename & ";Extended Properties=""Excel 8.0;""")
        conMyData.Open()
        cmdselect = New OleDbCommand("SELECT *     FROM  [" & tablenamestr & "]", conMyData)
        rs = cmdselect.ExecuteReader()
        Dim num As Integer = scAdd(rs, parentid)
        Dim dwz_ As New DWZJson.DWZ
        dwz_.statusCode = DWZJson.statusCode.OK
        dwz_.message = "导入记录" & num & "条！"

        Response.Write(StringHandling.DWZJson.Alert(dwz_))
        Response.End()
    End Function

End Class