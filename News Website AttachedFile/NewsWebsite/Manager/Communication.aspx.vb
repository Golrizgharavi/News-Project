Imports System.Data
Imports System.Data.SqlClient
Partial Class Manager_Communication
    Inherits System.Web.UI.Page
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim ObjCon As New SqlConnection(strcon)
            Dim objComm As New SqlCommand("SELECT * FROM TblPages WHERE ID=2 ", ObjCon)
            ObjCon.Open()
            Dim objdr As SqlDataReader = objComm.ExecuteReader
            If objdr.Read Then
                txtContentCmm.Text = objdr!Content
            End If
            ObjCon.Close()
        End If
        
    End Sub

    Protected Sub BtnUpdateCmm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdateCmm.Click
        Dim objcon As New SqlConnection(strcon)
        Dim objcom As New SqlCommand("update TblPages set content=@content where id=2", objcon)
        objcom.Parameters.Add("@content", SqlDbType.NVarChar).Value = txtContentCmm.Text.Trim
        objcom.CommandType = CommandType.Text
        objcon.Open()
        objcom.ExecuteNonQuery()
        objcon.Close()

    End Sub
End Class
