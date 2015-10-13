Imports System.Data.SqlClient
Imports Wzsckj.com.Common

Public Class AssetsBLL
     Shared Function insert(ast As Model.Assets) As Model.Assets
        Return dal.assetsDAL.insert(ast)
    End Function
    Shared Function Update(ast As Model.Assets) As Model.Assets
        Return dal.assetsDAL.Update(ast)

    End Function
    Shared Function del(AssetsID As Integer) As Boolean
        Return dal.assetsDAL.del(AssetsID)
    End Function
    Shared Function Multidel(AssetsIDs As String) As Boolean
        Return dal.assetsDAL.Multidel(AssetsIDs)
    End Function
    Shared Function dt() As DataTable
        Return dal.assetsDAL.dt
    End Function
    Shared Function dt(caseid As Integer) As DataTable
        Return dal.assetsDAL.dt(caseid)
    End Function
    Shared Function rs(AssetsID As Integer) As SqlDataReader
        Return dal.assetsDAL.rs(AssetsID)

    End Function

    Shared Function Entity(AssetsID As Integer) As Model.Assets
        Return dal.assetsDAL.Entity(AssetsID)
    End Function
    Shared Function Count(Caseid As Integer) As Int16
        Return dal.assetsDAL.Count(Caseid)
    End Function
    Shared Function CountBybarcode(Barcode As String) As Int16
        Return dal.assetsDAL.CountBybarcode(Barcode)

    End Function

    Shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        Return dal.assetsDAL.PagerDt(pi)
    End Function
    Shared Function BarCode(typeid As Integer) As String
        Return dal.assetsDAL.BarCode(typeid)

    End Function
    Shared Function BarCode(typeid As Integer, Caseid As Integer) As String
        Return dal.assetsDAL.BarCode(typeid, Caseid)
    End Function
    Shared Function PurchaseCode(typeid As Integer, keyword As String) As String
        Return dal.assetsDAL.PurchaseCode(typeid, keyword)
    End Function
    Shared Function PurchaseCode(typeid As Integer) As String
        Dim k As String = Now.Date.ToString("yyyy-MM-dd").Replace("-", "")
        Dim code As String = PurchaseCode(typeid, k)
        If code = "" Then
            Return k & "-1"
        End If
        If code.Contains("-") Then
            Dim a() As String
            a = code.Split("-")
            Dim pindex As Integer = a(1)
            pindex = pindex + 1
            Return a(0) & "-" & pindex
        Else
            Return k & "-1"
        End If
    End Function

    Shared Function AssetsId(BarCode As String) As Int16
        Return dal.assetsDAL.AssetsId(BarCode)

    End Function
    Shared Function AssetsIdByTitle(title As String) As Int16
        Return dal.assetsDAL.AssetsIdByTitle(title)

    End Function

    Shared Function BarCodeNew(typeid As Integer, PrevStr As String, SnLength As Integer) As String
        '获得数据库中最新的条形码编号
        Dim bc As String = DAL.AssetsDAL.BarCode(typeid)



        '如果为空，则系统参数snlength长度的编号00001
        If bc = "" Then
            Dim i As Integer
            Dim s As String = ""
            For i = 1 To SnLength - 1
                s = s & "0"
            Next
            Return PrevStr & s & 1
        End If
        '如果存在最新编号，进行生成下个编号
        If bc <> "" Then

            Dim prev As String = bc.Substring(0, 2)
            bc = bc.Remove(0, 2) '删除前面单位001和1、2表示固定资产和流动资产类别的字符串
            If bc.Contains("-") Then
                Dim a() As String
                a = bc.Split("-")
                Dim pindex As Integer = Convert.ToInt32(a(0))
                pindex = pindex + 1
                Dim temp As String = "" & pindex
                Dim i As Integer
                Dim s As String = ""
                For i = 1 To SnLength - temp.Length
                    s = s & "0"
                Next
                Return PrevStr & s & temp
            Else
                Dim i As Integer
                Dim s As String = ""
                Dim pindex As Integer = Convert.ToInt32(bc)

                pindex = pindex + 1
                Dim temp As String = "" & pindex

                For i = 1 To SnLength - temp.Length
                    s = s & "0"
                Next
                Return PrevStr & s & temp
            End If

        End If

    End Function
    Shared Function BarCodeNew(typeid As Integer, Caseid As Integer, PrevStr As String, SnLength As Integer) As String
        Dim bc As String = BarCode(typeid, Caseid)
        If bc = "" Then
            Dim i As Integer
            Dim s As String = ""
            For i = 1 To SnLength - 1
                s = s & "0"
            Next
            Return PrevStr & s & 1
        End If
        If bc.Contains("-") Then
            Dim a() As String
            a = BarCode(typeid).Split("-")
            Dim n As Integer = a.Length
            Dim es As Integer = bc.IndexOf(a(n - 1))
            Dim pindex As Integer = a(n - 1)
            pindex = pindex + 1
            Dim temp As String = "" & pindex
            Dim i As Integer
            Dim s As String = ""
            For i = 1 To SnLength - temp.Length
                s = s & "0"
            Next
            Return bc.Substring(0, bc.Length - a(n - 1).ToString.Length) & s & temp
        Else
            Dim i As Integer
            Dim s As String = ""
            For i = 1 To SnLength - 1
                s = s & "0"
            Next
            Return PrevStr & s & 1
        End If

    End Function
    Shared Function FloatCode(typeid As Integer) As String


    End Function
    Shared Function Title(AssetsID As Integer) As String
        Return dal.assetsDAL.Title(AssetsID)

    End Function
    Shared Function AssetsId(SourceCaseid As Integer, title As String) As Int16
        Return dal.assetsDAL.AssetsId(SourceCaseid, title)

    End Function

End Class
