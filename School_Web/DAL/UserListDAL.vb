Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling
Public Class UserListDAL


#Region "用户信息"
    Shared Function insert(U As Model.Userlist) As Model.Userlist
        Dim sqlPara(18) As SqlParameter
        Dim sql As String
        sql = "insert into Userlist (GradeId,ClassId,RoleId,UserName,Truename,TruenameEn,Pwd,LastLogin,PubDate,LocalIp,LoginTimes,OtherGuID,State,Sex,FaceUrl,Tel,QQ,QQWX) values (@GradeId,@ClassId,@RoleId,@UserName,@Truename,@TruenameEn,@Pwd,@LastLogin,@PubDate,@LocalIp,@LoginTimes,@OtherGuID,@State,@Sex,@FaceUrl,@Tel,@QQ,@QQWX);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(0).Value = U.GradeId
        sqlpara(1) = New SqlParameter("@ClassId", SqlDbType.int)
        sqlpara(1).Value = U.ClassId
        sqlpara(2) = New SqlParameter("@RoleId", SqlDbType.int)
        sqlpara(2).Value = U.RoleId
        sqlpara(3) = New SqlParameter("@UserName", SqlDbType.nvarchar)
        sqlpara(3).Value = U.UserName
        sqlpara(4) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(4).Value = U.Truename
        sqlpara(5) = New SqlParameter("@TruenameEn", SqlDbType.nvarchar)
        sqlpara(5).Value = U.TruenameEn
        sqlpara(6) = New SqlParameter("@Pwd", SqlDbType.nvarchar)
        sqlpara(6).Value = U.Pwd
        sqlpara(7) = New SqlParameter("@LastLogin", SqlDbType.datetime)
        sqlpara(7).Value = U.LastLogin
        sqlpara(8) = New SqlParameter("@PubDate", SqlDbType.datetime)
        sqlpara(8).Value = U.PubDate
        sqlpara(9) = New SqlParameter("@LocalIp", SqlDbType.nvarchar)
        sqlpara(9).Value = U.LocalIp
        sqlpara(10) = New SqlParameter("@LoginTimes", SqlDbType.int)
        sqlpara(10).Value = U.LoginTimes
        sqlpara(11) = New SqlParameter("@OtherGuID", SqlDbType.nvarchar)
        sqlpara(11).Value = U.OtherGuID
        sqlpara(12) = New SqlParameter("@State", SqlDbType.bit)
        sqlpara(12).Value = U.State
        sqlpara(13) = New SqlParameter("@Sex", SqlDbType.nvarchar)
        sqlpara(13).Value = U.Sex
        sqlpara(14) = New SqlParameter("@FaceUrl", SqlDbType.nvarchar)
        sqlpara(14).Value = U.FaceUrl
        sqlpara(15) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(15).Value = U.Tel
        sqlpara(16) = New SqlParameter("@QQ", SqlDbType.nvarchar)
        sqlpara(16).Value = U.QQ
        sqlpara(17) = New SqlParameter("@QQWX", SqlDbType.nvarchar)
        sqlpara(17).Value = U.QQWX
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        U.UserId = i
        Return U
    End Function
    Shared Function Update(U As Model.Userlist) As Model.Userlist
        Dim sqlPara(18) As SqlParameter
        Dim sql As String
        sql = "update Userlist  set GradeId=@GradeId,ClassId=@ClassId,RoleId=@RoleId,UserName=@UserName,Truename=@Truename,TruenameEn=@TruenameEn,Pwd=@Pwd,LastLogin=@LastLogin,PubDate=@PubDate,LocalIp=@LocalIp,LoginTimes=@LoginTimes,OtherGuID=@OtherGuID,State=@State,Sex=@Sex,FaceUrl=@FaceUrl,Tel=@Tel,QQ=@QQ,QQWX=@QQWX  where  UserId=@UserId "
        sqlpara(0) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(0).Value = U.UserId
        sqlpara(1) = New SqlParameter("@GradeId", SqlDbType.int)
        sqlpara(1).Value = U.GradeId
        sqlpara(2) = New SqlParameter("@ClassId", SqlDbType.int)
        sqlpara(2).Value = U.ClassId
        sqlpara(3) = New SqlParameter("@RoleId", SqlDbType.int)
        sqlpara(3).Value = U.RoleId
        sqlpara(4) = New SqlParameter("@UserName", SqlDbType.nvarchar)
        sqlpara(4).Value = U.UserName
        sqlpara(5) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(5).Value = U.Truename
        sqlpara(6) = New SqlParameter("@TruenameEn", SqlDbType.nvarchar)
        sqlpara(6).Value = U.TruenameEn
        sqlpara(7) = New SqlParameter("@Pwd", SqlDbType.nvarchar)
        sqlpara(7).Value = U.Pwd
        sqlpara(8) = New SqlParameter("@LastLogin", SqlDbType.datetime)
        sqlpara(8).Value = U.LastLogin
        sqlpara(9) = New SqlParameter("@PubDate", SqlDbType.datetime)
        sqlpara(9).Value = U.PubDate
        sqlpara(10) = New SqlParameter("@LocalIp", SqlDbType.nvarchar)
        sqlpara(10).Value = U.LocalIp
        sqlpara(11) = New SqlParameter("@LoginTimes", SqlDbType.int)
        sqlpara(11).Value = U.LoginTimes
        sqlpara(12) = New SqlParameter("@OtherGuID", SqlDbType.nvarchar)
        sqlpara(12).Value = U.OtherGuID
        sqlpara(13) = New SqlParameter("@State", SqlDbType.bit)
        sqlpara(13).Value = U.State
        sqlpara(14) = New SqlParameter("@Sex", SqlDbType.nvarchar)
        sqlpara(14).Value = U.Sex
        sqlpara(15) = New SqlParameter("@FaceUrl", SqlDbType.nvarchar)
        sqlpara(15).Value = U.FaceUrl
        sqlpara(16) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(16).Value = U.Tel
        sqlpara(17) = New SqlParameter("@QQ", SqlDbType.nvarchar)
        sqlpara(17).Value = U.QQ
        sqlpara(18) = New SqlParameter("@QQWX", SqlDbType.nvarchar)
        sqlpara(18).Value = U.QQWX
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return U
    End Function
   shared Function Del(userid As Integer) As Integer
        Dim sql As String
        sql = "delete from userlist where Userid=" & userid
        Dim i As Int16 = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        Return i
    End Function
   shared Function MultiDel(userids As String) As Integer
        Dim sql As String
        sql = "delete from userlist where Userid in(" & userids & ")"
        Dim i As Int16 = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        Return i
    End Function

    shared Function UpdateLoginTimes(username As String) As Boolean
        Dim sql As String
        sql = "update userlist set logintimes=logintimes+1 where username=@username"
        Dim sqlPara(0) As SqlParameter

        sqlPara(0) = New SqlParameter("@username", SqlDbType.NVarChar)
        sqlPara(0).Value = username

        If SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0 Then
            Return True
        End If
    End Function
 
   shared Function ModPwd(userid As Integer, ByVal Newpwd As String) As Boolean
        Dim sqlParm(1) As SqlParameter
        sqlParm(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlParm(0).Value = userid

        sqlParm(1) = New SqlParameter("@newpwd", SqlDbType.NVarChar)
        sqlParm(1).Value = Newpwd
        Dim sql As String = "update userlist where @newwhere userid=@userid"

        Dim i As Int16 = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlParm)
        If i > 0 Then
            Return True
        End If
    End Function
    Shared Function GetEntity(username As String) As Userlist
        Return Fabricate.Fill(Of Userlist)(rsByUsername(username))
    End Function

   shared Function GetEntity(userid As Integer) As Userlist
        Return Fabricate.Fill(Of Userlist)(RsByUserid(userid))
    End Function
   shared Function RsByUserid(userid As Integer) As SqlDataReader
        Dim sql As String

        sql = "select * from  userlist where    userid=" & userid

        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)

    End Function
   shared Function Truename(userid As Integer) As String
        Dim sql As String

        sql = "select truename from  userlist where    userid=" & userid

        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
   shared Function UserName(userid As Integer) As String
        Dim sql As String

        sql = "select UserName from  userlist where    userid=" & userid

        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function

   shared Function Userid(UserNameStr As String) As Int16

        Dim sql As String = "select userid from userlist where username=@username"
        Dim sqlPara(0) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@username", SqlDbType.NVarChar)
        sqlPara(0).Value = UserNameStr
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)

    End Function
   shared Function Userid(UserNameStr As String, roleid As Integer) As Int16

        Dim sql As String = "select userid from userlist where username=@username and roleid=@roleid"
        Dim sqlPara(1) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@username", SqlDbType.NVarChar)
        sqlPara(0).Value = UserNameStr
        sqlPara(1) = New SqlParameter("@roleid", SqlDbType.Int)
        sqlPara(1).Value = roleid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)

    End Function

   shared Function PwdUpdate(UserNameStr As String, pwdstr As String) As Boolean

        Dim sql As String = "update userlist set pwd=@pwd where username=@username"
        Dim sqlPara(1) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@username", SqlDbType.NVarChar)
        sqlPara(0).Value = UserNameStr
        sqlPara(1) = New SqlParameter("@pwd", SqlDbType.NVarChar)
        sqlPara(1).Value = pwdstr
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function
   shared Function TruenameEnUpdate(userid As Integer, TruenameEn As String) As Boolean

        Dim sql As String = "update userlist set TruenameEn=@TruenameEn where userid=@userid"
        Dim sqlPara(1) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = userid
        sqlPara(1) = New SqlParameter("@TruenameEn", SqlDbType.NVarChar)
        sqlPara(1).Value = TruenameEn
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function
   shared Function GradeidUpdate(userid As Integer, gradeid As Integer) As Boolean

        Dim sql As String = "update userlist set gradeid=@gradeid where userid=@userid"
        Dim sqlPara(1) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@userid", SqlDbType.Int)
        sqlPara(0).Value = userid
        sqlPara(1) = New SqlParameter("@gradeid", SqlDbType.Int)
        sqlPara(1).Value = gradeid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function


   shared Function Isexit(Truename As String) As Boolean

        Dim sql As String = "select count(*) from userlist where Truename=@Truename"
        Dim sqlPara(0) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@Truename", SqlDbType.NVarChar)
        sqlPara(0).Value = Truename
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara) > 0

    End Function
   shared Function Count(roleid As Integer) As Integer

        Dim sql As String = "select count(*) from userlist where roleid=@roleid"
        Dim sqlPara(0) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@roleid", SqlDbType.Int)
        sqlPara(0).Value = roleid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)

    End Function

   shared Function Userid2(Truename As String, Optional roleid As Integer = 13) As Int16

        Dim sql As String = "select userid from userlist where Truename=@Truename"
        Dim sqlPara(1) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@Truename", SqlDbType.NVarChar)
        sqlPara(0).Value = Truename
        sqlPara(1) = New SqlParameter("@roleid", SqlDbType.Int)
        sqlPara(1).Value = roleid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)

    End Function

   shared Function rsByUsername(ByVal UserNameStr As String) As SqlDataReader
        Dim sql As String = "select * from userlist where username=@username"
        Dim sqlPara(0) As Data.SqlClient.SqlParameter
        sqlPara(0) = New SqlParameter("@username", SqlDbType.NVarChar)
        sqlPara(0).Value = UserNameStr
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql, sqlPara)
    End Function
   shared Function Dt() As DataTable
        Dim sql As String = "select * from userlist"

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function DtPinNull() As DataTable
        Dim sql As String = "select userid,truename,TruenameEn from userlist where TruenameEn is null"

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

   shared Function Dt(userinfo As Model.Userlist, Optional orderby As String = "username asc") As DataTable
        Dim sql As New Text.StringBuilder
        sql.Append("select newid() as newid_,* from userlist where 1=1 ")
        If userinfo.GradeId > 0 Then sql.Append(" and gradeid = " & userinfo.GradeId)
        If userinfo.RoleId > 0 Then sql.Append(" and RoleId = " & userinfo.RoleId)
        If userinfo.ClassId > 0 Then sql.Append(" and ClassId = " & userinfo.ClassId)
        sql.Append("order by " & orderby)
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql.ToString).Tables(0)
    End Function
   shared Function userCount(userinfo As Model.Userlist) As Integer
        Dim sql As New Text.StringBuilder
        sql.Append("select count(*) from userlist where 1=1 ")
        If userinfo.GradeId > 0 Then sql.Append(" and gradeid = " & userinfo.GradeId)
        If userinfo.RoleId > 0 Then sql.Append(" and RoleId = " & userinfo.RoleId)
        If userinfo.ClassId > 0 Then sql.Append(" and ClassId = " & userinfo.ClassId)

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql.ToString)
    End Function

   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "userlist"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function dt(truename As String, top As Integer, roleid As Integer) As DataTable
        Dim sql As String = "select top " & top & " * from userlist where roleid=" & roleid & " and  (truename like '%" & truename & "%') or (truenameEn like '%" & truename & "%')"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
#End Region
End Class
