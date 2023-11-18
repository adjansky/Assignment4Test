<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment4Test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="welcomeTitle">
            <h1 id="welcomeTitle">Welcome to Karate School</h1>
            <p class="lead">Explore the art of Karate | Join our community to learn, grow, and excel in Karate.</p>
            <p><a href="About.aspx" class="btn btn-primary btn-md">Discover More &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="membersTitle">
                <h2 id="membersTitle">For Members</h2>
                <p>
                    Access your course details, track your progress, and manage your payments. Engage with your instructors and fellow Karate enthusiasts.
                </p>
                <p>
                    <a class="btn btn-default" href="Member.aspx">Member Area &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="instructorsTitle">
                <h2 id="instructorsTitle">For Instructors</h2>
                <p>
                    Manage your sections, interact with your students, and update course content. Utilize tools to enhance the learning experience.
                </p>
                <p>
                    <a class="btn btn-default" href="Instructor.aspx">Instructor Area &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="adminTitle">
                <h2 id="adminTitle">For Administrators</h2>
                <p>
                    Oversee the Karate School operations, manage member and instructor profiles, and ensure a seamless experience for all users.
                </p>
                <p>
                    <a class="btn btn-default" href="Admin.aspx">Administrator Area &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
