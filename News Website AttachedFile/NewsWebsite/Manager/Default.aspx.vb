
Partial Class Manager_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Dim LoginCookie As HttpCookie = HttpContext.Current.Request.Cookies("LoginUserCookie")

        If (HttpContext.Current.Request.Cookies("LoginUserCookie") Is Nothing) Then
            Response.Redirect("/Manager/Login.aspx")
        End If

    End Sub

 
End Class
