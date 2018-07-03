//Copyright (c) Nishit Tated. All Rights Reserved. 
  // project name: College Alumni System
  //This project is licensed under the MIT license, see LICENSE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; 
using System.Data;
using System.Configuration;
using System.Web.Security;

public partial class Event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con2.Open();

        SqlCommand objc = new SqlCommand("INSERT INTO Event (Title,Description,Location, EventDate,Time) VALUES('" + TextBox1.Text + "','" + TextBox5.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox4.Text + "')", con2);
        objc.ExecuteNonQuery();

        con2.Close();
  
    }
}
