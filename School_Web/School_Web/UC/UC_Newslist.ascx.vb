Imports View

Public Class UC_Newslist
    Inherits System.Web.UI.UserControl
    Dim caseid_, Typeid_ As Integer
    Dim boxcss_, StartString_, EndString_ As String
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
    Property BoxCss As String
        Get
            Return boxcss_
        End Get
        Set(value As String)
            If value = "" Then
                boxcss_ = "span4"
            Else

                boxcss_ = value
            End If
        End Set
    End Property
    Property StartString As String
        Get
            Return StartString_
        End Get
        Set(value As String)
            StartString_ = value
        End Set
    End Property
    Property EndString As String
        Get
            Return EndString_
        End Get
        Set(value As String)
            EndString_ = value
        End Set
    End Property

    Dim dmview As New DataMainView

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
          Select Typeid
            Case CaseType.News, CaseType.BBS

                Literal1.Text = StartString & dmview.infolistWithBar(Caseid, BoxCss, 10) & EndString
            Case CaseType.Picture

                Literal1.Text = StartString & dmview.PiclistWithBar(Caseid, BoxCss, 6) & EndString

        End Select


    End Sub
End Class