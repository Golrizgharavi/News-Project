<%@ Page Language="VB" MasterPageFile="~/Manager/Main.master" AutoEventWireup="false" CodeFile="Communication.aspx.vb" Inherits="Manager_Communication" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
    <tr>
        <td>متن تماس با ما</td>
        <td>
            <asp:TextBox  Width="600px" Height="500px " TextMode="MultiLine" ID="txtContentCmm" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="BtnUpdateCmm" runat="server" Text="تغییر" /></td>
            <td></td>
    </tr>
</table>
</asp:Content>

