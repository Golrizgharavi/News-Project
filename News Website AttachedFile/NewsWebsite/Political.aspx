<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="Political.aspx.vb" Inherits="Political" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="PageTitle">
اخبار فرهنگی و هنری 
</div>
<div id="DownPart">
    <asp:Repeater ID="RptDownPrt" runat="server">
        <ItemTemplate>
            <div class="NewsRow1">
                 <div class="NewsRowImage"><img src="<%#GetImagePath(DataBinder.Eval(Container.DataItem,"ID"))%>" alt="" /></div>
                    <div class="NewsText">
                        <span><a href=""><%#DataBinder.Eval(Container.DataItem, "Title")%></a>&nbsp;&nbsp<%#DataBinder.Eval(Container.DataItem, "Date")%></span>
                        <p><%#DataBinder.Eval(Container.DataItem, "Content")%></p>
                 </div>
             </div>
          </ItemTemplate>
     </asp:Repeater>
   
     
     
</div>
</asp:Content>

