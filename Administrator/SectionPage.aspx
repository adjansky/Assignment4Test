<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin1.Master" AutoEventWireup="true" CodeBehind="SectionPage.aspx.cs" Inherits="Assignment4Test.Administrator.SectionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 480px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Please enter the member ID and the section ID to add a member to a section</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Member ID:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Section ID:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Add" Width="76px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
