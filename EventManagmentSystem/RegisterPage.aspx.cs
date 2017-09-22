using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventManagmentSystem
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = un1.Text;

            string password = pw1.Text;
            string cfpassword = cpw1.Text;


            SqlConnection con = new SqlConnection(@" Data Source=SUYPC116;Initial Catalog= EventManagment;Integrated Security=true;");
            con.Open();
            SqlCommand com = new SqlCommand("insert into RegisterTable (UserName,Password)values(@name,@password)", con);
            com.Parameters.AddWithValue("@Name", un1.Text);

            com.Parameters.AddWithValue("@password", pw1.Text);
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/LoginPage.aspx");


           




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }

        protected void un1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@" Data Source=SUYPC116;Initial Catalog= EventManagment;Integrated Security=true;");
            con.Open();
            string str = "select * from RegisterTable where UserName='" + un1.Text + "'";
            SqlCommand com = new SqlCommand(str, con);
            int count = Convert.ToInt32(com.ExecuteScalar());
            if(count>0)
            {
                Validation.Text = "UserName exist";
            }
            





        }
    }
}