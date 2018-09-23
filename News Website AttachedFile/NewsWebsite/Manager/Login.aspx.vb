Imports System.Data
Imports System.Data.SqlClient
Partial Class Manager_Login
    Inherits System.Web.UI.Page
    Public StrCon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ObjCon As New SqlConnection(StrCon)
        Dim strQuery As String = "if exists(select * from TblUser where Username=@Username and Password=@Password) select 0 else select 1"
        Dim objComm As New SqlCommand(strQuery, ObjCon)
        objComm.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text.Trim
        objComm.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text.Trim
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        Dim Resualt As Integer = CInt(objComm.ExecuteScalar)
        If Resualt = 0 Then
            Li_message.Text = ""
            CreateLoginCookie(txtUsername.Text.Trim, chkRemember.Checked)
            Response.Redirect("/Manager/")
        Else
            Li_message.Text = "نام کاربری یا رمز عبور اشتباه می باشد ."
        End If
    End Sub
    Public Sub CreateLoginCookie(ByVal Username As String, ByVal Rememberme As Boolean)
        Dim LoginCookie As New HttpCookie("LoginUserCookie")
        LoginCookie.Value = Now.Date
        If Rememberme = True Then
            LoginCookie.Expires = Now.AddMonths(1)
        Else
            LoginCookie.Expires = Now.AddMinutes(30)
        End If
        HttpContext.Current.Response.Cookies.Add(LoginCookie)

    End Sub



End Class
