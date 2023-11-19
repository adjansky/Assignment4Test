<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin1.Master" AutoEventWireup="true" CodeBehind="SectionPage.aspx.cs" Inherits="Assignment4Test.Administrator.SectionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 240px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Please enter the member ID and the section ID (1-13) to add a member to a section</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Member ID:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Section ID:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Add" Width="76px" OnClick="Button1_Click" />
    </p>
    <p>
        <br />
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
