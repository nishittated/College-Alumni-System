using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AlumniHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSiteVisited.Text = "No of times website visited=" + Application["SiteVisitedCounter"].ToString();
        lblOnlineUsers.Text = "No of users logon on the site=" + Application["OnlineUserCounter"].ToString();
    }
    protected void btnClearSesson_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }
}