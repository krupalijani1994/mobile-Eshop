using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class customer_products : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {

		if (Session["username"] == null)
		{
			Response.Redirect("Default.aspx");
		}


		if (!IsPostBack)
		{
			display();
		}
	}

    private void SearchProducts()
    {


        using (SqlCommand cmd = new SqlCommand())
        {
            string sql = "SELECT ProductID,ProductActive, ProductName, ProductDetails, ProductPrice,ProductQuantity,Path FROM tblProduct";
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                sql += " WHERE ProductName LIKE @ProductName + '%'";
                cmd.Parameters.AddWithValue("@ProductName", txtSearch.Text.Trim());
            }
            cmd.CommandText = sql;
            cmd.Connection = con;
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                rproducts.DataSource = dt;
                rproducts.DataBind();
            }
        }
    }

    protected void Search(object sender, EventArgs e)
    {
        this.SearchProducts();
    }


	void display()
	{
		con.Open();
		String allqry = "select * from tblProduct";
		SqlCommand cmd1 = new SqlCommand(allqry, con);
		SqlDataAdapter da = new SqlDataAdapter(cmd1);
		DataSet ds = new DataSet();
		da.Fill(ds);
		rproducts.DataSource = ds;
		rproducts.DataBind();
		con.Close();
	}
}