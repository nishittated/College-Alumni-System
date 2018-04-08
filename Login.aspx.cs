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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
  /*  protected void login(object sender, EventArgs e)
    {
     SqlConnection con = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
       
        SqlCommand objcmd = new SqlCommand("INSERT INTO Log (UserName,Password) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        objcmd.ExecuteNonQuery();

        con.Close();
    
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Log", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@pwd", TextBox2.Text.Trim());
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            cmd.Dispose();
            if (dt.Rows.Count > 0)
            {
                //lblStatus.Text = "Login Successfull";
                //Or in show messagebox using  ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Login Successfull');", true);
                //Or write using Response.Write("Login Successfull");
                 Response.Redirect("index.html");
            }
            else
            {
                //lblStatus.Text = "Wrong Username/Password";
                //Or show in messagebox usingScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Wrong Username/Password');", true);
                Response.Write("Wrong Username/Password");
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!! following error occured : " + ex.Message.ToString() + "');", true);
            // Response.Write("Oops!! following error occured: " +ex.Message.ToString());           
        }
        finally
        {
            dt.Clear();
            dt.Dispose();
            adp.Dispose();
        }        
    }*/
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand objcmd = new SqlCommand("select * from Log where UserName='" + TextBox1.Text + "' and Password= '" + TextBox2.Text + "'", con);
        objcmd.ExecuteNonQuery();

        SqlDataAdapter adp = new SqlDataAdapter(objcmd);
        DataTable dt = new DataTable();

        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Label1.Text = "Correct !!";
            Session["UserName"] = TextBox1.Text;
            Response.Redirect("AlumniHome.aspx");
        }
        else
        {
            Label1.Text = "Invalid UserName or Password";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        con.Close();
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }

    protected void Button6_Insert(object sender, EventArgs e)
    {
        Event2 eve = new Event2();

        int i = eve.Insert(TextBox1.Text,  TextBox2.Text);
        if (i > 0)
        {
            Label2.Text = "Data Inserted";
        }
    }

    protected void Button6_Update(object sender, EventArgs e)
    {
        Event2 eve = new Event2();

        int i = eve.Update(TextBox1.Text, TextBox2.Text);

        if (i > 0)
        {
             Label3.Text = "Data Updated";
        }
    }

    protected void Button6_Delete(object sender, EventArgs e)
    {
        Event2 eve = new Event2();

        int i = eve.Delete (TextBox1.Text);
        if (i > 0)
        {
            Label4.Text = "Data Deleted";
        }
    }
}
