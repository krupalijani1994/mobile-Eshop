<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	<div>

        <p>
            <asp:Image ID="Image1" runat="server" CssClass="image"/>
      </p>
</div>
<div style="float:left; ">
      <p>
        <asp:Label ID="lblproduct" runat="server" Text="Product Name:" Width="150px"></asp:Label>
        <asp:Label ID="lblpro" runat="server" Text="" Width="150px" CssClass="lbl"></asp:Label>
      </p>
      
      <p>
        <asp:Label ID="lbldetails" runat="server" Text="Details:" Width="150px" ></asp:Label>
        <asp:Label ID="lbldateail" runat="server" Text="" Width="220px" Font-Size="13px" CssClass="lbl"></asp:Label>

      </p>


      <p>
        <asp:Label ID="lblprice" runat="server" Text="Price:" Width="150px"></asp:Label>
        <asp:Label ID="lblprc" runat="server" Text="" Width="150px"></asp:Label>

      </p>

       
    <asp:Button ID="btnbuynow" runat="server" Text="Buy Now" CssClass="btnbuynow" 
            onclick="btnbuynow_Click" />
            
            <asp:Button ID="btnback" runat="server" Text="Back" CssClass="buttonback" OnClick="btnback_Click" 
           />
    
            </div>

</asp:Content>

