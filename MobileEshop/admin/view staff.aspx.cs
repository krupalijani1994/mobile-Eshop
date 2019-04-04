using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_view_staff : System.Web.UI.Page
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
            this.SearchStaff();
        }
    }

    private void SearchStaff()
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            string sql = "SELECT * FROM tblStaff";
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                sql += " WHERE StaffFirstName LIKE @StaffFirstName + '%'";
                cmd.Parameters.AddWithValue("@StaffFirstName", txtSearch.Text.Trim());
            }
            cmd.CommandText = sql;
            cmd.Connection = con;
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GvStaff.DataSource = dt;
                GvStaff.DataBind();
            }

        }


    }
    protected void Search(object sender, EventArgs e)
    {
        this.SearchStaff();
    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {
        GvStaff.PageIndex = e.NewPageIndex;
        this.SearchStaff();
    }



    protected void gvStaff_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        con.Open();
        string id = GvStaff.Rows[e.RowIndex].Cells[1].Text;
        string fname = (((TextBox)GvStaff.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
        string lname = (((TextBox)GvStaff.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
        string phoneno = (((TextBox)GvStaff.Rows[e.RowIndex].Cells[4].Controls[0]).Text);
        string address = (((TextBox)GvStaff.Rows[e.RowIndex].Cells[5].Controls[0]).Text);
        string email = (((TextBox)GvStaff.Rows[e.RowIndex].Cells[6].Controls[0]).Text);

        String qry = "UPDATE tblStaff set StaffFirstName = '" + fname + "', StaffLastName = '" + lname + "', StaffPhoneNo = '" + phoneno + "', StaffAddress = '" + address + "' , StaffEmail = '" + email + "'  WHERE StaffID = '" + id + "'";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        Response.Redirect("view staff.aspx");
        con.Close();


    }


        protected void gvStaff_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvStaff.EditIndex = e.NewEditIndex;
            SearchStaff();

        }
        protected void gvStaff_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvStaff.EditIndex = -1;
            SearchStaff();

        }





    }
