<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin1.Master" AutoEventWireup="true" CodeBehind="EditInstructor.aspx.cs" Inherits="Assignment4Test.Administrator.EditInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 440px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Please enter the info of the member/instructor to be deleted</p>
    <p>
        &nbsp;</p>
    <p>
        First Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Delete" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
