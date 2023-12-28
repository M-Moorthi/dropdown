<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dropdown.aspx.cs" Inherits="dropdown.Dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
           <div>
           <asp:Label ID="Label5" runat="server" Text="Label">Id</asp:Label>
           <asp:TextBox ID="txt_id" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label1" runat="server" Text="Label">Name</asp:Label>
           <asp:TextBox ID="txt_name" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label2" runat="server" Text="Label">Gender</asp:Label>
           <asp:RadioButtonList ID="txt_gender" runat="server">
               <asp:ListItem Text="MALE" Value="MALE"></asp:ListItem>
               <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
               <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
           </asp:RadioButtonList>
           <br />
           <asp:Label ID="Label3" runat="server" Text="Label">Country</asp:Label>
           <asp:DropDownList ID="txt_country" runat="server">
                <asp:ListItem Text="India" Value="India"></asp:ListItem>
                <asp:ListItem Text="Usa" Value="Usa"></asp:ListItem>
                <asp:ListItem Text="America" Value="America"></asp:ListItem>
           </asp:DropDownList>
           <br />
           <asp:Label ID="Label4" runat="server" Text="Label">Education</asp:Label>
               <asp:CheckBoxList ID="txt_education" runat="server">
                      <asp:ListItem Text="10th" Value="10"></asp:ListItem>
<asp:ListItem Text="12th" Value="12"></asp:ListItem>
<asp:ListItem Text="UG" Value="UG"></asp:ListItem>
               </asp:CheckBoxList>
          
           <br />
           <asp:Button ID="btn_add" runat="server" Text="Add" OnClick="btn_add_Click" />
           <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" />
           <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" />
           <asp:Button ID="btn_fetch" runat="server" Text="Fetch" OnClick="btn_fetch_Click" />
               <br />
               <asp:GridView ID="GridView1" runat="server"></asp:GridView>
       </div>
        </center>
        
    </form>
</body>
</html>
