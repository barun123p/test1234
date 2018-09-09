<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

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
                        <td><asp:Label ID="Label8" runat="server" Text="UserName"></asp:Label></td>
                        <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                        <td><asp:Label ID="Label9" runat="server" Text="Password"></asp:Label></td>
                        <td><asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
                 </tr>
                                       
            </table>
          
        </div>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Button ID="btnSinup" runat="server" Text="Sign Up" OnClick="btnSinup_Click" style="height: 29px"  />
    </form>
    <asp:Label ID="lblError" BackColor="Red"  runat="server" Text=""></asp:Label>

</body>
</html>
