<%@ Page Language="VB" MasterPageFile="~/Manager/Main.master" AutoEventWireup="false" CodeFile="SearchNews.aspx.vb" Inherits="Manager_SearchNews" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table>
        <tr>
            <td>نوع خبر</td>
            <td>
                <asp:DropDownList AutoPostBack="true" ID="DdlNews" runat="server">
                    <asp:ListItem Value="0">همه ی اخبار</asp:ListItem>
                    <asp:ListItem  Value="1">اخبار فرهنگی</asp:ListItem>
                    <asp:ListItem  Value="2">اخبار ورزشی</asp:ListItem>
                </asp:DropDownList>
            </td>   
        </tr>
         <tr>
            <td> شناسه مورد نظر را وارد کنید</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                
        
        </tr>
         <tr>
            <td></td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" >
                <asp:ListItem value=0>نوع جستجو </asp:ListItem>
                    <asp:ListItem value=1>جستجو بر اساس عنوان خبر</asp:ListItem>
                    <asp:ListItem value=2> جستجو جهت ویرایش</asp:ListItem>
                    <asp:ListItem value=3> جستجو بر اساس مشخصه خبر</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td> <asp:TemplateField> 
              <ItemTemplate>  
                 <asp:Button id="BtnDlt" runat="server" text="حذف"  CommandName="Delete" OnClientClick="return confirm('آیا مطمئن هستید؟؟');" ></asp:Button> 
                   </ItemTemplate>
                    </asp:TemplateField> 
              </td>
            <%--<td> <asp:Button ID="BtnDlt" runat="server" Text="حذف" /></td>--%>
                
            <td><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>               
        </tr>
        <tr>
            <td></td>
            <td>
                </td>
        </tr>
    <%---------------------------------------------------%> 
     
    <tr>
        <td>عنوان</td>
        <td><asp:TextBox ID="txtTitle" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            
    </tr>
    <tr>
        <td>خلاصه خبر</td>
        <td><asp:TextBox ID="txtSumery" runat="server" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td>محتوای خبر</td>
        <td><asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
        <tr>
            <td>تاریخ:</td>
            <td> <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox></td>
               
        </tr>
    <tr>
        <td>نوع خبر</td>
        <td> 
            <asp:DropDownList ID="DropDownList2" runat="server">
             <asp:ListItem  Value="1">سیاسی</asp:ListItem>
             <asp:ListItem Value="2">ورزشی</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    
    
        <tr>
            <td><asp:Button ID="BtnUpdate" runat="server" Text="تغییر" /></td>
            <td></td>
        
        </tr>
           
    </table>
    <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
    <%--<table>
       <tr>
            <td colspan="2">
                
            </td>
        </tr>
    </table>--%>

</asp:Content>

