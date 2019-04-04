<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="products.aspx.cs" Inherits="customer_products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <div class="wrap">
                 <div class="search">
                     <asp:TextBox ID="txtSearch" runat="server" class="searchTerm" placeholder="What are you looking for?" ></asp:TextBox>
                        <asp:Button Text="Search" runat="server" class="searchButton" OnClick="Search" />
         <%--   <input type="text" class="searchTerm" placeholder="What are you looking for?">
                  <button type="submit" class="searchButton" >
                    </button>--%>
                  <i class="fa fa-search"></i>
        
   </div>
</div>
    <div style="width:1200px; height:auto">
      
   <asp:Repeater ID="rproducts" runat="server"  >
   <ItemTemplate>
  
  
						<div class="product-frame">
							<div class="product">
								<a title="View product" class="view-button" href='ProductDetails.aspx?productID=<%#Eval("ProductID")%>'>view product</a>
								<div class="img-holder" style="width:253px; height:144px">
								
									<asp:Image ID="Image2" runat="server" ImageUrl='<%#"~/admin/"+Eval("path")%>' />
									
                                </div>								
								<div class="img-bottom"></div>
								<div class="price-box">
									<p>price
									<asp:Label ID="Label1" runat="server" Text='<%#Eval("ProductPrice")%>' CssClass="price" ></asp:Label>
                                   </p>
								</div>
								<div class="product-entry">
									<p class="model"><asp:Label ID="Label2" runat="server" Text='<%#Eval("ProductName")%>' ></asp:Label>
                                     </p>
									</div>
							</div>
						</div>
					
   


</ItemTemplate>
    </asp:Repeater>

    </div>



 





</asp:Content>

