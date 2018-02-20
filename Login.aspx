<%--Copyright (c) Nishit Tated. All Rights Reserved.
   project name: College Alumni System
  This project is licensed under the MIT license, see LICENSE.--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login
        <br />
        <br />
        UserName:&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <br />
        Password:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button2_Click" />
        <asp:Button ID="Button2" runat="server" Text="Create Your Account" OnClick="Button2_Click1"/> 
        
        <br /> <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        <br /> <br />
        <asp:Button ID="Button6" runat="server" Text="Insert" OnClick="Button6_Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br /> <br />

            <asp:Button ID="Button7" runat="server" Text="Update" OnClick="Button6_Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br /> <br />

     <asp:Button ID="Button8" runat="server" Text="Delete" OnClick="Button6_Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
