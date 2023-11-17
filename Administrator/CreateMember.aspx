<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin1.Master" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="Assignment4Test.Administrator.CreateMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 360px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Please enter the info of the member/instructor to be created</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Create" />
    </p>
    <p class="auto-style1">
        &nbsp;</p>
</asp:Content>
