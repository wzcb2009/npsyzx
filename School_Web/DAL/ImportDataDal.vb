Imports Wzsckj.com.Common

Public Class ImportDataDal
    Shared Function userlist() As DataTable
        Dim sql As String
        sql = "select * from userlist where roleid=2"
        Return SqlHelper.ExecuteDataset(ConnStr2, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function Username(userid As Integer) As String
        Dim sql As String
        sql = "select username from userlist where roleid=2 and user_id=" & userid
        Return SqlHelper.ExecuteScalar(ConnStr2, CommandType.Text, sql)

    End Function
    Shared Function subjectname(id As Integer) As String
        Dim sql As String
        sql = "select subject_name from Subject  where id= " & id
        Return SqlHelper.ExecuteScalar(ConnStr2, CommandType.Text, sql)

    End Function
    Shared Function classname(classid As Integer) As String
        Dim sql As String
        sql = "select classname from dbo.VIEW_grade_class where class_id= " & classid
        Return SqlHelper.ExecuteScalar(ConnStr2, CommandType.Text, sql)

    End Function
    Shared Function UserClasssubjectDt()
        Dim sql As String
        sql = "select * from User_Class_subject where termid=7  "
        Return SqlHelper.ExecuteDataset(ConnStr2, CommandType.Text, sql).Tables(0)

    End Function
End Class
