using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

public partial class Staff : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection c = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        c.Open();

        SqlCommand sc = new SqlCommand("INSERT INTO Staff (Staff_ID,Name, EmailID,ContactNo) VALUES('" + TextBox4.Text + "','" + TextBox1.Text + "' ,'" + TextBox3.Text + "','" + TextBox2.Text + "')", c);
        sc.ExecuteNonQuery();

        c.Close();
    }
}