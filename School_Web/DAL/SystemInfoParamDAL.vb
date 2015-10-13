Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling
Public Class SystemInfoParamDAL
#Region "学校配置信息"
   shared Function Insert(sip As SystemInfoParam) As SystemInfoParam
        Dim sql As String
        sql = "INSERT INTO  [System_Info_Param]( [schoolname],[Address],[Contact],[Icp],[Content],[pubdate],uploadpath)     VALUES ( @schoolname,@Address,@Contact,@Icp,@Content,@pubdate,@uploadpath);SELECT @@IDENTITY"
        Dim sqlPara(7) As SqlParameter
        sqlPara(0) = New SqlParameter("@id", SqlDbType.Int)
        sqlPara(0).Value = sip.Id
        sqlPara(1) = New SqlParameter("@schoolname", SqlDbType.NVarChar)
        sqlPara(1).Value = sip.Schoolname
        sqlPara(2) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(2).Value = sip.Address
        sqlPara(3) = New SqlParameter("@Contact", SqlDbType.NVarChar)
        sqlPara(3).Value = sip.Contact
        sqlPara(4) = New SqlParameter("@Icp", SqlDbType.NVarChar)
        sqlPara(4).Value = sip.Icp
        sqlPara(5) = New SqlParameter("@Content", SqlDbType.NText)
        sqlPara(5).Value = sip.Content
        sqlPara(6) = New SqlParameter("@pubdate", SqlDbType.DateTime)
        sqlPara(6).Value = sip.Pubdate
        sqlPara(7) = New SqlParameter("@Uploadpath", SqlDbType.NVarChar)
        sqlPara(7).Value = sip.Uploadpath

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        sip.Id = i
        Return sip

    End Function
   shared Function Update(sip As SystemInfoParam) As SystemInfoParam
        Dim sql As String
        sql = "UPDATE [System_Info_Param]    set   schoolname=@schoolname, Address=@Address, Contact=@Contact, Icp=@Icp, Content=@Content, pubdate=@pubdate, uploadpath=@uploadpath WHERE id=@id"
        Dim sqlPara(7) As SqlParameter
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = sip.Id
        sqlPara(2) = New SqlParameter("@schoolname", SqlDbType.NVarChar)
        sqlPara(2).Value = sip.Schoolname
        sqlPara(3) = New SqlParameter("@Address", SqlDbType.NVarChar)
        sqlPara(3).Value = sip.Address
        sqlPara(4) = New SqlParameter("@Contact", SqlDbType.NVarChar)
        sqlPara(4).Value = sip.Contact
        sqlPara(5) = New SqlParameter("@Icp", SqlDbType.NVarChar)
        sqlPara(5).Value = sip.Icp
        sqlPara(6) = New SqlParameter("@Content", SqlDbType.NText)
        sqlPara(6).Value = sip.Content
        sqlPara(7) = New SqlParameter("@pubdate", SqlDbType.DateTime)
        sqlPara(7).Value = sip.Pubdate
        sqlPara(1) = New SqlParameter("@Uploadpath", SqlDbType.NVarChar)
        sqlPara(1).Value = sip.Uploadpath
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql, sqlPara)
        Return sip

    End Function
   shared Function rs(ByVal id As Int16) As SqlDataReader
        Dim sql As String
        sql = "select * from System_Info_Param where id= " & id

        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)

    End Function
   shared Function name(ByVal id As Int16) As String
        Dim sql As String
        sql = "select schoolname from System_Info_Param where id= " & id
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
   shared Function System_udpath(id As Integer) As String
        Dim sql As String
        sql = "select udpath from System_Info_Param where id= " & id
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
   shared Function IsExit(id As Integer) As Boolean
        Dim sql As String
        sql = "select count(*) from System_Info_Param where id= " & id
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End Function
#End Region
End Class
