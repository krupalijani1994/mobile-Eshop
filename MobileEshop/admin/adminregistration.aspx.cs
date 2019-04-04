using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminregistration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["username"] == null)
        {
            Response.Redirect("AdminLogin.aspx");
        }

    }

    protected void btnregister_Click(object sender, EventArgs e)
    {

        string enterPassword;
        enterPassword = txtpassword.Text;


        // Create a new instance of the hash crypto service provider.
        HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
        // Convert the data (entered password) to hash to an array of Bytes.
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enterPassword);
        // Compute the Hash. This returns an array of Bytes.
        byte[] bytHash = hashAlg.ComputeHash(bytValue);
        // represent the hash value as a base64-encoded string, for security --> 
        // -->if you need to display the value or transmit it over a network.
        string hashedPassword = Convert.ToBase64String(bytHash);

        con.Open();

        String qry = "insert into tbl_adminlogin(fname,lname,address,postcode,city,username,password,gender,email,phoneno,dob)values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtadd.Text + "','" + txtpostcode.Text + "','" + drpcity.Text + "','" + txtusername.Text + "','" + hashedPassword + "','" + rabgender.Text + "','" + txtemail.Text + "','" + txtcontno.Text + "','" + txtdob.Text + "')";

        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        Response.Redirect("Default.aspx");
        con.Close();
        txtfname.Text = null;
        txtlname.Text = null;
        txtadd.Text = null;
        drpcity.Text = null;
        txtusername.Text = null;
        enterPassword = txtpassword.Text = null;
        txtconpass.Text = null;
        rabgender.Text = null;
        txtemail.Text = null;
        txtcontno.Text = null;
        txtdob.Text = null;
    }
}