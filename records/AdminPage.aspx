<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="records.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Records</h1>
                <hr />
                <asp:Label ID="Label1" runat="server"></asp:Label>

             <hr />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <asp:Button ID="Button3" runat="server" Text="Refresh" OnClick="Button3_Click1" />
                

             <hr />
               <center>  <asp:Label ID="Label4" runat="server" Text="id:"></asp:Label>
              <br /> 
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label5" runat="server" Text="Name:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label6" runat="server" Text="Last name:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label7" runat="server" Text="Solary:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label8" runat="server" Text="City:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label9" runat="server" Text="Social security number:"></asp:Label>
                 <br /> 
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                 <br />

                <asp:Label ID="Label10" runat="server" Text="Role:"></asp:Label>
              <br /> 
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label11" runat="server" Text="Password:"></asp:Label>
                 <br /> 
                <asp:TextBox ID="TextBox8" input type="password" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label12" runat="server" Text="Email address:"></asp:Label>
               <br /> 
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label13" runat="server" Text="Phone number:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                  
                <asp:Label ID="Label14" runat="server" Text="Education:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label15" runat="server" Text="Address:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label16" runat="server" Text="Work experience:"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label17" runat="server" Text="Financial depatment"></asp:Label>
               <br /> 
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <br />

                <asp:Label ID="Label18" runat="server" Text="Sales depatment"></asp:Label>
            <br /> 
                <asp:CheckBox ID="CheckBox2" runat="server" />
                <br />

                <asp:Label ID="Label19" runat="server" Text="Administrative depatment"></asp:Label>
           <br /> 
                <asp:CheckBox ID="CheckBox3" runat="server" />
                <br />
                  
                <asp:Label ID="Label20" runat="server" Text="Marketing depatment"></asp:Label>
            <br /> 
                <asp:CheckBox ID="CheckBox4" runat="server" />
                <br />

                <asp:Label ID="Label21" runat="server" Text="Technological depatment"></asp:Label>
              <br /> 
                <asp:CheckBox ID="CheckBox5" runat="server" />
                <br />

                <asp:Label ID="Label22" runat="server" Text="Communication depatment"></asp:Label>
              <br /> 
                <asp:CheckBox ID="CheckBox6" runat="server" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="" Visible="True"></asp:Label>
           
                <br />
                <br />
                <hr />
                    <asp:Button ID="Button2" runat="server" Text="Insert" OnClick="Button2_Click1" />
                <br />
                <br />
                    <asp:Button ID="Button1" runat="server" Text="Log out" PostBackUrl="~/Login.aspx" />
              </center>
            </center>
        </div>
    </form>
</body>
</html>
