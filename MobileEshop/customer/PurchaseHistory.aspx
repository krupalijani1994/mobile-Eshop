<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="PurchaseHistory.aspx.cs" Inherits="customer_PurchaseHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div style="margin:48px 0px 0px 21px">

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <Columns>
            
            <asp:BoundField DataField="ProductName" HeaderText="Product name" 
                SortExpression="ProductName" />
            <asp:BoundField DataField="ProductQuantity" HeaderText="Quantity" SortExpression="ProductQuantity" />
            <asp:BoundField DataField="rate" HeaderText="Rate" SortExpression="rate" />
            <asp:BoundField DataField="amount" HeaderText="Total Price " 
                SortExpression="amount" />
            
        
              
            </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>


</div>
</asp:Content>

