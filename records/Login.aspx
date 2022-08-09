<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="records.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1>Login</h1>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            &#160 &#160 <asp:TextBox ID="TextBox1" runat="server" Width="115px"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
           &#160 &#160 <asp:TextBox ID="TextBox2" input type="password" runat="server" Width="118px"></asp:TextBox>
            <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Width="202px" OnClick="Button1_Click" />
           <tr> <td> <br />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Incorect User Credentials" ForeColor="Red" Visible="False"></asp:Label>
                </td> </tr>
                
        </div>
    </form>
</body>
</html>
