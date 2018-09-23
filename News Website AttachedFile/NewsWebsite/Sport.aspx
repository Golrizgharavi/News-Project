<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="Sport.aspx.vb" Inherits="Sport" title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link type="text/css" rel="Stylesheet" href="/Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="PageTitle">
اخبار ورزشی 
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
    <%-- <div class="NewsRow1">
         <div class="NewsRowImage"><img src="/Images/NImage.jpg" alt="" /></div>
            <div class="NewsText">
                <span><a href="">یس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیز</a></span>
                <p>یس یمستیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزاذس ی.تذ سیز.نذ سیز</p>
         </div>
     </div>
     
     <div class="NewsRow1">
         <div class="NewsRowImage"><img src="/Images/NImage.jpg" alt="" /></div>
            <div class="NewsText">
                <span><a href="">یس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیز</a></span>
                <p>یس یمستیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزاذس ی.تذ سیز.نذ سیز</p>
         </div>
     </div>
     
     <div class="NewsRow1">
         <div class="NewsRowImage"><img src="/Images/NImage.jpg" alt="" /></div>
            <div class="NewsText">
                <span><a href="">یس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیز</a></span>
                <p>یس یمستیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزاذس ی.تذ سیز.نذ سیز</p>
         </div>
     </div>
     
     <div class="NewsRow1">
         <div class="NewsRowImage"><img src="/Images/NImage.jpg" alt="" /></div>
            <div class="NewsText">
                <span><a href="">یس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیز</a></span>
                <p>یس یمستیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزاذس ی.تذ سیز.نذ سیز</p>
         </div>
     </div>
     
     <div class="NewsRow1">
         <div class="NewsRowImage"><img src="/Images/NImage.jpg" alt="" /></div>
            <div class="NewsText">
                <span><a href="">یس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیز</a></span>
                <p>یس یمستیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزیس یمستاذس ی.تذ سیزاذس ی.تذ سیز.نذ سیز</p>
         </div>
     </div>--%>
     
     
</div>
</asp:Content>


