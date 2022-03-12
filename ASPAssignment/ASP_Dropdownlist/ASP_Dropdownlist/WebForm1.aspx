<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Dropdownlist.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    Select Any Item <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="88px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList><br /><br/><br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Image ID="Image1" runat="server" Height="150px" Width="250px" /><br /><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Cost" Height="35px" Width="50px" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" Text="Cost of the Item"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
        <div>
        </div>
    
</body>
</html>
