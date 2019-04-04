using System;
using System.Collections;
using System.Configuration;
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


public partial class customer_review_and_compare : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            GetData1();
            GetData2();
        }
    }






    protected void drpcomp1_SelectedIndexChanged(object sender, EventArgs e)
    {

        {
            using (SqlCommand Cmd = new SqlCommand("select ProductName,ProductDetails from tblProduct where ProductName= @ProductName", con))
            {
                con.Open();

                Cmd.Parameters.AddWithValue("@ProductName", (drpcomp1.SelectedValue));
                SqlDataReader Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    comp1.DataSource = Dr;
                    comp1.DataBind();
                }
                Dr.Close();

                con.Close();
            }

        }
    }
    DataTable GetData1()
    {
        //  DataTable dt = new DataTable();
        // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);

        //  using (SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString))
        //{
        //    using (SqlCommand Cmd = new SqlCommand("select * FROM tblProduct "))
        //    {
        //        con.Open();
        //        SqlDataAdapter adpt = new SqlDataAdapter(Cmd);
        //        adpt.Fill(dt);
        //    }

        //}

        con.Open();
        string com1 = "select * from tblProduct";
        SqlDataAdapter adp1 = new SqlDataAdapter(com1, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);
        drpcomp1.DataSource = dt1;
        drpcomp1.DataTextField = "ProductName";
        drpcomp1.DataValueField = "ProductName";
        drpcomp1.DataBind();
        drpcomp1.Items.Insert(0, new ListItem("<--Select-->", "0"));

        con.Close();
        return dt1;
    }
    DataTable GetData2()
    {
        con.Open();

        string com2 = "select * from tblProduct";
        SqlDataAdapter adp1 = new SqlDataAdapter(com2, con);
        DataTable dt = new DataTable();
        adp1.Fill(dt);
        drpcomp2.DataSource = dt;
        drpcomp2.DataTextField = "ProductName";
        drpcomp2.DataValueField = "ProductName";
        drpcomp2.DataBind();

        drpcomp2.Items.Insert(0, new ListItem("<--Select-->", "0"));

        con.Close();
        return dt;
    }

    protected void drpcomp2_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (SqlCommand Cmd = new SqlCommand("select ProductName,ProductDetails from tblProduct where ProductName= @ProductName", con))
        {
            con.Open();
            Cmd.Parameters.Add(new SqlParameter("@ProductName", drpcomp2.SelectedValue));

            //Cmd.Parameters.AddWithValue("@ProductName", (drpcomp2.SelectedValue));
            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.HasRows)
            {
                comp2.DataSource = Dr;
                comp2.DataBind();


            }
            Dr.Close();

            con.Close();

        }


    }






































}