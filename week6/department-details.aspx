<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="department-details.aspx.cs" Inherits="week6.department_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Department Details</h1>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" CssClass="col-sm-3">Department Name:</asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" required></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" CssClass="col-sm-3">Budget:</asp:Label>
        <asp:TextBox ID="txtbudget" runat="server" required min="0" Max="999999" step="1" Type="number"></asp:TextBox>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-success col-sm-offset-3" OnClick="Button1_Click" />
</asp:Content>
