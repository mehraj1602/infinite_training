<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment_25thDec_.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    <h1 style="color:aquamarine;">Insert Your Details:</h1>
    <br />

    Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name" Text="<span style='color:red'>*</span> <span style='color:black'>Name is required</span>" EnableHtmlEncode="false" Display="Dynamic" ControlToValidate="txtname" ValidationGroup="regn" ></asp:RequiredFieldValidator>
    <br /> <br />
    Family Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="txtfamilyname" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Family" Text="<span style='color:red'>*</span> <span style='color:black'>Family name cannot be blank</span>" EnableHtmlEncode="false" ControlToValidate="txtfamilyname" Display="Dynamic" ForeColor="Red" ValidationGroup="regn" ></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtname" ControlToValidate="txtfamilyname" Display="Dynamic" ErrorMessage="Family" Text="<span style='color:red'>*</span> <span style='color:black'>differs from name</span>" EnableHtmlEncode="false" ValidationGroup="regn" ></asp:CompareValidator>
    <br /> <br />
    Address : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtaddress" Display="Dynamic" ErrorMessage="Address" Text="<span style='color:red'>*</span> <span style='color:black'>Address is required</span>" EnableHtmlEncode="false" ValidationGroup="regn"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtaddress" Display="Dynamic" ErrorMessage="Address" Text="<span style='color:red'>*</span> <span style='color:black'>Address must have at least 2 characters</span>" EnableHtmlEncode="false" ValidationExpression=".{2,}" ValidationGroup="regn"></asp:RegularExpressionValidator>
    <br /><br />
    City : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>           
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="City" Text="<span style='color:red'>*</span> <span style='color:black'>City is required</span>" EnableHtmlEncode="false" ValidationGroup="regn" ></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="City" Text="<span style='color:red'>*</span> <span style='color:black'>City must have at least 2 characters</span>" EnableHtmlEncode="false" ValidationExpression=".{2,}" ValidationGroup="regn"></asp:RegularExpressionValidator>
    <br /><br />
    Zip Code : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtzipcode" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtzipcode" Display="Dynamic" ErrorMessage="Zip code" Text="<span style='color:red'>*</span> <span style='color:black'>Zip Code is required</span>" EnableHtmlEncode="false" ValidationGroup="regn" ></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtzipcode" Display="Dynamic" ErrorMessage="Zip code" Text="<span style='color:red'>*</span> <span style='color:black'>(XXXXX)</span>" EnableHtmlEncode="false" ValidationExpression="^\d{5}$" ValidationGroup="regn"></asp:RegularExpressionValidator>
    <br /><br />
    Phone : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtphone" Display="Dynamic" ErrorMessage="Phone number" Text="<span style='color:red'>*</span> <span style='color:black'>Phone number is required</span>" EnableHtmlEncode="false" ValidationGroup="regn" ></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtphone" Display="Dynamic" ErrorMessage="Phone number" Text="<span style='color:red'>*</span> <span style='color:black'>(XX-XXXXXXX or XXX-XXXXXXX)</span>" EnableHtmlEncode="false" ValidationExpression="^(\d{2}-\d{7}|\d{3}-\d{7})$" ValidationGroup="regn"></asp:RegularExpressionValidator>
    <br /><br />
    Email : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Email" Text="<span style='color:red'>*</span> <span style='color:black'>Email is required</span>" EnableHtmlEncode="false" ValidationGroup="regn"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Email"     Text="<span style='color:red'>*</span> <span style='color:black'>example@example.com</span>" EnableHtmlEncode="false" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="regn"></asp:RegularExpressionValidator>
    <br /><br />

    <asp:Button ID="btncheck" Text="Check" runat="server" ValidationGroup="regn" />

    <br /><br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="ValidationSum" ShowMessageBox="true" ShowSummary="true" ValidationGroup="regn" />

</div>
    </form>
</body>
</html>
