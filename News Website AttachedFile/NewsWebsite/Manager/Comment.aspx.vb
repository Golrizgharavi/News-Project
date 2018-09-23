Imports System.Data
Imports System.Data.SqlClient
Partial Class Manager_Comment
    Inherits System.Web.UI.Page
    Public StrCon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ObjCon As New SqlConnection(StrCon)
        Dim strQuery As String = "Select ID as 'شناسه پیام', Name as 'نام',Email as 'پست الکترونیکی' ,Content as 'متن',Active as 'وضعیت' From TblComment"
     
        Dim objComm As New SqlCommand(strQuery, ObjCon)
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        Dim Objdr As SqlDataReader = objComm.ExecuteReader
        If Objdr.HasRows Then
            GVComment.DataSource = Objdr
            GVComment.DataBind()
        End If
        Objdr.Close()
        ObjCon.Close()
    End Sub

    Protected Sub btmSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btmSave.Click
        Dim ObjCon As New SqlConnection(StrCon)
        Dim strQuery As String = "update TblComment set Active= @Active where ID=@ID"
        Dim objComm As New SqlCommand(strQuery, ObjCon)
        objComm.Parameters.Add("@Active", SqlDbType.Bit).Value = chkActive.Checked
        objComm.Parameters.Add("@ID", SqlDbType.Int).Value = txtID.Text.Trim
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        If objComm.ExecuteNonQuery > 0 Then
            Li_Message.Text = "عملیات با موفقیت انجام شد"
        Else
            Li_Message.Text = "در انجام عملیات خطا رخ داده"
        End If
        ObjCon.Close()
    End Sub

    Protected Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        Dim objcon As New SqlConnection(StrCon)
        Dim objcom As New SqlCommand("delete from TblComment where ID=@id", objcon)
        objcom.Parameters.Add("@id", SqlDbType.Int).Value = CInt(txtID.Text)
        objcom.CommandType = CommandType.Text
        objcon.Open()
        objcom.ExecuteNonQuery()
        objcon.Close()

        Label1.Text = "رکورد " & txtID.Text & " باموفقیت حذف شد."
        txtID.Text = " "
    End Sub
End Class
