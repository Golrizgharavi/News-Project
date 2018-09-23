Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Public strConn As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString
    Public Function GetImagePath(ByVal imageId As Integer) As String

        Return ("/NewsImage/" & imageId.ToString & ".jpg")

    End Function
    Public Sub BindTopNews()
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select top 1  * from TblNews ", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.HasRows Then
            RptTopPrt.DataSource = DTreader
            RptTopPrt.DataBind()

        End If
        DTreader.Close()
        objConn.Close()

    End Sub
    Public Sub DownPartRows()
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select top 10 * from  TblNews", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.HasRows Then
            RptDownPrt.DataSource = DTreader
            RptDownPrt.DataBind()

        End If
        DTreader.Close()
        objConn.Close()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindTopNews()
        DownPartRows()
    End Sub
End Class
