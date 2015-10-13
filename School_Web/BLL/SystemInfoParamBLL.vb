Imports Model
Imports DAL
Public Class SystemInfoParamBLL
 shared  Function  AddAndSave(sip As SystemInfoParam) As SystemInfoParam
        If SystemInfoParamDAL.IsExit(1) Then
            SystemInfoParamDAL.Update(sip)

        Else

            SystemInfoParamDAL.Insert(sip)
        End If
        Return sip
    End Function
    Shared Function Name(id As Integer) As String
        Return SystemInfoParamDAL.name(id)
    End Function
    Shared Function Rs(id As Integer) As SqlClient.SqlDataReader
        Return SystemInfoParamDAL.rs(id)

    End Function
End Class
