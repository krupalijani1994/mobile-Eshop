<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="adminregistration.aspx.cs" Inherits="admin_adminregistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <p style=" font-size: 30px;
    font-style: oblique;
    color: darkblue;
    text-align: center;"> Admin Registration</p>
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
</asp:Content>

