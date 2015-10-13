Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class BlogInfoDAL
    Shared Function insert(BI As Model.BlogInfo) As Model.BlogInfo
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "insert into BlogInfo (Title,SecondTitle,Remark,UserId,Nickname,TempPath,Username,TrueName,Pubdate,Clicks,LevelId) values (@Title,@SecondTitle,@Remark,@UserId,@Nickname,@TempPath,@Username,@TrueName,@Pubdate,@Clicks,@LevelId);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(0).Value = BI.Title
        sqlPara(1) = New SqlParameter("@SecondTitle", SqlDbType.NVarChar)
        sqlPara(1).Value = BI.SecondTitle
        sqlPara(2) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(2).Value = BI.Remark
        sqlPara(3) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(3).Value = BI.UserId
        sqlPara(4) = New SqlParameter("@Nickname", SqlDbType.NVarChar)
        sqlPara(4).Value = BI.Nickname
        sqlPara(5) = New SqlParameter("@TempPath", SqlDbType.NVarChar)
        sqlPara(5).Value = BI.TempPath
        sqlPara(6) = New SqlParameter("@Username", SqlDbType.NVarChar)
        sqlPara(6).Value = BI.Username
        sqlPara(7) = New SqlParameter("@TrueName", SqlDbType.NVarChar)
        sqlPara(7).Value = BI.TrueName
        sqlPara(8) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(8).Value = BI.Pubdate
        sqlPara(9) = New SqlParameter("@Clicks", SqlDbType.Int)
        sqlPara(9).Value = BI.Clicks
        sqlPara(10) = New SqlParameter("@LevelId", SqlDbType.Int)
        sqlPara(10).Value = BI.LevelId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        BI.Id = i
        Return BI
    End Function
    Shared Function Update(BI As Model.BlogInfo) As Model.BlogInfo
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "update BlogInfo  set Title=@Title,SecondTitle=@SecondTitle,Remark=@Remark,Nickname=@Nickname,TempPath=@TempPath,Username=@Username,TrueName=@TrueName,Pubdate=@Pubdate,Clicks=@Clicks,LevelId=@LevelId  where  UserId=@UserId "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = BI.Id
        sqlPara(1) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(1).Value = BI.Title
        sqlPara(2) = New SqlParameter("@SecondTitle", SqlDbType.NVarChar)
        sqlPara(2).Value = BI.SecondTitle
        sqlPara(3) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(3).Value = BI.Remark
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = BI.UserId
        sqlPara(5) = New SqlParameter("@Nickname", SqlDbType.NVarChar)
        sqlPara(5).Value = BI.Nickname
        sqlPara(6) = New SqlParameter("@TempPath", SqlDbType.NVarChar)
        sqlPara(6).Value = BI.TempPath
        sqlPara(7) = New SqlParameter("@Username", SqlDbType.NVarChar)
        sqlPara(7).Value = BI.Username
        sqlPara(8) = New SqlParameter("@TrueName", SqlDbType.NVarChar)
        sqlPara(8).Value = BI.TrueName
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = BI.Pubdate
        sqlPara(10) = New SqlParameter("@Clicks", SqlDbType.Int)
        sqlPara(10).Value = BI.Clicks
        sqlPara(11) = New SqlParameter("@LevelId", SqlDbType.Int)
        sqlPara(11).Value = BI.LevelId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return BI
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from BlogInfo where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from BlogInfo where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  BlogInfo"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  BlogInfo where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function rsByUserid(UserId As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  BlogInfo where UserId=" & UserId
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function EntityByUserid(Id As Integer) As Model.BlogInfo
        Return Fabricate.Fill(Of Model.BlogInfo)(rsByUserid(Id))
    End Function

    Shared Function Entity(Id As Integer) As Model.BlogInfo
        Return Fabricate.Fill(Of Model.BlogInfo)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "BlogInfo"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function IsExit(userid As Integer) As Boolean
        Dim sql As String
        sql = "select count(*) from  BlogInfo where userid =" & userid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql) > 0

    End Function

End Class
