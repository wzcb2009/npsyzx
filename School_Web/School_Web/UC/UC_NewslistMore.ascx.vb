Imports View
Imports Wzsckj.com.Common

Public Class UC_NewslistMore
    Inherits System.Web.UI.UserControl

    Dim pi As PagerInfo
    Dim caseid_, Typeid_ As Integer
    Property Caseid As Integer
        Get
            Return caseid_
        End Get
        Set(value As Integer)
            caseid_ = value
        End Set
    End Property
    Property Typeid As Integer
        Get
            Return Typeid_
        End Get
        Set(value As Integer)
            Typeid_ = value
        End Set
    End Property
    Dim dmview As New DataMainView
    Dim pageIndex As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pageIndex = IIf(Request.QueryString("page") = "", 1, Request.QueryString("page"))

        pi.PageIndex = pageIndex
        pi.PageSize = AspNetPager1.PageSize
        Select Case Typeid
            Case CaseType.News, CaseType.BBS
                lt_list.Text = "<ul class='newslist'>" & dmview.infoPagelist(Caseid, pi) & "</ul>"
            Case CaseType.Picture
                lt_list.Text = "<div class='piclist'>" & dmview.PicturePagelist(Caseid, pi) & "<div style='clear:both'></div></div>"

        End Select


        AspNetPager1.RecordCount = pi.TotalCount

    End Sub


End Class