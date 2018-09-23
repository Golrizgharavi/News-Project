Imports System.Data
Imports System.Data.SqlClient

Partial Class CommentPage
    Inherits System.Web.UI.Page
    Public Shared strConn As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objConn As New SqlConnection(strConn)
        Dim objcommand As New SqlCommand("select  * from  TblComment where Active=1 ", objConn)
        objcommand.CommandType = CommandType.Text
        objConn.Open()
        Dim DTreader As SqlDataReader = objcommand.ExecuteReader
        If DTreader.HasRows Then
            rptComment.DataSource = DTreader
            rptComment.DataBind()
        End If
        DTreader.Close()
        objConn.Close()
    End Sub


    Protected Sub btmSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btmSend.Click
        Dim ObjCon As New SqlConnection(strConn)
        Dim objComm As New SqlCommand("INSERT INTO [NewsDB].[dbo].[TblComment]([Name],[Email],[Content],[Active])VALUES (@Name,@Email,@Content,0); select @@Identity ", ObjCon)
        objComm.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtName.Text.Trim
        objComm.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text.Trim
        objComm.Parameters.Add("@Content", SqlDbType.NVarChar).Value = txtContent.Text.Trim
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        
        If objComm.ExecuteNonQuery > 0 Then

            Li_Message.Text = "ثبت با موفقیت انجام شد"
            txtContent.Text = ""
            txtName.Text = ""
            txtEmail.Text = ""
        Else
            Li_Message.Text = "در ورود اطلاعات خطایی رخ داده"
        End If

    End Sub
End Class
