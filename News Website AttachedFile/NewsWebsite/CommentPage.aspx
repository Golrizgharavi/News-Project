<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="CommentPage.aspx.vb" Inherits="CommentPage" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link type="text/css" rel="Stylesheet" href="/Styles/Pages.css" />
    <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
    <link type="text/css" rel="Stylesheet" href="/Styles/Comment.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="PageTitle">
نظرات
</div>
<div class="ContentDiv">
    <asp:Repeater ID="rptComment" runat="server">
        <ItemTemplate>
            <div class="ViewCommentsDiv">
                <div>
                    <div class="CommentTitle"><span><b>فرستنده :</b><%#DataBinder.Eval(Container.DataItem, "Name")%> </span> <div><%#DataBinder.Eval(Container.DataItem, "Email")%></div></div>
                    <div class="CommentContainer"><%#DataBinder.Eval(Container.DataItem, "[Content]")%></div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    
     <%--<div class="ViewCommentsDiv">
        <div>
            <div class="CommentTitle"><span><b>فرستنده :</b>گلریز</span> <div>golriz@yahoo.com</div></div>
            <div class="CommentContainer">dsfsdfsfs</div>
        </div>
    </div>--%>
    
</div>

<div id="SendComment">
<form id="Form1" runat="server">
<table>
    <tr>
        <td colspan="2"><asp:Literal ID="Li_Message" runat="server"></asp:Literal></td>
            
    </tr>
    <tr>
        <td>نام و نام خانوادگی :</td><td><asp:TextBox MaxLength="50" ID="txtName" runat="server"></asp:TextBox></td>
         <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="خالی!" ControlToValidate="txtName"></asp:RequiredFieldValidator></td>   
    </tr>
    <tr>
        <td>پست الکترونیکی :</td><td><asp:TextBox ID="txtEmail" MaxLength="50" runat="server"></asp:TextBox></td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="آدرس نامعتبر " ControlToValidate="txtEmail" ValidationExpression="\S*\@\S*\.\S*"></asp:RegularExpressionValidator></td>
            
    </tr>
    <tr>
        <td>متن نظر :</td><td><asp:TextBox TextMode="MultiLine" MaxLength="500" ID="txtContent" runat="server"></asp:TextBox></td>
         <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="خالی!" ControlToValidate="txtContent"></asp:RequiredFieldValidator></td>     
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td><asp:Button ID="btmSend" runat="server" Text="ارسال" /></td>
            
    </tr>
</table>
</form>
</div>
</asp:Content>
