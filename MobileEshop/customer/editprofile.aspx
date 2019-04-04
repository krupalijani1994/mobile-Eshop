<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="editprofile.aspx.cs" Inherits="customer_editprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:310px;float:left; margin:34px 0px 0px 21px;">
        
<p>
    <asp:Label ID="lblfname" runat="server" Text="First Name:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtfname" runat="server" CssClass="txt_field"  ></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvfname" runat="server" ErrorMessage="Please Enter First Name" ControlToValidate="txtfname" Text="*"></asp:RequiredFieldValidator>
</p>

<p>
    <asp:Label ID="lbllname" runat="server" Text="Last Name:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtlname" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvlname" runat="server" ControlToValidate="txtlname" ErrorMessage="Please Enter Last Name">*</asp:RequiredFieldValidator>
</p>
    
<p>
    <asp:Label ID="lbladd" runat="server" Text="Address:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtadd" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvadd" runat="server" ControlToValidate="txtadd" ErrorMessage="Please Enter Address">*</asp:RequiredFieldValidator>
</p>
  
<p>
    <asp:Label ID="lblpostcode" runat="server" Text="PostCode:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtpostcode" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvpin" runat="server" ControlToValidate="txtpostcode" ErrorMessage="Please Enter pincode">*</asp:RequiredFieldValidator>
</p>  
  

<p>
<asp:Label ID="lblcity" runat="server" Text="city:" Width="90px" ></asp:Label>
    <asp:DropDownList ID="drpcity" runat="server" Width="140px" CssClass="cmd">
        <asp:listitem>Leicester</asp:listitem>
         </asp:DropDownList>
</p>



<p>
    <asp:Label ID="lblemail" runat="server" Text="Email:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtemail" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter your Email Id">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtemail" ErrorMessage="Invalid Email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator> 
    
    </p>            
    

    
<p>
    <asp:Label ID="lblcontno" runat="server" Text="Contact No:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtphoneno" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtphoneno" ErrorMessage="Please Enter your contact number">*</asp:RequiredFieldValidator>
</p>     
  
    
<p>
    <asp:Label ID="lbldob" runat="server" Text="DOB:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtdob" runat="server" CssClass="txt_field"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvdob" runat="server" ControlToValidate="txtdob" ErrorMessage="Please Enter date of birth">*</asp:RequiredFieldValidator>
</p>     
  <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="editupdate" OnClick="btnupdate_Click" />
  <asp:Button ID="btncancle" runat="server" Text="Cancle" CssClass="editcancle" OnClick="btncancle_Click"  />
 </div>
    
</asp:Content>

