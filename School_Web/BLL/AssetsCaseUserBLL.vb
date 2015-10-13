Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class AssetsCaseUserBLL
     Shared Function ordercode() As String
        Dim t As String = Now.Date.ToString("yyyy-MM-dd").Replace("-", "")
        Dim lastcode As String = LastOrderCode()
        If lastcode = "" Then
            Return t & "-01"
        Else
            If lastcode.Contains("-") Then
                Dim a() As String = lastcode.Split("-")
                Dim n As Integer = Convert.ToInt16(a(1))
                If n > 0 And n < 10 Then
                    Return a(0) & "-0" & n + 1
                Else
                    Return a(0) & "-" & n + 1
                End If
            Else
                Return t & "-"

            End If
        End If

    End Function
    Shared Function GetId(acu As Model.AssetsCaseUser) As Integer
        Return DAL.AssetsCaseUserDAL.GetId(acu)
    End Function

    Shared Function SaveAndUpdate(acu As Model.AssetsCaseUser) As Model.AssetsCaseUser
        If acu.Id = 0 Then
            acu.Id = DAL.AssetsCaseUserDAL.GetId(acu)
        End If

        If acu.Id = 0 Then
            Return DAL.AssetsCaseUserDAL.insert(acu)
        Else
            Return DAL.AssetsCaseUserDAL.Update(acu)
        End If
    End Function
    Shared Function AddandSave(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        If Not IsExit(CU.Assetsid, CU.StateCaseId) Then
            Return insert(CU)
        Else
            Return Update2(CU)
        End If
    End Function
    Shared Function IsExit(AssetsId As Integer, StateCaseId As Integer) As Boolean
        Return DAL.AssetsCaseUserDAL.IsExit(AssetsId, StateCaseId)
    End Function

    Shared Function insert(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Return DAL.AssetsCaseUserDAL.insert(CU)
    End Function
    Shared Function Update(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Return DAL.AssetsCaseUserDAL.Update(CU)
    End Function
    Shared Function Update2(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Return DAL.AssetsCaseUserDAL.Update2(CU)

    End Function
    Shared Function UpdateCurrentSate(AssetsId As Integer, CurrentState As Integer) As Boolean
        Return DAL.AssetsCaseUserDAL.UpdateCurrentSate(AssetsId, CurrentState)
    End Function

    Shared Function del(Id As Integer) As Boolean
        Return DAL.AssetsCaseUserDAL.del(Id)
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Return DAL.AssetsCaseUserDAL.Multidel(Ids)
    End Function
    Shared Function dt() As DataTable
        Return DAL.AssetsCaseUserDAL.dt()
    End Function
    Shared Function Entity(AssetsId As Integer, CurrentState As Integer) As Model.AssetsCaseUser
        Return DAL.AssetsCaseUserDAL.Entity(AssetsId, CurrentState)
    End Function

    Shared Function Entity(Id As Integer) As Model.AssetsCaseUser
        Return DAL.AssetsCaseUserDAL.Entity(Id)
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return DAL.AssetsCaseUserDAL.PagerDt(pi)
    End Function
    Shared Function LastOrderCode() As String
        Return DAL.AssetsCaseUserDAL.LastOrderCode

    End Function
    Shared Function OrderCodeIsExit(codebar As String) As Integer
        Return DAL.AssetsCaseUserDAL.OrderCodeIsExit(codebar)

    End Function
    Shared Function Count(ast As Model.Assets, StateCaseId As Integer, Optional strWhere As String = "") As Integer
        Return DAL.AssetsCaseUserDAL.Count(ast, StateCaseId, strWhere)
    End Function

End Class
