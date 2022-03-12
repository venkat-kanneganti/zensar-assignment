<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="aspassignment.validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
        

        
      <p> Insert your Details:</p><br />

Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="uname" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uname" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
<p>
Family Name:&nbsp; <asp:TextBox ID="fname" runat="server"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ForeColor="Red" ControlToCompare="uname" ControlToValidate="fname" ValidationGroup="vg">*</asp:CompareValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fname" ErrorMessage="Name required" ValidationGroup="vg">*</asp:RequiredFieldValidator>
</p>
<p>
Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="address" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="address" ErrorMessage="Atleat 2 characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$" ValidationGroup="vg">*</asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="address" ErrorMessage="Address is required" ValidationGroup="vg"></asp:RequiredFieldValidator>
</p>
<p>
City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="city" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="city" ErrorMessage="Atleast 2 characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$">*</asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="city" ErrorMessage="City required" ValidationGroup="vg"></asp:RequiredFieldValidator>
</p>
<p>
Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="zipcode" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="zipcode" ErrorMessage="should be 6 characters" ForeColor="Red" ValidationExpression="\d{6}" ValidationGroup="vg">*</asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="zipcode" ErrorMessage="Zipcode Required" ValidationGroup="vg"></asp:RequiredFieldValidator>
</p>
<p>
Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="phnumber" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="phnumber" ErrorMessage="Invalid Phone number" ForeColor="Red" ValidationExpression="\d{10}" ValidationGroup="vg">*</asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phnumber" ErrorMessage="Phone number is required" ValidationGroup="vg"></asp:RequiredFieldValidator>
</p>
<p>
E-mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="Email" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Incorrect email" ForeColor="Red" ControlToValidate="Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">*</asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Email Required" ControlToValidate="Email" ValidationGroup="vg"></asp:RequiredFieldValidator>
</p>
<asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Submit" ValidationGroup="vg" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg" />
 
        
 
    </form>

</body>
    

</html>
