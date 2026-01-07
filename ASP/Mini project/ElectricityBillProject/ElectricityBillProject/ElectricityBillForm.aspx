<%@ Page Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true"
    CodeBehind="ElectricityBillForm.aspx.cs"
    Inherits="ElectricityBillProject.ElectricityBillForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<link href="~/Content/electricity.css" rel="stylesheet" />

<div class="page-wrapper">

 
    <div class="app-card">

        <h4 class="section-heading"> Electricity Bill Entry</h4>
        <p class="subtitle">Enter consumer details and add bills to the list</p>

        <div class="row">

            <div class="col">
                <label class="form-label">Number of Bills</label>
                <asp:TextBox ID="txtCount" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtCount" runat="server"
                    ErrorMessage="Required" ForeColor="Red" ValidationGroup="elecbill" />
            </div>

            <div class="col">
                <label class="form-label">Consumer Number</label>
                <asp:TextBox ID="txtNo" CssClass="form-control" runat="server" AutoPostBack="true" OnTextChanged="txtNo_TextChanged"/>
                <asp:RequiredFieldValidator ControlToValidate="txtNo" runat="server"
                    ErrorMessage="Required" ForeColor="Red" ValidationGroup="elecbill" />
            </div>

            <div class="col">
                <label class="form-label">Consumer Name</label>
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtName" runat="server"
                    ErrorMessage="Required" ForeColor="Red" ValidationGroup="elecbill" />
            </div>

            <div class="col">
                <label class="form-label">Units Consumed</label>
                <asp:TextBox ID="txtUnits" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtUnits" runat="server"
                    ErrorMessage="Required" ForeColor="Red" ValidationGroup="elecbill" />
            </div>

        </div>

        <div class="button-row">
            <asp:Button ID="btnAdd" runat="server" Text=" Add Bill"
                CssClass="btn primary" ValidationGroup="elecbill" OnClick="btnAdd_Click" />

            <asp:Label ID="lblOutput" runat="server" CssClass="status-text" />
        </div>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
            CssClass="validation-text" ValidationGroup="elecbill" />
    </div>


  
    <div class="app-card">

        <h4 class="section-heading"> Retrieve Previous Bills</h4>
        <p class="subtitle">View last N recently added bills</p>

        <div class="row">

            <div class="col">
                <label class="form-label">Last N Bills</label>
                <asp:TextBox ID="txtLast" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtLast" runat="server"
                    ErrorMessage="Required" ForeColor="Red" ValidationGroup="elecbilllast" />
            </div>

        </div>

        <div class="button-row">
            <asp:Button ID="btnShow" runat="server" Text="Show Bills"
                CssClass="btn secondary" ValidationGroup="elecbilllast" OnClick="btnShow_Click" />
        </div>

        <asp:ValidationSummary ID="ValidationSummary2" runat="server"
            CssClass="validation-text" ValidationGroup="elecbilllast" />

        <asp:GridView ID="gvBills" runat="server" CssClass="styled-grid" />
    </div>

</div>

</asp:Content>