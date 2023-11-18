using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Assignment4Test
{
    public partial class Instructor : Page
    {
        // Connection string to the database
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ayanle's\\Desktop\\Modern Software Development\\Assignment4Test\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is not authenticated
                if (Session["UserName"] != null)
                {
                    string username = Session["UserName"].ToString();
                    LoadInstructorData(username); // Load instructor details
                    LoadSectionEnrollment(username); // Load section enrollment information

                    // User is logged in, so the logout button should be visible
                    LoginStatus1.Visible = true;
                }
                else
                {
                    // User is not authenticated, display a message
                    nameDisplayLabel.Text = "User is not authenticated.";
                    LoginStatus1.Visible = false; // Hide logout button as there's no user logged in
                }
            }
        }

        // Load instructor data based on the username
        private void LoadInstructorData(string username)
        {
            using (var db = new KarateDataContext(conn))
            {
                var instructorInfo = (from i in db.Instructors
                                      join nu in db.NetUsers on i.InstructorID equals nu.UserID
                                      where nu.UserName == username
                                      select new
                                      {
                                          i.InstructorFirstName,
                                          i.InstructorLastName
                                      }).FirstOrDefault();

                if (instructorInfo != null)
                {
                    // Display the instructor's name
                    nameDisplayLabel.Text = $" {instructorInfo.InstructorFirstName} {instructorInfo.InstructorLastName}";
                }
                else
                {
                    // Instructor not found
                    nameDisplayLabel.Text = "Instructor not found.";
                }
            }
        }

        // Load section enrollment data based on the username
        private void LoadSectionEnrollment(string username)
        {
            using (var db = new KarateDataContext(conn))
            {
                var sectionData = (from s in db.Sections
                                   join i in db.Instructors on s.Instructor_ID equals i.InstructorID
                                   join m in db.Members on s.Member_ID equals m.Member_UserID
                                   join nu in db.NetUsers on i.InstructorID equals nu.UserID
                                   where nu.UserName == username
                                   select new
                                   {
                                       SectionName = s.SectionName,
                                       MemberName = m.MemberFirstName + " " + m.MemberLastName
                                   }).ToList();

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
