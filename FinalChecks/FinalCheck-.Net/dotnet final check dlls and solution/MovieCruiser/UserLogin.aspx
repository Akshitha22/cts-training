<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="MovieCruiser.UserLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:aquamarine;
        }
    </style>
</head>  
<body>
    <form id="form" runat="server">
        <div>
            <h1><center>ADMIN LOGIN</center></h1>
            <p style="margin-left: 520px">
                &nbsp;</p>
            <p style="margin-left: 520px">
            <center>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Enter Name <asp:TextBox ID="Txtname" runat="server" BorderColor="#000099"></asp:TextBox></center>
                 <br />
            
    <br />
           <center>Enter Password <asp:TextBox ID="Txtpassword" runat="server" BorderColor="#000099"></asp:TextBox></center>
          <br />
        <br /> 
                
            <center><asp:Button ID="Login" runat="server" Text="Login" OnClick="Btnlogin_Click" BackColor="#000099" BorderColor="Black" ForeColor="White" Height="30px" Width="160px"/></center>
            </p>
        </div>
    </form></>
</html>