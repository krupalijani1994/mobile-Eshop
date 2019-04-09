<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	   <p>
            <asp:Image ID="Image1" runat="server" Width="265px"  Height="130px"/>
      </p>
      <p>
        <asp:Label ID="lblproduct" runat="server" Text="Product Name:" Width="150px"></asp:Label>
        <asp:Label ID="lblpro" runat="server" Text="" Width="150px" CssClass="lbl1"></asp:Label>

      </p>
      
      <p>
        <asp:Label ID="lbldetails" runat="server" Text="Details:" Width="150px"></asp:Label>
        <asp:Label ID="lbldateail" runat="server" Text="" Width="280px" Font-Size="13px" CssClass="lbl1"></asp:Label>

      </p>


      <p>
        <asp:Label ID="lblprice" runat="server" Text="Price:" Width="150px"></asp:Label>
        <asp:Label ID="lblprc" runat="server" Text="" Width="150px"></asp:Label>

      </p>
     <p>
        <asp:Label ID="lblquantity" runat="server" Text="Quantity:" Width="150px"></asp:Label>
         <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem>1</asp:ListItem>
             <asp:ListItem>2</asp:ListItem>
             <asp:ListItem>3</asp:ListItem>
             <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
         </asp:DropDownList>

         <asp:Button ID="checkout" runat="server" Text="Add to cart" />
      </p>
      <%--<p><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btnbuynow">Buy Now</asp:HyperLink></p>--%>
    
      

</asp:Content>

