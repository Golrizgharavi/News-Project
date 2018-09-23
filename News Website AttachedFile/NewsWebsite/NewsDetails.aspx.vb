Imports System.Data
Imports System.Data.SqlClient

Partial Class NewsDetails
    Inherits System.Web.UI.Page
    Public NewsID As Object = HttpContext.Current.Request.QueryString!id
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objcon As New SqlConnection(strcon)
        Dim objcomm As New SqlCommand("select * from TblNews where id=@id ", objcon)
        objcomm.Parameters.Add("@id", SqlDbType.Int).Value = CInt(NewsID)
        objcomm.CommandType = CommandType.Text
        objcon.Open()
        Dim objDR As SqlDataReader = objcomm.ExecuteReader

        If objDR.Read Then
            Li_Image.Text = "<img src=""/NewsImage/" & objDR!ID & ".jpg"" alt="""">"
            Li_Content.Text = objDR!Content.ToString
            Li_titleD.Text = objDR!Title.ToString
        End If
        objcon.Close()

    End Sub
End Class
