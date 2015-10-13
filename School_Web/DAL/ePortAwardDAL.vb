Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports System.Web.HttpContext
Public Class ePortAwardDAL
    Shared Function insert(P As Model.EportAward) As Model.EportAward
        Dim sqlPara(24) As SqlParameter
        Dim sql As String
        sql = "insert into ePortAward (ActiveId,UserId,Truename,Title,YearNum,TermId,GradeCaseId,LevelCaseId,Caseid,ParentCaseid,FilePath,Pubdate,UserChecked,Cent,Credit,Remark,MoneyNum,AdminChecked,SortIndex,Pindex,DepartmentId,GradeId,GroupId,ObjectFlag) values (@ActiveId,@UserId,@Truename,@Title,@YearNum,@TermId,@GradeCaseId,@LevelCaseId,@Caseid,@ParentCaseid,@FilePath,@Pubdate,@UserChecked,@Cent,@Credit,@Remark,@MoneyNum,@AdminChecked,@SortIndex,@Pindex,@DepartmentId,@GradeId,@GroupId,@ObjectFlag);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(0).Value = P.ActiveId
        sqlpara(1) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(1).Value = P.UserId
        sqlpara(2) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(2).Value = P.Truename
        sqlpara(3) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(3).Value = P.Title
        sqlpara(4) = New SqlParameter("@YearNum", SqlDbType.int)
        sqlpara(4).Value = P.YearNum
        sqlpara(5) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(5).Value = P.TermId
        sqlpara(6) = New SqlParameter("@GradeCaseId", SqlDbType.int)
        sqlpara(6).Value = P.GradeCaseId
        sqlpara(7) = New SqlParameter("@LevelCaseId", SqlDbType.int)
        sqlpara(7).Value = P.LevelCaseId
        sqlpara(8) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(8).Value = P.Caseid
        sqlpara(9) = New SqlParameter("@ParentCaseid", SqlDbType.int)
        sqlpara(9).Value = P.ParentCaseid
        sqlpara(10) = New SqlParameter("@FilePath", SqlDbType.nvarchar)
        sqlpara(10).Value = P.FilePath
        sqlpara(11) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(11).Value = P.Pubdate
        sqlpara(12) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(12).Value = P.UserChecked
        sqlpara(13) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(13).Value = P.Cent
        sqlpara(14) = New SqlParameter("@Credit", SqlDbType.float)
        sqlpara(14).Value = P.Credit
        sqlpara(15) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(15).Value = P.Remark
        sqlpara(16) = New SqlParameter("@MoneyNum", SqlDbType.Decimal)
        sqlpara(16).Value = P.MoneyNum
        sqlpara(17) = New SqlParameter("@AdminChecked", SqlDbType.bit)
        sqlpara(17).Value = P.AdminChecked
        sqlpara(18) = New SqlParameter("@SortIndex", SqlDbType.int)
        sqlpara(18).Value = P.SortIndex
        sqlpara(19) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(19).Value = P.Pindex
        sqlpara(20) = New SqlParameter("@DepartmentId", SqlDbType.int)
        sqlpara(20).Value = P.DepartmentId
        sqlpara(21) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(21).Value = P.GradeId
        sqlpara(22) = New SqlParameter("@GroupId", SqlDbType.int)
        sqlpara(22).Value = P.GroupId
        sqlpara(23) = New SqlParameter("@ObjectFlag", SqlDbType.bit)
        sqlpara(23).Value = P.ObjectFlag
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        P.Id = i
        Return P
    End Function
    Shared Function Update(P As Model.EportAward) As Model.EportAward
        Dim sqlPara(24) As SqlParameter
        Dim sql As String
        sql = "update ePortAward  set ActiveId=@ActiveId,UserId=@UserId,Truename=@Truename,Title=@Title,YearNum=@YearNum,TermId=@TermId,GradeCaseId=@GradeCaseId,LevelCaseId=@LevelCaseId,Caseid=@Caseid,ParentCaseid=@ParentCaseid,FilePath=@FilePath,Pubdate=@Pubdate,UserChecked=@UserChecked,Cent=@Cent,Credit=@Credit,Remark=@Remark,MoneyNum=@MoneyNum,AdminChecked=@AdminChecked,SortIndex=@SortIndex,Pindex=@Pindex,DepartmentId=@DepartmentId,GradeId=@GradeId,GroupId=@GroupId,ObjectFlag=@ObjectFlag  where  Id=@Id "
        sqlpara(0) = New SqlParameter("@Id", SqlDbType.int)
        sqlpara(0).Value = P.Id
        sqlpara(1) = New SqlParameter("@ActiveId", SqlDbType.int)
        sqlpara(1).Value = P.ActiveId
        sqlpara(2) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(2).Value = P.UserId
        sqlpara(3) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(3).Value = P.Truename
        sqlpara(4) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(4).Value = P.Title
        sqlpara(5) = New SqlParameter("@YearNum", SqlDbType.int)
        sqlpara(5).Value = P.YearNum
        sqlpara(6) = New SqlParameter("@TermId", SqlDbType.int)
        sqlpara(6).Value = P.TermId
        sqlpara(7) = New SqlParameter("@GradeCaseId", SqlDbType.int)
        sqlpara(7).Value = P.GradeCaseId
        sqlpara(8) = New SqlParameter("@LevelCaseId", SqlDbType.int)
        sqlpara(8).Value = P.LevelCaseId
        sqlpara(9) = New SqlParameter("@Caseid", SqlDbType.int)
        sqlpara(9).Value = P.Caseid
        sqlpara(10) = New SqlParameter("@ParentCaseid", SqlDbType.int)
        sqlpara(10).Value = P.ParentCaseid
        sqlpara(11) = New SqlParameter("@FilePath", SqlDbType.nvarchar)
        sqlpara(11).Value = P.FilePath
        sqlpara(12) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(12).Value = P.Pubdate
        sqlpara(13) = New SqlParameter("@UserChecked", SqlDbType.bit)
        sqlpara(13).Value = P.UserChecked
        sqlpara(14) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(14).Value = P.Cent
        sqlpara(15) = New SqlParameter("@Credit", SqlDbType.float)
        sqlpara(15).Value = P.Credit
        sqlpara(16) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(16).Value = P.Remark
        sqlpara(17) = New SqlParameter("@MoneyNum", SqlDbType.Decimal)
        sqlpara(17).Value = P.MoneyNum
        sqlpara(18) = New SqlParameter("@AdminChecked", SqlDbType.bit)
        sqlpara(18).Value = P.AdminChecked
        sqlpara(19) = New SqlParameter("@SortIndex", SqlDbType.int)
        sqlpara(19).Value = P.SortIndex
        sqlpara(20) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(20).Value = P.Pindex
        sqlpara(21) = New SqlParameter("@DepartmentId", SqlDbType.int)
        sqlpara(21).Value = P.DepartmentId
        sqlpara(22) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(22).Value = P.GradeId
        sqlpara(23) = New SqlParameter("@GroupId", SqlDbType.int)
        sqlpara(23).Value = P.GroupId
        sqlpara(24) = New SqlParameter("@ObjectFlag", SqlDbType.bit)
        sqlpara(24).Value = P.ObjectFlag
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return P
    End Function
   shared Function UpdateGroupid(groupid As Integer, Ids As String) As Boolean
        Dim sql As String
        sql = "update     ePortAward set groupid=" & groupid & " where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function

   shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(Ids As String) As Boolean
        Dim sql As String
        sql = "delete   from ePortAward where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  ePortAward"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  ePortAward where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(Id As Integer) As Model.EPortAward
        Return Fabricate.Fill(Of Model.EPortAward)(rs(Id))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "ePortAward"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetCount(p As Model.EportAward) As Integer
        Dim sql As String
        sql = "select count(*) from  ePortAward where caseid=" & p.Caseid & "and YearNum=" & p.YearNum
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
        If p.GradeCaseId > 0 Then
            sql = sql & "  and gradeCaseId=" & p.GradeCaseId

        End If

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function GetCount(p As Model.EportAward, StrWhere As String) As Integer
        Dim sql As String
        sql = "select count(*) from  ePortAward where caseid=" & p.Caseid
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
        If p.GradeCaseId > 0 Then
            sql = sql & "  and gradeCaseId=" & p.GradeCaseId

        End If
        If StrWhere <> "" Then
            sql = sql & StrWhere

        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function

   shared Function GetId(p As Model.EportAward) As Integer
        Dim sql As String
        sql = "select id from  ePortAward where caseid=" & p.Caseid & " and Activeid=" & p.ActiveId
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
    
        Current.Response.Write(sql)

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function UpdateAreaIdRest(ep As Model.EportAward) As Boolean
        Dim sql As String = "update eportAward set areaid =" & ep.AreaId & " where    activeid=" & ep.ActiveId & " and caseid=" & ep.Caseid & "   "

        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0

    End Function
   shared Function UpdateAreaId(ep As Model.EportAward, topnum As Integer) As Boolean
        Dim sql As String = "update eportAward set areaid =" & ep.AreaId & " where  id in (select top " & topnum & " id from eportaward where activeid=" & ep.ActiveId & " and caseid=" & ep.Caseid & " and areaid=0 order by pindex asc )"


        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0


    End Function


   shared Function Entity(p As Model.EportAward) As Model.EportAward
        Dim sql As String
        sql = "select * from  ePortAward where Activeid=" & p.ActiveId
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
        If p.Caseid > 0 Then
            sql = sql & " and  caseid=" & p.Caseid
        End If


        Return Fabricate.Fill(Of Model.EportAward)(SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function
   shared Function ClassDt(p As Model.EportAward, Optional orderStr As String = "pindex asc") As DataTable
        Dim sql As String
        sql = "select caseid,casename from systemcase where caseid in (select classid from userlist where userid in (select userid  from  ePortAward where 1=1"
        If p.Caseid > 0 Then
            sql = sql & " and Caseid=" & p.Caseid

        End If
        If p.ActiveId > 0 Then
            sql = sql & " and ActiveId=" & p.ActiveId

        End If
        If p.AreaId > 0 Then
            sql = sql & " and AreaId=" & p.AreaId

        End If
        If p.YearNum > 0 Then
            sql = sql & " and YearNum=" & p.YearNum

        End If
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
        If p.GradeCaseId > 0 Then
            sql = sql & "  and gradeCaseId=" & p.GradeCaseId

        End If
        If p.GroupId > 0 Then
            sql = sql & "  and GroupId=" & p.GroupId

        End If



        sql = sql & ")) order by " & orderStr


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function

   shared Function Dt(p As Model.EportAward, Optional orderStr As String = "pindex asc") As DataTable
        Dim sql As String
        sql = "select newid() as newid_, *  from  ePortAward where 1=1"
        If p.Caseid > 0 Then
            sql = sql & " and Caseid=" & p.Caseid

        End If
        If p.ActiveId > 0 Then
            sql = sql & " and ActiveId=" & p.ActiveId

        End If
        If p.AreaId > 0 Then
            sql = sql & " and AreaId=" & p.AreaId

        End If
        If p.YearNum > 0 Then
            sql = sql & " and YearNum=" & p.YearNum

        End If
        If p.UserId > 0 Then
            sql = sql & " and userid=" & p.UserId

        End If
        If p.GradeCaseId > 0 Then
            sql = sql & "  and gradeCaseId=" & p.GradeCaseId

        End If
        If p.GroupId > 0 Then
            sql = sql & "  and GroupId=" & p.GroupId

        End If



        sql = sql & " order by " & orderStr
         Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)

    End Function
   shared Function RankDT(ep As Model.EportAward) As DataTable
        Dim sql As String
        sql = "select rank()  over(order by cent desc) as row_number,userid from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    GroupId= " & ep.GroupId
        End If


        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function TjCount(ep As Model.EportAward, cent1 As Integer, cent2 As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid & " and (cent>=" & cent1 & " and cent<" & cent2 & ")"
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If




        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function UserCount(ep As Model.EportAward) As Integer
        Dim sql As String
        sql = "select count(*) from ePortAward where ActiveId=" & ep.ActiveId
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        If ep.Caseid > 0 Then
            sql = sql & " and    Caseid= " & ep.Caseid
        End If




        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function UserCount(ep As Model.EportAward, typeid As Integer) As Integer
        Dim sql As String
        sql = "select count(*) from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        If ep.Cent > 0 Then
            If typeid = 1 Then

                sql = sql & " and    Cent>=" & ep.Cent
            Else
                sql = sql & " and    Cent<=" & ep.Cent

            End If
        End If




        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function

   shared Function MinCent(ep As Model.EportAward, type As Integer) As Single
        Dim sql As String
        sql = "select min(cent) from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function avgCent(ep As Model.EportAward) As Single
        Dim sql As String
        sql = "select avg(cent) from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function StDevPCent(ep As Model.EportAward) As Single
        Dim sql As String
        sql = "select StDevP(cent) from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function
   shared Function TopPercentCent(ep As Model.EportAward, topPercent As Integer, type As Integer) As Single
        Dim sql As String
        If type = 1 Then
            sql = "select min(cent) from ("
        Else
            sql = "select max(cent) from ("

        End If
        sql = sql & "select top " & topPercent & " percent cent from ePortAward where ActiveId=" & ep.ActiveId & " and  Caseid= " & ep.Caseid
        If ep.GradeId > 0 Then
            sql = sql & " and    GradeId= " & ep.GradeId
        End If
        If ep.GroupId > 0 Then
            sql = sql & " and    groupid= " & ep.GroupId
        End If
        If type = 1 Then
            sql = sql & " order by cent desc"

        Else
            sql = sql & " order by cent asc"

        End If
        sql = sql & ") t"
       

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End Function

   shared Function SumDt(ep As Model.EportAward) As DataTable
        Dim sql As String
        sql = "select  activeid,userid,SUM(cent) as zf   from ePortAward where ActiveId=" & ep.ActiveId & "  group by activeid,UserId "
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

End Class
