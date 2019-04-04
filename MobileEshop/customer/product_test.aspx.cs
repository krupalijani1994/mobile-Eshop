using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class customer_product_test : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            this.SearchProducts();
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

   
}