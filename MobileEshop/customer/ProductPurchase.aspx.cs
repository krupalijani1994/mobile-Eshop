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
using System.Web.Mail;
using System.Net;
using System.Net.Mail;

public partial class customer_ProductPurchase : System.Web.UI.Page
{
	SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
	string body;
	string subject;

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


	protected void btnpay_Click(object sender, EventArgs e)
	{
        string date = DateTime.Now.ToString();
        con.Open();
     
		String qry = "insert into tbl_userpayment(uname,address,email,conctno,ProductID,ProductName,ProductQuantity,rate,amount,purchasedate)values('" + txtname.Text + "','" + txtadd.Text + "','" + txtemail.Text + "','" + txtphoneno.Text + "','" + txtpid.Text + "','" + txtpname.Text + "','" + txtqty.Text + "','" + txtrate.Text + "','" + txtprice.Text + "','" + date + "')";
		SqlCommand cmd = new SqlCommand(qry, con);
		cmd.ExecuteNonQuery();
		con.Close();
		SendMail();

		txtname.Text = null;
		txtadd.Text = null;
		txtemail.Text = null;
		txtphoneno.Text = null;
		txtpid.Text = null;
		txtpname.Text = null;
		txtqty.Text = null;
		txtrate.Text = null;
		txtprice.Text = null;
		Response.Redirect("Products.aspx");

	}
	protected void SendMail()
	{

		// Gmail Address from where you send the mail
		var fromAddress = "krupalijani1994@gmail.com";
		// any address where the email will be sending
		var toAddress = txtemail.Text.ToString();
		//Password of your gmail address
		const string fromPassword = "";
		// Passing the values and make a email formate to display
		body += "Thank you for purchasing with MobileEshop \n";
		body += "uname: "+ txtname.Text + "\n";
		body += "address: " + txtemail.Text + "\n";
		body += "email: " + txtemail.Text + "\n";
		body += "conctno: " + txtphoneno.Text + "\n";
		body += "pid: " + txtpid.Text + "\n";
		body += "pname: " + txtpname.Text + "\n";
		body += "qty: " + txtqty.Text + "\n";
		body += "rate: " + txtrate.Text + "\n";
		body += "amount: " + txtprice.Text + "\n";
		subject = "THANK YOU FOR SHOPPING WITH MobileEshop";
		//smtp settings
		var smtp = new System.Net.Mail.SmtpClient();
		{
			smtp.Host = "smtp.gmail.com";
			smtp.Port = 587;
			smtp.EnableSsl = true;
			smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
			smtp.Timeout = 20000;
		}
		// Passing values to smtp object
		 //smtp.Send(fromAddress, toAddress,subject,body);
	}

	void display()
	{
		con.Open();
		string uid = Session["uid"].ToString();
		string qry1 = "select * from tbl_register where regid='" + uid + "' ";
		SqlCommand cmd = new SqlCommand(qry1, con);
		SqlDataReader dr = cmd.ExecuteReader();
		if (dr.Read())
		{
			txtname.Text = dr["username"].ToString();
			txtadd.Text = dr["address"].ToString();
			txtemail.Text = dr["email"].ToString();
			txtphoneno.Text = dr["phoneno"].ToString();


		}

		con.Close();



		con.Open();

		String qry = "select * from tblProduct where ProductID='" + Request.Params.Get("ProductID") + "'";
		SqlCommand cmd1 = new SqlCommand(qry, con);
		SqlDataReader dr1;
		dr1 = cmd1.ExecuteReader();
		if (dr1.Read())
		{
			txtpid.Text = dr1["ProductID"].ToString();
			txtpname.Text = dr1["ProductName"].ToString();
			txtrate.Text = dr1["ProductPrice"].ToString();


		}

		con.Close();


	}
	protected void txtqty_TextChanged(object sender, EventArgs e)
	{
		txtprice.Text = (Decimal.Parse(txtqty.Text) * Decimal.Parse(txtrate.Text)).ToString();
	}
	protected void btnback_Click(object sender, EventArgs e)
	{
		Response.Redirect("Display Product.aspx");
	}
}


