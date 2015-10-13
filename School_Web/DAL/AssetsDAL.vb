Imports System.Data.SqlClient
Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Web.HttpContext
Public Class AssetsDAL
     Shared Function  insert(ast As Model.Assets) As Model.Assets
        Dim sqlPara(33) As SqlParameter
        Dim sql As String
        sql = "insert into Assets (TypeID,MagUserID,CaseID,CardCode,Barcode,Title,TitlePin,Price,Number,Unit,Remark,Pubdate,AccountedPubdate,BuyPubdate,Format,FactoryNumber,Factory,Style,PurchaseDate,ManufactureDate,PeriodLimitDate,Country,InvoiceCode,FundCaseID,SourceCaseID,ApplyCaseID,PurchaseCode,Supplier,SupplierManager,ForeignCurrencyPrice,TransportationCosts,Penalty,OtherCost) values (@TypeID,@MagUserID,@CaseID,@CardCode,@Barcode,@Title,@TitlePin,@Price,@Number,@Unit,@Remark,@Pubdate,@AccountedPubdate,@BuyPubdate,@Format,@FactoryNumber,@Factory,@Style,@PurchaseDate,@ManufactureDate,@PeriodLimitDate,@Country,@InvoiceCode,@FundCaseID,@SourceCaseID,@ApplyCaseID,@PurchaseCode,@Supplier,@SupplierManager,@ForeignCurrencyPrice,@TransportationCosts,@Penalty,@OtherCost);SELECT @@IDENTITY"
        sqlPara(31) = New SqlParameter("@TypeID", SqlDbType.Int)
        sqlPara(31).Value = ast.Typeid
        sqlPara(33) = New SqlParameter("@Unit", SqlDbType.NVarChar)
        sqlPara(33).Value = ast.Unit
        sqlPara(1) = New SqlParameter("@MagUserID", SqlDbType.Int)
        sqlPara(1).Value = ast.MagUserid
        sqlPara(2) = New SqlParameter("@CaseID", SqlDbType.Int)
        sqlPara(2).Value = ast.Caseid
        sqlPara(3) = New SqlParameter("@CardCode", SqlDbType.NVarChar)
        sqlPara(3).Value = ast.CardCode
        sqlPara(4) = New SqlParameter("@Barcode", SqlDbType.NVarChar)
        sqlPara(4).Value = ast.Barcode
        sqlPara(5) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(5).Value = ast.Title
        sqlPara(32) = New SqlParameter("@TitlePin", SqlDbType.NVarChar)
        sqlPara(32).Value = ast.TitlePin
        sqlPara(6) = New SqlParameter("@Price", SqlDbType.Decimal)
        sqlPara(6).Value = ast.Price
        sqlPara(7) = New SqlParameter("@Number", SqlDbType.Int)
        sqlPara(7).Value = ast.Number
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = ast.Remark
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = ast.Pubdate
        sqlPara(10) = New SqlParameter("@AccountedPubdate", SqlDbType.DateTime)
        sqlPara(10).Value = ast.AccountedPubdate
        sqlPara(11) = New SqlParameter("@BuyPubdate", SqlDbType.DateTime)
        sqlPara(11).Value = ast.BuyPubdate
        sqlPara(12) = New SqlParameter("@Format", SqlDbType.NVarChar)
        sqlPara(12).Value = ast.Format
        sqlPara(13) = New SqlParameter("@FactoryNumber", SqlDbType.NVarChar)
        sqlPara(13).Value = ast.FactoryNumber
        sqlPara(14) = New SqlParameter("@Factory", SqlDbType.NVarChar)
        sqlPara(14).Value = ast.Factory
        sqlPara(15) = New SqlParameter("@Style", SqlDbType.NVarChar)
        sqlPara(15).Value = ast.Style
        sqlPara(16) = New SqlParameter("@PurchaseDate", SqlDbType.DateTime)
        sqlPara(16).Value = ast.PurchaseDate
        sqlPara(17) = New SqlParameter("@ManufactureDate", SqlDbType.DateTime)
        sqlPara(17).Value = ast.ManufactureDate
        sqlPara(18) = New SqlParameter("@PeriodLimitDate", SqlDbType.DateTime)
        sqlPara(18).Value = ast.PeriodLimitDate
        sqlPara(19) = New SqlParameter("@Country", SqlDbType.NVarChar)
        sqlPara(19).Value = ast.Country
        sqlPara(20) = New SqlParameter("@InvoiceCode", SqlDbType.NVarChar)
        sqlPara(20).Value = ast.InvoiceCode
        sqlPara(21) = New SqlParameter("@FundCaseID", SqlDbType.Int)
        sqlPara(21).Value = ast.FundCaseid
        sqlPara(22) = New SqlParameter("@SourceCaseID", SqlDbType.Int)
        sqlPara(22).Value = ast.SourceCaseid
        sqlPara(23) = New SqlParameter("@ApplyCaseID", SqlDbType.Int)
        sqlPara(23).Value = ast.ApplyCaseid
        sqlPara(24) = New SqlParameter("@PurchaseCode", SqlDbType.NVarChar)
        sqlPara(24).Value = ast.PurchaseCode
        sqlPara(25) = New SqlParameter("@Supplier", SqlDbType.NVarChar)
        sqlPara(25).Value = ast.Supplier
        sqlPara(26) = New SqlParameter("@SupplierManager", SqlDbType.NVarChar)
        sqlPara(26).Value = ast.SupplierManager
        sqlPara(27) = New SqlParameter("@ForeignCurrencyPrice", SqlDbType.Decimal)
        sqlPara(27).Value = ast.ForeignCurrencyPrice
        sqlPara(28) = New SqlParameter("@TransportationCosts", SqlDbType.Decimal)
        sqlPara(28).Value = ast.TransportationCosts
        sqlPara(29) = New SqlParameter("@Penalty", SqlDbType.Decimal)
        sqlPara(29).Value = ast.Penalty
        sqlPara(30) = New SqlParameter("@OtherCost", SqlDbType.Decimal)
        sqlPara(30).Value = ast.OtherCost
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        ast.Assetsid = i
        Return ast
    End    Function 
     Shared Function  Update(ast As Model.Assets) As Model.Assets
        Dim sqlPara(33) As SqlParameter
        Dim sql As String
        sql = "update Assets  set TypeID=@TypeID,MagUserID=@MagUserID,CaseID=@CaseID,CardCode=@CardCode,Barcode=@Barcode,Title=@Title,TitlePin=@TitlePin,Price=@Price,Number=@Number,Unit=@Unit,Remark=@Remark,Pubdate=@Pubdate,AccountedPubdate=@AccountedPubdate,BuyPubdate=@BuyPubdate,Format=@Format,FactoryNumber=@FactoryNumber,Factory=@Factory,Style=@Style,PurchaseDate=@PurchaseDate,ManufactureDate=@ManufactureDate,PeriodLimitDate=@PeriodLimitDate,Country=@Country,InvoiceCode=@InvoiceCode,FundCaseID=@FundCaseID,SourceCaseID=@SourceCaseID,ApplyCaseID=@ApplyCaseID,PurchaseCode=@PurchaseCode,Supplier=@Supplier,SupplierManager=@SupplierManager,ForeignCurrencyPrice=@ForeignCurrencyPrice,TransportationCosts=@TransportationCosts,Penalty=@Penalty,OtherCost=@OtherCost  where  AssetsID=@AssetsID "
        sqlPara(31) = New SqlParameter("@TypeID", SqlDbType.Int)
        sqlPara(31).Value = ast.Typeid
        sqlPara(32) = New SqlParameter("@TitlePin", SqlDbType.NVarChar)
        sqlPara(32).Value = ast.TitlePin
        sqlPara(33) = New SqlParameter("@Unit", SqlDbType.NVarChar)
        sqlPara(33).Value = ast.Unit

        sqlPara(0) = New SqlParameter("@AssetsID", SqlDbType.Int)
        sqlPara(0).Value = ast.Assetsid
        sqlPara(1) = New SqlParameter("@MagUserID", SqlDbType.Int)
        sqlPara(1).Value = ast.MagUserid
        sqlPara(2) = New SqlParameter("@CaseID", SqlDbType.Int)
        sqlPara(2).Value = ast.Caseid
        sqlPara(3) = New SqlParameter("@CardCode", SqlDbType.NVarChar)
        sqlPara(3).Value = ast.CardCode
        sqlPara(4) = New SqlParameter("@Barcode", SqlDbType.NVarChar)
        sqlPara(4).Value = ast.Barcode
        sqlPara(5) = New SqlParameter("@Title", SqlDbType.NVarChar)
        sqlPara(5).Value = ast.Title
        sqlPara(6) = New SqlParameter("@Price", SqlDbType.Decimal)
        sqlPara(6).Value = ast.Price
        sqlPara(7) = New SqlParameter("@Number", SqlDbType.Int)
        sqlPara(7).Value = ast.Number
        sqlPara(8) = New SqlParameter("@Remark", SqlDbType.NVarChar)
        sqlPara(8).Value = ast.Remark
        sqlPara(9) = New SqlParameter("@Pubdate", SqlDbType.DateTime)
        sqlPara(9).Value = ast.Pubdate
        sqlPara(10) = New SqlParameter("@AccountedPubdate", SqlDbType.DateTime)
        sqlPara(10).Value = ast.AccountedPubdate
        sqlPara(11) = New SqlParameter("@BuyPubdate", SqlDbType.DateTime)
        sqlPara(11).Value = ast.BuyPubdate
        sqlPara(12) = New SqlParameter("@Format", SqlDbType.NVarChar)
        sqlPara(12).Value = ast.Format
        sqlPara(13) = New SqlParameter("@FactoryNumber", SqlDbType.NVarChar)
        sqlPara(13).Value = ast.FactoryNumber
        sqlPara(14) = New SqlParameter("@Factory", SqlDbType.NVarChar)
        sqlPara(14).Value = ast.Factory
        sqlPara(15) = New SqlParameter("@Style", SqlDbType.NVarChar)
        sqlPara(15).Value = ast.Style
        sqlPara(16) = New SqlParameter("@PurchaseDate", SqlDbType.DateTime)
        sqlPara(16).Value = ast.PurchaseDate
        sqlPara(17) = New SqlParameter("@ManufactureDate", SqlDbType.DateTime)
        sqlPara(17).Value = ast.ManufactureDate
        sqlPara(18) = New SqlParameter("@PeriodLimitDate", SqlDbType.DateTime)
        sqlPara(18).Value = ast.PeriodLimitDate
        sqlPara(19) = New SqlParameter("@Country", SqlDbType.NVarChar)
        sqlPara(19).Value = ast.Country
        sqlPara(20) = New SqlParameter("@InvoiceCode", SqlDbType.NVarChar)
        sqlPara(20).Value = ast.InvoiceCode
        sqlPara(21) = New SqlParameter("@FundCaseID", SqlDbType.Int)
        sqlPara(21).Value = ast.FundCaseid
        sqlPara(22) = New SqlParameter("@SourceCaseID", SqlDbType.Int)
        sqlPara(22).Value = ast.SourceCaseid
        sqlPara(23) = New SqlParameter("@ApplyCaseID", SqlDbType.Int)
        sqlPara(23).Value = ast.ApplyCaseid
        sqlPara(24) = New SqlParameter("@PurchaseCode", SqlDbType.NVarChar)
        sqlPara(24).Value = ast.PurchaseCode
        sqlPara(25) = New SqlParameter("@Supplier", SqlDbType.NVarChar)
        sqlPara(25).Value = ast.Supplier
        sqlPara(26) = New SqlParameter("@SupplierManager", SqlDbType.NVarChar)
        sqlPara(26).Value = ast.SupplierManager
        sqlPara(27) = New SqlParameter("@ForeignCurrencyPrice", SqlDbType.Decimal)
        sqlPara(27).Value = ast.ForeignCurrencyPrice
        sqlPara(28) = New SqlParameter("@TransportationCosts", SqlDbType.Decimal)
        sqlPara(28).Value = ast.TransportationCosts
        sqlPara(29) = New SqlParameter("@Penalty", SqlDbType.Decimal)
        sqlPara(29).Value = ast.Penalty
        sqlPara(30) = New SqlParameter("@OtherCost", SqlDbType.Decimal)
        sqlPara(30).Value = ast.OtherCost
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return ast
    End    Function 
     Shared Function  del(AssetsID As Integer) As Boolean
        Dim sql As String
        sql = "delete   from Assets where AssetsID=" & AssetsID
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End    Function 
     Shared Function  Multidel(AssetsIDs As String) As Boolean
        Dim sql As String
        sql = "delete   from Assets where AssetsID in(" & AssetsIDs & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End    Function 
     Shared Function  dt() As DataTable
        Dim sql As String
        sql = "select * from Assets "
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End    Function 
     Shared Function  dt(caseid As Integer) As DataTable
        Dim sql As String
        sql = "select * from Assets where caseid= " & caseid

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End    Function 
     Shared Function  rs(AssetsID As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from Assets where AssetsID=" & AssetsID
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End    Function 
     Shared Function  Title(AssetsID As Integer) As String
        Dim sql As String
        sql = "select title from Assets where AssetsID=" & AssetsID
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
    End    Function 

     Shared Function  Entity(AssetsID As Integer) As Model.Assets
        Return Fabricate.Fill(Of Model.Assets)(rs(AssetsID))
    End    Function 
     Shared Function  Count(Caseid As Integer) As Int16
        Dim sql As String
        sql = "select count(*) from Assets where Caseid=" & Caseid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End    Function 
     Shared Function  CountBybarcode(Barcode As String) As Int16
        Dim sql As String
        sql = "select count(*) from Assets where Barcode='" & Barcode & "'"
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)
    End    Function 
     Shared Function  PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "Assets"
        Return PagerHelper.ProPager(pi, ConnStr)
    End    Function 
     Shared Function  PurchaseCode(typeid As Integer, keyword As String) As String
        Dim sql As String
        sql = "select top 1 PurchaseCode from Assets where typeid=" & typeid & " and PurchaseCode like '" & keyword & "%' order by PurchaseCode desc"
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 
     Shared Function  BarCode(typeid As Integer) As String
        Dim sql As String
        sql = "select top 1 Barcode from Assets where typeid=" & typeid & " and len(barcode)<=10 order by barcode desc"


        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 

     Shared Function  BarCode(typeid As Integer, Caseid As Integer) As String
        Dim sql As String
        sql = "select top 1 Barcode from Assets where typeid=" & typeid & " and caseid=" & Caseid & " order by barcode desc"
        Return SafeData.s_string(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 
     Shared Function  AssetsId(BarCode As String) As Int16
        Dim sql As String
        sql = "select AssetsId from Assets where BarCode='" & BarCode & "'"
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 
     Shared Function  AssetsIdByTitle(title As String, Optional typeid As Integer = 0) As Int16
        Dim sql As String
        sql = "select AssetsId from Assets where title='" & title & "'"
        If typeid > 0 Then
            sql = sql & " and typeid=" & typeid
        End If
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 

     Shared Function  AssetsId(SourceCaseid As Integer, title As String) As Int16
        Dim sql As String
        sql = "select AssetsId from Assets where title='" & title & "' and SourceCaseid=" & SourceCaseid
        Return SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))

    End    Function 
End Class
