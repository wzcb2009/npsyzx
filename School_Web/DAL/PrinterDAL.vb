Imports Wzsckj.com.Common
Imports System.Data.SqlClient

Public Class PrinterDAL
    Shared Function insert(P As Model.Printer) As Model.Printer
        Dim sqlPara(15) As SqlParameter
        Dim sql As String
        sql = "insert into Printer (Title,Url,PageSize,MarginLeft,MarginRight,MarginTop,MarginButom,CopyCount,ShowBarCode,PageHeader,PageFooter,IsLandScape,ContentURL,State,UserId) values (@Title,@Url,@PageSize,@MarginLeft,@MarginRight,@MarginTop,@MarginButom,@CopyCount,@ShowBarCode,@PageHeader,@PageFooter,@IsLandScape,@ContentURL,@State,@UserId);SELECT @@IDENTITY"
        sqlPara(0) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(0).Value = P.Title
        sqlPara(1) = New SqlParameter("@Url", SqlDbType.NVarChar)
        sqlPara(1).Value = P.Url
        sqlPara(2) = New SqlParameter("@PageSize", SqlDbType.NVarChar)
        sqlPara(2).Value = P.PageSize
        sqlPara(3) = New SqlParameter("@MarginLeft", SqlDbType.Float)
        sqlPara(3).Value = P.MarginLeft
        sqlPara(4) = New SqlParameter("@MarginRight", SqlDbType.Float)
        sqlPara(4).Value = P.MarginRight
        sqlPara(5) = New SqlParameter("@MarginTop", SqlDbType.Float)
        sqlPara(5).Value = P.MarginTop
        sqlPara(6) = New SqlParameter("@MarginButom", SqlDbType.Float)
        sqlPara(6).Value = P.MarginButom
        sqlPara(7) = New SqlParameter("@CopyCount", SqlDbType.Int)
        sqlPara(7).Value = P.CopyCount
        sqlPara(8) = New SqlParameter("@ShowBarCode", SqlDbType.Bit)
        sqlPara(8).Value = P.ShowBarCode
        sqlPara(9) = New SqlParameter("@PageHeader", SqlDbType.NVarChar)
        sqlPara(9).Value = P.PageHeader
        sqlPara(10) = New SqlParameter("@PageFooter", SqlDbType.NVarChar)
        sqlPara(10).Value = P.PageFooter
        sqlPara(11) = New SqlParameter("@IsLandScape", SqlDbType.Int)
        sqlPara(11).Value = P.IsLandScape
        sqlPara(12) = New SqlParameter("@ContentURL", SqlDbType.NVarChar)
        sqlPara(12).Value = P.Contenturl
        sqlPara(13) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(13).Value = P.State
        sqlPara(14) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(14).Value = P.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        P.Id = i
        Return P
    End Function
    Shared Function Update(P As Model.Printer) As Model.Printer
        Dim sqlPara(15) As SqlParameter
        Dim sql As String
        sql = "update Printer  set Title=@Title,Url=@Url,PageSize=@PageSize,MarginLeft=@MarginLeft,MarginRight=@MarginRight,MarginTop=@MarginTop,MarginButom=@MarginButom,CopyCount=@CopyCount,ShowBarCode=@ShowBarCode,PageHeader=@PageHeader,PageFooter=@PageFooter,IsLandScape=@IsLandScape,ContentURL=@ContentURL,State=@State,UserId=@UserId  where  Id=@Id "
        sqlPara(0) = New SqlParameter("@Id", SqlDbType.Int)
        sqlPara(0).Value = P.Id
        sqlPara(1) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(1).Value = P.Title
        sqlPara(2) = New SqlParameter("@Url", SqlDbType.NVarChar)
        sqlPara(2).Value = P.Url
        sqlPara(3) = New SqlParameter("@PageSize", SqlDbType.NVarChar)
        sqlPara(3).Value = P.PageSize
        sqlPara(4) = New SqlParameter("@MarginLeft", SqlDbType.Float)
        sqlPara(4).Value = P.MarginLeft
        sqlPara(5) = New SqlParameter("@MarginRight", SqlDbType.Float)
        sqlPara(5).Value = P.MarginRight
        sqlPara(6) = New SqlParameter("@MarginTop", SqlDbType.Float)
        sqlPara(6).Value = P.MarginTop
        sqlPara(7) = New SqlParameter("@MarginButom", SqlDbType.Float)
        sqlPara(7).Value = P.MarginButom
        sqlPara(8) = New SqlParameter("@CopyCount", SqlDbType.Int)
        sqlPara(8).Value = P.CopyCount
        sqlPara(9) = New SqlParameter("@ShowBarCode", SqlDbType.Bit)
        sqlPara(9).Value = P.ShowBarCode
        sqlPara(10) = New SqlParameter("@PageHeader", SqlDbType.NVarChar)
        sqlPara(10).Value = P.PageHeader
        sqlPara(11) = New SqlParameter("@PageFooter", SqlDbType.NVarChar)
        sqlPara(11).Value = P.PageFooter
        sqlPara(12) = New SqlParameter("@IsLandScape", SqlDbType.Int)
        sqlPara(12).Value = P.IsLandScape
        sqlPara(13) = New SqlParameter("@ContentURL", SqlDbType.NVarChar)
        sqlPara(13).Value = P.Contenturl
        sqlPara(14) = New SqlParameter("@State", SqlDbType.Bit)
        sqlPara(14).Value = P.State
        sqlPara(15) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(15).Value = P.UserId
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return P
    End Function
    Shared Function del(Id As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Printer where Id=" & Id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function Multidel(Ids As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Printer where Id in(" & Ids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from  Printer"
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
    Shared Function rs(Id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from  Printer where Id=" & Id
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
    Shared Function Entity(Id As Integer) As Model.Printer
        Return Fabricate.Fill(Of Model.Printer)(rs(Id))
    End Function
    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "Printer"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function

End Class
