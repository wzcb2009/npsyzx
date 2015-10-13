Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Data.OleDb

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim sql As String = "select * from pe_class where parentid=@parentid"
            Dim sqlPara(0) As OleDb.OleDbParameter
            sqlPara(0) = New OleDb.OleDbParameter("@parentid", OleDbType.VarChar)
            sqlPara(0).Value = 0

            Dim dt As DataTable = OLEHelper.ExecuteDataSet(sql, sqlPara).Tables(0)


            BindHelper.Bind(DropDownList1, dt, "classid", "classname")

        End If
    End Sub
    Function caseadd(parentid As Integer, newparentid As Integer) As Boolean
        Dim sql As String = "select * from pe_class where parentid=@parentid"
        Dim sqlPara(0) As OleDb.OleDbParameter
        sqlPara(0) = New OleDb.OleDbParameter("@parentid", OleDbType.VarChar)
        sqlPara(0).Value = parentid
        Dim dt As DataTable = OLEHelper.ExecuteDataSet(sql, sqlPara).Tables(0)
        Dim sc As Model.SystemCase

        For Each r As DataRow In dt.Rows
            sc = New Model.SystemCase
            sc.ParentId = newparentid
            Dim oldcaseid As Integer = r("classid")
            sc.CaseId = scbll.NewCaseId
            sc.CaseName = r("classname")
            sc.Pindex = r("OrderID")
            sc.PubDate = Now
            scbll.Add(sc)
            newsadd(oldcaseid, sc.CaseId)

            caseadd(oldcaseid, sc.CaseId)
        Next
    End Function
    Public ConnStr As String = System.Configuration.ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

    Function lastnewsadd() As Boolean
        Dim sql As String
        sql = "select * from dbo.PE_Article where DATEDIFF (day, '2013-10-1',createtime)>0"
        Dim dt As DataTable = SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
        Dim dm As Model.DataMain

        For Each r As Data.DataRow In dt.Rows
            Dim caseid As Integer = r("classid")
            Dim casename2 As String = casename(caseid)
            Dim newcaseid As Integer = scbll.CaseidByName(casename2)
            dm = New Model.DataMain
            dm.Caseid = newcaseid
            dm.Title = r("title")
            dm.Author = r("author")
            dm.Remark = r("keyword")
            dm.BrowCount = r("hits")
            dm.Content = r("content")
            dm.Status = IIf(r("status") = 3, True, False)
            dm.PubDate = r("CreateTime")
            dm.EndDate = r("CreateTime")
            dmbll.AddandSave(dm)
        Next
    End Function
    Function casename(caseid As Integer) As String
        Dim sql As String
        sql = "select classname from pe_class where classid= " & caseid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
    Function newsadd(caseid As Integer, newcaseid As Integer) As Boolean
        Dim sql As String
        sql = "select * from pe_article where classid=@caseid"
        Dim sqlPara(0) As OleDb.OleDbParameter
        sqlPara(0) = New OleDb.OleDbParameter("@caseid", OleDbType.VarChar)
        sqlPara(0).Value = caseid

        Dim dt As DataTable = OLEHelper.ExecuteDataSet(sql, sqlPara).Tables(0)
        Dim dm As Model.DataMain

        For Each r As DataRow In dt.Rows
            dm = New Model.DataMain
            dm.Caseid = newcaseid
            dm.Title = r("title")
            dm.Author = r("author")
            dm.Remark = r("keyword")
            dm.BrowCount = r("hits")
            dm.Content = r("content")
            dm.Status = IIf(r("status") = 3, True, False)
            dm.PubDate = r("CreateTime")
            dm.EndDate = r("CreateTime")
            dmbll.AddandSave(dm)
        Next
    End Function
    Dim dmbll As New BLL.DataMainBLL
    Dim scbll As New BLL.SystemCaseBLL
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        caseadd(1, 93)


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dmbll As New BLL.DataMainBLL
        Dim fileBll As New BLL.FilelistBLL
        Dim dt As DataTable = dmbll.Dt(DropDownList1.SelectedValue, 1000)
        Dim dm As Model.DataMain
        Dim file As Model.FileList
        Dim i As Integer
        For Each r As DataRow In dt.Rows
            dm = New Model.DataMain
            dm = dmbll.Entity(r("id"))
            dm.Content = Trim(dm.Content)

            If dm.Content.Length = 0 Then
                Continue For
            End If
            If dm.Content.StartsWith("upload/") Then
                file = New Model.FileList
                file.Title = dm.Title
                file.Parentid = dm.Id
                file.ProjectId = dm.Caseid
                file.Ext = IO.Path.GetExtension(dm.Content).Replace(".", "")
                file.Pubdate = dm.PubDate
                file.Path = dm.Content
                fileBll.Add(file)
                dm.Content = ""
                dmbll.AddandSave(dm)
                i = i + 1
            End If

        Next
        Response.Write(i)

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modsc(16)

    End Sub
    Function modsc(parentid As Integer)
        Dim dt As DataTable = scbll.Dt(parentid)
        Dim sc As Model.SystemCase
        For Each r As DataRow In dt.Rows
            Dim caseid As Int16 = r("caseid")
            sc = New Model.SystemCase
            sc = scbll.Entity(caseid)
            If scbll.HaveSub(caseid) Then
                sc.CaseData = 6
            Else
                sc.CaseData = 7

            End If
            scbll.Modify(sc)

            modsc(caseid)

        Next

    End Function

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dt As DataTable = dmbll.Dt(0, 10000)
        Response.Write(dt.Rows.Count)

        For Each r As DataRow In dt.Rows
            Dim dm As New Model.DataMain
            dm = dmbll.Entity(r("id"))
            dm.Content = Replace(dm.Content, "[InstallDir_ChannelDir]{$UploadDir}", "/Article/UploadFiles")
            dmbll.AddandSave(dm)
        Next
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lastnewsadd()

    End Sub
End Class