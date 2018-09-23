<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="AboutUs.aspx.vb" Inherits="AboutUs" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link type="text/css" rel="Stylesheet" href="/Styles/Pages.css" />
    <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="PageTitle">
درباره ما
</div>
<div id="ContentDiv">
    <asp:Literal ID="Li_Content" runat="server"></asp:Literal>
</div>
</asp:Content>

