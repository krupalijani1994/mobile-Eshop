using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class customer_PurchaseHistory : System.Web.UI.Page
{
	SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            if (!IsPostBack)
            {
                purchasedisplay();


            }
        }
        else
        {
            //Response.Write("<script type='text/javascript'>alert('no session stored');</script>");
           Response.Redirect("~/Default.aspx");
        }
    }

    //string uid = Session["uid"].ToString();
    ////String allqry = "select * from  tbl_userpayment where uname = session.uid";
    //string query = "Select * from tbl_userpayment where uid=@uid";
    //SqlCommand cmd = new SqlCommand(query, con);
    //SqlDataAdapter da = new SqlDataAdapter(cmd);
    //DataSet ds = new DataSet();

    //cmd.Parameters.AddWithValue("@uid", uid);
    //da.Fill(ds);
    //GridView1.DataSource = ds;
    //GridView1.DataBind();
    //con.Close();
    //con.Open();
    //    String qry = "Select * from tbl_userpayment JOIN tbl_register ON tbl_userpayment.uname = tbl_register.username WHERE uname ='" + uid + "'";
    //SqlCommand cmd = new SqlCommand(qry, con);
    //SqlDataAdapter da = new SqlDataAdapter(cmd);
    //DataSet ds = new DataSet();
    //cmd.ExecuteNonQuery();
    //    Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
    //    Response.Redirect("view customer.aspx");
    //    da.Fill(ds);
    //    GridView1.DataSource = ds;
    //    GridView1.DataBind();
    //    con.Close();



    

    void purchasedisplay()
    {

        con.Open();
        string username = Session["username"].ToString();
        String qry = "Select * from tbl_userpayment JOIN tbl_register ON tbl_userpayment.uname = tbl_register.username WHERE uname ='" + username + "'";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        cmd.ExecuteNonQuery();
        //Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        //Response.Redirect("view customer.aspx");
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
}
