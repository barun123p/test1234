<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                        <td><asp:Label ID="Label6" runat="server" Text="UserId"></asp:Label></td>
                        <td><asp:TextBox ID="txtUserId" runat="server"></asp:TextBox></td>
                 </tr>
                <tr>
                        <td><asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label></td>
                        <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                        <td><asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label></td>
                        <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                 </tr>
                <tr>
                        <td><asp:Label ID="Label3" runat="server" Text="Street"></asp:Label></td>
                        <td><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
                 </tr>
                <tr>
                        <td><asp:Label ID="Label4" runat="server" Text="City"></asp:Label></td>
                        <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                 </tr>
                  <tr>
                        <td><asp:Label ID="Label5" runat="server" Text="State"></asp:Label></td>
                        <td><asp:TextBox ID="TxtState" runat="server"></asp:TextBox></td>
                 </tr>>
                
                 <tr>
                        <td><asp:Label ID="Label7" runat="server" Text="ZipCode"></asp:Label></td>
                        <td><asp:TextBox ID="TxtZipCode" runat="server"></asp:TextBox></td>
                 </tr>
                  <tr>
                        <td><asp:Label ID="Label8" runat="server" Text="UserId"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                 </tr>
               
                 
                <tr>
                        <td><asp:Label ID="Label9" runat="server" Text="UserName"></asp:Label></td>
                        <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                        <td><asp:Label ID="Label10" runat="server" Text="Password"></asp:Label></td>
                        <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                        <td><asp:Label ID="Label12" runat="server" Text="RePassword"></asp:Label></td>
                        <td><asp:TextBox ID="RetypePassword" runat="server"></asp:TextBox></td>
                 </tr>

                 <tr>
                        <td><asp:Label ID="Label11" runat="server" Text="ClientID"></asp:Label></td>
                        <td><asp:TextBox ID="txtClientId" runat="server" Height="16px" Width="160px"></asp:TextBox></td>
                 </tr>
               
                        
            </table>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
