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
using System;
using System.Configuration;

public partial class customer_editprofile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            if (!IsPostBack)
            {
                userdisplay();
                

            }
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }


    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        con.Open();
        string uid = Session["uid"].ToString();
        String update = "update tbl_register set fname='" + txtfname.Text + "',lname='" + txtlname.Text + "',address='" + txtadd.Text + "',postcode='" + txtpostcode.Text + "',city='" + drpcity.Text + "',email='" + txtemail.Text + "',phoneno='" + txtphoneno.Text + "',dob='" + txtdob.Text + "' where regid='" + uid + "'";
        SqlCommand cmd = new SqlCommand(update, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Updated..!');</script>");
        con.Close();
    }



    void userdisplay()
    {

        con.Open();
        string uid = Session["uid"].ToString();
        String qry1 = "select * from tbl_register where regid='" + uid + "' ";
        SqlCommand cmd1 = new SqlCommand(qry1, con);
        SqlDataReader dr1;
        dr1 = cmd1.ExecuteReader();
        if (dr1.Read())
        {
            txtfname.Text = dr1["fname"].ToString();
            txtlname.Text = dr1["lname"].ToString();
            txtadd.Text = dr1["address"].ToString();
            txtpostcode.Text = dr1["postcode"].ToString();
            drpcity.Text = dr1["city"].ToString();
            txtemail.Text = dr1["email"].ToString();
            txtphoneno.Text = dr1["phoneno"].ToString();
            txtdob.Text = dr1["dob"].ToString();

        }
        con.Close();
    }

    protected void btncancle_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("");
    }
   

}