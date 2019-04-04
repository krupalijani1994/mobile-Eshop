<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="admin_AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style=" background-color:black">
    <style>
        body {
            background: url('../images/bg_center.jpg') no-repeat center center;
            min-height: 600px;
            padding: 200px 0 0;
          
        }
    </style>
    <form id="form1" runat="server">
        <div >
  
    
        
     <div >
    <div>
    	<center><h1 style="color:white">Admin Panel </h1></center></div>
      <center>  <p> <asp:Label ID="Label1" runat="server" Text="Username : " style="color:White"></asp:Label> 
        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox></p>
         
       <p><asp:Label ID="Label2" runat="server" Text="Password : " style="color:White"></asp:Label>
         <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></p>
         <p>
           <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/></p></center>
            
         
   
    
        
  	</div>
    

    <script src="http://code.jquery.com/jquery-1.7.1.min.js" type="text/javascript"></script>
		<script src="js/script.js" type="text/javascript"></script>


        </div>
    </form>
</body>
</html>
