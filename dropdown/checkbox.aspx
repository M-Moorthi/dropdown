<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkbox.aspx.cs" Inherits="dropdown.checkbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_name" runat="server" Text="NAME"></asp:Label>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            GRADUATION
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Text="10th" Value="10th"></asp:ListItem>
                <asp:ListItem Text="12th" Value="12th"></asp:ListItem>
                <asp:ListItem Text="UG" Value="UG"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btn_save" runat="server" Text="SAVE" OnClick="btn_save_Click" />
        </div>
    </form>
</body>
</html>
