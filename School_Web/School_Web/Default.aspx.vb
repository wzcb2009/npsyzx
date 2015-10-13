Imports View


Public Class Index
    Inherits System.Web.UI.Page
    Dim dmview As New DataMainView
    Public hotlisttitle As String

    Const newsTitleLen = 38
    Const leftNewsTitleLen = 28

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        flog_class.Debug(" dmview.infolist(107, 6, newsTitleLen)")
        lt_xykx.Text = dmview.infolist(107, 6, newsTitleLen)
        flog_class.Debug(" dmview.infolist(121, 6, newsTitleLen)")
        lt_xwgk.Text = dmview.infolist(121, 6, newsTitleLen)
        '  lt_mtgz.Text = dmview.infolist(93, , newsTitleLen)
        flog_class.Debug(" dmview.infolist(121, 6, newsTitleLen)")
        lt_jyky.Text = dmview.infolist(121, 6, newsTitleLen)
        flog_class.Debug(" dmview.infolist(178, , newsTitleLen)")
        lt_dyzx.Text = dmview.infolist(178, , newsTitleLen)
        flog_class.Debug(" dmview.infolist(114, newsTitleLen)")
        ' lt_mshj.Text = dmview.Picturelist(708, 8, 120, 160)
        lt_xydj.Text = dmview.infolist(114, newsTitleLen)
        flog_class.Debug("  dmview.Picturelist(181, 8, 160, 0)")
        lt_xyhd.Text = dmview.Picturelist(181, 8, 160, 0)
        flog_class.Debug(" dmview.infolist(117, 9, newsTitleLen)")
        lt_xstd.Text = dmview.infolist(117, 9, newsTitleLen - 4)
        flog_class.Debug(" dmview.PicturelistHotFlash(107, 5, hotlisttitle, 340, 240)")
        '  lt_xshdhot.Text = dmview.PicturelistHotSingle(117, 5, 330, 260)
        'lt_xsl.Text = dmview.infolist(113, 6, leftNewsTitleLen)
        lt_hotnews.Text = dmview.PicturelistHotFlash(107, 5, hotlisttitle, 340, 240)
        flog_class.Debug(" dmview.infolist(498, 10, newsTitleLen)")
        lt_twst.Text = dmview.infolist(498, 10, leftNewsTitleLen)
        flog_class.Debug("结束")
        ' lt_xxry.Text = dmview.PicturelistSingle(220, 1, 260, 190)
    End Sub

End Class