using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventManagmentSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC116;Initial Catalog=EventManagment;Integrated Security=true;");
            con.Open();

            SqlCommand com = new SqlCommand("select * from RegisterTable where UserName=@name  AND Password=@password ", con);
            com.Parameters.AddWithValue("@name", un1.Text);
            com.Parameters.AddWithValue("@password", pw1.Text);
            Session["name"] = un1.Text;
             SqlDataReader ad = com.ExecuteReader();
            if(ad.Read()==true)
            {
                Session["name"] = un1.Text;
                Response.Redirect("~/Welcome.aspx");
            }
            else
            {
                Label3.Text = "Invalid username or password";
                Label3.Visible = true;
            }
            con.Close();



       }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }
    }
}
