<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Manager_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    
    <link type="text/css" rel="Stylesheet" href="/Manager/Style/Main.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="LoginDiv">
        <table>
            <tr>
                <td colspan="2">
                    <asp:Literal ID="Li_message" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>نام کاربری</td>
                <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
            </tr> 
            <tr>
                <td>رمز عبور</td>
                <td><asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr> 
            <tr>
                <td>&nbsp;</td>
                <td><asp:CheckBox ID="chkRemember" Text="مرا به خاطر بسپار" runat="server" /></td>
            </tr>    
            <tr>
              <td></td>  
              <td>
                  <asp:Button ID="Button1" runat="server" Text="ورود" />
                </td>        
            </tr> 
        </table>
    </div>
    </form>
</body>
</html>
