﻿<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="row">
  <div class="column side">
    <h2 style=" text-align: center; margin-right: 60px;"> Promotion </h2>
    <p> <asp:Image ID="image1" runat="server" style="height:500px" ImageUrl="images\iphone-xSPACEGREY.png" /> 
    </p>
     <p class="promotion">Iphone X</p>
  </div>
  
  <div style=" top:60px;
        position:relative;
        left:15%;" class="column middle">
      <div style="width:358px;float:left; height:900px; margin:33px 0px 0px 1px;">

<p style=" font-size: 30px;
    font-style: oblique;
    color: darkblue;
    text-align: center;"> Register here...</p>
<p>
    <asp:Label ID="lblfname" runat="server" Text="First name:" Width="162px"></asp:Label>
     <asp:TextBox ID="txtfname" runat="server" CssClass="txt_field"> </asp:TextBox>
     <asp:RegularExpressionValidator ID="rev1" runat="server" ErrorMessage="Characters Only" ControlToValidate="txtfname" ValidationExpression="^[a-zA-Z'.\s]{1,40}$" ForeColor="Red"></asp:RegularExpressionValidator>
    </p>
    
<p>
    <asp:Label ID="lbllname" runat="server" Text="Last name:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtlname" runat="server" CssClass="txt_field"></asp:TextBox>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Characters Only" ControlToValidate="txtlname" ValidationExpression="^[a-zA-Z'.\s]{1,40}$" ForeColor="Red"></asp:RegularExpressionValidator>
    </p>
     
<p>
    <asp:Label ID="lbladd" runat="server" Text="Address:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtadd" runat="server" CssClass="txt_field" TextMode="MultiLine"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="enter address" ControlToValidate="txtadd"></asp:RequiredFieldValidator>
    </p>
    
<p>
    <asp:Label ID="lblpostcode" runat="server" Text="PostCode:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtpostcode" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtpostcode"></asp:RequiredFieldValidator>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Enter Correct Postcode" ControlToValidate="txtpostcode" ValidationExpression="^(\d{6}-\d{4}|\d{6}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$" ForeColor="Red"></asp:RegularExpressionValidator>
    </p>
    
       

<p>
<asp:Label ID="lblcity" runat="server" Text="city:" Width="162px" ></asp:Label>
    <asp:DropDownList ID="drpcity" runat="server" Width="140px" CssClass="cmd" >
    <asp:ListItem>Leicester</asp:ListItem>
        </asp:DropDownList>

</p>
         


<p>
    <asp:Label ID="lblusername" runat="server" Text="Username:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtusername" runat="server" CssClass="txt_field"></asp:TextBox>
    </p>
    
<p>
    <asp:Label ID="lblpass" runat="server" Text="Password:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtpassword" runat="server" CssClass="txt_field" TextMode="Password"></asp:TextBox>

    </p>
    
<p>
    <asp:Label ID="lbconpass" runat="server" Text="Re-Enter Password:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtconpass" runat="server" CssClass="txt_field" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage=" password does not match"  ControlToValidate="txtconpass" ControlToCompare="txtpassword" ForeColor="Red"></asp:CompareValidator> 
    </p>
  
    

<p>
     <asp:Label ID="lblgender" runat="server" Text="Gender:" Width="162px"></asp:Label>
     <asp:RadioButtonList ID="rabgender" runat="server" CssClass="gender" RepeatDirection="Horizontal" RepeatLayout="Flow">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
</p>

<p>
    <asp:Label ID="lblemail" runat="server" Text="Email:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtemail" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RegularExpressionValidator ID="rev2" runat="server" ErrorMessage="Please Enter Valid Email ID"
                    ValidationGroup="" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    </asp:RegularExpressionValidator></p>
    
    

    
<p>
    <asp:Label ID="lblcontno" runat="server" Text="Contact no:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtcontno" runat="server" CssClass="txt_field"></asp:TextBox></p>
          <asp:RegularExpressionValidator ID="validationphoneno" ForeColor="Red" runat="server" ErrorMessage="Enter valid Phone number" ControlToValidate="txtcontno" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ></asp:RegularExpressionValidator>
   
    
<p>
    <asp:Label ID="lbldob" runat="server" Text="Date of birth:" Width="162px"></asp:Label>
    <asp:TextBox ID="txtdob" runat="server" CssClass="txt_field"></asp:TextBox></p>
     
     <asp:Button ID="btnregister" runat="server" Text="Register" style="height: 44px" OnClick="btnregister_Click" />
    <asp:Button ID="btnreset" runat="server" Text="Reset" 
        style="height: 44px"/>

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
        <asp:Image ID="image4" runat="server" style="height:200px; margin-left:46px;" ImageUrl="images\g9.jpg" /> 
        

        </P>
         <asp:Label ID="Label3" runat="server" style="margin-left:140px; color:blue;"  Text="Galaxy 9"></asp:Label>
        


      </div>
      <p>  <asp:Image ID="image5" runat="server" style="height:200px" ImageUrl="images\iphone8.png" />
        <asp:Image ID="image7" runat="server" style="height:200px" ImageUrl="images\motorolaE.png" />
      </p>
      <p>
        <asp:Label ID="Label4" runat="server" style="margin-left:60px; color:blue;" Text="iphone 8"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="margin-left:70px; color:blue;" Text="Motorola E"></asp:Label>
          </p>
      
  </div>
</div>
</asp:Content>
