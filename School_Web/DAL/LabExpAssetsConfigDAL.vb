Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class LabExpAssetsConfigDAL
   shared Function insert(LEC As Model.LabExpAssetsConfig) As Model.LabExpAssetsConfig
        Dim sqlPara(9) As SqlParameter
        Dim sql As String
        sql = "insert into LabExpAssetsConfig (LabId,AssetCaseId,Title,Pindex,Num,UnitName,Manager,Location,Pubdate) values (@LabId,@AssetCaseId,@Title,@Pindex,@Num,@UnitName,@Manager,@Location,@Pubdate);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@LabId", SqlDbType.Int)
        sqlPara(0).Value = LEC.LabId
        sqlPara(1) = New SqlParameter("@AssetCaseId", SqlDbType.Int)
        sqlPara(1).Value = LEC.AssetCaseId
        sqlPara(2) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(2).Value = LEC.Title
        sqlPara(3) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(3).Value = LEC.Pindex
        sqlPara(4) = New SqlParameter("@Num", SqlDbType.Int)
        sqlPara(4).Value = LEC.Num
        sqlPara(5) = New SqlParameter("@UnitName", SqlDbType.NVarChar)
        sqlPara(5).Value = LEC.UnitName
        sqlPara(6) = New SqlParameter("@Manager", SqlDbType.NVarChar)
        sqlPara(6).Value = LEC.Manager
        sqlPara(7) = New SqlParameter("@Location", SqlDbType.Int)
        sqlPara(7).Value = LEC.Location
        sqlPara(8) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(8).Value = LEC.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        LEC.Id = i
        Return LEC
    End Function
   shared Function Update(LEC As Model.LabExpAssetsConfig) As Model.LabExpAssetsConfig
        Dim sqlPara(9) As SqlParameter
        Dim sql As String
        sql = "update LabExpAssetsConfig  set LabId=@LabId,AssetCaseId=@AssetCaseId,Title=@Title,Pindex=@Pindex,Num=@Num,UnitName=@UnitName,Manager=@Manager,Location=@Location,Pubdate=@Pubdate  where   "
        sqlPara(0) = New SqlParameter("@ID", SqlDbType.Int)
        sqlPara(0).Value = LEC.Id
        sqlPara(1) = New SqlParameter("@LabId", SqlDbType.Int)
        sqlPara(1).Value = LEC.LabId
        sqlPara(2) = New SqlParameter("@AssetCaseId", SqlDbType.Int)
        sqlPara(2).Value = LEC.AssetCaseId
        sqlPara(3) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(3).Value = LEC.Title
        sqlPara(4) = New SqlParameter("@Pindex", SqlDbType.Int)
        sqlPara(4).Value = LEC.Pindex
        sqlPara(5) = New SqlParameter("@Num", SqlDbType.Int)
        sqlPara(5).Value = LEC.Num
        sqlPara(6) = New SqlParameter("@UnitName", SqlDbType.NVarChar)
        sqlPara(6).Value = LEC.UnitName
        sqlPara(7) = New SqlParameter("@Manager", SqlDbType.NVarChar)
        sqlPara(7).Value = LEC.Manager
        sqlPara(8) = New SqlParameter("@Location", SqlDbType.Int)
        sqlPara(8).Value = LEC.Location
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = LEC.Pubdate

        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return LEC
    End Function
   shared Function del(ID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabExpAssetsConfig where ID=" & ID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function Multidel(IDs As Integer) As Boolean
        Dim sql As String
        sql = "delete   from LabExpAssetsConfig where ID in(" & IDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  LabExpAssetsConfig"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function rs(ID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  LabExpAssetsConfig where ID=" & ID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(ID As Integer) As Model.LabExpAssetsConfig
        Return Fabricate.Fill(Of Model.LabExpAssetsConfig)(rs(ID))
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "LabExpAssetsConfig"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
