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

        KarateDataContext dbcon;
        KarateDataContext dbcon2;
        
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Austin\\Desktop\\AAATEST_Nov17\\AAATEST_Nov17\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAll();
        }


        public void ShowAll()
        {
            dbcon = new KarateDataContext(conn);
            var result = from x in dbcon.Members
                         select x;
            GridView1.DataSource = result;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(conn))
            {
                int memberIDToAdd = Convert.ToInt32(TextBox1.Text);
                int chosenSectionID = Convert.ToInt32(TextBox2.Text);
                string addQuery = $"INSERT INTO Section (Member_ID) VALUES (" 
                    

                //using (SqlCommand)
            }

        }
    }
}