Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports Wzsckj.com.Common
Imports stringHandling
Imports System.Web.HttpContext
Public Class DataMainDAL
    Shared Function insert(DM As Model.DataMain) As Model.DataMain
        Dim sqlPara(21) As SqlParameter
        Dim sql As String
        sql = "insert into Data_Main (ModuleId,ZyTypeid,ParentId,UserID,UnitId,CaseID,PIndex,BrowCount,Status,Cmd,UserRight,Author,PubDate,DocGetNum,DocNum,Title,Remark,Content,Cent,EndDate,Caseids) values (@ModuleId,@ZyTypeid,@ParentId,@UserID,@UnitId,@CaseID,@PIndex,@BrowCount,@Status,@Cmd,@UserRight,@Author,@PubDate,@DocGetNum,@DocNum,@Title,@Remark,@Content,@Cent,@EndDate,@Caseids);SELECT @@IDENTITY"
        sqlpara(0) = New SqlParameter("@ZyTypeid", SqlDbType.int)
        sqlpara(0).Value = DM.ZyTypeid
        sqlPara(21) = New SqlParameter("@ModuleId", SqlDbType.Int)
        sqlPara(21).Value = DM.ModuleId
        sqlPara(1) = New SqlParameter("@ParentId", SqlDbType.Int)
        sqlpara(1).Value = DM.ParentId
        sqlpara(2) = New SqlParameter("@UserID", SqlDbType.int)
        sqlpara(2).Value = DM.UserID
        sqlpara(3) = New SqlParameter("@UnitId", SqlDbType.int)
        sqlpara(3).Value = DM.UnitId
        sqlpara(4) = New SqlParameter("@CaseID", SqlDbType.int)
        sqlpara(4).Value = DM.CaseID
        sqlpara(5) = New SqlParameter("@PIndex", SqlDbType.int)
        sqlpara(5).Value = DM.PIndex
        sqlpara(6) = New SqlParameter("@BrowCount", SqlDbType.int)
        sqlpara(6).Value = DM.BrowCount
        sqlpara(7) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(7).Value = DM.Status
        sqlpara(8) = New SqlParameter("@Cmd", SqlDbType.bit)
        sqlpara(8).Value = DM.Cmd
        sqlpara(9) = New SqlParameter("@UserRight", SqlDbType.bit)
        sqlpara(9).Value = DM.UserRight
        sqlpara(10) = New SqlParameter("@Author", SqlDbType.nvarchar)
        sqlpara(10).Value = DM.Author
        sqlpara(11) = New SqlParameter("@PubDate", SqlDbType.datetime)
        sqlpara(11).Value = DM.PubDate
        sqlpara(12) = New SqlParameter("@DocGetNum", SqlDbType.nvarchar)
        sqlpara(12).Value = DM.DocGetNum
        sqlpara(13) = New SqlParameter("@DocNum", SqlDbType.nvarchar)
        sqlpara(13).Value = DM.DocNum
        sqlpara(14) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(14).Value = DM.Title
        sqlpara(15) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(15).Value = DM.Remark
        sqlpara(16) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(16).Value = DM.Content
        sqlpara(17) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(17).Value = DM.Cent
        sqlpara(18) = New SqlParameter("@EndDate", SqlDbType.datetime)
        sqlpara(18).Value = DM.EndDate
        sqlpara(19) = New SqlParameter("@Caseids", SqlDbType.nvarchar)
        sqlpara(19).Value = DM.Caseids
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        DM.ID = i
        Return DM
    End Function
    Shared Function Update(DM As Model.DataMain) As Model.DataMain
        Dim sqlPara(20) As SqlParameter
        Dim sql As String
        sql = "update Data_Main  set ZyTypeid=@ZyTypeid,ParentId=@ParentId,UserID=@UserID,UnitId=@UnitId,CaseID=@CaseID,PIndex=@PIndex,BrowCount=@BrowCount,Status=@Status,Cmd=@Cmd,UserRight=@UserRight,Author=@Author,PubDate=@PubDate,DocGetNum=@DocGetNum,DocNum=@DocNum,Title=@Title,Remark=@Remark,Content=@Content,Cent=@Cent,EndDate=@EndDate,Caseids=@Caseids  where  ID=@ID "
        sqlpara(0) = New SqlParameter("@ID", SqlDbType.int)
        sqlpara(0).Value = DM.ID
        sqlpara(1) = New SqlParameter("@ZyTypeid", SqlDbType.int)
        sqlpara(1).Value = DM.ZyTypeid
        sqlpara(2) = New SqlParameter("@ParentId", SqlDbType.int)
        sqlpara(2).Value = DM.ParentId
        sqlpara(3) = New SqlParameter("@UserID", SqlDbType.int)
        sqlpara(3).Value = DM.UserID
        sqlpara(4) = New SqlParameter("@UnitId", SqlDbType.int)
        sqlpara(4).Value = DM.UnitId
        sqlpara(5) = New SqlParameter("@CaseID", SqlDbType.int)
        sqlpara(5).Value = DM.CaseID
        sqlpara(6) = New SqlParameter("@PIndex", SqlDbType.int)
        sqlpara(6).Value = DM.PIndex
        sqlpara(7) = New SqlParameter("@BrowCount", SqlDbType.int)
        sqlpara(7).Value = DM.BrowCount
        sqlpara(8) = New SqlParameter("@Status", SqlDbType.bit)
        sqlpara(8).Value = DM.Status
        sqlpara(9) = New SqlParameter("@Cmd", SqlDbType.bit)
        sqlpara(9).Value = DM.Cmd
        sqlpara(10) = New SqlParameter("@UserRight", SqlDbType.bit)
        sqlpara(10).Value = DM.UserRight
        sqlpara(11) = New SqlParameter("@Author", SqlDbType.nvarchar)
        sqlpara(11).Value = DM.Author
        sqlpara(12) = New SqlParameter("@PubDate", SqlDbType.datetime)
        sqlpara(12).Value = DM.PubDate
        sqlpara(13) = New SqlParameter("@DocGetNum", SqlDbType.nvarchar)
        sqlpara(13).Value = DM.DocGetNum
        sqlpara(14) = New SqlParameter("@DocNum", SqlDbType.nvarchar)
        sqlpara(14).Value = DM.DocNum
        sqlpara(15) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(15).Value = DM.Title
        sqlpara(16) = New SqlParameter("@Remark", SqlDbType.nvarchar)
        sqlpara(16).Value = DM.Remark
        sqlpara(17) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(17).Value = DM.Content
        sqlpara(18) = New SqlParameter("@Cent", SqlDbType.float)
        sqlpara(18).Value = DM.Cent
        sqlpara(19) = New SqlParameter("@EndDate", SqlDbType.datetime)
        sqlpara(19).Value = DM.EndDate
        sqlpara(20) = New SqlParameter("@Caseids", SqlDbType.nvarchar)
        sqlpara(20).Value = DM.Caseids
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return DM
    End Function
   shared Function del(id As Integer, userid As Integer) As Boolean
        Dim sql As String
        sql = "delete from Data_Main where id= " & id & " and userid=" & userid
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        End If
    End Function

   shared Function del(id As Integer) As Boolean
        Dim sql As String
        sql = "delete from Data_Main where id= " & id
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        End If
    End Function
   shared Function Multidel(ids As String) As Boolean
        Dim sql As String
        sql = "delete from Data_Main where id in( " & ids & ")"
        Dim i As Integer = SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)
        If i > 0 Then
            Return True
        End If
    End Function

   shared Function GetId(dm As Model.DataMain) As Integer
        Dim sql As String
        sql = "select id from data_main where caseid=" & dm.Caseid & " and userid=" & dm.Userid & " and parentid=" & dm.ParentId
        Return SafeData.s_integer((SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)))


    End Function
    Shared Function GetPrevId(id) As Integer
        Dim sql As String
        sql = "select id from data_main where  id<" & id
        Return SafeData.s_integer((SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)))


    End Function

    Shared Function GetNextId(id) As Integer
        Dim sql As String
        sql = "select id from data_main where  id>" & id
        Return SafeData.s_integer((SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)))


    End Function
    Shared Function RsPrev(id As Integer, caseid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select top 1 * from Data_Main where id< " & id & " and caseid=" & caseid & " order by id desc"
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function

    Shared Function RsNext(id As Integer, caseid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select top 1 * from Data_Main where id>" & id & " and caseid=" & caseid & "  order by id asc"
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function





    Shared Function Rs(id As Integer, userid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from Data_Main where id= " & id & " and userid=" & userid
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function

   shared Function Rs(id As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from Data_Main where id= " & id
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function
   shared Function RsByCaseId(caseid As Integer, Optional unitid As Integer = 0, Optional typeid As Integer = 0) As SqlDataReader
        Dim sql As String
        sql = "select top 1 * from Data_Main where caseid= " & caseid
        If unitid > 0 Then
            sql = sql & " and unitid=" & unitid
        End If
        If typeid > 0 Then
            sql = sql & " and zytypeid=" & typeid
        End If
        sql = sql & " order by pubdate desc"
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function
   shared Function RsByParentid(parentid As Integer, Optional userid As Integer = 0) As SqlDataReader
        Dim sql As String
        sql = "select top 1 * from Data_Main where parentid= " & parentid
        If userid > 0 Then
            sql = sql & " and userid=" & userid

        End If
        Return (SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function
   shared Function EntityByParentId(parentid As Integer, userid As Integer) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(RsByParentid(parentid, userid))
    End Function

   shared Function EntityByCaseId(caseid As Integer, Optional unitid As Integer = 0, Optional typeid As Integer = 0) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(RsByCaseId(caseid, unitid, typeid))
    End Function
    Shared Function Entity(id As Integer, userid As Integer) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(Rs(id, userid))
    End Function

   shared Function Entity(id As Integer) As Model.DataMain
        Return Fabricate.Fill(Of Model.DataMain)(Rs(id))
    End Function
   shared Function Dt() As DataTable
        Dim sql As String
        sql = "select * from data_main"


        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))


    End Function
    Shared Function DtDistinctUserId(sd As String, ed As String) As DataTable
        Dim sql As String
        sql = "select   userid,count(*) as num from data_main where 1=1 "
        Dim sdstr As String = StringHandling.String.DateBetweenStr(sd, ed)
        If sdstr <> "" Then sql = sql & " and " & sdstr
        sql = sql & " group by userid "
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))


    End Function

   shared Function DtByUserid(caseid As Integer, userid As Integer) As DataTable
        Dim sql As String

        sql = "select  * from data_main where caseid =" & caseid & " and userid=" & userid & " order by pubdate desc"
       

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function cmd_Dt(caseid As Integer, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & " * from data_main where cmd=1"
        Else
            sql = "select * from data_main where  cmd=1 "

        End If
        If caseid > 0 Then
            sql = sql & " and  caseid =" & caseid
        End If
        sql = sql & "  order by pubdate desc"
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function DtByModuleid(Moduleid As Integer, Optional topRows As Integer = 10, Optional orderby As String = "pubdate desc") As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & " * from data_main where 1=1"
        Else
            sql = "select * from data_main where 1=1 "

        End If
        If Moduleid > 0 Then
            sql = sql & " and  Moduleid =" & Moduleid
        End If
        sql = sql & "  order by " & orderby
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function

   shared Function Dt(caseid As Integer, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & " * from data_main where 1=1"
        Else
            sql = "select * from data_main where 1=1 "

        End If
        If caseid > 0 Then
            sql = sql & " and  caseid =" & caseid
        End If
        sql = sql & " and status=1  order by pubdate desc"
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function Dt(dm As Model.DataMain, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & " * from data_main where 1=1"
        Else
            sql = "select * from data_main where 1=1 "

        End If
        If dm.Caseid > 0 Then
            sql = sql & " and  caseid =" & dm.Caseid
        End If
        If dm.Userid > 0 Then
            sql = sql & " and  Userid =" & dm.Userid
        End If
        If dm.ZyTypeid > 0 Then
            sql = sql & " and  ZyTypeid =" & dm.ZyTypeid
        End If
        sql = sql & "  order by pubdate desc"
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function

   shared Function DtByParentid(parentid As Integer, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & " * from data_main where parentid =" & parentid & "  order by pubdate desc"
        Else
            sql = "select * from data_main where caseid =" & parentid & "  order by pubdate desc"

        End If

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
    Shared Function DtChecked(caseids As String, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & "  * from data_main where caseid in(" & caseids & ") and status=1 order by pubdate desc"

        Else
            sql = "select * from data_main where caseid in(" & caseids & ") and status=1 order by pubdate desc"

        End If

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function

   shared Function Dt(caseids As String, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & "  * from data_main where caseid in(" & caseids & ") and status=1 order by pubdate desc"

        Else
            sql = "select * from data_main where caseid in(" & caseids & ") and status=1  order by pubdate desc"

        End If

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function DtByTypeid(caseids As String, courseid As Integer, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & "  * from data_main where zyTypeid in(" & caseids & ")  "

        Else
            sql = "select * from data_main where zyTypeid in(" & caseids & ") "

        End If
        If courseid > 0 Then
            sql = sql & " and unitid=" & courseid

        End If
        sql = sql & " order by pubdate desc"



        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function DtByCaseid(caseids As String, courseid As Integer, Optional topRows As Integer = 10) As DataTable
        Dim sql As String
        If topRows > 0 Then
            sql = "select top " & topRows & "  * from data_main where caseid in(" & caseids & ")  "

        Else
            sql = "select * from data_main where caseid in(" & caseids & ") "

        End If
        If courseid > 0 Then
            sql = sql & " and unitid=" & courseid

        End If
        sql = sql & " order by caseid asc"



        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function

   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "data_main"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
   shared Function DtByuser(userid As Integer) As DataTable
        Dim sql As String
        sql = "select * from data_main where userid =" & userid

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function UserDt(caseids As String, Optional topnum As Integer = 0) As DataTable
        Dim sql As String
        If topnum = 0 Then
            sql = "  select    distinct    userid   from View_Data_Main where caseid in(" & caseids & ")"

        Else

            sql = "  select      distinct    top " & topnum & " userid  from View_Data_Main where caseid in(" & caseids & ")"
        End If

        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))
    End Function
   shared Function Pindex(caseid As Integer) As Integer
        Dim sql As String
        sql = "select max(pindex)  from Data_Main where caseid= " & caseid
        Dim i As Integer = SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
        Return i
    End Function
   shared Function UpdateClicks(id As Integer) As Boolean
        Dim sql As String
        sql = "update   data_main set BrowCount=BrowCount+1 where id=" & id
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0


    End Function
   shared Function Count(parentid As Integer) As Integer
        Dim sql As String
        sql = "select count(id)  from Data_Main where parentid= " & parentid
        Dim i As Integer = SafeData.s_integer(SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql))
        Return i
    End Function
   shared Function DtbyUserGroup(caseid As Integer, groupid As Integer) As DataTable
        Dim sql As String
        sql = "select * from data_main where caseid=" & caseid & " and id in (select parentid from data_main where caseid=" & caseid & " and userid in (select userid from User_SystemCase where caseid =" & groupid & "))"
        Return (SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0))

    End Function
   shared Function Entity(dm As Model.DataMain) As Model.DataMain
        Dim sql As String
        sql = "select * from Data_Main where parentid= " & dm.ParentId & " and userid=" & dm.Userid
        Return Fabricate.Fill(Of Model.DataMain)(SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql))

    End Function

End Class
