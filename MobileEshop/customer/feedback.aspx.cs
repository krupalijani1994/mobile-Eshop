using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_feedback : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["shopkey"]);
    string body;
    string subject;
    protected void Page_Load(object sender, EventArgs e)
    {

        txtname.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string date = DateTime.Now.ToString();
        con.Open();

        String qry = "insert into tbl_feedback(name,email,conctno,msg,visitdate) Values('" + txtname.Text + "','" + txtemail.Text + "','" + txtcon.Text + "','" + txtmsg.Text + "','" + date + "')";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<Script type='text/JavaScript'>alert('Thank You For Your FeedBack.....');</Script>");
        con.Close();
        SendMail();
        txtname.Text = null;
        txtemail.Text = null;
        txtcon.Text = null;
        txtmsg.Text = null;
    }

    protected void SendMail()
    {

        // Gmail Address from where you send the mail
        var fromAddress = "krupalijani1994@gmail.com";
        // any address where the email will be sending
        var toAddress = txtemail.Text.ToString();
        //Password of your gmail address
        const string fromPassword = "PASSWORD HEREE";
        // Passing the values and make a email formate to display
        body += "name: " + txtname.Text + "\n";
        body += "email: " + txtemail.Text + "\n";
        body += "conctno: \n" + txtcon.Text + "\n";
        body += "msg: \n" + txtmsg.Text + "\n";
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
        //smtp.Send(fromAddress, toAddress, subject, body);
    }
}