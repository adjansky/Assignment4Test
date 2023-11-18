<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment4Test.Member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Main Content -->
    <div class="container py-4">
    <div class="container">
    <div class="row">
        <div class="col-md-8">
            <h2 class="mb-3">Member Details</h2>
            </div>
            <div class="col-md-4 text-md-right">
                <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="Logout" CssClass="btn btn-primary mt-2 mt-md-0" OnLoggingOut="LoginStatus1_LoggingOut" />
            </div>
        </div>
    </div>

        <h5>Welcome back, 
            <asp:Label ID="nameDisplayLabel" runat="server" CssClass="font-weight-bold text-primary"></asp:Label>
        </h5>

        <div class="mt-4 mb-2">
            <h3>Payment History</h3>
           <asp:GridView ID="GridViewSections" runat="server" AutoGenerateColumns="False" CssClass="table table-responsive-md table-hover">
                <Columns>
                    <asp:BoundField DataField="SectionName" HeaderText="Section Name" />
                    <asp:BoundField DataField="InstructorName" HeaderText="Instructor Name" />
                    <asp:BoundField DataField="SectionStartDate" HeaderText="Start Date" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="SectionFee" HeaderText="Fee" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>

        </div>
    </div>

    
</asp:Content>



