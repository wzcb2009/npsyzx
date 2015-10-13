Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class GuestBookDAL
   shared Function insert(GB As Model.GuestBook) As Model.GuestBook
        Dim sqlPara(11) As SqlParameter
        Dim sql As String
        sql = "insert into GuestBook (Caseid,Name,Tel,eMail,QQ,CodeNum,Address,Title,Remark,Sequence,PostDate,PostIP,Reply,ReplyDate,ReplyIP,IsShow) values (@Caseid,@Name,@Tel,@eMail,@QQ,@CodeNum,@Address,@Title,@Remark,@Sequence,@PostDate,@PostIP,@Reply,@ReplyDate,@ReplyIP,@IsShow);SELECT @@IDENTITY"
        sqlPara(1) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(1).Value = GB.Caseid
        sqlPara(2) = New SqlParameter("@Name", SqlDbType.NVarChar)
        sqlPara(2).Value = GB.Name
        sqlPara(3) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(3).Value = GB.Tel
        sqlPara(4) = New SqlParameter("@eMail", SqlDbType.NVarChar)
        sqlPara(4).Value = GB.EMail
        sqlPara(5) = New SqlParameter("@QQ", SqlDbType.NVarChar)
        sqlPara(5).Value = GB.Qq
        sqlPara(6) = New SqlParameter("@CodeNum", SqlDbType.NVarChar)
        sqlPara(6).Value = GB.CodeNum
        sqlPara(7) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(7).Value = GB.Address
        sqlPara(8) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(8).Value = GB.Title
        sqlPara(9) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(9).Value = GB.Remark
        sqlPara(10) = New SqlParameter("@Sequence", SqlDbType.Int)
        sqlPara(10).Value = GB.Sequence
        sqlPara(11) = New SqlParameter("@PostDate", SqlDbType.DateTime)
        sqlPara(11).Value = GB.PostDate
         Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        GB.Id = i
        Return GB
    End Function
   shared Function Update(GB As Model.GuestBook) As Model.GuestBook
        Dim sqlPara(16) As SqlParameter
        Dim sql As String
        sql = "update GuestBook  set Caseid=@Caseid,Name=@Name,Tel=@Tel,eMail=@eMail,QQ=@QQ,CodeNum=@CodeNum,Address=@Address,Title=@Title,Remark=@Remark,Sequence=@Sequence,PostDate=@PostDate,PostIP=@PostIP,Reply=@Reply,ReplyDate=@ReplyDate,ReplyIP=@ReplyIP,IsShow=@IsShow  where  ID=@ID "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = GB.Id
        sqlPara(1) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(1).Value = GB.Caseid
        sqlPara(2) = New SqlParameter("@Name", SqlDbType.NVarChar)
        sqlPara(2).Value = GB.Name
        sqlPara(3) = New SqlParameter("@Tel", SqlDbType.NVarChar)
        sqlPara(3).Value = GB.Tel
        sqlPara(4) = New SqlParameter("@eMail", SqlDbType.NVarChar)
        sqlPara(4).Value = GB.EMail
        sqlPara(5) = New SqlParameter("@QQ", SqlDbType.NVarChar)
        sqlPara(5).Value = GB.Qq
        sqlPara(6) = New SqlParameter("@CodeNum", SqlDbType.NVarChar)
        sqlPara(6).Value = GB.CodeNum
        sqlPara(7) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(7).Value = GB.Address
        sqlPara(8) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(8).Value = GB.Title
        sqlPara(9) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(9).Value = GB.Remark
        sqlPara(10) = New SqlParameter("@Sequence", SqlDbType.Int)
        sqlPara(10).Value = GB.Sequence
        sqlPara(11) = New SqlParameter("@PostDate", SqlDbType.DateTime)
        sqlPara(11).Value = GB.PostDate
        sqlPara(12) = New SqlParameter("@PostIP", SqlDbType.NVarChar)
        sqlPara(12).Value = GB.Postip
        sqlPara(13) = New SqlParameter("@Reply", SqlDbType.NVarChar)
        sqlPara(13).Value = GB.Reply
        sqlPara(14) = New SqlParameter("@ReplyDate", SqlDbType.DateTime)
        sqlPara(14).Value = GB.ReplyDate
        sqlPara(15) = New SqlParameter("@ReplyIP", SqlDbType.NVarChar)
        sqlPara(15).Value = GB.Replyip
        sqlPara(16) = New SqlParameter("@IsShow", SqlDbType.Bit)
        sqlPara(16).Value = GB.IsShow
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return GB
    End Function
   shared Function Reply(GB As Model.GuestBook) As Model.GuestBook
        Dim sqlPara(4) As SqlParameter
        Dim sql As String
        sql = "update GuestBook  set  Reply=@Reply,ReplyDate=@ReplyDate,ReplyIP=@ReplyIP,IsShow=@IsShow  where  ID=@ID "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = GB.Id
        sqlPara(1) = New SqlParameter("@Reply", SqlDbType.NVarChar)
        sqlPara(1).Value = GB.Reply
        sqlPara(2) = New SqlParameter("@ReplyDate", SqlDbType.DateTime)
        sqlPara(2).Value = GB.ReplyDate
        sqlPara(3) = New SqlParameter("@ReplyIP", SqlDbType.NVarChar)
        sqlPara(3).Value = GB.Replyip
        sqlPara(4) = New SqlParameter("@IsShow", SqlDbType.Bit)
        sqlPara(4).Value = GB.IsShow
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        Return GB
    End Function

   shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from GuestBook where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from GuestBook where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  GuestBook"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  GuestBook where ID=ID"
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(ID As Integer) As Model.GuestBook
        Return Fabricate.Fill(Of Model.GuestBook)(rs(ID))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "GuestBook"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
