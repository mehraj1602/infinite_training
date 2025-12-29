<%@ Page Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="ElectricityBillForm.aspx.cs" Inherits="ElectricityBillProject.ElectricityBillForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            Number of Bills:
<asp:TextBox ID="txtCount" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Number of Bills cannot be blank" ControlToValidate="txtCount" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCount" ValidationExpression="^\d+$" ErrorMessage="Number of Bills must be numeric" ForeColor="Red" ValidationGroup="elecbill">*</asp:RegularExpressionValidator>
<br/><br/>
Consumer Number:
<asp:TextBox ID="txtNo" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Consumer Number cannot be blank" ControlToValidate="txtNo" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<br/><br/>
Consumer Name:
<asp:TextBox ID="txtName" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Consumer Name cannot be blank" ControlToValidate="txtName" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtName" ValidationExpression="^[A-Za-z ]{3,}$" ErrorMessage="Consumer Name must contain only letters and minimum 3 characters" ForeColor="Red" ValidationGroup="elecbill">*</asp:RegularExpressionValidator>
<br/><br/>
Units Consumed:
<asp:TextBox ID="txtUnits" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Units Consumed cannot be blank" ControlToValidate="txtUnits" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<br/><br/>
<asp:Button ID="btnAdd" runat="server" Text="Add Bill" OnClick="btnAdd_Click" ValidationGroup="elecbill" /><br/>

<asp:Label ID="lblOutput" runat="server" /><br/>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="elecbill" />


Last N Bills to Retrieve:
<asp:TextBox ID="txtLast" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter Last N Bills to Retrieve" ControlToValidate="txtLast" ForeColor="Red" ValidationGroup="elecbilllast" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtLast" ValidationExpression="^\d+$" ErrorMessage="Last N Bills must be numeric" ForeColor="Red" ValidationGroup="elecbilllast">*</asp:RegularExpressionValidator>
<br/><br/>
<asp:Button ID="btnShow" runat="server" Text="Show Bills" OnClick="btnShow_Click" ValidationGroup="elecbilllast"/><br/>
<asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="elecbilllast" />

<asp:GridView ID="gvBills" runat="server" />
        </div>
</asp:Content>
