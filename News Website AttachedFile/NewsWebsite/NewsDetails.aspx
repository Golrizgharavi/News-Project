<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="NewsDetails.aspx.vb" Inherits="NewsDetails" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link type="text/css" rel="Stylesheet" href="/Styles/Pages.css" />
    <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="PageTitle">
جزئیات خبر 
</div>
<div id="TitleDitail">
    
    <asp:Literal ID="Li_titleD" runat="server"></asp:Literal><br />
    <asp:Literal ID="Li_Image" runat="server"></asp:Literal>
</div>
<div id="ContentDiv">
    <asp:Literal ID="Li_Content" runat="server"></asp:Literal>
</div>

</asp:Content>


