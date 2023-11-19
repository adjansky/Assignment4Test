using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4Test.Administrator
{
    public partial class CreateMember : System.Web.UI.Page
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
            var result=from x in dbcon.Members
                       select x;
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            NetUser myUser= new NetUser();
            myUser.UserName=txtUserName.Text;
            myUser.UserPassword=txtPassword.Text;
            myUser.UserType = DropDownList1.SelectedItem.Text;


            dbcon.NetUsers.InsertOnSubmit(myUser);
            dbcon.SubmitChanges();

            //search for ID

            NetUser myID=(from x in dbcon.NetUsers
                          where x.UserName==myUser.UserName
                          select x).FirstOrDefault();
            int memberID = myID.UserID;

            


            //add new member
            dbcon2=new KarateDataContext(conn);

            Member myMember=new Member();
            myMember.Member_UserID=memberID;
            myMember.MemberFirstName = txtFirst.Text;
            myMember.MemberLastName=txtLast.Text;
            myMember.MemberDateJoined= DateTime.Now;
            myMember.MemberPhoneNumber=txtPnone.Text;
            myMember.MemberEmail=txtEmail.Text;
            
            //add data to the DB

            dbcon.Members.InsertOnSubmit(myMember);
            dbcon.SubmitChanges();
            ShowAll();


        }
    }
}








