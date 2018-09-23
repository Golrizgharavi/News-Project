<%@ Page Language="VB" MasterPageFile="~/Manager/Main.master" AutoEventWireup="false" CodeFile="News.aspx.vb" Inherits="Manager_News" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="MContentDiv">
<table>
<tr>
    <td>
        <asp:Literal ID="li_Message" runat="server"></asp:Literal></td>
        <td></td>
</tr>
<tr>
    <td>تصویر خبر</td>
    <td><asp:FileUpload ID="FUImage" runat="server" /></td>
        
</tr>
    <tr>
        <td>عنوان خبر</td>
        <td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>خلاصه خبر</td>
        <td><asp:TextBox ID="txtSummery" TextMode="MultiLine" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>متن خبر</td>
        <td><asp:TextBox ID="txtContent" TextMode="MultiLine" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>نوع خبر</td>
        <td>
            <asp:DropDownList ID="ddlType" runat="server">
            <asp:ListItem Value="1">خبر هنری</asp:ListItem>
            <asp:ListItem Value="2">خبر ورزشی</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="btmSave" runat="server" Text="اضافه کن" /></td>
    </tr>
    
</table>
</div>
</asp:Content>

