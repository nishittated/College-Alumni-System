/* Copyright (c) Nishit Tated. All Rights Reserved.
   project name: College Alumni System
  This project is licensed under the MIT license, see LICENSE. */

using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Event
/// </summary>
 
public class Event2
{
    SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    public Event2()
    {
        //
        // TODO: Add constructor logic here
    }
    public int Insert(string name, string passwd)
    {
        sqlcon.Open();
        string sql = "insert into Log values ('" +name+"', '" +passwd+"')";

        SqlCommand cmd = new SqlCommand(sql, sqlcon); 
        int ans =  cmd.ExecuteNonQuery();
        return ans;
        sqlcon.Close();
    }

    public int Update(string name, string passwd)
    {
        sqlcon.Open();
        string sql = "Update Log set Password ='"+passwd+"' where Username = '" +name +"' ";
        SqlCommand cmd = new SqlCommand(sql, sqlcon);
        int ans = cmd.ExecuteNonQuery();
        return ans;

        sqlcon.Close();
    }

    public int Delete(string n) 
    {
        sqlcon.Open();

        string sql=  "DELETE from Log where UserName ='"+n+"' ";
        SqlCommand cmd = new SqlCommand(sql, sqlcon);
        int ans = cmd.ExecuteNonQuery();
        return ans;

        sqlcon.Close();
    }
    public DataTable FetchAllEvents()
    {
        string sql = "Select * from Log Order By UserName";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlcon);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}   
