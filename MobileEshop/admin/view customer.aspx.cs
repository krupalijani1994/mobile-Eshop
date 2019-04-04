using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_view_customer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("AdminLogin.aspx");
        }


      

        if (!this.IsPostBack)
        {
            this.SearchCustomers();
        }
    }
    private void SearchCustomers()
    {   
        using (SqlCommand cmd = new SqlCommand())
        {
            string sql = "SELECT * FROM tbl_register";
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                sql += " WHERE fname LIKE @fname + '%'";
                cmd.Parameters.AddWithValue("@fname", txtSearch.Text.Trim());
            }
            cmd.CommandText = sql;
            cmd.Connection = con;
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                customer.DataSource = dt;
                customer.DataBind();
            }

        }


    }



    protected void Search(object sender, EventArgs e)
    {
        this.SearchCustomers();
    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {
        customer.PageIndex = e.NewPageIndex;
        this.SearchCustomers();
    }



    protected void customer_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
      con.Open();
            string id = customer.Rows[e.RowIndex].Cells[1].Text;
            string fname = (((TextBox)customer.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            string lname = (((TextBox)customer.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            string address = (((TextBox)customer.Rows[e.RowIndex].Cells[4].Controls[0]).Text);
            string postcode = (((TextBox)customer.Rows[e.RowIndex].Cells[5].Controls[0]).Text);
            string username = (((TextBox)customer.Rows[e.RowIndex].Cells[6].Controls[0]).Text);
        
        //string query = "UPDATE tbl_register set fname = '" + fname + "', lname = '" + lname + "', address = '" + address + "', postcode = '" + postcode + "' , username = '" + username + "'  WHERE regid = '" + id + "'";

        //SqlCommand cmd = new SqlCommand(query);
        //cmd.CommandType = CommandType.Text;

        //cmd.Connection = con;
        //cmd.ExecuteNonQuery();

        //customer.EditIndex = -1;
        //SearchCustomers();

        //con.Close();

        String qry = "UPDATE tbl_register set fname = '" + fname + "', lname = '" + lname + "', address = '" + address + "', postcode = '" + postcode + "' , username = '" + username + "'  WHERE regid = '" + id + "'";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        Response.Redirect("view customer.aspx");
        con.Close();



        //DataTable dt = (DataTable)Session["TaskTable"];

        ////Update the values.
        //GridViewRow row = customer.Rows[e.RowIndex];
        ////	dt.Rows[row.DataItemIndex]["regid"] = ((TextBox)(row.Cells[0].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["fname"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["lname"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["address"] = ((TextBox)(row.Cells[4].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["postcode"] = ((TextBox)(row.Cells[5].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["username"] = ((TextBox)(row.Cells[6].Controls[0])).Text;

        ////dt.Rows[row.DataItemIndex]["IsComplete"] = ((CheckBox)(row.Cells[3].Controls[0])).Checked;

        ////Reset the edit index.
        //customer.EditIndex = -1;

        ////Bind data to the GridView control.
        //SearchCustomers();

    }

    protected void customer_RowEditing(object sender, GridViewEditEventArgs e)
    {
        customer.EditIndex = e.NewEditIndex;
        SearchCustomers();

    }
    protected void customer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        customer.EditIndex = -1;
        SearchCustomers();

    }



}



