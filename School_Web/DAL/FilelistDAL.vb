Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Model
Imports Wzsckj.com.Common
Imports StringHandling
Imports System.Web.HttpContext
Public Class FilelistDAL
    Shared Function insert(FL As Model.FileList) As Model.FileList
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "insert into FileList (UserId,caseid,Parentid,Pindex,ProjectId,Path,Title,Ext,Filesize,Content,IndexImagePath,Pubdate) values (@UserId,@caseid,@Parentid,@Pindex,@ProjectId,@Path,@Title,@Ext,@Filesize,@Content,@IndexImagePath,@Pubdate);SELECT @@IDENTITY"
        sqlPara(12) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(12).Value = FL.Caseid
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlpara(1).Value = FL.UserId
        sqlpara(2) = New SqlParameter("@Parentid", SqlDbType.int)
        sqlpara(2).Value = FL.Parentid
        sqlpara(3) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(3).Value = FL.Pindex
        sqlpara(4) = New SqlParameter("@ProjectId", SqlDbType.int)
        sqlpara(4).Value = FL.ProjectId
        sqlpara(5) = New SqlParameter("@Path", SqlDbType.nvarchar)
        sqlpara(5).Value = FL.Path
        sqlpara(6) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(6).Value = FL.Title
        sqlpara(7) = New SqlParameter("@Ext", SqlDbType.nvarchar)
        sqlpara(7).Value = FL.Ext
        sqlpara(8) = New SqlParameter("@Filesize", SqlDbType.float)
        sqlpara(8).Value = FL.Filesize
        sqlpara(9) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(9).Value = FL.Content
        sqlpara(10) = New SqlParameter("@IndexImagePath", SqlDbType.nvarchar)
        sqlpara(10).Value = FL.IndexImagePath
        sqlpara(11) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(11).Value = FL.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        FL.FileId = i
        Return FL
    End Function
   shared Function Update(FL As Model.FileList) As Model.FileList
        Dim sqlPara(12) As SqlParameter
        Dim sql As String
        sql = "update FileList  set  caseid=@caseid,UserId=@UserId,Parentid=@Parentid,Pindex=@Pindex,ProjectId=@ProjectId,Path=@Path,Title=@Title,Ext=@Ext,Filesize=@Filesize,Content=@Content,IndexImagePath=@IndexImagePath,Pubdate=@Pubdate  where  FileId=@FileId "
        sqlPara(12) = New SqlParameter("@Caseid", SqlDbType.Int)
        sqlPara(12).Value = FL.Caseid
        sqlPara(0) = New SqlParameter("@fileid", SqlDbType.Int)
        sqlPara(0).Value = FL.FileId
        sqlPara(1) = New SqlParameter("@UserId", SqlDbType.Int)
        sqlPara(1).Value = FL.UserId
        sqlPara(2) = New SqlParameter("@Parentid", SqlDbType.Int)
        sqlpara(2).Value = FL.Parentid
        sqlpara(3) = New SqlParameter("@Pindex", SqlDbType.int)
        sqlpara(3).Value = FL.Pindex
        sqlpara(4) = New SqlParameter("@ProjectId", SqlDbType.int)
        sqlpara(4).Value = FL.ProjectId
        sqlpara(5) = New SqlParameter("@Path", SqlDbType.nvarchar)
        sqlpara(5).Value = FL.Path
        sqlpara(6) = New SqlParameter("@Title", SqlDbType.nvarchar)
        sqlpara(6).Value = FL.Title
        sqlpara(7) = New SqlParameter("@Ext", SqlDbType.nvarchar)
        sqlpara(7).Value = FL.Ext
        sqlpara(8) = New SqlParameter("@Filesize", SqlDbType.float)
        sqlpara(8).Value = FL.Filesize
        sqlpara(9) = New SqlParameter("@Content", SqlDbType.nvarchar)
        sqlpara(9).Value = FL.Content
        sqlpara(10) = New SqlParameter("@IndexImagePath", SqlDbType.nvarchar)
        sqlpara(10).Value = FL.IndexImagePath
        sqlpara(11) = New SqlParameter("@Pubdate", SqlDbType.datetime)
        sqlpara(11).Value = FL.Pubdate
        Dim i As Integer = SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql, sqlPara)
        Return FL
    End Function
   shared Function Update(projectid As Integer, fileids As String, Optional Parentid As Integer = 0) As Boolean
        Dim sql As String
        If Parentid > 0 Then
            sql = "update     FileList set parentid=" & Parentid & " where fileid in(" & fileids & ")"

        Else

            sql = "update     FileList set projectid=" & projectid & " where fileid in(" & fileids & ")"
        End If
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function
    Shared Function Update2(parentid As Integer, fileids As String, userid As Integer) As Boolean
        Dim sql As String
        sql = "update     FileList set parentid=" & parentid & " where fileid in(" & fileids & ") and userid=" & userid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function

   shared Function UpdateUserid(Userid As Integer, fileids As String) As Boolean
        Dim sql As String

        sql = "update     FileList set userid=" & Userid & " where fileid in(" & fileids & ")"


        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function

   shared Function DelByParentid(Parentid As Integer, Caseid As Integer) As Integer
        Dim sql As String
        sql = "delete   from FileList where Parentid=" & Parentid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function
 
   shared Function DelByParentid(Parentid As Integer) As Integer
        Dim sql As String
        sql = "delete   from FileList where projectid=" & Parentid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function
   shared Function DelByParentid(Parentids As String) As Integer
        Dim sql As String
        sql = "delete   from FileList where projectid in(" & Parentids & ")"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function
   shared Function DelByProjectid(Pindex As Integer, projectids As String) As Integer
        Dim sql As String
        sql = "delete   from FileList where projectid in(" & projectids & ") and pindex=" & Pindex
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql)

    End Function

   shared Function del(fileid As Integer) As Boolean
        Dim sql As String
        sql = "delete   from FileList where fileid=" & fileid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0
    End Function
   shared Function dt(projectid As Integer) As DataTable
        Dim sql As String
        sql = "select * from FileList where projectid=" & projectid
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt2(parentid As Integer, unitid As Integer, caseid As Integer) As DataTable
        Dim sql As String
        sql = "select * from FileList where parentid=" & parentid & " and caseid=" & caseid
        If unitid > 0 Then
            sql = sql & " and projectid=" & unitid
        End If

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function PagerDt(ByRef pi As PagerInfo) As DataTable
        pi.Tablename = "filelist"
        Return PagerHelper.ProPager(pi, ConnStr)
    End Function
    Shared Function dt() As DataTable
        Dim sql As String
        sql = "select * from FileList "
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

   shared Function dt(pindex As Integer, projectid As Integer) As DataTable
        Dim sql As String
        sql = "select * from FileList where projectid=" & projectid & " and pindex=" & pindex
        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function dt(f As Model.FileList, Optional top As Integer = 0, Optional orderStr As String = "pubdate asc") As DataTable
        Dim sql As String
        If top = 0 Then
            sql = "select   * from FileList where projectid=" & f.ProjectId & " and pindex=" & f.Pindex

        Else
            sql = "select top " & top & " * from FileList where projectid=" & f.ProjectId & " and pindex=" & f.Pindex

        End If
        If f.UserId > 0 Then sql = sql & " and userid=" & f.UserId
        If f.CaseId > 0 Then sql = sql & " and caseid=" & f.CaseId
        If f.Parentid > 0 Then sql = sql & " and Parentid=" & f.Parentid
        sql = sql & " order by " & orderStr



        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function

   shared Function dt(pindex As Integer, projectid As Integer, userid As Integer) As DataTable
        Dim sql As String
        sql = "select * from FileList where projectid=" & projectid & " and pindex=" & pindex
        If userid > 0 Then sql = sql & " and userid=" & userid

        Return SqlHelper.ExecuteDataset(ConnStr, CommandType.Text, sql).Tables(0)
    End Function
   shared Function Count(projectid As Integer, pindex As Integer, sd As String, ed As String) As Int16
        Dim sql As String
        sql = "select count(*) from FileList where projectid=" & projectid & " and pindex=" & pindex
        If sd <> "" Then

        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function Count(projectid As Integer, pindex As Integer) As Int16
        Dim sql As String
        sql = "select count(*) from FileList where projectid=" & projectid & " and pindex=" & pindex
         
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function


   shared Function Count(f As FileList, Optional StrWhere As String = "") As Int16
        Dim sql As String
        sql = "select count(*) from FileList where projectid=" & f.ProjectId & " and pindex=" & f.Pindex
        If f.CaseId > 0 Then
            sql = sql & " and caseid=" & f.CaseId
        End If
        If f.UserId > 0 Then
            sql = sql & " and userid=" & f.UserId
        End If
        If f.Parentid > 0 Then
            sql = sql & " and Parentid=" & f.Parentid
        End If
        sql = sql & StrWhere
      
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function fileid(projectid As Integer, parentid As Integer, caseid As Integer) As Int16
        Dim sql As String
        sql = "select top 1 FILEID from FileList where projectid=" & projectid & " and parentid=" & parentid & " and caseid=" & caseid

        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function fileid(file As Model.FileList) As Int16
        Dim sql As String
        sql = "select top 1 FILEID from FileList where 1=1"
         If file.ProjectId > 0 Then
            sql = sql & " and projectid=" & file.ProjectId

        End If
        If file.UserId > 0 Then
            sql = sql & " and userid=" & file.UserId

        End If
        If file.Parentid > 0 Then
            sql = sql & " and parentid=" & file.Parentid

        End If
        If file.CaseId > 0 Then
            sql = sql & " and caseid=" & file.CaseId

        End If
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function


   shared Function Count(projectid As Integer) As Int16
        Dim sql As String
        sql = "select count(*) from FileList where projectid=" & projectid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function CountbyParentid(parentid As Integer) As Int16
        Dim sql As String
        sql = "select count(*) from FileList where parentid=" & parentid
        Return SqlHelper.ExecuteScalar(ConnStr, CommandType.Text, sql)

    End Function
   shared Function rsByParentid(caseid As Integer, Parentid As Integer, Optional projectid As Integer = 0) As SqlDataReader
        Dim sql As String
        sql = "select top 1 * from FileList where 1=1"
        If Parentid > 0 Then
            sql = sql & " and  parentid=" & Parentid
        End If
        If caseid > 0 Then
            sql = sql & " and caseid=" & caseid
        End If
        If projectid > 0 Then
            sql = sql & " and projectid=" & projectid
        End If
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function rs(fileid As Integer) As SqlDataReader
        Dim sql As String
        sql = "select * from FileList where fileid=" & fileid
        Return SqlHelper.ExecuteReader(ConnStr, CommandType.Text, sql)
    End Function
   shared Function Entity(fileid As Integer) As Model.FileList
        Return Fabricate.Fill(Of Model.FileList)(rs(fileid))
    End Function
   shared Function EntityByparentid(caseid As Integer, Parentid As Integer, projectid As Integer) As Model.FileList
        Return Fabricate.Fill(Of Model.FileList)(rsByParentid(caseid, Parentid, projectid))
    End Function
   shared Function UpdateGradeid(Gradeid As Integer, userid As Integer, typeid As Integer) As Boolean
        Dim sql As String
        sql = "update FileList set gradeid=" & Gradeid & " where userid=" & userid & " and    Parentid=" & typeid & " and CaseId>0"
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0

    End Function
   shared Function Updateclick(fileid As Integer) As Boolean
        Dim sql As String
        sql = "update FileList set clicks=clicks+1 where fileid=" & fileid
        Return SqlHelper.ExecuteNonQuery(ConnStr, CommandType.Text, sql) > 0

    End Function
End Class
