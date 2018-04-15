//Copyright (c) Nishit Tated. All Rights Reserved.
  // project name: College Alumni System
  //This project is licensed under the MIT license, see LICENSE.
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using System.Web.UI; 
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Sign_In : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();

        SqlCommand objcmd = new SqlCommand("insert into Log (UserName,Password) values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        objcmd.ExecuteNonQuery();

        con.Close();
    }
}
