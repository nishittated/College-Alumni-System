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
using System.Data;

public partial class Event1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        string com = "Select * from Event";
        SqlDataAdapter adpt = new SqlDataAdapter(com, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();
        DropDownList1.DataTextField = "Title";
        DropDownList1.DataValueField = "Event_ID";
        DropDownList1.DataBind();
    }
   

   /* protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con2.Open();

        SqlCommand objc = new SqlCommand("INSERT INTO Event (Title,Description,Location, EventDate,Time) VALUES('" + TextBox1.Text + "','" + TextBox5.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox4.Text + "')", con2);
        objc.ExecuteNonQuery();

        con2.Close();

    }*/
    protected void Button0_Click(object sender, EventArgs e)
    {
        SqlConnection con9 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con9.Open();

        SqlCommand sqcmd = new SqlCommand("insert into Event (Title,Description,Location, EventDate,Time) values('" + TextBox1.Text + "','" + TextBox5.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox4.Text + "')", con9);
        sqcmd.ExecuteNonQuery();

        ShowMessage("Added Successfully");
        con9.Close();
    }
    void ShowMessage(string msg)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Event Inserted Successfully.!!')", true);
        //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<scriptlanguage='javascript'>alert('" + msg + "');</script>");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("Update Event set Title='" + TextBox1.Text + "',Description='" + TextBox5.Text + "', Location ='" + TextBox2.Text + "',EventDate='" + TextBox3.Text + "' ,Time='" + TextBox4.Text + "' where Title='" + TextBox1.Text + "'", con);
        cmd.ExecuteNonQuery();
        ShowMessag("Event Updated Successfully.!!");
        con.Close();
    }
   private void ShowMessag(string p)
    {
       // throw new NotImplementedException();
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Event Updated Successfully.!!')", true);
    }
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("Delete from Event where Title='" + TextBox1.Text + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * from Event where Title='" + TextBox1.Text + "'", con);
        cmd.ExecuteNonQuery();
        SqlDataReader reader = cmd.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
    }

    protected void Button1_Click9(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\v11.0; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from Event where Event_Id = '" + DropDownList1.SelectedValue + "'", con);
        SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        Adpt.Fill(dt);
        //GridView2.DataSource = dt;
        GridView2.DataBind();
        Label1.Text = "record found";
        con.Close();
    }

    

    /*
    protected void Page_Load1(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        string strQuery = "select Title,Description,Location, EventDate,Time" +  " from Event";
        SqlCommand cmd = new SqlCommand(strQuery);
       // GridView2.DataSource = GetData(cmd);
        GridView2.DataBind();
    }
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {
        BindData();
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataBind();
    }*/
}
