Imports View
Imports Wzsckj.com.Common

Public Class WebSearch
    Inherits System.Web.UI.Page
    Dim pi As PagerInfo

    Dim dmview As New DataMainView
    Dim pageIndex As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pageIndex = IIf(Request.QueryString("page") = "", 1, Request.QueryString("page"))
        Dim keyword As String = Request.QueryString("keyword")
        keyword = StringHandling.SafeData.SafeString(keyword)
        lt_sitenav.Text = keyword

        pi.PageIndex = pageIndex
        pi.PageSize = AspNetPager1.PageSize
        pi.strwhere = "title like '%" & keyword & "%'"
        lt_list.Text = "<ul class='newslist'>" & dmview.KeywordinfoPagelist(pi) & "</ul>"
 
        AspNetPager1.RecordCount = pi.TotalCount

    End Sub

End Class