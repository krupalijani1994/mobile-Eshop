<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="ProductPurchase.aspx.cs" Inherits="customer_ProductPurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	<div style="margin-top:42px">
   <div style="width:260px"><h3>User Details..</h3></div>
<div style="width:260px;float:left; margin:-6px 0px 0px 1px;">

<p>
    <asp:Label ID="lblname" runat="server" Text="User Name:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtname" runat="server" CssClass="txt_field"  ></asp:TextBox>
    </p>

    
<p>
    <asp:Label ID="lbladd" runat="server" Text="Address:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtadd" runat="server" CssClass="txt_field"></asp:TextBox>
   </p>



<p>
    <asp:Label ID="lblemail" runat="server" Text="Email:" Width="100px">Email:</asp:Label>
    <asp:TextBox ID="txtemail" runat="server" CssClass="txt_field"></asp:TextBox>
    </p>            
    

    
<p>
    <asp:Label ID="lblcontno" runat="server" Text="Contact no:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtphoneno" runat="server" CssClass="txt_field"></asp:TextBox>
   </p>
    

</div>
<div style="width:260px;margin:-39px 42px 0px 0px;float:right"><h3>Products Details..</h3></div>

<div style="width:300px;margin:-11px 0px 0px 0px;float:right;">
<p>
    <asp:Label ID="lblpid" runat="server" Text="Product Id:" Width="120px"></asp:Label>
    <asp:TextBox ID="txtpid" runat="server" CssClass="txt_field"></asp:TextBox>
    
    </p>

  <p>
    <asp:Label ID="lblpname" runat="server" Text="Product Name:" Width="120px"></asp:Label>
    <asp:TextBox ID="txtpname" runat="server" CssClass="txt_field"></asp:TextBox>
    
    </p>

<p>
    <asp:Label ID="lblqty" runat="server" Text="Quantity:" Width="120px"></asp:Label>
    <asp:TextBox ID="txtqty" runat="server" CssClass="txt_field" AutoPostBack="true" 
        ontextchanged="txtqty_TextChanged"></asp:TextBox>
    
   </p>
<p>
    <asp:Label ID="lblrate" runat="server" Text="Rate:" Width="120px"></asp:Label>
    <asp:TextBox ID="txtrate" runat="server" CssClass="txt_field" AutoPostBack="true"></asp:TextBox>
    
   </p>


<p>
    <asp:Label ID="lblprice" runat="server" Text="Total Price:" Width="120px" ></asp:Label>
    <asp:TextBox ID="txtprice" runat="server" CssClass="txt_field" AutoPostBack="true"></asp:TextBox>
    
   </p>
  
   </div>
    <asp:Button ID="btnpay" runat="server" Text="Payment"  CssClass="btnpay" 
        onclick="btnpay_Click" />
        <asp:Button ID="btnback" runat="server" Text="Back"  CssClass="btnpay1" 
        onclick="btnback_Click"  />

</div>

</asp:Content>

