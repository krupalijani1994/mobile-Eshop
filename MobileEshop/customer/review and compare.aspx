<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="review and compare.aspx.cs" Inherits="customer_review_and_compare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="css/StyleSheet2.css" rel="stylesheet" />
    <div style="text-align:center">
      <h1>  Please select 1 item from each dropdown menu to compare 2 items with one another!
          <br>
          Thank you.</h1>
    </div>
  <div class="column side">
          
        <asp:dropdownlist ID="drpcomp1" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="drpcomp1_SelectedIndexChanged" style="background-color: #FFFFFF; font-weight: 700; text-align: center; font-family: 'Times New Roman', Times, serif; font-size: large;" Width="202px" Height="50px"></asp:dropdownlist>

    <asp:gridview Id="comp1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" >
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
      
    </asp:gridview>
  </div>

  <div class="column middle">

    
        <asp:dropdownlist ID="drpcomp2" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="drpcomp2_SelectedIndexChanged" style="background-color: #FFFFFF; margin-top: 0px; font-weight: 700; font-size: large; font-family: 'Times New Roman', Times, serif;" Height="50px" Width="203px"></asp:dropdownlist>

    <asp:gridview Id="comp2" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal"   >
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
      
    </asp:gridview>
  </div>
   </div>
  



    </asp:Content>

