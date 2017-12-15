<%@ Page Title="" Language="C#" MasterPageFile="~/Event.master" AutoEventWireup="true" CodeFile="Event1.aspx.cs" Inherits="Event1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="css/coin-slider.css" />              
    
      <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>&nbsp;Event Details<br />
        <br />
        Title: </em>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Give Title of your Event"></asp:RequiredFieldValidator>
        <br />
        <br />
        Description:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>  &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <br />
        <br />
        Location:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Input your location here"></asp:RequiredFieldValidator>
        <br />
        <br />
        Event Date: <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="This field can't be blank"></asp:RequiredFieldValidator>
        <br />
        <br />
        Time:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" TextMode="DateTime"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        </strong>
    
        <br />        
        <asp:Button ID="Button2" runat="server" Text="Add Event " OnClick="Button0_Click" /> &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Update Event " OnClick="Button1_Click" /> &nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete Event " OnClick="Button3_Click" /> &nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="See Event " OnClick="Button4_Click" />    
          <br />
          <br />
          <asp:GridView ID="GridView1" runat="server">
          </asp:GridView>
    </div>

    <div>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Status:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Open</asp:ListItem>
            <asp:ListItem>Close</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Required" InitialValue="None"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Click Me" OnClick="Button1_Click9" Style="height: 26px" />
        <br />
        <br />
        
       <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" AutoGenerateColumns="False" DataKeyNames="Event_Id" DataSourceID="SqlDataSource1" GridLines="Horizontal" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Event_Id" HeaderText="Event_Id" InsertVisible="False" ReadOnly="True" SortExpression="Event_Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                <asp:BoundField DataField="EventDate" HeaderText="EventDate" SortExpression="EventDate" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                <asp:HyperLinkField DataTextField="Title" NavigateUrl="OldRegister1.aspx" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>

                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Event] WHERE [Event_Id] = @original_Event_Id" InsertCommand="INSERT INTO [Event] ([Title], [Description], [Location], [EventDate], [Time]) VALUES (@Title, @Description, @Location, @EventDate, @Time)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Event]" UpdateCommand="UPDATE [Event] SET [Title] = @Title, [Description] = @Description, [Location] = @Location, [EventDate] = @EventDate, [Time] = @Time WHERE [Event_Id] = @original_Event_Id">
        <DeleteParameters>
            <asp:Parameter Name="original_Event_Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
             <asp:Parameter Name="Title" Type="String" />
             <asp:Parameter Name="Description" Type="String" />
             <asp:Parameter Name="Location" Type="String" />
             <asp:Parameter Name="EventDate" DbType="Date" />
             <asp:Parameter Name="Time" DbType="DateTime2" />
        </InsertParameters>
        
        <UpdateParameters>
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Location" Type="String" />
            <asp:Parameter Name="EventDate" DbType="Date" />
            <asp:Parameter Name="Time" DbType="DateTime2" />
            
            <asp:Parameter Name="original_Event_Id" Type="Int32" />
        </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    </div>
</asp:Content>

