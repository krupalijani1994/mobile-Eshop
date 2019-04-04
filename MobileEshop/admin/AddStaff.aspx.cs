using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_AddStaff : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        
        if (!IsPostBack)
        {
            if (Request.Params.Get("state") == "view")
            {
                Response.Redirect("AddStaff.aspx");
            }
            
        }
    }

    protected void btnregister_Click(object sender, EventArgs e)
    {
        con.Open();
        String qry = "insert into tblStaff(StaffFirstName,StaffLastName,StaffGender,StaffPhoneNo,StaffAddress,StaffEmail,DOB)values('" + txtfname.Text + "','" + txtlname.Text + "','" + rabgender.Text + "','" + txtphoneno.Text + "','" + txtadd.Text + "','" + txtemail.Text + "','" + txtdob.Text + "')";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        //Response.Redirect("register.aspx");
        con.Close();
        txtfname.Text = null;
        txtlname.Text = null;
        txtadd.Text = null;
        rabgender.Text = null;
        txtemail.Text = null;
        txtphoneno.Text = null;
        txtdob.Text = null;
    }
}