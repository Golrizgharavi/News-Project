Imports System.Data
Imports System.Data.SqlClient
Partial Class Political
    Inherits System.Web.UI.Page
    Public strConn As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString
    Public Function GetImagePath(ByVal imageId As Integer) As String

        Return ("/NewsImage/" & imageId.ToString & ".jpg")

    End Function

    Public Sub DownPartRows()
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select  * from  TblNews where Type=1 ", objConn)
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
        DownPartRows()
    End Sub
End Class
