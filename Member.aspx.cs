using Assignment4Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4Test
{
    public partial class Member : Page
    {
        // Connection string to the database
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ayanle's\\Desktop\\Modern Software Development\\Assignment4Test\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is logged in
                if (Session["UserName"] != null)
                {
                    string username = Session["UserName"].ToString();
                    LoadMemberData(username); // Load member details
                    LoadSectionHistory(username); // Load payment history

                    // User is logged in, so the logout button should be visible
                    LoginStatus1.Visible = true;
                }
                else
                {
                    // User is not logged in, display a message
                    nameDisplayLabel.Text = "User is not authenticated.";
                    LoginStatus1.Visible = false; // Hide logout button as there's no user logged in
                }
            }
        }

        // Load member data based on the username
        private void LoadMemberData(string username)
        {
            using (var db = new KarateDataContext(conn))
            {
                var memberInfo = (from m in db.Members
                                  join nu in db.NetUsers on m.Member_UserID equals nu.UserID
                                  where nu.UserName == username
                                  select new
                                  {
                                      m.MemberFirstName,
                                      m.MemberLastName
                                  }).FirstOrDefault();

                if (memberInfo != null)
                {
                    // Display the member's name
                    nameDisplayLabel.Text = $" {memberInfo.MemberFirstName} {memberInfo.MemberLastName}";
                }
                else
                {
                    // Member not found
                    nameDisplayLabel.Text = "Member not found.";
                }
            }
            Session.Clear();
        }

        // Load payment history based on the username
        private void LoadSectionHistory(string username)
        {
            using (var db = new KarateDataContext(conn))
            {
                // query the fee and user info from those tables 
                var sectionData = (from s in db.Sections
                                   join m in db.Members on s.Member_ID equals m.Member_UserID
                                   join i in db.Instructors on s.Instructor_ID equals i.InstructorID
                                   join nu in db.NetUsers on m.Member_UserID equals nu.UserID
                                   where nu.UserName == username
                                   select new
                                   {
                                       SectionName = s.SectionName,
                                       InstructorName = i.InstructorFirstName + " " + i.InstructorLastName,
                                       SectionStartDate = s.SectionStartDate,
                                       SectionFee = s.SectionFee
                                   }).ToList();
                // display the result
                GridViewSections.DataSource = sectionData;
                GridViewSections.DataBind();

            }
        }


        protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            // Check if the session has user data
            if (Session["UserName"] != null)
            {
                // Clear the session to log out the user
                Session.Clear();

                // Redirect the user to the login page or home page after logging out
                Response.Redirect("Login.aspx");
            }
        }
    }
}
