<%@ Page Language="VB" MasterPageFile="~/Manager/Main.master" AutoEventWireup="false" CodeFile="Comment.aspx.vb" Inherits="Manager_Comment" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView ID="GVComment" runat="server"></asp:GridView>
<table>
<tr>
    <td colspan="2">
        <asp:Literal ID="Li_Message" runat="server"></asp:Literal></td>
</tr>
    <tr>
        <td>شناسه پیام :</td><td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>فعال</td><td><asp:CheckBox ID="chkActive" runat="server" /></td>
    </tr>
    <tr>
         <td>&nbsp;</td>
         <td><asp:Button ID="btmSave" runat="server" Text="ثبت" /></td>
    </tr>
     <tr>
         <td>&nbsp;</td>
          <td> <asp:TemplateField> 
              <ItemTemplate>  
                 <asp:Button id="BtnDelete" runat="server" text="حذف"  CommandName="Delete" OnClientClick="return confirm('آیا مطمئن هستید؟؟');" ></asp:Button> 
                   </ItemTemplate>
                    </asp:TemplateField> 
              </td>
         <%--<td><asp:Button ID="BtnDelete" runat="server" Text="حذف" /></td>--%>
             
    </tr>
    <tr>
         <td>&nbsp;</td>
         <td><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>
             
    </tr>
    
</table>
</asp:Content>

