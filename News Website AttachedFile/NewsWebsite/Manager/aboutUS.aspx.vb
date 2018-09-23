Imports System.Data
Imports System.Data.SqlClient

Partial Class Manager_aboutUS
    Inherits System.Web.UI.Page
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim ObjCon As New SqlConnection(strcon)
            Dim objComm As New SqlCommand("SELECT * FROM TblPages WHERE ID=1 ", ObjCon)
            ObjCon.Open()
            Dim objdr As SqlDataReader = objComm.ExecuteReader
            If objdr.Read Then
                txtContent.Text = objdr!Content
            End If
            ObjCon.Close()
        End If
        
    End Sub

    Protected Sub BtnUpdateAU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdateAU.Click
        Dim objcon As New SqlConnection(strcon)
        Dim objcom As New SqlCommand("update TblPages set content=@content where id=1", objcon)
        objcom.Parameters.Add("@content", SqlDbType.NVarChar).Value = txtContent.Text.Trim
        objcom.CommandType = CommandType.Text
        objcon.Open()
        objcom.ExecuteNonQuery()
        objcon.Close()

    End Sub
End Class
