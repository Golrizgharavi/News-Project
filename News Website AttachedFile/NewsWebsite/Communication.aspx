<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="Communication.aspx.vb" Inherits="Communication" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link type="text/css" rel="Stylesheet" href="/Styles/Pages.css" />
    <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="PageTitle">
         تماس با ما  
    </div>
    <div id="CommunicationDiv">
        <asp:Literal ID="Li_Communication" runat="server"></asp:Literal>
    </div>
</asp:Content>

