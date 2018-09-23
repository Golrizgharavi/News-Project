Imports System.Data
Imports System.Data.SqlClient

Partial Class AboutUs
    Inherits System.Web.UI.Page
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AboutUs()
    End Sub
    Public Sub AboutUs()
        Dim ObjCon As New SqlConnection(strcon)
        Dim ObjCom As New SqlCommand("select * from TblPages where id=1", ObjCon)
        ObjCom.CommandType = CommandType.Text
        ObjCon.Open()
        Dim ObjDR As SqlDataReader = ObjCom.ExecuteReader
        If ObjDR.Read Then
            Li_Content.Text = ObjDR!Content
        End If
        ObjCon.Close()
        ObjDR.Close()


    End Sub
End Class
