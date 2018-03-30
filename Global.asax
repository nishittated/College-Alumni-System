<%--Copyright (c) Nishit Tated. All Rights Reserved.
   project name: College Alumni System
  This project is licensed under the MIT license, see LICENSE.--%> 
<%@ Application Language="C#" %>

<script runat="server">
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        Application["SiteVisitedCounter"] = 0;
        //to check how many users have currently opened our site
        Application["OnlineUserCounter"] = 0;
    }
    
    void Application_End(object sender, EventArgs e) 
    {   //  Code that runs on application shutdown 
    }
        
    void Application_Error(object sender, EventArgs e) 
    {  // Code that runs when an unhandled error occur
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
        Application.Lock();
        Application["SiteVisitedCounter"] = Convert.ToInt32(Application["SiteVisitedCounter"]) + 1;
        //to check how many users have currently opened our site write the following line
        Application["OnlineUserCounter"] = Convert.ToInt32(Application["OnlineUserCounter"]) + 1;
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["OnlineUserCounter"] = Convert.ToInt32(Application["OnlineUserCounter"]) - 1;
        Application.UnLock();
    }
</script>
