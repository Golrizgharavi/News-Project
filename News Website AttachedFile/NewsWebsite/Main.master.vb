Imports System.Data
Imports System.Data.SqlClient
Partial Class Main
    Inherits System.Web.UI.MasterPage
    Public strConn As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindLastNews()
        WebsiteEstimation()
    End Sub
    Public Sub BindLastNews()
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select top 30 * from TblNews", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.HasRows Then
            rptLastNews.DataSource = DTreader
            rptLastNews.DataBind()

        End If
        DTreader.Close()
        objConn.Close()

    End Sub
    Public Sub WebsiteEstimation()
        Dim VisitCookie1 As HttpCookie = HttpContext.Current.Request.Cookies("VisitCookie")
        If VisitCookie1 Is Nothing Then
            Dim VisitCookie As New HttpCookie("VisitCookie")
            VisitCookie.Expires = Now.AddMinutes(1)
            addVisit()
        Else
            ViewVisit()
        End If
    End Sub
    Public Sub addVisit()

        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("update TblEstimation set Count = Count + 1; select Count From TblEstimation", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.Read Then
            Li_Number.Text = DTreader!Count.ToString
        End If
        DTreader.Close()
        objConn.Close()
    End Sub
    Public Sub ViewVisit()
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select * from TblEstimation", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.Read Then
            Li_Number.Text = DTreader!Count.ToString
        End If
        DTreader.Close()
        objConn.Close()
    End Sub
End Class

