<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="generate reports.aspx.cs" Inherits="admin_generate_reports" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

		<div>
		<p>
            <asp:Label ID="lbldate" runat="server" Text="By Date:"></asp:Label>
            <asp:TextBox ID="txtdate" runat="server" CssClass="txt_field"></asp:TextBox>

                        <asp:calendar ID="CalendarExtender1" runat="server" TargetControlID="txtdate"></asp:calendar>
    
            <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="buttonsearch" 
                onclick="btnsearch_Click" />
            </p>
		</div>
		<div>
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black" >
        <RowStyle BackColor="White" />
        <Columns>
            
<%--            <asp:BoundField DataField="purchasedate" HeaderText="Purchase Date" DataFormatString="{0:d}" HtmlEncode="false" />
             --%>
            <asp:BoundField DataField="uid" HeaderText="UserID" />
            <asp:BoundField DataField="email" HeaderText="Email Address" />
            <asp:BoundField DataField="purchasedate" HeaderText="Purchase Date" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="ProductQuantity" HeaderText="Product Quantity" />
       
            
        
             </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>

		

		
		</div>

</asp:Content>

