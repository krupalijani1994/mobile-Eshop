using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Security.Cryptography;

public partial class admin_AdminLogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {

        txtusername.Focus();

        
    }


    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string enteredPassword = txtpassword.Text;

        // Create a new instance of the hash crypto service provider.
        HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
        // Convert the data to hash to an array of Bytes.
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enteredPassword);
        // Compute the Hash. This returns an array of Bytes.
        byte[] bytHash = hashAlg.ComputeHash(bytValue);
        // Optionally, represent the hash value as a base64-encoded string, 
        // For example, if you need to display the value or transmit it over a network.
        string hashedPassword = Convert.ToBase64String(bytHash);

        con.Open();
            String qry = "select * from tbl_adminlogin where username='" + txtusername.Text + "' and password='" + hashedPassword + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["aid"] = dr["adminid"].ToString();
                Session["username"] = dr["username"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Invalid USername or Password..!');</script>");
            }
            con.Close();
            txtusername.Text = null;
            txtpassword = null;
        
    }
}