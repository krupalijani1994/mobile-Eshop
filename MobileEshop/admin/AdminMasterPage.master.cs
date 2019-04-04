using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbluser.Text = "Welcome  " + Session["username"].ToString();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((Session["username"] != null) || (Session["username"] != ""))
        {
            Session["username"] = null;
            Session["username"] = "";
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Redirect("AdminLogin.aspx");
        }
    }
}
