using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4Test
{
    public partial class Login : Page
    {
        // Connection string to the database
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ayanle's\\Desktop\\Modern Software Development\\Assignment4Test\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the user is already authenticated and redirect if necessary
            if (User.Identity.IsAuthenticated)
            {
                RedirectUser(User.Identity.Name);
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string password = Login1.Password;

            // Authenticate the user
            if (AuthenticateUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                RedirectUser(username); // Call RedirectUser to redirect based on user type
            }
            // Handle failed login here
        }
        // Method to Redirect based on User Type
        private void RedirectUser(string username)
        {
            
            // Get the user's type and redirect accordingly
            string userType = GetUserType(username);
            switch (userType)
            {
                case "Member":
                    Response.Redirect("Member.aspx");
                    break;
                case "Instructor":
                    Response.Redirect("Instructor.aspx");
                    break;
                case "Administrator":
                    //Response.Redirect("Administrator.aspx");
                    Response.Redirect("Administrator/AdministratorPage.aspx"); 
                
                    break;
                default:
                    // Handle unknown user type or redirect to a default page
                    break;
            }
        }
        // Authenticate Method 
        private bool AuthenticateUser(string username, string password)
        {
            using (var db = new KarateDataContext(conn))
            {
                var user = db.NetUsers.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

                if (user != null)
                {
                    // Set an authentication cookie to mark the user as authenticated
                    FormsAuthentication.SetAuthCookie(username, false);

                    // Set session variables upon successful authentication
                    Session["UserName"] = username;

                    return true;
                }

                return false;
            }
        }

        // Method to get the User Type 
        private string GetUserType(string username)
        {
            using (var db = new KarateDataContext(conn))
            {
                var user = db.NetUsers.FirstOrDefault(u => u.UserName == username);
                return user?.UserType;
            }
        }
    }
}
