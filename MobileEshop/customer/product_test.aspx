<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="product_test.aspx.cs" Inherits="customer_product_test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox>
<asp:Button Text="Search" runat="server" OnClick="Search"/>
     

   <asp:Repeater ID="rproducts" runat="server"  >
   <ItemTemplate>
  
  <div>
						<div class="product-frame">
							<div >
								<a title="View product" class="view-button" href='ProductDetails.aspx?productID=<%#Eval("ProductID")%>'>view product</a>
								<div class="img-holder" >
								
									<asp:Image ID="Image2" runat="server" ImageUrl='<%#"~/admin/"+Eval("path")%>' />
									
                                </div>								
								<div class="img-bottom"></div>
								<div class="price-box">
									<p>price
									<asp:Label ID="Label1" runat="server" Text='<%#Eval("ProductPrice")%>' ></asp:Label>
                                   </p>
								</div>
								<div class="product-entry">
									<asp:Label ID="Label2" runat="server" Text='<%#Eval("ProductName")%>' ></asp:Label>
                                     </p>
									</div>
							</div>
						</div>
					
   
      </div>

</ItemTemplate>
    </asp:Repeater>

</asp:Content>

