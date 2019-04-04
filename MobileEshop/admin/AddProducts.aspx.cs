using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public partial class admin_AddProducts : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] == null)
		{
			Response.Redirect("AdminLogin.aspx");
		}

		txtname.Focus();
		if (!IsPostBack)
		{
			if (Request.Params.Get("state") == "view")
			{
				Response.Redirect("DisplayProduct.aspx");
			}
			//if (Request.Params.Get("state") == "delete")
			//{
			//	con.Open();
			//	String del = "delete from tbl_addproduct where ProductID='" + Request.Params.Get("ProductID") + "'";
			//	SqlCommand cmd1 = new SqlCommand(del, con);
			//	cmd1.ExecuteNonQuery();
			//	con.Close();
			//}


		}
		


	}



protected void btnadd_Click(object sender, EventArgs e)
    {
        string Fname = Path.GetFileName(FileUpload1.PostedFile.FileName);
        if (Fname == "")
        {
            Response.Write("<script>alert('Please Select File To Upload');</script>");
        }
        else
        {

            con.Open();
            String qry = "Insert into tblProduct(ProductName,ProductDetails,ProductPrice,ProductQuantity,Path) values('" + txtname.Text + "','" + txtdetails.Text + "','" + txtprice.Text + "','" + txtquantity.Text + "','" + "uploadImg/" + Fname + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                FileUpload1.SaveAs(Server.MapPath("uploadImg/" + Fname));
                Response.Write("<script>alert('File Uploaded');</script>");
                Response.Redirect("../customer/products.aspx");
                con.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Select File To Upload');</script>");
            }
        }


    }
	
}