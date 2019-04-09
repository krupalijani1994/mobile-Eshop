<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    
  
    <script src="js/JavaScript.js"></script>
    <link href="css/StyleSheet.css" rel="stylesheet" />

<div class="row">
  <div class="column side">
    <h2 style=" text-align: center; margin-right: 60px;">Promotion</h2>
    <p> <asp:Image ID="image1" runat="server" style="height:500px" ImageUrl="images\iphone-xSPACEGREY.png" /> </p>
     <p class="promotion">Iphone X</p>
  </div>
  
  
    
    
    <div  class="column middle">

	


<h2>Mobiles</h2>

<div style="max-width:200px" >
    
  <img class="mySlides" src="images/iphone-xSPACEGREY.png" style="width:100%">
  <img class="mySlides" src="images/motorolaE.png" style="width:100%">
  <img class="mySlides" src="images/iphone8.png" style="width:100%">
</div>
<div class="login" style="width:310px;float:left;">
        
<p>
    <asp:Label ID="lblusername" runat="server" Text="User Name:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtusername" runat="server" CssClass="txt_field"  ></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvfname" runat="server" ErrorMessage="Please Enter username" ControlToValidate="txtusername" Text="*"></asp:RequiredFieldValidator>
</p>

<p>
    <asp:Label ID="lblpassword" runat="server" Text="Password:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtpassword" runat="server" CssClass="txt_field" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvlname" runat="server" ControlToValidate="txtpassword" ErrorMessage="Please Enter password">*</asp:RequiredFieldValidator>
</p>
    <p style= "text-align:center">
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </p>

</div>
    
</div>
  
  <div class="column side">
    <h2 style="margin-left:105px;">Trending </h2>
      <div>
    <p> <asp:Image ID="image2" runat="server" style="height:200px" ImageUrl="images\iphone5s.png" /> 
        
            <asp:Image ID="image3" runat="server" style="height:200px" ImageUrl="images\iphone6s.png" /> 
        </p>
          <asp:Label ID="Label1" runat="server" style="margin-left:50px; color:blue;"  Text="iphone 5s"></asp:Label>
          <asp:Label ID="Label2" runat="server" style="margin-left:90px; color:blue;" Text="iphone 6s"></asp:Label>
          </div>
    <div>
        <p>
        <asp:Image ID="image4" runat="server" style="height:200px; margin-left:46px;" ImageUrl="image\g9.jpg" /> 
        

        </P>
         <asp:Label ID="Label3" runat="server" style="margin-left:140px; color:blue;"  Text="Galaxy 9"></asp:Label>
        


      </div>
      <p>  <asp:Image ID="image5" runat="server" style="height:200px" ImageUrl="images\iphone8.png" />
        <asp:Image ID="image7" runat="server" style="height:200px" ImageUrl="images\motorolaE.png" /> </p>
      <p>
        <asp:Label ID="Label4" runat="server" style="margin-left:60px; color:blue;" Text="iphone 8"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="margin-left:70px; color:blue;" Text="Motorola E"></asp:Label>
          </p>

  </div>
</div>
       <script src="js/JavaScript.js"></script>
        </asp:Content>


