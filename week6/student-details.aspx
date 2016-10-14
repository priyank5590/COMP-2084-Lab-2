<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student-details.aspx.cs" Inherits="week6.student_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Details</h1>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" CssClass="col-sm-3">Last Name:</asp:Label>
        <asp:TextBox ID="txtLast" runat="server" required></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="txtLast"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" CssClass="col-sm-3">First Name:</asp:Label>
        <asp:TextBox ID="txtFirst" runat="server" required></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="txtFirst"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label3" runat="server" CssClass="col-sm-3">Enrollment Date:</asp:Label>
        <asp:TextBox ID="txtDate" runat="server" type="date"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="txtDate"></asp:RequiredFieldValidator>
    </div>
    <asp:Button ID="saveStudent" runat="server" Text="Save" CssClass="btn btn-success col-sm-offset-3" OnClick="saveStudent_Click" />
</asp:Content>
