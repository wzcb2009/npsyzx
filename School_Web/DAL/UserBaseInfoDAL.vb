Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports StringHandling

Public Class UserBaseInfoDAL
   shared Function insert(UBI As Model.UserBaseInfo) As Model.UserBaseInfo
        Dim sqlPara(26) As SqlParameter
        Dim sql As String
        sql = "insert into UserBaseInfo (UserId,Truename,Truename2,PicUrl,Sex,BirthDay,CardID,Party,Profession,HomeTown,BirthPlace,Religion,Nation,Marriage,Address,Tel,Healthy,Educational,Specialty,GraduateSchool,Pubdate,MagUserId,State,CheckedDate,JoinDate,OutDate) values (@UserId,@Truename,@Truename2,@PicUrl,@Sex,@BirthDay,@CardID,@Party,@Profession,@HomeTown,@BirthPlace,@Religion,@Nation,@Marriage,@Address,@Tel,@Healthy,@Educational,@Specialty,@GraduateSchool,@Pubdate,@MagUserId,@State,@CheckedDate,@JoinDate,@OutDate);SELECT @@IDENTITY"
        sqlpara(1) = New SqlParameter("@UserId", SqlDbType.int)
        sqlpara(1).Value = UBI.UserId
        sqlpara(2) = New SqlParameter("@Truename", SqlDbType.nvarchar)
        sqlpara(2).Value = UBI.Truename
        sqlpara(3) = New SqlParameter("@Truename2", SqlDbType.nvarchar)
        sqlpara(3).Value = UBI.Truename2
        sqlpara(4) = New SqlParameter("@PicUrl", SqlDbType.nvarchar)
        sqlpara(4).Value = UBI.PicUrl
        sqlpara(5) = New SqlParameter("@Sex", SqlDbType.nvarchar)
        sqlpara(5).Value = UBI.Sex
        sqlpara(6) = New SqlParameter("@BirthDay", SqlDbType.datetime)
        sqlpara(6).Value = UBI.BirthDay
        sqlpara(7) = New SqlParameter("@CardID", SqlDbType.nvarchar)
        sqlpara(7).Value = UBI.CardID
        sqlpara(8) = New SqlParameter("@Party", SqlDbType.nvarchar)
        sqlpara(8).Value = UBI.Party
        sqlpara(9) = New SqlParameter("@Profession", SqlDbType.nvarchar)
        sqlpara(9).Value = UBI.Profession
        sqlpara(10) = New SqlParameter("@HomeTown", SqlDbType.nvarchar)
        sqlpara(10).Value = UBI.HomeTown
        sqlpara(11) = New SqlParameter("@BirthPlace", SqlDbType.nvarchar)
        sqlpara(11).Value = UBI.BirthPlace
        sqlpara(12) = New SqlParameter("@Religion", SqlDbType.nvarchar)
        sqlpara(12).Value = UBI.Religion
        sqlpara(13) = New SqlParameter("@Nation", SqlDbType.nvarchar)
        sqlpara(13).Value = UBI.Nation
        sqlpara(14) = New SqlParameter("@Marriage", SqlDbType.nvarchar)
        sqlpara(14).Value = UBI.Marriage
        sqlpara(15) = New SqlParameter("@Address", SqlDbType.nvarchar)
        sqlpara(15).Value = UBI.Address
        sqlpara(16) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(16).Value = UBI.Tel
        sqlpara(17) = New SqlParameter("@Healthy", SqlDbType.nvarchar)
        sqlpara(17).Value = UBI.Healthy
        sqlpara(18) = New SqlParameter("@Educational", SqlDbType.nvarchar)
        sqlpara(18).Value = UBI.Educational
        sqlpara(19) = New SqlParameter("@Specialty", SqlDbType.nvarchar)
        sqlpara(19).Value = UBI.Specialty
        sqlpara(20) = New SqlParameter("@GraduateSchool", SqlDbType.nvarchar)
        sqlpara(20).Value = UBI.GraduateSchool
        sqlpara(21) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(21).Value = UBI.Pubdate
        sqlpara(22) = New SqlParameter("@MagUserId", SqlDbType.int)
        sqlpara(22).Value = UBI.MagUserId
        sqlpara(23) = New SqlParameter("@State", SqlDbType.bit)
        sqlpara(23).Value = UBI.State
        sqlpara(24) = New SqlParameter("@CheckedDate", SqlDbType.datetime)
        sqlpara(24).Value = UBI.CheckedDate
        sqlpara(25) = New SqlParameter("@JoinDate", SqlDbType.nvarchar)
        sqlpara(25).Value = UBI.JoinDate
        sqlpara(26) = New SqlParameter("@OutDate", SqlDbType.nvarchar)
        sqlpara(26).Value = UBI.OutDate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        UBI.BaseInfoId = i
        Return UBI
    End Function
   shared Function Update(UBI As Model.UserBaseInfo) As Model.UserBaseInfo
        Dim sqlPara(26) As SqlParameter
        Dim sql As String
        sql = "update UserBaseInfo  set UserId=@UserId,Truename=@Truename,Truename2=@Truename2,PicUrl=@PicUrl,Sex=@Sex,BirthDay=@BirthDay,CardID=@CardID,Party=@Party,Profession=@Profession,HomeTown=@HomeTown,BirthPlace=@BirthPlace,Religion=@Religion,Nation=@Nation,Marriage=@Marriage,Address=@Address,Tel=@Tel,Healthy=@Healthy,Educational=@Educational,Specialty=@Specialty,GraduateSchool=@GraduateSchool,Pubdate=@Pubdate,MagUserId=@MagUserId,State=@State,CheckedDate=@CheckedDate,JoinDate=@JoinDate,OutDate=@OutDate  where  BaseInfoId=@BaseInfoId "
        sqlPara(0) = New SqlParameter("@BaseInfoId", SqlDbType.Int)
        sqlPara(0).Value = UBI.BaseInfoId
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = UBI.UserId
        sqlPara(2) = New SqlParameter("@Truename", SqlDbType.NVarChar)
        sqlpara(2).Value = UBI.Truename
        sqlpara(3) = New SqlParameter("@Truename2", SqlDbType.nvarchar)
        sqlpara(3).Value = UBI.Truename2
        sqlpara(4) = New SqlParameter("@PicUrl", SqlDbType.nvarchar)
        sqlpara(4).Value = UBI.PicUrl
        sqlpara(5) = New SqlParameter("@Sex", SqlDbType.nvarchar)
        sqlpara(5).Value = UBI.Sex
        sqlpara(6) = New SqlParameter("@BirthDay", SqlDbType.datetime)
        sqlpara(6).Value = UBI.BirthDay
        sqlpara(7) = New SqlParameter("@CardID", SqlDbType.nvarchar)
        sqlpara(7).Value = UBI.CardID
        sqlpara(8) = New SqlParameter("@Party", SqlDbType.nvarchar)
        sqlpara(8).Value = UBI.Party
        sqlpara(9) = New SqlParameter("@Profession", SqlDbType.nvarchar)
        sqlpara(9).Value = UBI.Profession
        sqlpara(10) = New SqlParameter("@HomeTown", SqlDbType.nvarchar)
        sqlpara(10).Value = UBI.HomeTown
        sqlpara(11) = New SqlParameter("@BirthPlace", SqlDbType.nvarchar)
        sqlpara(11).Value = UBI.BirthPlace
        sqlpara(12) = New SqlParameter("@Religion", SqlDbType.nvarchar)
        sqlpara(12).Value = UBI.Religion
        sqlpara(13) = New SqlParameter("@Nation", SqlDbType.nvarchar)
        sqlpara(13).Value = UBI.Nation
        sqlpara(14) = New SqlParameter("@Marriage", SqlDbType.nvarchar)
        sqlpara(14).Value = UBI.Marriage
        sqlpara(15) = New SqlParameter("@Address", SqlDbType.nvarchar)
        sqlpara(15).Value = UBI.Address
        sqlpara(16) = New SqlParameter("@Tel", SqlDbType.nvarchar)
        sqlpara(16).Value = UBI.Tel
        sqlpara(17) = New SqlParameter("@Healthy", SqlDbType.nvarchar)
        sqlpara(17).Value = UBI.Healthy
        sqlpara(18) = New SqlParameter("@Educational", SqlDbType.nvarchar)
        sqlpara(18).Value = UBI.Educational
        sqlpara(19) = New SqlParameter("@Specialty", SqlDbType.nvarchar)
        sqlpara(19).Value = UBI.Specialty
        sqlpara(20) = New SqlParameter("@GraduateSchool", SqlDbType.nvarchar)
        sqlpara(20).Value = UBI.GraduateSchool
        sqlpara(21) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(21).Value = UBI.Pubdate
        sqlpara(22) = New SqlParameter("@MagUserId", SqlDbType.int)
        sqlpara(22).Value = UBI.MagUserId
        sqlpara(23) = New SqlParameter("@State", SqlDbType.bit)
        sqlpara(23).Value = UBI.State
        sqlpara(24) = New SqlParameter("@CheckedDate", SqlDbType.datetime)
        sqlpara(24).Value = UBI.CheckedDate
        sqlpara(25) = New SqlParameter("@JoinDate", SqlDbType.nvarchar)
        sqlpara(25).Value = UBI.JoinDate
        sqlpara(26) = New SqlParameter("@OutDate", SqlDbType.nvarchar)
        sqlpara(26).Value = UBI.OutDate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return UBI
    End Function


   shared Function del(BaseInfoId As Integer) As Boolean
        Dim sql As String
        sql = "delete   from UserBaseInfo where BaseInfoId=" & BaseInfoId
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(BaseInfoIds As String) As Boolean
        Dim sql As String
        sql = "delete   from UserBaseInfo where BaseInfoId in(" & BaseInfoIds & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  UserBaseInfo"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(userid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  UserBaseInfo where userid=" & userid
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function rsByUserid(userid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  UserBaseInfo where userid=" & userid
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(userid As Integer) As Model.UserBaseInfo
        Return Fabricate.Fill(Of Model.UserBaseInfo)(rs(userid))
    End Function
   shared Function EntityByUserid(userid As Integer) As Model.UserBaseInfo
        Return Fabricate.Fill(Of Model.UserBaseInfo)(rsByUserid(userid))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "UserBaseInfo"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function GetId(bi As Model.UserBaseInfo) As Integer
        Dim sql As String
        sql = "select BaseInfoId from  UserBaseInfo where userid= " & bi.UserId

        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))


    End Function
   shared Function UpdatePic(userid As Integer, filepath As String) As Boolean
        Dim sql As String
        sql = "update UserBaseInfo set picurl='" & filepath & "'  where userid=" & userid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function

End Class
