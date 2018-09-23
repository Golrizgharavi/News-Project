
Partial Class Manager_Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim LoginCookie As HttpCookie = HttpContext.Current.Request.Cookies("LoginUserCookie")
        'If Not Request.Cookies("LoginUserCookie") Is Nothing Then
        '    HttpContext.Current.Response.Cookies(LoginCookie.Value).Expires = Now.AddYears(-1)
        '    Response.Redirect("/Manager/Login.aspx")
        'End If
        If (Not Request.Cookies("LoginUserCookie") Is Nothing) Then
            Dim mycookie As New HttpCookie("LoginUserCookie")
            mycookie.Expires = DateTime.Now.AddDays(-10)
            Response.Cookies.Add(mycookie)
            Response.Redirect("/Manager/Login.aspx")
        End If

    End Sub
End Class
