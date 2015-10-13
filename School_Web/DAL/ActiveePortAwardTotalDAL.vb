Imports Wzsckj.com.Common
Imports System.Data.SqlClient
Imports System.Web.HttpContext
Public Class ActiveePortAwardTotalDAL
   shared Function insert(PT As Model.ActiveePortAwardTotal) As Model.ActiveePortAwardTotal
        Dim sqlPara(5) As SqlParameter
        Dim sql As String
        sql = "insert into ActiveePortAwardTotal (ActiveId,UserId,Total,ClassSortIndex,GradeSortIndex) values (@ActiveId,@UserId,@Total,@ClassSortIndex,@GradeSortIndex);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(0).Value = PT.ActiveId
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = PT.UserId
        sqlPara(2) = New SqlParameter("@Total", SqlDbType.Float)
        sqlPara(2).Value = PT.Total
        sqlPara(3) = New SqlParameter("@ClassSortIndex", SqlDbType.Int)
        sqlPara(3).Value = PT.ClassSortIndex
        sqlPara(4) = New SqlParameter("@GradeSortIndex", SqlDbType.Int)
        sqlPara(4).Value = PT.GradeSortIndex
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        PT.Id = i
        Return PT
    End Function
   shared Function Update(PT As Model.ActiveePortAwardTotal) As Model.ActiveePortAwardTotal
        Dim sqlPara(5) As SqlParameter
        Dim sql As String
        sql = "update ActiveePortAwardTotal  set ActiveId=@ActiveId,UserId=@UserId,Total=@Total,ClassSortIndex=@ClassSortIndex,GradeSortIndex=@GradeSortIndex  where  id=@id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = PT.Id
        sqlPara(1) = New SqlParameter("@ActiveId", SqlDbType.Int)
        sqlPara(1).Value = PT.ActiveId
        sqlPara(2) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(2).Value = PT.UserId
        sqlPara(3) = New SqlParameter("@Total", SqlDbType.Float)
        sqlPara(3).Value = PT.Total
        sqlPara(4) = New SqlParameter("@ClassSortIndex", SqlDbType.Int)
        sqlPara(4).Value = PT.ClassSortIndex
        sqlPara(5) = New SqlParameter("@GradeSortIndex", SqlDbType.Int)
        sqlPara(5).Value = PT.GradeSortIndex
 
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return PT
    End Function
   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveePortAwardTotal where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ActiveePortAwardTotal where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ActiveePortAwardTotal"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(ept As Model.ActiveePortAwardTotal) As DataTable
        Dim sql As String
        sql = "select * from  ActiveePortAwardTotal where ActiveId=" & ept.ActiveId

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(ept As Model.ActiveePortAwardTotal, classid As Integer) As DataTable
        Dim sql As String
        sql = "select * from  ActiveePortAwardTotal where ActiveId=" & ept.ActiveId & " and userid in (select userid from userlist where classid=" & classid & ")"

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ActiveePortAwardTotal where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.ActiveePortAwardTotal
        Return Fabricate.Fill(Of Model.ActiveePortAwardTotal)(rs(Id))
    End Function
   shared Function Entity(ept As Model.ActiveePortAwardTotal) As Model.ActiveePortAwardTotal
        Dim sql As String
        sql = "select * from  ActiveePortAwardTotal where ActiveId=" & ept.ActiveId & " and userid=" & ept.UserId


        Return Fabricate.Fill(Of Model.ActiveePortAwardTotal)(SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))
    End Function
   shared Function GetId(ept As Model.ActiveePortAwardTotal) As Integer
        Dim sql As String
        sql = "select id from  ActiveePortAwardTotal where ActiveId=" & ept.ActiveId & " and userid=" & ept.UserId
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ActiveePortAwardTotal"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function Rankdt(ep As Model.EportAward) As DataTable
        Dim sql As String
        sql = "select ActiveePortAwardTotal.*,gradeid,classid,RANK() over (order by total desc) as pm from ActiveePortAwardTotal,userlist where Userlist.UserId =ActiveePortAwardTotal.UserId and activeid= " & ep.ActiveId
        If ep.GradeId > 0 Then
            sql = sql & " and gradeid=" & ep.GradeId

        End If
        If ep.GroupId > 0 Then
            sql = sql & " and classid=" & ep.GroupId

        End If
 
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function
   shared Function TjCount(ep As Model.EportAward, cent1 As Integer, cent2 As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from ActiveePortAwardTotal  where  UserId in(select userid from userlist where classid =" & ep.GroupId & ") and activeid= " & ep.ActiveId & " and (total>" & cent1 & " and total <" & cent2 & ")"


        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function MinCent(ep As Model.EportAward) As Single
        Dim sql As String
        Dim s As String
        If ep.GradeId > 0 Then
            s = " and gradeid =" & ep.GradeId
        ElseIf ep.GroupId > 0 Then
            s = " and classid =" & ep.GroupId

        End If
        sql = "select min(total) from ActiveePortAwardTotal  where  UserId in(select userid from userlist where total>0 " & s & ") and activeid= " & ep.ActiveId
 

        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function avgCent(ep As Model.EportAward) As Single
        Dim sql As String
        Dim s As String
        If ep.GradeId > 0 Then
            s = " and gradeid =" & ep.GradeId
        ElseIf ep.GroupId > 0 Then
            s = " and classid =" & ep.GroupId

        End If
        sql = "select avg(total) from ActiveePortAwardTotal  where total>0 and   UserId in(select userid from userlist where 1=1 " & s & ") and activeid= " & ep.ActiveId

 
        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function StDevPCent(ep As Model.EportAward) As Single
        Dim sql As String
        Dim s As String
        If ep.GradeId > 0 Then
            s = " and gradeid =" & ep.GradeId
        ElseIf ep.GroupId > 0 Then
            s = " and classid =" & ep.GroupId

        End If
        sql = "select StDevP(total) from ActiveePortAwardTotal  where total>0 and    UserId in(select userid from userlist where 1=1 " & s & ") and activeid= " & ep.ActiveId


        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

   shared Function userCount(ep As Model.EportAward) As Integer
        Dim sql As String
        Dim s As String
        If ep.GradeId > 0 Then
            s = " and gradeid =" & ep.GradeId
        ElseIf ep.GroupId > 0 Then
            s = " and classid =" & ep.GroupId

        End If
        sql = "select count(userid) from ActiveePortAwardTotal  where total>0 and   UserId in(select userid from userlist where 1=1 " & s & ") and activeid= " & ep.ActiveId
 

        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function userCount(ep As Model.EportAward, typeid As Integer) As Integer
        Dim sql As String
        Dim s As String
        If ep.GradeId > 0 Then
            s = " and gradeid =" & ep.GradeId
        ElseIf ep.GroupId > 0 Then
            s = " and classid =" & ep.GroupId

        End If
        sql = "select count(userid) from ActiveePortAwardTotal  where total>0 and   UserId in(select userid from userlist where 1=1 " & s & ") and activeid= " & ep.ActiveId
        If typeid = 1 Then
            sql = sql & " and total>=" & ep.Cent
        Else
            sql = sql & " and total<=" & ep.Cent

        End If


        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

   shared Function TopPercentCent(ep As Model.EportAward, TopPercent As Integer, typeid As Integer) As Integer
        Dim sql As String
        If typeid = 1 Then
            sql = "select min(total) from ( select top " & TopPercent & " percent total from ActiveePortAwardTotal  where  UserId in(select userid from userlist where total>0 and gradeid =" & ep.GradeId & ") and activeid= " & ep.ActiveId & " order by total desc) t"
        Else
            sql = "select max(total) from (select top " & TopPercent & " percent total from ActiveePortAwardTotal  where  UserId in(select userid from userlist where total>0 and gradeid =" & ep.GradeId & ") and activeid= " & ep.ActiveId & " order by total asc) t"

        End If




        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
 
   shared Function MaxCent(ep As Model.EportAward) As Single
        Dim sql As String
        sql = "select max(total) from ActiveePortAwardTotal  where  UserId in(select userid from userlist where total>0 and gradeid =" & ep.GradeId & ") and activeid= " & ep.ActiveId



        Return StringHandling.SafeData.s_single(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

End Class
