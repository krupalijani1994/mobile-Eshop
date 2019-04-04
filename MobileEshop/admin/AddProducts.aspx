<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddProducts.aspx.cs" Inherits="admin_AddProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
     <div style="float:left; margin:10px 10px 0px 0px;">
   <h2>Add Product</h2>
<p>
    <asp:Label ID="lblname" runat="server" Text="Name:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtname" runat="server" CssClass="txt_field"></asp:TextBox>
</p>

<p>
    <asp:Label ID="lbldetail" runat="server" Text="Details:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtdetails" runat="server"  CssClass="txtdetails" TextMode="MultiLine"></asp:TextBox>
</p>


<p>
    <asp:Label ID="lblprice" runat="server" Text="Price:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtprice" runat="server" CssClass="txt_field"></asp:TextBox>
</p>
 <p>
    <asp:Label ID="lblquantity" runat="server" Text="Quantity:" Width="90px"></asp:Label>
    <asp:TextBox ID="txtquantity" runat="server" CssClass="txt_field"></asp:TextBox>
</p>
          <p>
    <asp:Label ID="lblstatus" runat="server" Text="Status:" Width="90px"></asp:Label>
              <asp:CheckBoxList ID="Chkstatus"  runat="server" >
                  <asp:ListItem>Active</asp:ListItem>
                  <asp:ListItem>Deactive</asp:ListItem>
              </asp:CheckBoxList>
</p>
<p>
<asp:Label ID="lblpic" runat="server" Text="Pic:" Width="90px"></asp:Label>

    <asp:FileUpload ID="FileUpload1" runat="server"  />

    
</p>

        <asp:Button ID="btnadd" runat="server" Text="Add" CssClass="btnadd" OnClick="btnadd_Click"   />

</div>


     <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
         <Columns>
              <asp:ImageField DataImageUrlField="path" HeaderText="Path" ControlStyle-Width="150px" ControlStyle-Height="150px">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
            </asp:ImageField>
             <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
             <asp:BoundField DataField="ProductDetails" HeaderText="ProductDetails" SortExpression="ProductDetails" />
             <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
              <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
         </Columns>
         <EditRowStyle BackColor="#999999" />
         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
     </asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Mobile Eshop\Mobile E-shop\App_Data\mobileEshop.mdf&quot;;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ProductName], [ProductDetails], [ProductPrice],[path] FROM [tblProduct]">
</asp:SqlDataSource>
    
</asp:Content>

