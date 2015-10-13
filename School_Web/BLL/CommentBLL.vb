Imports Wzsckj.com.Common
Imports DAL

Public Class CommentBLL

    Shared Function Dt(parentid As Integer) As DataTable
        Return CommentDAL.dt(parentid)

    End Function

    Shared Function AvgCent(parentid As Integer) As Single
        Return CommentDAL.AvgCent(parentid)

    End Function

    Shared Function PagerDt(ByRef pi As PagerInfo, parentid As Integer) As DataTable
        pi.strwhere = "parentid=" & parentid
        Return CommentDAL.PagerDt(pi)
    End Function
    Shared Function Rs(id As Integer) As SqlClient.SqlDataReader
        Return CommentDAL.Rs(id)
    End Function
    Shared Function AddandMod(c As Model.Comment) As Model.Comment
        If c.Id = 0 Then
            Return CommentDAL.insert(c)

        Else
            Return CommentDAL.Update(c)
        End If
    End Function
    Shared Function Del(id As Integer) As Boolean
        Return CommentDAL.del(id)
    End Function
    Shared Function MultiDel(ids As String) As Boolean
        Return CommentDAL.MultiDel(ids)
    End Function
End Class
