using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4Test.Administrator
{
 
    public partial class AdministratorPage : System.Web.UI.Page
    {
        KarateDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Austin\\Desktop\\Assignment4Test\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateDataContext(conn);

            //read data from the table
                var result =from x in dbcon.Members
                            select new {x.MemberFirstName, x.MemberLastName, x.MemberPhoneNumber,x.MemberDateJoined};
            GridView1.DataSource = result;
            GridView1.DataBind();



        }
    }
}