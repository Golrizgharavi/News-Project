Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class News
    Public Shared strConn As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString
    Public Shared Function WebsiteEstimation() As Integer
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("update TblEstimation set Count = Count + 1; select Count From TblEstimation", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.Read Then
            Return (DTreader!Count.ToString)
        End If
        DTreader.Close()
        objConn.Close()
    End Function
End Class
