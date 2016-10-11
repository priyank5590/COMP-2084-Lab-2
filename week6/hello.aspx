<%@ Page Title="Week 4 - Hello Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="week6.hello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hello</h1>
    <div>
    <asp:label id="lblMessage" runat="server" cssclass="alert alert-info" visible="false"></asp:label>
    </div>
    <asp:textbox id="txtName" runat="server" placeholder="Enter your name" />

    <asp:button id="btnSubmit" runat="server" text="submit" cssclass="btn btn-success" OnClick="btnSubmit_Click" />
</asp:Content>
