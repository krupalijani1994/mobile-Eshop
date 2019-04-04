﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="view staff.aspx.cs" Inherits="admin_view_staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox>
<asp:Button Text="Search" runat="server" OnClick="Search"/>
<hr />

    <asp:GridView ID="GvStaff" runat="server"   DataKeyNames="StaffID" AutoGenerateDeleteButton="True"  
        OnPageIndexChanging="OnPaging" CellPadding="3" onrowediting="gvStaff_RowEditing" onrowcancelingedit="gvStaff_RowCancelingEdit"
    onrowupdating="gvStaff_RowUpdating" AllowSorting="True"  AutoGenerateEditButton="True" Width="352px" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
        <Columns>
            <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID" />
            <asp:BoundField DataField="StaffFirstName" HeaderText="StaffFirstName" SortExpression="StaffFirstName" />
            <asp:BoundField DataField="StaffLastName" HeaderText="StaffLastName" SortExpression="StaffLastName" />
            <asp:BoundField DataField="StaffPhoneNo" HeaderText="StaffPhoneNo" SortExpression="StaffPhoneNo" />
            <asp:BoundField DataField="StaffAddress" HeaderText="StaffAddress" SortExpression="StaffAddress" />
            <asp:BoundField DataField="StaffEmail" HeaderText="StaffEmail" SortExpression="StaffEmail" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;H:\Desktop\Mobile Eshop\Mobile E-shop\App_Data\mobileEshop.mdf&quot;;Integrated Security=True;Connect Timeout=30" DeleteCommand="DELETE FROM [tblStaff] WHERE [StaffID] = @StaffID" InsertCommand="INSERT INTO [tblStaff] ([StaffFirstName], [StaffLastName], [StaffPhoneNo], [StaffAddress], [StaffEmail]) VALUES (@StaffFirstName, @StaffLastName, @StaffPhoneNo, @StaffAddress, @StaffEmail)" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [StaffID], [StaffFirstName], [StaffLastName], [StaffPhoneNo], [StaffAddress], [StaffEmail] FROM [tblStaff]" UpdateCommand="UPDATE [tblStaff] SET [StaffFirstName] = @StaffFirstName, [StaffLastName] = @StaffLastName, [StaffPhoneNo] = @StaffPhoneNo, [StaffAddress] = @StaffAddress, [StaffEmail] = @StaffEmail WHERE [StaffID] = @StaffID">
        <DeleteParameters>
            <asp:Parameter Name="StaffID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="StaffFirstName" Type="String" />
            <asp:Parameter Name="StaffLastName" Type="String" />
            <asp:Parameter Name="StaffPhoneNo" Type="String" />
            <asp:Parameter Name="StaffAddress" Type="String" />
            <asp:Parameter Name="StaffEmail" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="StaffFirstName" Type="String" />
            <asp:Parameter Name="StaffLastName" Type="String" />
            <asp:Parameter Name="StaffPhoneNo" Type="String" />
            <asp:Parameter Name="StaffAddress" Type="String" />
            <asp:Parameter Name="StaffEmail" Type="String" />
            <asp:Parameter Name="StaffID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

