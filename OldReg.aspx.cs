//Copyright (c) Nishit Tated. All Rights Reserved.
  // project name: College Alumni System
  //This project is licensed under the MIT license, see LICENSE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

public partial class victorypro_OldReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        co.Open();

        SqlCommand objcm = new SqlCommand("INSERT INTO OldRegister (Name, Address,Registerno ,JoiningDate, EmailID,DOB, ContactNumber, Gender, Qualification, Designation) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "' ,'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox8.Text + "', '" + TextBox9.Text + "', '" + TextBox10.Text + "', '" + RadioButtonList1.Text + "', '" + TextBox11.Text + "', '" + TextBox13.Text + "')", co);
        objcm.ExecuteNonQuery();

        co.Close();
    }
}
