<%@ Page Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectricityBillProject.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h2>Admin Login</h2>

            <asp:TextBox ID="txtUser" runat="server" Placeholder="Username" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username cannot be blank" ControlToValidate="txtUser" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            <br/><br/>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Placeholder="Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Password must" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            <br/><br/>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" ValidationGroup="login" /><br/>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="login" />
        </div>
</asp:Content>