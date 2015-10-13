Imports StringHandling

Public Class Footer
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        flog_class.Debug("Footer")
        If Not IsPostBack Then
            flog_class.Debug("BLL.SystemInfoParamBLL")
            Dim sysl As New BLL.SystemInfoParamBLL
            Dim temp As New StringBuilder
            flog_class.Debug("sysl.Rs(1)")
            Dim rs As Data.SqlClient.SqlDataReader = sysl.Rs(1)

            If rs.Read Then

                temp.Append("<p>" & rs("schoolname") & " 版权所有 Copyright©2011-2014 ,All Rights Reserved </p>")
                temp.AppendLine("<p>")
                If SafeData.s_string(rs("address")) <> "" Then
                    temp.Append("地址：" & rs("address"))
                End If

                temp.Append(" 电话：" & rs("contact"))
                temp.Append(" <a href='http://www.miibeian.gov.cn/' targer=_blank>" & rs("ICP") & "</a> ")
                temp.Append(rs("content"))
                temp.AppendLine("</p>")
            End If
            rs.Close()
            rs = Nothing
            flog_class.Debug("Literal1.Text ")
            Literal1.Text = temp.ToString
        End If
    End Sub

End Class