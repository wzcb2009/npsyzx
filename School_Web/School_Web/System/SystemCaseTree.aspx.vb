Imports Wzsckj.com.Common

Public Class SystemCaseTree
    Inherits System.Web.UI.Page
    Dim bll As New BLL.SystemCaseBLL
    Dim ubll As New BLL.UserSystemCaseBLL
    Dim userid As Integer
    Dim ap As New ActionPara
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ap = ActionHelper.PageActionPara
        Dim dt As DataTable = bll.Dt()
        Dim udt As DataTable = ubll.dt(userid)

        Select Case ap.Action
            Case ActionEnum.RightSet
                treel.Text = UserCaseTree(dt, udt, ap.Parentid, "tree treeFolder treeCheck expand")
            Case ActionEnum.MultiSelect
                Dim sc As New Model.SystemCase
                sc = bll.Entity(ap.ID)
                Dim sdt As DataTable
                If sc IsNot Nothing Then
                    If sc.CaseDataTypeid = 2 Then
                        sdt = bll.Dt(sc.CaseData)
                    End If

                End If

                treel.Text = UserCaseTree2(dt, sdt, ap.Parentid, "tree treeFolder treeCheck expand")
            Case ActionEnum.Selection
                treel.Text = UserCaseTree3(dt, udt, ap.Parentid, "tree treeFolder  expand")

        End Select

    End Sub
    Function CaseTree3(ByVal dt As Data.DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs
            temp.AppendLine("<li><a href=""#""   onclick=""$.bringBack({{caseid:'" & r("caseid") & "', casename:'" & r("casename") & "'})"">" & r("casename") & "</a> ")
            temp.AppendLine(CaseTree3(dt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
    Function UserCaseTree3(ByVal dt As Data.DataTable, udt As DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs

            temp.AppendLine("<li><a href=""#""      onclick=""$.bringBack({{caseid:'" & r("caseid") & "', casename:'" & r("casename") & "'})"">" & r("casename") & "</a> ")
            temp.AppendLine(UserCaseTree3(dt, udt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
    Function CaseTree2(ByVal dt As Data.DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs
            temp.AppendLine("<li><a href=""#"" tname=""ids""   tvalue=""{caseid:'" & r("caseid") & "', casename:'" & r("casename") & "'}"">" & r("casename") & "</a> ")
            temp.AppendLine(CaseTree2(dt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
    Function UserCaseTree2(ByVal dt As Data.DataTable, udt As DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs
            Dim flag As Boolean
            flag = ubll.Haved(udt, r("caseid"))
            Dim c As String = ""
            If flag = True Then
                c = "checked"
            Else
                c = ""
            End If
            temp.AppendLine("<li><a href=""#"" " & c & " tname=""ids"",  tvalue=""{caseid:'" & r("caseid") & "', casename:'" & r("casename") & "'}"">" & r("casename") & "</a> ")
            temp.AppendLine(UserCaseTree2(dt, udt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
    Function CaseTree(ByVal dt As Data.DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs
            temp.AppendLine("<li><a href=""#"" tname=""caseid"",  tvalue=""" & r("caseid") & """ >" & r("casename") & "</a> ")
            temp.AppendLine(CaseTree(dt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
    Function UserCaseTree(ByVal dt As Data.DataTable, udt As DataTable, ByVal parentid As Integer, Optional ByVal mode As String = "") As String

        Dim rs() As Data.DataRow = dt.Select(" parentid=" & parentid)

        Dim temp As New StringBuilder

         If rs.Length > 0 Then
            If mode = "" Then
                temp.AppendLine("<ul>")
            Else
                temp.AppendLine("<ul class=""" & mode & """>")
            End If
        End If
        For Each r As DataRow In rs
            Dim flag As Boolean
            flag = ubll.Haved(udt, r("caseid"))
            Dim c As String = ""
            If flag = True Then
                c = "checked"
            Else
                c = ""
            End If
            temp.AppendLine("<li><a href=""#"" " & c & " tname=""caseid"",  tvalue=""" & r("caseid") & """ >" & r("casename") & "</a> ")
            temp.AppendLine(UserCaseTree(dt, udt, r("caseid")))
            temp.AppendLine("</li>")
        Next
        If rs.Length > 0 Then
            temp.AppendLine("</ul>")
        End If
        Return temp.ToString
    End Function
End Class