<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin1.Master" AutoEventWireup="true" CodeBehind="AdministratorPage.aspx.cs" Inherits="Assignment4Test.Administrator.AdministratorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table style="width:100%;">
        <tr>
            <td>Hi,<asp:LoginName ID="LoginName1" runat="server" />
            </td>
            <td>
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Members</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="347px">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
