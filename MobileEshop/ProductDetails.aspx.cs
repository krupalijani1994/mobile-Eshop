using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetails : System.Web.UI.Page
{
	SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			display();
		}
	}

	protected void btnbuynow_Click(object sender, EventArgs e)
	{
		Response.Write("<script type='text/javascript'>alert('Please Login or Registration First');window.location.assign('Default.aspx');</script>");

	}

	void display()
	{
		con.Open();
		string id = Request.Params.Get("ProductID").ToString();
		String qry = "select * from tblProduct where ProductID='" + id + "'";
		SqlCommand cmd = new SqlCommand(qry, con);
		SqlDataReader dr;
		dr = cmd.ExecuteReader();
		if (dr.Read())
		{
			Image1.ImageUrl = "Admin/" + dr["path"].ToString();
			lblpro.Text = dr["ProductName"].ToString();
			lbldateail.Text = dr["ProductDetails"].ToString();
			lblprc.Text = dr["ProductPrice"].ToString();



		}
		con.Close();

	}


	protected void btnback_Click(object sender, EventArgs e)
	{
		Response.Redirect("Products.aspx");
	}
}