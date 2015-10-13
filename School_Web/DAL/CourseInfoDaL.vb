Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports StringHandling

Public Class CourseInfoDaL
   shared Function insert(CI As Model.CourseInfo) As Model.CourseInfo
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "insert into CourseInfo (Name,SubjectParentName,SubjectTypeName,SubjectName,SubjectObjects,TypeId,PropertyIds,LessonCount,UserId,Remark,Clicks,Pubdate) values (@Name,@SubjectParentName,@SubjectTypeName,@SubjectName,@SubjectObjects,@TypeId,@PropertyIds,@LessonCount,@UserId,@Remark,@Clicks,@Pubdate);SELECT @@IDENTITY"
        sqlpara(1) = New SqlParameter("@Name", SqlDbType.nvarchar)
        sqlpara(1).Value = CI.Name
        sqlpara(2) = New SqlParameter("@SubjectParentName", SqlDbType.nvarchar)
        sqlpara(2).Value = CI.SubjectParentName
        sqlpara(3) = New SqlParameter("@SubjectTypeName", SqlDbType.nvarchar)
        sqlpara(3).Value = CI.SubjectTypeName
        sqlpara(4) = New SqlParameter("@SubjectName", SqlDbType.nvarchar)
        sqlpara(4).Value = CI.SubjectName
        sqlpara(5) = New SqlParameter("@SubjectObjects", SqlDbType.nvarchar)
        sqlpara(5).Value = CI.SubjectObjects
        sqlpara(6) = New SqlParameter("@TypeId", SqlDbType.int)
        sqlpara(6).Value = CI.TypeId
        sqlpara(7) = New SqlParameter("@PropertyIds", SqlDbType.nvarchar)
        sqlpara(7).Value = CI.PropertyIds
        sqlpara(8) = New SqlParameter("@LessonCount", SqlDbType.int)
        sqlpara(8).Value = CI.LessonCount
        sqlpara(9) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(9).Value = CI.UserId
        sqlpara(10) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(10).Value = CI.Remark
        sqlpara(11) = New SqlParameter("@Clicks", SqlDbType.int)
        sqlpara(11).Value = CI.Clicks
        sqlpara(12) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(12).Value = CI.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        CI.ID = i
        Return CI
    End Function
   shared Function Update(CI As Model.CourseInfo) As Model.CourseInfo
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "update CourseInfo  set Name=@Name,SubjectParentName=@SubjectParentName,SubjectTypeName=@SubjectTypeName,SubjectName=@SubjectName,SubjectObjects=@SubjectObjects,TypeId=@TypeId,PropertyIds=@PropertyIds,LessonCount=@LessonCount,UserId=@UserId,Remark=@Remark,Clicks=@Clicks,Pubdate=@Pubdate  where  ID=@ID "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = CI.Id
        sqlPara(1) = New SqlParameter("@Name", SqlDbType.NVarChar)
        sqlPara(1).Value = CI.Name
        sqlPara(2) = New SqlParameter("@SubjectParentName", SqlDbType.NVarChar)
        sqlpara(2).Value = CI.SubjectParentName
        sqlpara(3) = New SqlParameter("@SubjectTypeName", SqlDbType.nvarchar)
        sqlpara(3).Value = CI.SubjectTypeName
        sqlpara(4) = New SqlParameter("@SubjectName", SqlDbType.nvarchar)
        sqlpara(4).Value = CI.SubjectName
        sqlpara(5) = New SqlParameter("@SubjectObjects", SqlDbType.nvarchar)
        sqlpara(5).Value = CI.SubjectObjects
        sqlpara(6) = New SqlParameter("@TypeId", SqlDbType.int)
        sqlpara(6).Value = CI.TypeId
        sqlpara(7) = New SqlParameter("@PropertyIds", SqlDbType.nvarchar)
        sqlpara(7).Value = CI.PropertyIds
        sqlpara(8) = New SqlParameter("@LessonCount", SqlDbType.int)
        sqlpara(8).Value = CI.LessonCount
        sqlpara(9) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(9).Value = CI.UserId
        sqlpara(10) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(10).Value = CI.Remark
        sqlpara(11) = New SqlParameter("@Clicks", SqlDbType.int)
        sqlpara(11).Value = CI.Clicks
        sqlpara(12) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(12).Value = CI.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return CI
    End Function
   shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from CourseInfo where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from CourseInfo where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  CourseInfo"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  CourseInfo where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(ID As Integer) As Model.CourseInfo
        Return Fabricate.Fill(Of Model.CourseInfo)(rs(ID))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "CourseInfo"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetId(userid As Integer) As Integer
        Dim sql As String
        sql = "select id from courseinfo where  userid=" & userid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
End Class
