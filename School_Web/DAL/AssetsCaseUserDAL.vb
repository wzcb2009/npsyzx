Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Web.HttpContext
Public Class AssetsCaseUserDAL
     Shared Function  insert(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Dim sqlPara(16) As SqlParameter
        Dim sql As String
        sql = "insert into Assets_CaseUser (ParentId,CaseId,AssetsID,UserId,StateCaseId,State,PlaceId,DepartmentID,MagUserId,Remark,SerialNumber,Pubdate,AssetsCount,CurrentState,SourceCaseID,OrderCode) values (@ParentId,@CaseId,@AssetsID,@UserId,@StateCaseId,@State,@PlaceId,@DepartmentID,@MagUserId,@Remark,@SerialNumber,@Pubdate,@AssetsCount,@CurrentState,@SourceCaseID,@OrderCode);SELECT @@IDENTITY"
        sqlPara(1) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(1).Value = CU.ParentId
        sqlPara(2) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(2).Value = CU.CaseId
        sqlPara(3) = New SqlParameter("@AssetsID", SqlDbType.Int)
        sqlPara(3).Value = CU.Assetsid
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = CU.UserId
        sqlPara(5) = New SqlParameter("@StateCaseId", SqlDbType.Int)
        sqlPara(5).Value = CU.StateCaseId
        sqlPara(6) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(6).Value = CU.State
        sqlPara(7) = New SqlParameter("@PlaceId", SqlDbType.Int)
        sqlPara(7).Value = CU.PlaceId
        sqlPara(8) = New SqlParameter("@DepartmentID", SqlDbType.Int)
        sqlPara(8).Value = CU.Departmentid
        sqlPara(9) = New SqlParameter("@MagUserId", SqlDbType.Int)
        sqlPara(9).Value = CU.MagUserId
        sqlPara(10) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(10).Value = CU.Remark
        sqlPara(11) = New SqlParameter("@SerialNumber", SqlDbType.NVarChar)
        sqlPara(11).Value = CU.SerialNumber
        sqlPara(12) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(12).Value = CU.Pubdate
        sqlPara(13) = New SqlParameter("@AssetsCount", SqlDbType.Int)
        sqlPara(13).Value = CU.AssetsCount
        sqlPara(14) = New SqlParameter("@CurrentState", SqlDbType.Bit)
        sqlPara(14).Value = CU.CurrentState
        sqlPara(15) = New SqlParameter("@SourceCaseID", SqlDbType.Int)
        sqlPara(15).Value = CU.SourceCaseid
        sqlPara(16) = New SqlParameter("@OrderCode", SqlDbType.NVarChar)
        sqlPara(16).Value = CU.Ordercode
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        CU.Id = i
        Return CU
    End Function
    Shared Function Update(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Dim sqlPara(16) As SqlParameter
        Dim sql As String
        sql = "update Assets_CaseUser  set ParentId=@ParentId,CaseId=@CaseId,AssetsID=@AssetsID,UserId=@UserId,StateCaseId=@StateCaseId,State=@State,PlaceId=@PlaceId,DepartmentID=@DepartmentID,MagUserId=@MagUserId,Remark=@Remark,SerialNumber=@SerialNumber,Pubdate=@Pubdate,AssetsCount=@AssetsCount,CurrentState=@CurrentState,SourceCaseID=@SourceCaseID ,OrderCode=@OrderCode where  Id=@Id "

        sqlPara(0) = New SqlParameter("@id", SqlDbType.Int)
        sqlPara(0).Value = CU.Id
        sqlPara(1) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(1).Value = CU.ParentId
        sqlPara(2) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(2).Value = CU.CaseId
        sqlPara(3) = New SqlParameter("@AssetsID", SqlDbType.Int)
        sqlPara(3).Value = CU.Assetsid
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = CU.UserId
        sqlPara(5) = New SqlParameter("@StateCaseId", SqlDbType.Int)
        sqlPara(5).Value = CU.StateCaseId
        sqlPara(6) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(6).Value = CU.State
        sqlPara(7) = New SqlParameter("@PlaceId", SqlDbType.Int)
        sqlPara(7).Value = CU.PlaceId
        sqlPara(8) = New SqlParameter("@DepartmentID", SqlDbType.Int)
        sqlPara(8).Value = CU.Departmentid
        sqlPara(9) = New SqlParameter("@MagUserId", SqlDbType.Int)
        sqlPara(9).Value = CU.MagUserId
        sqlPara(10) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(10).Value = CU.Remark
        sqlPara(11) = New SqlParameter("@SerialNumber", SqlDbType.NVarChar)
        sqlPara(11).Value = CU.SerialNumber
        sqlPara(12) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(12).Value = CU.Pubdate
        sqlPara(13) = New SqlParameter("@AssetsCount", SqlDbType.Int)
        sqlPara(13).Value = CU.AssetsCount
        sqlPara(14) = New SqlParameter("@CurrentState", SqlDbType.Bit)
        sqlPara(14).Value = CU.CurrentState
        sqlPara(15) = New SqlParameter("@SourceCaseID", SqlDbType.Int)
        sqlPara(15).Value = CU.SourceCaseid
        sqlPara(16) = New SqlParameter("@OrderCode", SqlDbType.NVarChar)
        sqlPara(16).Value = CU.Ordercode
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return CU
    End Function
    Shared Function Update2(CU As Model.AssetsCaseUser) As Model.AssetsCaseUser
        Dim sqlPara(16) As SqlParameter
        Dim sql As String
        sql = "update Assets_CaseUser  set ParentId=@ParentId,CaseId=@CaseId,UserId=@UserId, PlaceId=@PlaceId,DepartmentID=@DepartmentID,,CurrentState=@CurrentState,State=@State,MagUserId=@MagUserId,Remark=@Remark,SerialNumber=@SerialNumber,Pubdate=@Pubdate,AssetsCount=@AssetsCount,OrderCode=@OrderCode  where AssetsID=@AssetsID and StateCaseId=@StateCaseId and SourceCaseID=@SourceCaseID "
        sqlPara(1) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlPara(1).Value = CU.ParentId
        sqlPara(12) = New SqlParameter("@PlaceId", SqlDbType.Int)
        sqlPara(12).Value = CU.PlaceId
        sqlPara(13) = New SqlParameter("@DepartmentID", SqlDbType.Int)
        sqlPara(13).Value = CU.Departmentid
        sqlPara(14) = New SqlParameter("@CurrentState", SqlDbType.Bit)
        sqlPara(14).Value = CU.CurrentState
        sqlPara(15) = New SqlParameter("@SourceCaseID", SqlDbType.Int)
        sqlPara(15).Value = CU.SourceCaseid
        sqlPara(16) = New SqlParameter("@OrderCode", SqlDbType.NVarChar)
        sqlPara(16).Value = CU.Ordercode

        sqlPara(2) = New SqlParameter("@CaseId", SqlDbType.Int)
        sqlPara(2).Value = CU.CaseId
        sqlPara(3) = New SqlParameter("@AssetsID", SqlDbType.Int)
        sqlPara(3).Value = CU.Assetsid
        sqlPara(4) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(4).Value = CU.UserId
        sqlPara(5) = New SqlParameter("@StateCaseId", SqlDbType.Int)
        sqlPara(5).Value = CU.StateCaseId
        sqlPara(6) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(6).Value = CU.State
        sqlPara(7) = New SqlParameter("@MagUserId", SqlDbType.Int)
        sqlPara(7).Value = CU.MagUserId
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = CU.Remark
        sqlPara(9) = New SqlParameter("@SerialNumber", SqlDbType.NVarChar)
        sqlPara(9).Value = CU.SerialNumber
        sqlPara(10) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(10).Value = CU.Pubdate
        sqlPara(11) = New SqlParameter("@AssetsCount", SqlDbType.Int)
        sqlPara(11).Value = CU.AssetsCount
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return CU
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Assets_CaseUser where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Assets_CaseUser where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  Assets_CaseUser"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(AssetsId As Integer, CurrentState As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  Assets_CaseUser where AssetsId=" & AssetsId & " and CurrentState=" & CurrentState
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  Assets_CaseUser where Id= " & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.AssetsCaseUser
        Return Fabricate.Fill(Of Model.AssetsCaseUser)(rs(Id))
    End Function
    Shared Function Entity(AssetsId As Integer, CurrentState As Integer) As Model.AssetsCaseUser
        Return Fabricate.Fill(Of Model.AssetsCaseUser)(rs(AssetsId, CurrentState))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "Assets_CaseUser"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function IsExit(AssetsId As Integer, StateCaseId As Integer) As Boolean
        Dim sql As String
        sql = "select count(*)    from Assets_CaseUser where AssetsId = " & AssetsId & " and StateCaseId=" & StateCaseId
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)) > 0
    End Function
    Shared Function GetId(acu As Model.AssetsCaseUser) As Integer
        Dim sql As String
        sql = "select id   from Assets_CaseUser where AssetsId = " & acu.Assetsid & " and userid=" & acu.UserId & " and parentid=" & acu.ParentId & " and StateCaseId=" & acu.StateCaseId


        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function

    Shared Function UpdateCurrentSate(AssetsId As Integer, CurrentState As Integer) As Boolean
        Dim sql As String
        sql = "update  Assets_CaseUser set CurrentState=" & CurrentState & " where AssetsId = " & AssetsId
        Return SafeData.s_integer(SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)) > 0
    End Function
    Shared Function LastOrderCode() As String
        Dim sql As String
        sql = "select top 1  OrderCode from Assets_CaseUser where ordercode like '" & Now.Date.ToString("yyyy-MM-dd").Replace("-", "") & "-%' order by id desc"
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function OrderCodeIsExit(codebar As String) As Integer
        Dim sql As String
        sql = "select count(*) from Assets_CaseUser where ordercode = '" & codebar & "' "
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
    Shared Function Count(ast As Model.Assets, StateCaseId As Integer, Optional strWhere As String = "") As Integer
        Dim sql As String
        sql = "select sum(AssetsCount ) from Assets_CaseUser where AssetsID= " & ast.Assetsid & " and SourceCaseID=" & ast.SourceCaseid & " and StateCaseId=" & StateCaseId
        If strWhere <> "" Then
            sql = sql & " and " & strWhere
        End If
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End Function
End Class
