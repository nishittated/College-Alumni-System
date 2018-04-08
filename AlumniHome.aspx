<%--Copyright (c) Nishit Tated. All Rights Reserved.
   project name: College Alumni System
  This project is licensed under the MIT license, see LICENSE.--%>
 
<%@ Page Title="" Language="C#" MasterPageFile="~/Alu.master" AutoEventWireup="true" CodeFile="AlumniHome.aspx.cs" Inherits="AlumniHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div> 
            <fieldset style ="width:220px;">
                <legend>Count website visited and Online users</legend>   
        <asp:Label ID="lblSiteVisited" runat="server" Text=""  style="color: #FFFFFF; background-color: #3366FF"></asp:Label><br />
        <asp:Label ID="lblOnlineUsers" runat="server" Text=""  style="color: #FFFFFF; background-color: #009933"></asp:Label><br />
       
        <asp:Button ID="btnClearSesson" runat="server" Text="Clear Session"  onclick="btnClearSesson_Click" />
             </fieldset>
        </div>
</asp:Content>

     
