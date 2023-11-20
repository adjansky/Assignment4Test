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
    public partial class SectionPage : System.Web.UI.Page
    {

        //Creating the data contexts for the database
        KarateDataContext dbcon;
        KarateDataContext dbcon2;
        
        //Creating the connection string
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Austin\\Desktop\\AAATEST_Nov17\\AAATEST_Nov17\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";
        
        //Creating the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        //Creating a helper method for refreshing the database
        public void ShowAll()
        {
            //Assigning a value to the database context
            dbcon = new KarateDataContext(conn);
            
            //Creating a result to show in the grid view
            var result = from x in dbcon.Members
                         select x;
            
            //Assigning the result and binding it to the grid view
            GridView1.DataSource = result;
            GridView1.DataBind();
        }


        //Creating the button click event
        protected void Button1_Click(object sender, EventArgs e)
        {

            //Creating a connection with the connection string
            using (SqlConnection connection = new SqlConnection(conn))
            {
                //Creating variables for the memberID and the sectionID
                int memberIDToAdd = Convert.ToInt32(TextBox1.Text);
                int chosenSectionID = Convert.ToInt32(TextBox2.Text);

                //Creating a query for adding a member to a section
                string addQuery = $"INSERT INTO Section (Member_ID) VALUES (@memberIDToAdd) WHERE SectionID = @chosenSectionID";
                
                //Creating a command with the query
                using (SqlCommand command = new SqlCommand(addQuery, connection)) 
                {
                    //Opening the connection
                    connection.Open();

                    //Filling in the parameters for the add query
                    command.Parameters.AddWithValue("@memberIDToAdd", memberIDToAdd);
                    command.Parameters.AddWithValue("chosenSectionID", chosenSectionID);

                    //Executing the query
                    command.ExecuteNonQuery();
                }

            }

            //Refreshing the grid view 
            ShowAll();
        }
    }
}