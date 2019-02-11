<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="customer_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="row">
  <div class="column side">
    <h2 style=" text-align: center; margin-right: 60px;">Promotion</h2>
    <p> <asp:Image ID="image1" runat="server" style="height:500px" ImageUrl="image\iphone-xSPACEGREY.png" /> </p>
     <p class="promotion">Iphone X</p>
  </div>
  
  <div style=" top:300px;
        position:relative;
        left:15%;" class="column middle">
    <h2>Register Page </h2>
      <P>
      <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     </P>
      <p>
      <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
          </p>
</div>
  
  <div class="column side">
    <h2 style="margin-left:105px;">Trending </h2>
      <div>
    <p> <asp:Image ID="image2" runat="server" style="height:200px" ImageUrl="image\iphone5s.png" /> 
        
            <asp:Image ID="image3" runat="server" style="height:200px" ImageUrl="image\iphone6s.png" /> 
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
      <p>  <asp:Image ID="image5" runat="server" style="height:200px" ImageUrl="image\iphone8.png" />
        <asp:Image ID="image7" runat="server" style="height:200px" ImageUrl="image\motorolaE.png" /> </p>
      <p>
        <asp:Label ID="Label4" runat="server" style="margin-left:60px; color:blue;" Text="iphone 8"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="margin-left:70px; color:blue;" Text="Motorola E"></asp:Label>
          </p>
      
  </div>
</div>
</asp:Content>

