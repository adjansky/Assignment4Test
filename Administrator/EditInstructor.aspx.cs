using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4Test.Administrator
{
    public partial class EditInstructor : System.Web.UI.Page
    {

        //Creating data contexts for the database
        KarateDataContext dbcon;
        KarateDataContext dbcon2;

        //Creating the connection string
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Austin\\Desktop\\AAATEST_Nov17\\AAATEST_Nov17\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";

        //Creating the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        //Creating a helper method for refreshing the grid view
        public void ShowAll()
        {
            //Assigning the context a value
            dbcon = new KarateDataContext(conn);

            //Creating a variable for bringing data to the gridview
            var result = from x in dbcon.Members
                         select x;

            //Assigning a value and binding the grid view 
            GridView1.DataSource = result;
            GridView1.DataBind();
        }

        //Creating the button click event
        protected void Button1_Click(object sender, EventArgs e)
        {

            //Creating a connection with the connection string
            using (SqlConnection connection = new SqlConnection(conn)) 
            {
                //Creating a variable to get the first name
                string fName = TextBox1.Text;

                //Creating a query for deleting a member from the table
                string deleteQuery = $"DELETE FROM Member WHERE MemberFirstName = @fName";

                //Creating a sql command 
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {

                    //Opening the connection
                    connection.Open();

                    //Adding the fName to the parameter
                    command.Parameters.AddWithValue("@fName", fName);

                    //Using int to retrieve the rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    //Using if/else to detect if a change was made 
                    if (rowsAffected > 0)
                    {
                        //Showing a message if a row is deleted
                        Console.WriteLine("Done.");
                    }
                    else
                    {
                        //Showing a message if no row is deleted
                        Console.WriteLine("No rows deleted.");
                    }

                }
            }
            


        }
    }
}