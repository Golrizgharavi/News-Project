Imports System.Data
Imports System.Data.SqlClient
Partial Class Communication
    Inherits System.Web.UI.Page
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cmmunication()
    End Sub
    Public Sub Cmmunication()
        Dim objCon As New SqlConnection(strcon)
        Dim objCOM As New SqlCommand("select * from TblPages where id=2 ", objCon)
        objCOM.CommandType = CommandType.Text
        objCon.Open()
        Dim objDR As SqlDataReader = objCOM.ExecuteReader
        If objDR.Read Then
            Li_Communication.Text = objDR!content


        End If
        objDR.Close()
        objCon.Close()

    End Sub
End Class
