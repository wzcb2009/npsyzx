Public Class ImportBLL
    Shared Function casedt() As DataTable
        Return DAL.ImportDAL.casedt
    End Function
    Shared Function casedt(parentid As Integer) As DataTable
        Return DAL.ImportDAL.casedt(parentid)
    End Function
    Shared Function datadt(parentid As Integer) As DataTable
        Return DAL.ImportDAL.datadt(parentid)
    End Function
End Class
