<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LogIn.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
     <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css'>
    <link href="../Content/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="login-form">
     <h1>LOG IN</h1>
     <div class="form-group ">
       <asp:TextBox runat="server" class="form-control" placeholder="Username " ID="logInUserNameTextbox"></asp:TextBox>  
       <i class="fa fa-user"></i> 
     </div>
     <div class="form-group log-status">
       <asp:TextBox runat="server" type="password" class="form-control" placeholder="Password" ID="logInUserPasswordTextbox"></asp:TextBox>  
       <i class="fa fa-lock"></i>
     </div>
      <span class="alert">Invalid Credentials</span>
      <a class="link" href="#">Lost your password?</a>
     <asp:Button runat="server" CssClass="log-btn" Text="Log In" OnClick="OnClick"/>
     
    
   </div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
   <script  src="Scripts/login.js"></script>
    </form>
</body>
</html>
