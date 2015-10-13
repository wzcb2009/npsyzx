Imports StringHandling
Imports View

Public Class WebCase
    Inherits System.Web.UI.Page

    Dim CaseID, CurCaseid As Integer
    Dim ucPath As String = "uc/"
    Dim scbll As New BLL.SystemCaseBLL
    Dim dmbll As New BLL.DataMainBLL
    Dim scView As New SystemCaseView


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim memoryUsage As Double = ((System.Diagnostics.Process.GetCurrentProcess().WorkingSet64) / 1024) / 1024
        'Response.Write(memoryUsage)
        'Response.End()
        CaseID = Request.QueryString("caseId")
        If Not IsPostBack Then


            '获取栏目定义数据，如果有数据定义重新复制caseid值，否则原值

            Dim typeid As Integer = SafeData.s_integer(scbll.CaseData(CaseID))

            If typeid = 0 Then
                typeid = CaseType.Categories

            End If
            If typeid = CaseType.Categories Then
                If scbll.subcount(CaseID, CaseType.Content) > 0 Then
                    CurCaseid = scbll.Caseid(CaseID)

                End If
            End If
            Dim dt As DataTable = scbll.Dt

            If typeid = CaseType.Categories Then
                lt_nav.Text = scView.WebNav(dt, CaseID, "", CurCaseid)

            Else

                Dim parentid As Integer
                parentid = scbll.Parentid(CaseID)


                If parentid > 0 And parentid <> SystemCaseConst.WebTopCaseid Then
                    lt_nav.Text = scView.WebNav(dt, parentid, "", CaseID)
                Else
                    lt_nav.Text = scView.WebNav(dt, CaseID, "", CaseID)

                End If

            End If
            If CurCaseid > 0 Then
                CaseID = CurCaseid
                typeid = SafeData.s_integer(scbll.CaseData(CaseID))
            End If
            lt_sitenav.Text = scView.WebNavPositon(dt, CaseID, CurCaseid)

            If typeid = CaseType.Content Then
                Dim dm As New Model.DataMain
                dm = dmbll.EntityByCaseId(CaseID)
                If dm IsNot Nothing Then
                    lt_Continer.Text = dm.Content

                End If
            ElseIf typeid = CaseType.IndexPage Then
                Dim dm As New Model.DataMain
                dm = dmbll.EntityByCaseId(CaseID)
                If dm IsNot Nothing Then
                    Dim urlstr As String = dm.Content
                    If urlstr <> "" Then
                        Response.Redirect(urlstr)
                    Else
                        Response.Redirect("default.aspx")
                    End If
                End If

            Else
                If typeid = CaseType.Categories Then
                    ShowClass(CaseID)
                Else
                    Dim user As New UC_NewslistMore
                    user = Me.LoadControl(ucPath & "UC_NewslistMore.ascx")
                    user.Caseid = CaseID
                    user.Typeid = typeid
                    PH.Controls.Add(user)
                    If typeid = CaseType.BBS Then
                        Dim vl As New View.DataMainView
                        ' lt_userlist.Text = vl.UserFacelist(CaseID)

                    End If


                End If

            End If
        End If



    End Sub

    Sub ShowClass(ByVal caseid As Integer)
        Dim dt As DataTable = scbll.Dt(caseid)
        Dim i As Integer
        i = 0
        For Each r As Data.DataRow In dt.Rows
            Dim typeid As Integer = SafeData.s_integer(r("casedata"))
            If typeid = CaseType.Content Then
                Continue For
            End If
            i = i + 1
            Dim sc As New Model.SystemCase
            sc = scbll.Entity(r("caseid"))
            Dim user As New UC_Newslist
            user = Me.LoadControl(ucPath & "UC_Newslist.ascx")
            user.Caseid = sc.CaseId
            user.Typeid = typeid
            user.BoxCss = "span6"
            'If i Mod 2 = 1 Then
            '    user.StartString = "<div class=""row-fluid"">"
            'Else
            '    user.EndString = "</div>"


            'End If

            PH.Controls.Add(user)
        Next

        dt.Dispose()


    End Sub

End Class