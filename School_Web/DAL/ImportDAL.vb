Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Public Class ImportDAL
    Shared Function casedt() As DataTable
        Dim sql As String
        sql = "select * from NwebCn_NewsSort"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function casedt(parentid As Integer) As DataTable
        Dim sql As String
        sql = "select * from NwebCn_NewsSort where parentid=" & parentid

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

    Shared Function datadt(parentid As Integer) As DataTable
        Dim sql As String
        sql = "select * from NwebCn_News where SortID=" & parentid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function

End Class
