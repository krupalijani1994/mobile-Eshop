using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

public partial class admin_change_password : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        //txtopassword.Focus();


    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string enteredPassword = txtnewPassword.Text;


        // Create a new instance of the hash crypto service provider.
        HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
        // Convert the data to hash to an array of Bytes.
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enteredPassword);
        // Compute the Hash. This returns an array of Bytes.
        byte[] bytHash = hashAlg.ComputeHash(bytValue);
        // Optionally, represent the hash value as a base64-encoded string, 
        // For example, if you need to display the value or transmit it over a network.
        string newPassword = Convert.ToBase64String(bytHash);



        con.Open();
        String aid = Session["aid"].ToString();
        
            {
                String update = "update tbl_adminlogin set password='" + newPassword + "' where adminid='" + aid + "'";
                SqlCommand cmd2 = new SqlCommand(update, con);
                con.Close();
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                Response.Write("<script type='text/javascript'>alert('sucessfully updated Password..!');</script>");
            }          
        
        ////else
        //{
        //    Response.Write("<script type='text/javascript'>alert('Invalid Password..!');</script>");

        //}
        //con.Close();
     
        txtnewPassword.Text = null;

    }
}