<%@ Page Language="VB" MasterPageFile="~/Manager/Main.master" AutoEventWireup="false" CodeFile="aboutUS.aspx.vb" Inherits="Manager_aboutUS" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
    <tr>
        <td>متن درباره ما</td>
        <td>
            <asp:TextBox  Width="600px" Height="500px " TextMode="MultiLine" ID="txtContent" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="BtnUpdateAU" runat="server" Text="تغییر" /></td>
            <td></td>
    </tr>
</table>
</asp:Content>

